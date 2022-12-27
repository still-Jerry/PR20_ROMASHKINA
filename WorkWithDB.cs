using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Repair
{
    public static class WorkWithDB
    {
       public static string pwd;
        
        public static SQLiteConnection ConnectDB(string pwd)
        {
            try{
                string connectionStr = @"Data Source=PR20_ROMASHKINA.db;";
            SQLiteConnection con = new SQLiteConnection(connectionStr);
              

            con.Open();
            return con;
              }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
  
        }

        //public static void SelectTables(ComboBox ComboBox) {
        //    try{
        //    SQLiteCommand Command = new SQLiteCommand("SHOW FULL TABLES", ConnectDB(pwd));
        //    SQLiteDataReader reader = Command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        ComboBox.Items.Add(reader[0].ToString());
        //    }
          
        //    Command.Connection.Close();
        //      }
        //    catch (Exception ex) {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        public static void FuncInBD(DataGridView dataGridView, string CommandText)
        {
            try
            {
                SQLiteCommand Command = new SQLiteCommand(CommandText, ConnectDB(pwd));
                Command.ExecuteNonQuery();
                //закрываем соединение
                Command.Connection.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public static void TakeFromDB(DataGridView dataGridView, string tableSelected)
        {
            try{
            //SELECT idMaster as ID, F  AS Фамилия, I AS Имя, O AS Отчество, WasBorn  AS 'Дата Рождения',  JobTitle AS  Должность FROM master;
            //создание запроса 
            SQLiteCommand Command = new SQLiteCommand();
            Command.Connection = ConnectDB(pwd);
            //Command.CommandText = "SELECT idMaster as ID, F  AS Фамилия, I AS Имя, O AS Отчество, WasBorn  AS 'Дата Рождения',  JobTitle AS  Должность FROM " + tableSelected + ";";

            Command.CommandText = "SELECT * FROM " + tableSelected + ";";
            Command.ExecuteNonQuery(); //выполнили запрос без возвращаемого результата

            // используем адапетр для заполнения DataSet
            SQLiteDataAdapter da = new SQLiteDataAdapter(Command);

            //Заполняем  таблицу на форме
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Columns[0].Visible = false;
            //закрываем соединение
            Command.Connection.Close();
              }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
