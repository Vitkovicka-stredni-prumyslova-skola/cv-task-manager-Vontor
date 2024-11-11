using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_manager
{
    class Task{

        // Properties
        public string Name { get; set; }
        public string Content { get; set; }
        public bool Checked { get; set; }

        // Constructor
        public Task(string name, string content, bool isChecked)
        {
            Name = name;
            Content = content;
            Checked = isChecked;
        }
    }

    public partial class Form1 : Form
    {
        private List<Task> tasks;

        public Form1()
        {
            InitializeComponent();


            //načíst soubor např json z předešlých ukolu
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gui_task_name.Text.Length == 0 || gui_task_content.Text.Length == 0)
            {
                MessageBox.Show("Nenechte nic prázdne", "Error", MessageBoxButtons.OK);
            }
            else
            {
                //zkusíme najít starý task
                Task foundTask = tasks.FirstOrDefault(task => task.Name.Equals(gui_task_name.Text, StringComparison.OrdinalIgnoreCase));


                if(foundTask != null)//task existuje
                {

                }
                else//task neexistuje
                {
                    Task new_task_object = new Task(gui_task_name.Text, gui_task_content.Text, false);
                    tasks.Add(new_task_object);
                    //vytvoření nového tasku
                }
                /*gui_task_name.Text;
                gui_task_conent.Text;*/
                gui_check.Checked = false;
            }
            
        }

        private void gui_task_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gui_check_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
