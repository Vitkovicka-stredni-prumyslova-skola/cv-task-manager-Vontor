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
            this.gui_save = new System.Windows.Forms.Button();
            this.gui_task_content = new System.Windows.Forms.TextBox();
            this.gui_task_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gui_task_list = new System.Windows.Forms.CheckedListBox();
            this.gui_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // gui_save
            // 
            this.gui_save.Location = new System.Drawing.Point(19, 413);
            this.gui_save.Name = "gui_save";
            this.gui_save.Size = new System.Drawing.Size(75, 23);
            this.gui_save.TabIndex = 0;
            this.gui_save.Text = "Uložit";
            this.gui_save.UseVisualStyleBackColor = true;
            this.gui_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // gui_task_content
            // 
            this.gui_task_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gui_task_content.Location = new System.Drawing.Point(19, 122);
            this.gui_task_content.Multiline = true;
            this.gui_task_content.Name = "gui_task_content";
            this.gui_task_content.Size = new System.Drawing.Size(288, 273);
            this.gui_task_content.TabIndex = 1;
            this.gui_task_content.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gui_task_name
            // 
            this.gui_task_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gui_task_name.Location = new System.Drawing.Point(19, 46);
            this.gui_task_name.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.gui_task_name.Name = "gui_task_name";
            this.gui_task_name.Size = new System.Drawing.Size(288, 30);
            this.gui_task_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Obsah úkolu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Název úkolu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gui_task_list
            // 
            this.gui_task_list.FormattingEnabled = true;
            this.gui_task_list.Location = new System.Drawing.Point(323, 12);
            this.gui_task_list.Name = "gui_task_list";
            this.gui_task_list.Size = new System.Drawing.Size(219, 424);
            this.gui_task_list.TabIndex = 7;
            this.gui_task_list.SelectedIndexChanged += new System.EventHandler(this.gui_task_list_SelectedIndexChanged);
            // 
            // gui_check
            // 
            this.gui_check.AutoSize = true;
            this.gui_check.Location = new System.Drawing.Point(125, 417);
            this.gui_check.Name = "gui_check";
            this.gui_check.Size = new System.Drawing.Size(63, 17);
            this.gui_check.TabIndex = 8;
            this.gui_check.Text = "splněno";
            this.gui_check.UseVisualStyleBackColor = true;
            this.gui_check.CheckedChanged += new System.EventHandler(this.gui_check_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.gui_check);
            this.Controls.Add(this.gui_task_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gui_task_name);
            this.Controls.Add(this.gui_task_content);
            this.Controls.Add(this.gui_save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gui_save;
        private System.Windows.Forms.TextBox gui_task_content;
        private System.Windows.Forms.TextBox gui_task_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckedListBox gui_task_list;
        private System.Windows.Forms.CheckBox gui_check;
    }
}

