namespace BJ_Edit
{
    partial class Window
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Open_default_bj = new System.Windows.Forms.Button();
            this.Descriptions = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.Functions_list = new System.Windows.Forms.ListBox();
            this.Save_file = new System.Windows.Forms.Button();
            this.Load_custom_bj = new System.Windows.Forms.Button();
            this.Code_label = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.Add_function = new System.Windows.Forms.Button();
            this.Add_comment = new System.Windows.Forms.Button();
            this.Delete_function = new System.Windows.Forms.Button();
            this.Load_w3mj = new System.Windows.Forms.Button();
            this.Close_file = new System.Windows.Forms.Button();
            this.Load_w3mwts = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Load_bj = new System.Windows.Forms.Button();
            this.Load_w3mmisc = new System.Windows.Forms.Button();
            this.Save_changes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Process_label = new System.Windows.Forms.Label();
            this.Edited_functions_count = new System.Windows.Forms.Label();
            this.Edited_functions_label = new System.Windows.Forms.Label();
            this.New_functions_count = new System.Windows.Forms.Label();
            this.New_functions_label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Functions_count_label = new System.Windows.Forms.Label();
            this.Functions_count = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Open_default_bj
            // 
            this.Open_default_bj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Open_default_bj.Location = new System.Drawing.Point(861, 576);
            this.Open_default_bj.Name = "Open_default_bj";
            this.Open_default_bj.Size = new System.Drawing.Size(165, 25);
            this.Open_default_bj.TabIndex = 0;
            this.Open_default_bj.Text = "Стандартные функции BJ";
            this.Open_default_bj.UseVisualStyleBackColor = true;
            this.Open_default_bj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Descriptions
            // 
            this.Descriptions.Location = new System.Drawing.Point(306, 34);
            this.Descriptions.Multiline = true;
            this.Descriptions.Name = "Descriptions";
            this.Descriptions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Descriptions.Size = new System.Drawing.Size(537, 97);
            this.Descriptions.TabIndex = 1;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(306, 151);
            this.Code.MaxLength = 60000;
            this.Code.Multiline = true;
            this.Code.Name = "Code";
            this.Code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Code.Size = new System.Drawing.Size(537, 388);
            this.Code.TabIndex = 2;
            this.Code.WordWrap = false;
            // 
            // Functions_list
            // 
            this.Functions_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Functions_list.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Functions_list.FormattingEnabled = true;
            this.Functions_list.ItemHeight = 12;
            this.Functions_list.Location = new System.Drawing.Point(12, 17);
            this.Functions_list.Name = "Functions_list";
            this.Functions_list.ScrollAlwaysVisible = true;
            this.Functions_list.Size = new System.Drawing.Size(278, 576);
            this.Functions_list.TabIndex = 3;
            this.Functions_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Fname_DrawItem);
            this.Functions_list.SelectedIndexChanged += new System.EventHandler(this.Fname_SelectedIndexChanged);
            // 
            // Save_file
            // 
            this.Save_file.Enabled = false;
            this.Save_file.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save_file.Location = new System.Drawing.Point(858, 332);
            this.Save_file.Name = "Save_file";
            this.Save_file.Size = new System.Drawing.Size(165, 53);
            this.Save_file.TabIndex = 5;
            this.Save_file.Text = "Сохранить файл";
            this.Save_file.UseVisualStyleBackColor = true;
            this.Save_file.Click += new System.EventHandler(this.button3_Click);
            // 
            // Load_custom_bj
            // 
            this.Load_custom_bj.Location = new System.Drawing.Point(861, 545);
            this.Load_custom_bj.Name = "Load_custom_bj";
            this.Load_custom_bj.Size = new System.Drawing.Size(165, 25);
            this.Load_custom_bj.TabIndex = 7;
            this.Load_custom_bj.Text = "Открыть внешний BJ";
            this.Load_custom_bj.UseVisualStyleBackColor = true;
            this.Load_custom_bj.Click += new System.EventHandler(this.button5_Click);
            // 
            // Code_label
            // 
            this.Code_label.AutoSize = true;
            this.Code_label.Location = new System.Drawing.Point(304, 134);
            this.Code_label.Name = "Code_label";
            this.Code_label.Size = new System.Drawing.Size(29, 13);
            this.Code_label.TabIndex = 9;
            this.Code_label.Text = "Код:";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Description_label.Location = new System.Drawing.Point(304, 17);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(60, 13);
            this.Description_label.TabIndex = 10;
            this.Description_label.Text = "Описание:";
            // 
            // Add_function
            // 
            this.Add_function.Enabled = false;
            this.Add_function.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_function.Location = new System.Drawing.Point(27, 24);
            this.Add_function.Name = "Add_function";
            this.Add_function.Size = new System.Drawing.Size(140, 25);
            this.Add_function.TabIndex = 11;
            this.Add_function.Text = "Добавить функцию";
            this.toolTip1.SetToolTip(this.Add_function, "add a function from above");
            this.Add_function.UseVisualStyleBackColor = true;
            this.Add_function.Click += new System.EventHandler(this.button6_Click);
            // 
            // Add_comment
            // 
            this.Add_comment.Enabled = false;
            this.Add_comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_comment.Location = new System.Drawing.Point(173, 24);
            this.Add_comment.Name = "Add_comment";
            this.Add_comment.Size = new System.Drawing.Size(140, 25);
            this.Add_comment.TabIndex = 12;
            this.Add_comment.Text = "Добавить комментарий";
            this.toolTip1.SetToolTip(this.Add_comment, "add a comment from above");
            this.Add_comment.UseVisualStyleBackColor = true;
            this.Add_comment.Click += new System.EventHandler(this.button7_Click);
            // 
            // Delete_function
            // 
            this.Delete_function.Enabled = false;
            this.Delete_function.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_function.Location = new System.Drawing.Point(318, 24);
            this.Delete_function.Name = "Delete_function";
            this.Delete_function.Size = new System.Drawing.Size(91, 25);
            this.Delete_function.TabIndex = 13;
            this.Delete_function.Text = "Удалить";
            this.toolTip1.SetToolTip(this.Delete_function, "remove current item from the listbox");
            this.Delete_function.UseVisualStyleBackColor = true;
            this.Delete_function.Click += new System.EventHandler(this.button8_Click);
            // 
            // Load_w3mj
            // 
            this.Load_w3mj.Enabled = false;
            this.Load_w3mj.Location = new System.Drawing.Point(858, 154);
            this.Load_w3mj.Name = "Load_w3mj";
            this.Load_w3mj.Size = new System.Drawing.Size(165, 53);
            this.Load_w3mj.TabIndex = 15;
            this.Load_w3mj.Text = "Сшить с war3map.j";
            this.toolTip1.SetToolTip(this.Load_w3mj, "import all custom scripts( variables, triggers, custom codes, etc.) into Blizzard" +
        ".j ");
            this.Load_w3mj.UseVisualStyleBackColor = true;
            this.Load_w3mj.Click += new System.EventHandler(this.button10_Click);
            // 
            // Close_file
            // 
            this.Close_file.Location = new System.Drawing.Point(858, 273);
            this.Close_file.Name = "Close_file";
            this.Close_file.Size = new System.Drawing.Size(165, 53);
            this.Close_file.TabIndex = 16;
            this.Close_file.Text = "Закрыть файл";
            this.toolTip1.SetToolTip(this.Close_file, "clear screen, unload current Blizzard.j");
            this.Close_file.UseVisualStyleBackColor = true;
            this.Close_file.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // Load_w3mwts
            // 
            this.Load_w3mwts.Enabled = false;
            this.Load_w3mwts.Location = new System.Drawing.Point(858, 214);
            this.Load_w3mwts.Name = "Load_w3mwts";
            this.Load_w3mwts.Size = new System.Drawing.Size(165, 53);
            this.Load_w3mwts.TabIndex = 17;
            this.Load_w3mwts.Text = "Использовать war3map.wts";
            this.toolTip1.SetToolTip(this.Load_w3mwts, "replace all the string tags with original string");
            this.Load_w3mwts.UseVisualStyleBackColor = true;
            this.Load_w3mwts.Click += new System.EventHandler(this.button11_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Blizzard.j";
            this.openFileDialog1.Filter = "Blizzard.j|*.j|All File(*.*)|*.*";
            this.openFileDialog1.Title = "Open custom Blizzard.j";
            // 
            // Load_bj
            // 
            this.Load_bj.Location = new System.Drawing.Point(858, 34);
            this.Load_bj.Name = "Load_bj";
            this.Load_bj.Size = new System.Drawing.Size(165, 54);
            this.Load_bj.TabIndex = 18;
            this.Load_bj.Text = "Загрузить Blizzard.j";
            this.Load_bj.UseVisualStyleBackColor = true;
            this.Load_bj.Click += new System.EventHandler(this.button12_Click);
            // 
            // Load_w3mmisc
            // 
            this.Load_w3mmisc.Enabled = false;
            this.Load_w3mmisc.Location = new System.Drawing.Point(858, 94);
            this.Load_w3mmisc.Name = "Load_w3mmisc";
            this.Load_w3mmisc.Size = new System.Drawing.Size(165, 53);
            this.Load_w3mmisc.TabIndex = 19;
            this.Load_w3mmisc.Text = "Загрузить war3mapMisc.txt";
            this.Load_w3mmisc.UseVisualStyleBackColor = true;
            this.Load_w3mmisc.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // Save_changes
            // 
            this.Save_changes.Enabled = false;
            this.Save_changes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_changes.Location = new System.Drawing.Point(415, 24);
            this.Save_changes.Name = "Save_changes";
            this.Save_changes.Size = new System.Drawing.Size(91, 25);
            this.Save_changes.TabIndex = 8;
            this.Save_changes.Text = "Сохранить";
            this.toolTip1.SetToolTip(this.Save_changes, "save changes from above");
            this.Save_changes.UseVisualStyleBackColor = true;
            this.Save_changes.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Save_changes);
            this.groupBox1.Controls.Add(this.Add_function);
            this.groupBox1.Controls.Add(this.Add_comment);
            this.groupBox1.Controls.Add(this.Delete_function);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(306, 545);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 65);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // Process_label
            // 
            this.Process_label.AutoSize = true;
            this.Process_label.Location = new System.Drawing.Point(584, 10);
            this.Process_label.Name = "Process_label";
            this.Process_label.Size = new System.Drawing.Size(101, 13);
            this.Process_label.TabIndex = 22;
            this.Process_label.Text = "[текущий процесс]";
            // 
            // Edited_functions_count
            // 
            this.Edited_functions_count.AutoSize = true;
            this.Edited_functions_count.BackColor = System.Drawing.SystemColors.Control;
            this.Edited_functions_count.ForeColor = System.Drawing.Color.Red;
            this.Edited_functions_count.Location = new System.Drawing.Point(118, 602);
            this.Edited_functions_count.MaximumSize = new System.Drawing.Size(150, 13);
            this.Edited_functions_count.Name = "Edited_functions_count";
            this.Edited_functions_count.Size = new System.Drawing.Size(13, 13);
            this.Edited_functions_count.TabIndex = 23;
            this.Edited_functions_count.Text = "0";
            // 
            // Edited_functions_label
            // 
            this.Edited_functions_label.AutoSize = true;
            this.Edited_functions_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Edited_functions_label.Location = new System.Drawing.Point(148, 602);
            this.Edited_functions_label.Name = "Edited_functions_label";
            this.Edited_functions_label.Size = new System.Drawing.Size(57, 13);
            this.Edited_functions_label.TabIndex = 24;
            this.Edited_functions_label.Text = "изменено";
            // 
            // New_functions_count
            // 
            this.New_functions_count.AutoSize = true;
            this.New_functions_count.BackColor = System.Drawing.Color.LightGreen;
            this.New_functions_count.Location = new System.Drawing.Point(213, 602);
            this.New_functions_count.MaximumSize = new System.Drawing.Size(150, 13);
            this.New_functions_count.Name = "New_functions_count";
            this.New_functions_count.Size = new System.Drawing.Size(13, 13);
            this.New_functions_count.TabIndex = 25;
            this.New_functions_count.Text = "0";
            // 
            // New_functions_label
            // 
            this.New_functions_label.AutoSize = true;
            this.New_functions_label.Location = new System.Drawing.Point(243, 602);
            this.New_functions_label.Name = "New_functions_label";
            this.New_functions_label.Size = new System.Drawing.Size(38, 13);
            this.New_functions_label.TabIndex = 26;
            this.New_functions_label.Text = "новых";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem1.Text = "English";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem2.Text = "简体中文";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "wc3 map|*.w3x;*.w3m|mpq|*.mpq|All File(*.*)|*.*";
            this.openFileDialog2.Title = "Choose your map";
            // 
            // Functions_count_label
            // 
            this.Functions_count_label.AutoSize = true;
            this.Functions_count_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Functions_count_label.Location = new System.Drawing.Point(44, 602);
            this.Functions_count_label.Name = "Functions_count_label";
            this.Functions_count_label.Size = new System.Drawing.Size(50, 13);
            this.Functions_count_label.TabIndex = 28;
            this.Functions_count_label.Text = "функции";
            // 
            // Functions_count
            // 
            this.Functions_count.AutoSize = true;
            this.Functions_count.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Functions_count.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Functions_count.Location = new System.Drawing.Point(14, 602);
            this.Functions_count.MaximumSize = new System.Drawing.Size(150, 13);
            this.Functions_count.Name = "Functions_count";
            this.Functions_count.Size = new System.Drawing.Size(13, 13);
            this.Functions_count.TabIndex = 27;
            this.Functions_count.Text = "0";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 628);
            this.Controls.Add(this.Functions_count_label);
            this.Controls.Add(this.Functions_count);
            this.Controls.Add(this.Close_file);
            this.Controls.Add(this.New_functions_label);
            this.Controls.Add(this.New_functions_count);
            this.Controls.Add(this.Edited_functions_label);
            this.Controls.Add(this.Edited_functions_count);
            this.Controls.Add(this.Process_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Code_label);
            this.Controls.Add(this.Load_bj);
            this.Controls.Add(this.Load_custom_bj);
            this.Controls.Add(this.Load_w3mj);
            this.Controls.Add(this.Functions_list);
            this.Controls.Add(this.Open_default_bj);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Load_w3mmisc);
            this.Controls.Add(this.Load_w3mwts);
            this.Controls.Add(this.Save_file);
            this.Controls.Add(this.Descriptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BJ Editor (Ev3nt Edition)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open_default_bj;
        private System.Windows.Forms.TextBox Descriptions;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button Save_file;
        private System.Windows.Forms.Button Load_custom_bj;
        public System.Windows.Forms.ListBox Functions_list;
        private System.Windows.Forms.Label Code_label;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.Button Add_function;
        private System.Windows.Forms.Button Add_comment;
        private System.Windows.Forms.Button Delete_function;
        private System.Windows.Forms.Button Load_w3mj;
        private System.Windows.Forms.Button Close_file;
        private System.Windows.Forms.Button Load_w3mwts;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Load_bj;
        private System.Windows.Forms.Button Load_w3mmisc;
        private System.Windows.Forms.Button Save_changes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Process_label;
        private System.Windows.Forms.Label Edited_functions_count;
        private System.Windows.Forms.Label Edited_functions_label;
        private System.Windows.Forms.Label New_functions_count;
        private System.Windows.Forms.Label New_functions_label;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label Functions_count_label;
        private System.Windows.Forms.Label Functions_count;
    }
}