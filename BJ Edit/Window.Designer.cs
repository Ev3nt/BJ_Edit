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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
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
            resources.ApplyResources(this.Open_default_bj, "Open_default_bj");
            this.Open_default_bj.Name = "Open_default_bj";
            this.Open_default_bj.UseVisualStyleBackColor = true;
            this.Open_default_bj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Descriptions
            // 
            resources.ApplyResources(this.Descriptions, "Descriptions");
            this.Descriptions.Name = "Descriptions";
            // 
            // Code
            // 
            resources.ApplyResources(this.Code, "Code");
            this.Code.Name = "Code";
            // 
            // Functions_list
            // 
            this.Functions_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Functions_list.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Functions_list.FormattingEnabled = true;
            resources.ApplyResources(this.Functions_list, "Functions_list");
            this.Functions_list.Name = "Functions_list";
            this.Functions_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Fname_DrawItem);
            this.Functions_list.SelectedIndexChanged += new System.EventHandler(this.Fname_SelectedIndexChanged);
            // 
            // Save_file
            // 
            resources.ApplyResources(this.Save_file, "Save_file");
            this.Save_file.Name = "Save_file";
            this.Save_file.UseVisualStyleBackColor = true;
            this.Save_file.Click += new System.EventHandler(this.button3_Click);
            // 
            // Load_custom_bj
            // 
            resources.ApplyResources(this.Load_custom_bj, "Load_custom_bj");
            this.Load_custom_bj.Name = "Load_custom_bj";
            this.Load_custom_bj.UseVisualStyleBackColor = true;
            this.Load_custom_bj.Click += new System.EventHandler(this.button5_Click);
            // 
            // Code_label
            // 
            resources.ApplyResources(this.Code_label, "Code_label");
            this.Code_label.Name = "Code_label";
            // 
            // Description_label
            // 
            resources.ApplyResources(this.Description_label, "Description_label");
            this.Description_label.Name = "Description_label";
            // 
            // Add_function
            // 
            resources.ApplyResources(this.Add_function, "Add_function");
            this.Add_function.Name = "Add_function";
            this.toolTip1.SetToolTip(this.Add_function, resources.GetString("Add_function.ToolTip"));
            this.Add_function.UseVisualStyleBackColor = true;
            this.Add_function.Click += new System.EventHandler(this.button6_Click);
            // 
            // Add_comment
            // 
            resources.ApplyResources(this.Add_comment, "Add_comment");
            this.Add_comment.Name = "Add_comment";
            this.toolTip1.SetToolTip(this.Add_comment, resources.GetString("Add_comment.ToolTip"));
            this.Add_comment.UseVisualStyleBackColor = true;
            this.Add_comment.Click += new System.EventHandler(this.button7_Click);
            // 
            // Delete_function
            // 
            resources.ApplyResources(this.Delete_function, "Delete_function");
            this.Delete_function.Name = "Delete_function";
            this.toolTip1.SetToolTip(this.Delete_function, resources.GetString("Delete_function.ToolTip"));
            this.Delete_function.UseVisualStyleBackColor = true;
            this.Delete_function.Click += new System.EventHandler(this.button8_Click);
            // 
            // Load_w3mj
            // 
            resources.ApplyResources(this.Load_w3mj, "Load_w3mj");
            this.Load_w3mj.Name = "Load_w3mj";
            this.toolTip1.SetToolTip(this.Load_w3mj, resources.GetString("Load_w3mj.ToolTip"));
            this.Load_w3mj.UseVisualStyleBackColor = true;
            this.Load_w3mj.Click += new System.EventHandler(this.button10_Click);
            // 
            // Close_file
            // 
            resources.ApplyResources(this.Close_file, "Close_file");
            this.Close_file.Name = "Close_file";
            this.toolTip1.SetToolTip(this.Close_file, resources.GetString("Close_file.ToolTip"));
            this.Close_file.UseVisualStyleBackColor = true;
            this.Close_file.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // Load_w3mwts
            // 
            resources.ApplyResources(this.Load_w3mwts, "Load_w3mwts");
            this.Load_w3mwts.Name = "Load_w3mwts";
            this.toolTip1.SetToolTip(this.Load_w3mwts, resources.GetString("Load_w3mwts.ToolTip"));
            this.Load_w3mwts.UseVisualStyleBackColor = true;
            this.Load_w3mwts.Click += new System.EventHandler(this.button11_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Blizzard.j";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // Load_bj
            // 
            resources.ApplyResources(this.Load_bj, "Load_bj");
            this.Load_bj.Name = "Load_bj";
            this.Load_bj.UseVisualStyleBackColor = true;
            this.Load_bj.Click += new System.EventHandler(this.button12_Click);
            // 
            // Load_w3mmisc
            // 
            resources.ApplyResources(this.Load_w3mmisc, "Load_w3mmisc");
            this.Load_w3mmisc.Name = "Load_w3mmisc";
            this.Load_w3mmisc.UseVisualStyleBackColor = true;
            this.Load_w3mmisc.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // Save_changes
            // 
            resources.ApplyResources(this.Save_changes, "Save_changes");
            this.Save_changes.Name = "Save_changes";
            this.toolTip1.SetToolTip(this.Save_changes, resources.GetString("Save_changes.ToolTip"));
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // Process_label
            // 
            resources.ApplyResources(this.Process_label, "Process_label");
            this.Process_label.Name = "Process_label";
            // 
            // Edited_functions_count
            // 
            resources.ApplyResources(this.Edited_functions_count, "Edited_functions_count");
            this.Edited_functions_count.BackColor = System.Drawing.SystemColors.Control;
            this.Edited_functions_count.ForeColor = System.Drawing.Color.Red;
            this.Edited_functions_count.Name = "Edited_functions_count";
            // 
            // Edited_functions_label
            // 
            resources.ApplyResources(this.Edited_functions_label, "Edited_functions_label");
            this.Edited_functions_label.Name = "Edited_functions_label";
            // 
            // New_functions_count
            // 
            resources.ApplyResources(this.New_functions_count, "New_functions_count");
            this.New_functions_count.BackColor = System.Drawing.Color.LightGreen;
            this.New_functions_count.Name = "New_functions_count";
            // 
            // New_functions_label
            // 
            resources.ApplyResources(this.New_functions_label, "New_functions_label");
            this.New_functions_label.Name = "New_functions_label";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // openFileDialog2
            // 
            resources.ApplyResources(this.openFileDialog2, "openFileDialog2");
            // 
            // Functions_count_label
            // 
            resources.ApplyResources(this.Functions_count_label, "Functions_count_label");
            this.Functions_count_label.Name = "Functions_count_label";
            // 
            // Functions_count
            // 
            resources.ApplyResources(this.Functions_count, "Functions_count");
            this.Functions_count.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Functions_count.Name = "Functions_count";
            // 
            // Window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Window";
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