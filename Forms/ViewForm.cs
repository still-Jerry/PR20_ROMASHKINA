using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Repair
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MenuForm Form = new MenuForm();
          
            this.Visible = false;
            Form.ShowDialog();
        }

        private void ViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            string connectionStr = @"Data Source=PR20_ROMASHKINA.db;";
            SQLiteConnection con = new SQLiteConnection(connectionStr);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(@"SELECT * FROM master;", con);
            cmd.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;


            con.Close();
            //WorkWithDB.TakeFromDB(dataGridView1, "master");
        }
    }
}