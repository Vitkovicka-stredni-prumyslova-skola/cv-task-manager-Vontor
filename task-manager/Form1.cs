using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace task_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Task> tasks;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//save button
        {
            if (gui_task_name.Text.Length == 0 || gui_task_content.Text.Length == 0)
            {
                MessageBox.Show("Nenechte nic prázdne", "Error", MessageBoxButtons.OK);
            }
            else
            {
                //zkusíme najít starý task
                Task foundTask = tasks.FirstOrDefault(task => task.Name.Equals(gui_task_name.Text, StringComparison.OrdinalIgnoreCase));


                if (foundTask != null)//task existuje
                {
                    Task new_task_object = new Task(gui_task_name.Text, gui_task_content.Text, false);

                    tasks.Add(new_task_object);

                    tasks.Remove(foundTask);
                }
                else//task neexistuje
                {
                    Task new_task_object = new Task(gui_task_name.Text, gui_task_content.Text, false);
                    tasks.Add(new_task_object);
                    //vytvoření nového tasku
                }
            }

            //vyprázdnit gui
            gui_task_name.Clear();
            gui_task_content.Clear();

            UpdateTaskListDisplay();
        }

        private void UpdateTaskListDisplay()
        {
            task_list.Items.Clear();
            foreach (var task in tasks)
            {
                task_list.Items.Add(task.Name, task.Checked);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < tasks.Count)
            {
                tasks[e.Index].Checked = (e.NewValue == CheckState.Checked);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTaskListDisplay();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//splněno
        {

        }

        private void gui_task_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Example: Show a confirmation dialog before closing
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the closing
            }
            else
            {
                // Perform any cleanup here
                SaveTasks(); // Example: Save tasks to a file or database
            }
        }

        private void SaveTasks()
        {

        }
    }

    class Task
    {


        public string Name { get; set; }
        public string Content { get; set; }
        public bool Checked { get; set; }

        // kontruktor
        public Task(string name, string content, bool isChecked)
        {
            Name = name;
            Content = content;
            Checked = isChecked;
        }
    }
}
