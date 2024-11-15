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


using System.IO;
using System.Text.Json;//jak jsem tenhle balíček získal je v repozitáři vysvětleno na dvou printscreenech!


namespace task_manager
{
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

    public partial class Form1 : Form
    {
        private List<Task> tasks;

        public Form1()
        {
            InitializeComponent();
            tasks = new List<Task>();
            LoadTasks();
            UpdateTaskListDisplay();
        }

        

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
                MessageBox.Show("Nenechte nic prázdné", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var existingTask = tasks.FirstOrDefault(task => task.Name.Equals(gui_task_name.Text, StringComparison.OrdinalIgnoreCase));
                if (existingTask != null)
                {
                    existingTask.Content = gui_task_content.Text;
                    MessageBox.Show("Úkol byl aktualizován.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tasks.Add(new Task(gui_task_name.Text, gui_task_content.Text, false));
                    MessageBox.Show("Úkol byl přidán.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //vyprázdnit gui
            gui_task_name.Clear();
            gui_task_content.Clear();
            UpdateTaskListDisplay();
            SaveTasks();

            
        }

        private void UpdateTaskListDisplay() // Aktualizace seznamu úkolů
        {
            task_list.Items.Clear();
            foreach (var task in tasks)
            {
                task_list.Items.Add(task.Name, task.Checked);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (task_list.SelectedIndex != -1) // Ensure a task is selected
            {
                var selectedTask = tasks[task_list.SelectedIndex];
                gui_task_name.Text = selectedTask.Name;
                gui_task_content.Text = selectedTask.Content;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < tasks.Count)
            {
                tasks[e.Index].Checked = (e.NewValue == CheckState.Checked);
                SaveTasks();
            }
        }


        private void Form1_Load(object sender, EventArgs e) // Načtení při startu
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs closingevent)
        {
            var result = MessageBox.Show("Opravdu chcete zavřít aplikaci?", "Potvrzení", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                closingevent.Cancel = true;
            }
            else
            {
                SaveTasks();
            }
        }

        private void SaveTasks() // Uložení úkolů do JSON
        {
            using (var writer = new StreamWriter("tasks.txt"))
            {
                foreach (var task in tasks)
                {
                    writer.WriteLine($"{task.Name}|{task.Content}|{task.Checked}");
                }
            }
        }

        private void LoadTasks() // Načtení úkolů z JSON
        {
            if (File.Exists("tasks.txt"))
            {
                using (var reader = new StreamReader("tasks.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            var name = parts[0];
                            var content = parts[1];
                            var isChecked = bool.Parse(parts[2]);
                            tasks.Add(new Task(name, content, isChecked));
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//delete button
        {
            if (task_list.SelectedIndex == -1)
            {
                MessageBox.Show("Vyberte úkol k odstranění.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tasks.RemoveAt(task_list.SelectedIndex);
            UpdateTaskListDisplay();
            SaveTasks();
            MessageBox.Show("Úkol byl smazán.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
        }

        private void button1_Click_2(object sender, EventArgs e)//add button
        {
            gui_task_name.Clear();
            gui_task_content.Clear();
        }
    }

    
}
