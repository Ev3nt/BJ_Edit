using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Threading;
using System.Globalization;

namespace BJ_Edit
{
    public partial class Window : Form
    {
        public Window()
        {
            System.Globalization.CultureInfo UICulture = new System.Globalization.CultureInfo("en-GB");
            Thread.CurrentThread.CurrentUICulture = UICulture;
            InitializeComponent();
        }

        Bj_structure_original BJorg = new Bj_structure_original(@"Original\Blizzard.j");
        Bj_structure BJ = null;
        ArrayList EditItems = new ArrayList();
        ArrayList AddItems = new ArrayList();
        bool IsNewBJ = true;
        w3j_structure W3J;

        public static string BJpath = "";

        private void ShowChanges()
        {
            ChangeLabel(1);
            EditItems.Clear();
            AddItems.Clear();
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";

            for (int i = 0; i < BJ.substance.Count; i++)
            {
                if (BJ.substance[i].GetType() == typeof(Bj_structure.function))
                {
                    bool InBJorg = false;
                    string funcname = ((Bj_structure.function)BJ.substance[i]).name;

                    for (int j = 0; j < BJorg.Function_org.Count; j++)
                        if (funcname == ((Bj_structure_original.function)BJorg.Function_org[j]).name)
                        {
                            InBJorg = true;

                            if (((Bj_structure.function)BJ.substance[i]).content.Trim() != ((Bj_structure_original.function)BJorg.Function_org[j]).content.Trim())
                                EditItems.Add(i);
                        }

                    if (InBJorg == false)
                        AddItems.Add(i);
                }

                if (BJ.substance[i].GetType() == typeof(string))
                    AddItems.Add(i);
                else if (BJ.substance[i].GetType() == typeof(ArrayList))
                    EditItems.Add(i);
            }

            ChangeLabel(0);
        }

        public void ChangeLabel(int flag)
        {
            if (flag == 1)
                Process_label.Text = "В процессе...";
            else if (flag == 0)
                Process_label.Text = "";

            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            Process_label.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeLabel(1);
            EditItems.Clear();
            AddItems.Clear();
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";
            IsNewBJ = false;
            Save_changes.Enabled = false;
            Save_file.Enabled = false;
            Add_function.Enabled = false;
            Add_comment.Enabled = false;
            Delete_function.Enabled = false;
            Load_w3mj.Enabled = false;
            Load_w3mwts.Enabled = false;

            Functions_list.Items.Clear();
            Code.Text = "";
            Descriptions.Text = "";

            for (int i = 0; i<BJorg.FunctionCount_org;i++)
                Functions_list.Items.Add(((Bj_structure_original.function)BJorg.Function_org[i]).name);

            ChangeLabel(0);
        }

        private void Fname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Code.Text = "";
            Descriptions.Text = "";

            if (IsNewBJ)
            {
                if (BJ.substance[Functions_list.SelectedIndex].GetType() == typeof(Bj_structure.function))  //fucntions
                {
                    Code.Text = ((Bj_structure.function)BJ.substance[Functions_list.SelectedIndex]).content;
                    Descriptions.Text = ((Bj_structure.function)BJ.substance[Functions_list.SelectedIndex]).description;
                }
                else if (BJ.substance[Functions_list.SelectedIndex].GetType() == typeof(Bj_structure.comment))  //comments
                    Code.Text = ((Bj_structure.comment)BJ.substance[Functions_list.SelectedIndex]).comments;
                else if (BJ.substance[Functions_list.SelectedIndex].GetType() == typeof(ArrayList))  // globals
                {
                    ArrayList temp = ((ArrayList)BJ.substance[Functions_list.SelectedIndex]);
                    string temps = "";

                    for (int i = 0; i < temp.Count; i++)
                    {
                        temps += temp[i].ToString() + System.Environment.NewLine;
                    }

                    Code.Text = temps.TrimEnd() + System.Environment.NewLine;
                }
                else if (BJ.substance[Functions_list.SelectedIndex].GetType() == typeof(string))  //w3j additions
                    Code.Text = ((string)BJ.substance[Functions_list.SelectedIndex]);

            }
            else
                for (int i = 0; i < BJorg.Function_org.Count; i++)
                    if (Functions_list.SelectedItem.ToString() == ((Bj_structure_original.function)BJorg.Function_org[i]).name)
                        Code.Text = ((Bj_structure_original.function)BJorg.Function_org[i]).content;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            ChangeLabel(1);
            EditItems.Clear();
            AddItems.Clear();
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";

            if (!System.IO.Directory.Exists("Output"))
            {
                System.IO.Directory.CreateDirectory("Output");
            }

            StreamWriter BJ_writer = new StreamWriter(@"Output\Blizzard.j");

            for (int i=0; i<BJ.substance.Count; i++)
                if (BJ.substance[i].GetType() == typeof(Bj_structure.comment))
                {
                    string s = ((Bj_structure.comment)BJ.substance[i]).comments.Trim();
                    BJ_writer.Write(s+System.Environment.NewLine+System.Environment.NewLine);
                }
                else if (BJ.substance[i].GetType() == typeof(ArrayList))
                {
                    bool Ghead = true;
                    BJ_writer.WriteLine("globals" + System.Environment.NewLine);

                    for (int j = 0; j < ((ArrayList)BJ.substance[i]).Count; j++)
                    {
                        string s=((ArrayList)BJ.substance[i])[j].ToString();
                        while (s.IndexOf("BJE_BJE_", StringComparison.OrdinalIgnoreCase) != -1)
                            s = s.Replace("bje_", "BJE_").Replace("BJE_BJE_", "BJE_");

                        if (Ghead)
                        {
                            if (s.Trim().Length != 0)
                                Ghead = false;
                            else
                                continue;
                        }

                        BJ_writer.WriteLine(s);
                    }

                    BJ_writer.WriteLine("endglobals" + System.Environment.NewLine);
                }
                else if (BJ.substance[i].GetType() == typeof(Bj_structure.function))
                {
                    string s = ((Bj_structure.function)BJ.substance[i]).description.Trim();
                    BJ_writer.WriteLine(s);
                    s = ((Bj_structure.function)BJ.substance[i]).content.Trim();

                    while (s.IndexOf("BJE_BJE_", StringComparison.OrdinalIgnoreCase) != -1)
                        s = s.Replace("bje_", "BJE_").Replace("BJE_BJE_", "BJE_");

                    BJ_writer.WriteLine(s + System.Environment.NewLine);
                }
                else if (BJ.substance[i].GetType() == typeof(string))
                {
                    string s = ((string)BJ.substance[i]).Trim();

                    while (s.IndexOf("BJE_BJE_", StringComparison.OrdinalIgnoreCase) != -1)
                        s = s.Replace("bje_", "BJE_").Replace("BJE_BJE_", "BJE_");

                    BJ_writer.Write(s + Environment.NewLine + Environment.NewLine);
                }

            BJ_writer.Close();
            BJpath = @"Output\Blizzard.j";
            MessageBox.Show("Файл сохранён по пути: " + Environment.NewLine + Environment.NewLine + "Output\\Blizzard.j", "Готово");
            ChangeLabel(0);
            ShowChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeLabel(1);
            EditItems.Clear();
            AddItems.Clear();
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.Trim()!="" && File.Exists(openFileDialog1.FileName))
            {
                BJ = new Bj_structure(openFileDialog1.FileName);
                ListBJNew();
            }

            BJpath = openFileDialog1.FileName;
            ChangeLabel(0);
            ShowChanges();
        }

        private void ListBJNew()
        {
            IsNewBJ = true;
            Save_changes.Enabled = true;
            Save_file.Enabled = true;
            Add_function.Enabled = true;
            Add_comment.Enabled = true;
            Delete_function.Enabled = true;

            if (File.Exists(@"Input\war3map.wts"))
                Load_w3mwts.Enabled = true;
            else
                Load_w3mwts.Enabled = false;

            if (File.Exists(@"Input\war3map.j"))
                Load_w3mj.Enabled = true;
            else
                Load_w3mj.Enabled = false;

            if (File.Exists(@"Input\war3mapMisc.txt"))
                Load_w3mmisc.Enabled = true;
            else
                Load_w3mmisc.Enabled = false;

            Functions_list.Items.Clear();
            Code.Text = "";
            Descriptions.Text = "";
            for (int i = 0; i < BJ.substance.Count; i++)
                if (BJ.substance[i].GetType() == typeof(Bj_structure.comment))
                    Functions_list.Items.Add("- Comment #" + ((Bj_structure.comment)BJ.substance[i]).index.ToString() + " -");
                else if (BJ.substance[i].GetType() == typeof(ArrayList))
                    Functions_list.Items.Add("- GLOBALS -");
                else if (BJ.substance[i].GetType() == typeof(Bj_structure.function))
                    Functions_list.Items.Add(((Bj_structure.function)BJ.substance[i]).name);
                else if (BJ.substance[i].GetType() == typeof(string))
                {
                    string FuncName = ((string)BJ.substance[i]);
                    FuncName = FuncName.Substring(0, FuncName.IndexOf(Environment.NewLine));

                    bool IsFunction = false;

                    for (int a = 0; a < FuncName.Length && !IsFunction; a++)
                        if (FuncName[a] == ' ')
                        {
                            Functions_list.Items.Add(FuncName.Split(' ')[1]);

                            IsFunction = true;
                        }

                    if (!IsFunction)
                        Functions_list.Items.Add("- W3J -");
                }

        }

        private void Fname_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (EditItems.Contains(e.Index))
            {
                e.DrawBackground();
                e.Graphics.DrawString(Functions_list.Items[e.Index].ToString(), e.Font, Brushes.Red, e.Bounds);
                e.DrawFocusRectangle();
            }
            else if (AddItems.Contains(e.Index))
            {
                e.DrawBackground();
                e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
                e.Graphics.DrawString(Functions_list.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
            else
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(Functions_list.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
            }

            New_functions_count.Text = (AddItems.Count).ToString();
            Functions_count.Text = (Functions_list.Items.Count).ToString();
            Edited_functions_count.Text = (EditItems.Count).ToString();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            EditItems.Clear();
            AddItems.Clear();
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";

            if (Functions_list.SelectedIndex == -1)
                return;
            else if (BJ.substance[Functions_list.SelectedIndex].GetType() == typeof(Bj_structure.function))
            {
                Bj_structure.function temp =((Bj_structure.function)BJ.substance[Functions_list.SelectedIndex]);
                temp.description = Descriptions.Text;
                temp.content = Code.Text;
                BJ.substance[Functions_list.SelectedIndex] = temp;
            }
            else if (BJ.substance[Functions_list.SelectedIndex].GetType() == typeof(Bj_structure.comment))
            {
                Bj_structure.comment temp = ((Bj_structure.comment)BJ.substance[Functions_list.SelectedIndex]);
                temp.comments = Code.Text;
                BJ.substance[Functions_list.SelectedIndex] = temp;
            }
            else if (BJ.substance[Functions_list.SelectedIndex].GetType() == typeof(string))
                BJ.substance[Functions_list.SelectedIndex] = Code.Text;
            else if (BJ.substance[Functions_list.SelectedIndex].GetType() == typeof(ArrayList))
            {
                ShowChanges();
                MessageBox.Show("Выберите функцию!", "Ошибка");

                return;
            }

            ShowChanges();
            MessageBox.Show("Сохранено.", "Готово");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                EditItems.Clear();
                AddItems.Clear();
                Functions_count.Text = "0";
                New_functions_count.Text = "0";
                Edited_functions_count.Text = "0";
                Bj_structure.function item = new Bj_structure.function();
                item.name = Code.Text.Substring(8, Code.Text.IndexOf(" takes") - 8);
                item.description = Descriptions.Text;
                item.content = Code.Text;
                int ti = Functions_list.SelectedIndex;
                BJ.substance.Insert(ti + 1, item);
                ListBJNew();
                Functions_list.SelectedIndex = ti + 1;
                ShowChanges();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так.", "Ошибка");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditItems.Clear();
            AddItems.Clear();
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";
            Bj_structure.comment item = new Bj_structure.comment();
            item.comments = Code.Text;
            item.index = BJ.commentCount;
            BJ.commentCount++;
            int ti = Functions_list.SelectedIndex;
            BJ.substance.Insert(ti + 1, item);
            ListBJNew();
            Functions_list.SelectedIndex = ti + 1;
            ShowChanges();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                EditItems.Clear();
                AddItems.Clear();
                Functions_count.Text = "0";
                New_functions_count.Text = "0";
                Edited_functions_count.Text = "0";
                int ti = Functions_list.SelectedIndex;
                BJ.substance.RemoveAt(ti);
                ListBJNew();
                Functions_list.SelectedIndex = ti;
                ShowChanges();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так.", "Ошибка");
            }
        }

        public void button10_Click(object sender, EventArgs e)
        {
            ChangeLabel(1);
            EditItems.Clear();
            AddItems.Clear();
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";
            W3J = new w3j_structure(@"Input\war3map.j");
            W3J.AddPreName("BJE_");
            int InitFuncIndex = 0;

            BJ.global.Add("    // war3map.j additions");
            for (int i = 0; i < W3J.globals.Length; i++)
                BJ.global.Add("    " + W3J.globals[i]);

            for (int i = 0; i < BJ.substance.Count; i++)
                if (BJ.substance[i].GetType() == typeof(Bj_structure.function))
                    if (((Bj_structure.function)BJ.substance[i]).name.Trim() == "InitBlizzard")
                    {
                        Bj_structure.function temp = (Bj_structure.function)BJ.substance[i];
                        temp.content = temp.content.Insert(temp.content.LastIndexOf("endfunction"), Environment.NewLine + "    // BJE_InitFuncs" + Environment.NewLine + W3J.CallFuncs);
                        BJ.substance[i] = temp;
                        InitFuncIndex = i;

                        break;
                    }

            BJ.substance.Insert(InitFuncIndex, W3J.Func_RunInitializationTriggers);
            BJ.substance.Insert(InitFuncIndex, W3J.Func_InitCustomTriggers);
            BJ.substance.Insert(InitFuncIndex, W3J.CSCandTrig);
            BJ.substance.Insert(InitFuncIndex, W3J.Func_InitGlobals);

            ListBJNew();
            ChangeLabel(0);
            ShowChanges();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Functions_list.Items.Clear();
            Descriptions.Text = "";
            Code.Text = "";
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";
            Add_function.Enabled = false;
            Add_comment.Enabled = false;
            Delete_function.Enabled = false;
            Save_changes.Enabled = false;
            Save_file.Enabled = false;
            Load_w3mwts.Enabled = false;
            Load_w3mj.Enabled = false;
            Load_w3mmisc.Enabled = false;
            W3J = null;
            BJ = null;
        }

        public void button11_Click(object sender, EventArgs e)
        {
            ChangeLabel(1);
            EditItems.Clear();
            AddItems.Clear();
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";
            wts_structure wts = new wts_structure(@"Input\war3map.wts");

            for (int i = 0; i < BJ.substance.Count; i++)
                if (BJ.substance[i].GetType() == typeof(string))
                    for (int j = 0; j < wts.TrigStr.Count; j++)
                    {
                        string s =(string)BJ.substance[i];
                        s = s.Replace(((wts_structure.wtsS)wts.TrigStr[j]).S, ((wts_structure.wtsS)wts.TrigStr[j]).TrigS);
                        BJ.substance[i] = s;
                    }

            ListBJNew();
            ChangeLabel(0);
            ShowChanges();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ChangeLabel(1);
            EditItems.Clear();
            AddItems.Clear();
            Functions_count.Text = "0";
            New_functions_count.Text = "0";
            Edited_functions_count.Text = "0";
            if (!System.IO.Directory.Exists(@"Input")) { System.IO.Directory.CreateDirectory("Input"); }
            if (!System.IO.File.Exists(@"Input\Blizzard.j")) { System.IO.File.Copy(@"Original\Blizzard.j", @"Input\Blizzard.j"); }
            BJ = new Bj_structure(@"Input\Blizzard.j");
            ListBJNew();
            ChangeLabel(0);
            ShowChanges();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            ChangeLabel(1);
            misc_structure misc = new misc_structure(@"Input\war3mapMisc.txt");
            Bj_structure.function temp = (Bj_structure.function)BJ.substance[BJ.substance.Count-1];
            temp.content = "function MeleeStartingHeroLimit takes nothing returns nothing"+Environment.NewLine;
            temp.content += "    local integer index" + Environment.NewLine;
            temp.content += "" + Environment.NewLine;
            temp.content += "    set index = 0" + Environment.NewLine;
            temp.content += "    loop" + Environment.NewLine;
            temp.content += "        // max heroes per player" + Environment.NewLine;
            temp.content += "        call SetPlayerMaxHeroesAllowed(bj_MELEE_HERO_LIMIT, Player(index))" + Environment.NewLine;
            temp.content += "" + Environment.NewLine;
            temp.content += "        // each player is restricted to a limit per hero type as well" + Environment.NewLine;

            for (int i = 0; i < misc.hero.Length; i++)
                temp.content += "        call ReducePlayerTechMaxAllowed(Player(index), '" + misc.hero[i] + "', bj_MELEE_HERO_TYPE_LIMIT)" + Environment.NewLine;

            temp.content += "" + Environment.NewLine;
            temp.content += "        set index = index + 1" + Environment.NewLine;
            temp.content += "        exitwhen index == bj_MAX_PLAYERS" + Environment.NewLine;
            temp.content += "    endloop" + Environment.NewLine;
            temp.content += "endfunction" + Environment.NewLine;

            BJ.substance[BJ.substance.Count - 1] = temp;
            ListBJNew();
            ChangeLabel(0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ChangeLabel(1);
            ChangeLabel(0);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0;
            Point point = new Point(btn.Left + this.Left + 5, btn.Top + this.Top + 40);
            contextMenuStrip1.Show(point);
        }
    }
}
