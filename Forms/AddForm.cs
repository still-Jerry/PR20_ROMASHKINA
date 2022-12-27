using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repair
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MenuForm Form = new MenuForm();
            
            this.Visible = false;
            Form.ShowDialog();
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
           
            WorkWithDB.TakeFromDB(dataGridView1,"master");

            //TablesComboBox.Items= SHOW TABLES [FROM db_name];
        }

        private void FTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void ITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void OTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void JobTitleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void AddingButton_Click(object sender, EventArgs e)
        {
            if (FTextBox.Text == "" || ITextBox.Text == "" || JobTitleTextBox.Text == "")
            {
                MessageBox.Show("Проверьте заполненность ключевых полей", "Ошибка добваления");
            }
            else {
                //string data = dateTimePicker.Value.Year + "." + dateTimePicker.Value.Month + "." + dateTimePicker.Value.Day;
                string data = dateTimePicker.Value.ToString("yyyy-MM-dd");
                string command = "Insert into master values (null, '" + FTextBox.Text + "', '" + ITextBox.Text + "', '" + OTextBox.Text + "','" + data + "', '" + JobTitleTextBox.Text + "');";
                WorkWithDB.FuncInBD(dataGridView1, command);
                WorkWithDB.TakeFromDB(dataGridView1, "master");
                ITextBox.Text = "";
                FTextBox.Text = "";
                OTextBox.Text = "";
                JobTitleTextBox.Text = "";
                MessageBox.Show("Успешное добавление!", "Поздравление");
            }
        }
        
       
    }
}
