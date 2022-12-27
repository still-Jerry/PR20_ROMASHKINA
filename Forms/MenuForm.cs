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
    public partial class MenuForm : Form
    {
        public static Boolean PwdVisible = true;
        public MenuForm()
        {
   
            InitializeComponent();
           
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            
            try
            {
               
            
                ViewForm Form = new ViewForm();
                this.Visible = false;
                Form.ShowDialog();

            }

            catch
            {
                MessageBox.Show("Пароль неверен.", "Ошибка соединения");

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           
            try
            {
               
                AddForm Form = new AddForm();
                this.Visible = false;
                Form.ShowDialog();
            
            }

            catch {
                MessageBox.Show("Пароль неверен.","Ошибка соединения");
                
            }
            
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

     
    }
}
