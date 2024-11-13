namespace task_manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.task_save = new System.Windows.Forms.Button();
            this.gui_task_content = new System.Windows.Forms.TextBox();
            this.gui_task_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.task_list = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.task_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // task_save
            // 
            this.task_save.Location = new System.Drawing.Point(11, 412);
            this.task_save.Name = "task_save";
            this.task_save.Size = new System.Drawing.Size(75, 23);
            this.task_save.TabIndex = 0;
            this.task_save.Text = "Uložit";
            this.task_save.UseVisualStyleBackColor = true;
            this.task_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // gui_task_content
            // 
            this.gui_task_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gui_task_content.Location = new System.Drawing.Point(11, 114);
            this.gui_task_content.Multiline = true;
            this.gui_task_content.Name = "gui_task_content";
            this.gui_task_content.Size = new System.Drawing.Size(288, 280);
            this.gui_task_content.TabIndex = 1;
            this.gui_task_content.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gui_task_name
            // 
            this.gui_task_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gui_task_name.Location = new System.Drawing.Point(11, 41);
            this.gui_task_name.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.gui_task_name.Name = "gui_task_name";
            this.gui_task_name.Size = new System.Drawing.Size(288, 30);
            this.gui_task_name.TabIndex = 2;
            this.gui_task_name.TextChanged += new System.EventHandler(this.gui_task_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Obsah úkolu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Název úkolu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // task_list
            // 
            this.task_list.FormattingEnabled = true;
            this.task_list.Location = new System.Drawing.Point(331, 41);
            this.task_list.Name = "task_list";
            this.task_list.Size = new System.Drawing.Size(231, 394);
            this.task_list.TabIndex = 7;
            this.task_list.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(327, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "seznam úkolů";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // task_check
            // 
            this.task_check.AutoSize = true;
            this.task_check.Location = new System.Drawing.Point(108, 416);
            this.task_check.Name = "task_check";
            this.task_check.Size = new System.Drawing.Size(63, 17);
            this.task_check.TabIndex = 9;
            this.task_check.Text = "splněno";
            this.task_check.UseVisualStyleBackColor = true;
            this.task_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.task_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.task_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gui_task_name);
            this.Controls.Add(this.gui_task_content);
            this.Controls.Add(this.task_save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button task_save;
        private System.Windows.Forms.TextBox gui_task_content;
        private System.Windows.Forms.TextBox gui_task_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckedListBox task_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox task_check;
    }
}

