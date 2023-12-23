using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Inventarization
{
    internal class DataBase
    {
        private static string dbFileName = "inventarization_DB.sqlite";
        private static SQLiteConnection SQLiteConnection = null;
        private SQLiteCommand command;
        private SQLiteDataAdapter adapter;
        private DataTable dataTable;
        DataTable dt = new DataTable();

        public DataBase()
        {
            SQLiteConnection = new SQLiteConnection($"Data Source={dbFileName};Version=3;");

            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);
            CreateOrCheckStartDB();
        }

        private void CreateOrCheckStartDB()
        {
            command = new SQLiteCommand();
            try
            {
                SQLiteConnection.Open();
                command.Connection = SQLiteConnection;
                command.CommandText = "CREATE TABLE IF NOT EXISTS [Things] (" +
                                            "[Id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                                            "[Type] TEXT NOT NULL," +
                                            "[Count] INTEGER NOT NULL," +
                                            "[Name] TEXT NOT NULL," +
                                            "[Color] TEXT," +
                                            "[Weight] REAL," +
                                            "[Material] TEXT," +
                                            "[Num] TEXT NOT NULL," +
                                            "[User] TEXT NOT NULL);";
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
        }

        public void InsertRowToDB(string type, string count, string name, string color, string weight, string matherial, string num, string user)
        {
            string query = $"INSERT INTO \"Things\" (Type, Count, Name, Color, Weight, Material, Num, User) " +
                            $"VALUES ('{type}','{count}','{name}','{color}','{weight}','{matherial}','{num}','{user}');";

            try
            {
                SQLiteConnection.Open();
                command = new SQLiteCommand(query, SQLiteConnection);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
        }

        public void ShowDB(DataGridView dGV)
        {
            string query = "SELECT Type as 'Тип', Count as 'Кол-во', Name as 'Название', Color as 'Цвет', Weight as 'Вес', Material as 'Материал', Num as 'Номер аудитории', User as 'Пользователь', \"\" as 'Удаление' " +
                            "FROM \"Things\";";

            try
            {
                SQLiteConnection.Open();
                adapter = new SQLiteDataAdapter(query, SQLiteConnection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dGV.Columns.Clear();

                for (int i = 0; i < dataTable.Columns.Count - 1; i++)
                {
                    DataGridViewColumn mainCol = new DataGridViewTextBoxColumn();
                    mainCol.HeaderText = dataTable.Columns[i].ColumnName;
                    dGV.Columns.Add(mainCol);
                    dGV.Columns[i].ReadOnly = true;
                }
                for (int i = dataTable.Columns.Count - 1; i < dataTable.Columns.Count; i++)
                {
                    DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
                    editCol.HeaderText = dataTable.Columns[i].ColumnName;
                    dGV.Columns.Add(editCol);
                    dGV.Columns[i].ReadOnly = true;
                }
                
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    dGV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
             
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    dGV.Rows.Add(dataTable.Rows[j].ItemArray);
                }
                dGV.Show();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
        }


        public void ShowDB(DataGridView dGV, string condition)
        {
            string query = "SELECT Type as 'Тип', Count as 'Кол-во', Name as 'Название', Color as 'Цвет', Weight as 'Вес', Material as 'Материал', Num as 'Номер аудитории', User as 'Пользователь', \"\" as 'Удаление' " +
                            $"FROM \"Things\"{condition};";

            try
            {
                SQLiteConnection.Open();
                adapter = new SQLiteDataAdapter(query, SQLiteConnection);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dGV.Columns.Clear();

                for (int i = 0; i < dataTable.Columns.Count - 1; i++)
                {
                    DataGridViewColumn mainCol = new DataGridViewTextBoxColumn();
                    mainCol.HeaderText = dataTable.Columns[i].ColumnName;
                    dGV.Columns.Add(mainCol);
                    dGV.Columns[i].ReadOnly = true;
                }
                for (int i = dataTable.Columns.Count - 1; i < dataTable.Columns.Count; i++)
                {
                    DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
                    editCol.HeaderText = dataTable.Columns[i].ColumnName;
                    dGV.Columns.Add(editCol);
                    dGV.Columns[i].ReadOnly = true;
                }
               
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    dGV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
             
                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    dGV.Rows.Add(dataTable.Rows[j].ItemArray);
                }
                dGV.Show();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
        }

        public DataTable GetType()
        {
            string query = "";
            dt.Columns.Clear();
            try
            {
                SQLiteConnection.Open();
                query = "SELECT DISTINCT Type FROM \"Things\" WHERE Type!=\"\";";
                adapter = new SQLiteDataAdapter(query, SQLiteConnection);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
            return dt;
        }

        public DataTable GetName()
        {
            string query = "";
            dt.Columns.Clear();
            try
            {
                SQLiteConnection.Open();
                query = "SELECT DISTINCT Name FROM \"Things\" WHERE Name!=\"\";";
                adapter = new SQLiteDataAdapter(query, SQLiteConnection);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
            return dt;
        }

        public DataTable GetColor()
        {
            string query = "";
            dt.Columns.Clear();
            try
            {
                SQLiteConnection.Open();
                query = "SELECT DISTINCT Color FROM \"Things\" WHERE Color!=\"\";";
                adapter = new SQLiteDataAdapter(query, SQLiteConnection);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
            return dt;
        }

        public DataTable GetMaterial()
        {
            string query = "";
            dt.Columns.Clear();
            try
            {
                SQLiteConnection.Open();
                query = "SELECT DISTINCT Material FROM \"Things\" WHERE Material!=\"\";";
                adapter = new SQLiteDataAdapter(query, SQLiteConnection);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
            return dt;
        }

        public DataTable GetNum()
        {
            string query = "";
            dt.Columns.Clear();
            try
            {
                SQLiteConnection.Open();
                query = "SELECT DISTINCT Num FROM \"Things\" WHERE Num!= \"\";";
                adapter = new SQLiteDataAdapter(query, SQLiteConnection);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
            return dt;
        }

        public void DeleteRowFromDB(DataGridView dGV, int rowInd, int colInd)
        {
            string type = $"Type = '{dGV.Rows[rowInd].Cells[0].Value.ToString()}'";
            string count = $"Count = '{dGV.Rows[rowInd].Cells[1].Value.ToString()}'";
            string name = $"Name = '{dGV.Rows[rowInd].Cells[2].Value.ToString()}'";
            string color = $"Color = '{dGV.Rows[rowInd].Cells[3].Value.ToString()}'";
            string weight = $"Weight = '{dGV.Rows[rowInd].Cells[4].Value.ToString().Replace(',','.')}'";
            string material = $"Material = '{dGV.Rows[rowInd].Cells[5].Value.ToString()}'";
            string num = $"Num = '{dGV.Rows[rowInd].Cells[6].Value.ToString()}'";
            string user = $"User = '{dGV.Rows[rowInd].Cells[7].Value.ToString()}'";


            string query = $"DELETE FROM \"Things\" WHERE {type} AND {count} AND {name} AND {color} AND {weight} AND {material} AND {num} AND {user};"; 

            try
            {
                var res = MessageBox.Show("Вы точно хотите удалить строку?", "Подтверждение удаления.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                SQLiteConnection.Open();
                command = new SQLiteCommand(query, SQLiteConnection);
                if (res == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Удалено.", "Удаление строки.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { SQLiteConnection.Close(); }
        }


    }
}
