using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarization
{
    public partial class Form1 : Form
    {
        string curUser = "";
        Detect_User user;
        DataBase data;
        public Form1()
        {
            InitializeComponent();
            user = new Detect_User();
            curUser = user.Name;
            data = new DataBase();
            ShowDB();
        }

        private void ShowDB()
        {
            data.ShowDB(mainDGV);

            UpdateType();
            UpdateName();
            UpdateColor();
            UpdateMatherial();
            UpdateNum();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (tBType.Text != "" && tBCount.Text != "" && tBName.Text != "" && tBNum.Text != "")
            {
                data.InsertRowToDB(tBType.Text, tBCount.Text, tBName.Text, tBColor.Text, tBWeight.Text, tBMaterial.Text, tBNum.Text, curUser);

                ShowDB();
            }
            else
            {
                MessageBox.Show("Не заполненны обязательные поля (Тип, Кол-во, Название, Номер аудитории)", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tBCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tBWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void UpdateType()
        {
            DataTable dataTable = new DataTable();
            dataTable = data.GetType();

            cmBType.Items.Clear();

            cmBType.Items.Add("");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cmBType.Items.Add(dataTable.Rows[i].ItemArray[0]);
            }
        }

        private void UpdateName()
        {
            DataTable dataTable = new DataTable();
            dataTable = data.GetName();

            cmBName.Items.Clear();

            cmBName.Items.Add("");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cmBName.Items.Add(dataTable.Rows[i].ItemArray[0]);
            }
        }

        private void UpdateColor()
        {
            DataTable dataTable = new DataTable();
            dataTable = data.GetColor();

            cmBColor.Items.Clear();

            cmBColor.Items.Add("");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cmBColor.Items.Add(dataTable.Rows[i].ItemArray[0]);
            }
        }

        private void UpdateMatherial()
        {
            DataTable dataTable = new DataTable();
            dataTable = data.GetMaterial();

            cmBMaterial.Items.Clear();

            cmBMaterial.Items.Add("");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cmBMaterial.Items.Add(dataTable.Rows[i].ItemArray[0]);
            }
        }

        private void UpdateNum()
        {
            DataTable dataTable = new DataTable();
            dataTable = data.GetNum();

            cmBNum.Items.Clear();

            cmBNum.Items.Add("");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cmBNum.Items.Add(dataTable.Rows[i].ItemArray[0]);
            }
        }

        private void btnFilter2_Click(object sender, EventArgs e)
        {
            if (cmBType.Text != "" || cmBName.Text != "" || cmBColor.Text != "" || cmBMaterial.Text != "" || cmBNum.Text != "" || tBVal1.Text != "" || tBVal2.Text != "")
            {
                if ((cmBDef1.SelectedIndex < 1 && tBVal1.Text != "") || (cmBDef1.SelectedIndex == -1 && tBVal1.Text != ""))
                {
                    MessageBox.Show("Заполните условия", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((cmBDef2.SelectedIndex < 1 && tBVal2.Text != "") || (cmBDef2.SelectedIndex == -1 && tBVal2.Text != ""))
                {
                    MessageBox.Show("Заполните условия", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string addQuery = "";

                string type = "";
                string name = "";
                string color = "";
                string material = "";
                string num = "";
                string count = "";
                string weight = "";

                if (cmBType.Text != "")
                    type = $"Type = '{cmBType.Text}'";
                if (cmBName.Text != "")
                    name = $"Name = '{cmBName.Text}'";
                if (cmBColor.Text != "")
                    color = $"Color = '{cmBColor.Text}'";
                if (cmBMaterial.Text != "")
                    material = $"Material = '{cmBMaterial.Text}'";
                if (cmBNum.Text != "")
                    num = $"Num = '{cmBNum.Text}'";
                if (cmBDef1.Text != "" && tBVal1.Text != "")
                    count = $"Count {cmBDef1.Text} '{tBVal1.Text}'";
                if (cmBDef2.Text != "" && tBVal2.Text != "")
                    weight = $"Weight {cmBDef2.Text} '{tBVal2.Text}'";

                string result_string = $" WHERE {type} AND {name} AND {color} AND {material} AND {num} AND {count} AND {weight}";

                while ((result_string.Remove(0, 7)).IndexOf(" AND ") == 0)
                    result_string = result_string.Remove(7, 5);
                while (result_string.IndexOf(" AND  AND ") != -1)
                    result_string = result_string.Replace(" AND  AND ", " AND ");
                while (result_string.IndexOf(" AND ", result_string.Length - 5) == result_string.Length - 5)
                    result_string = result_string.Remove(result_string.Length - 5);

                addQuery = $"{result_string}";

                data.ShowDB(mainDGV, addQuery);

            }
            else
            {
                MessageBox.Show("Поля не заполненны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmBType.SelectedIndex = 0;
            cmBName.SelectedIndex = 0;
            cmBColor.SelectedIndex = 0;
            cmBMaterial.SelectedIndex = 0;
            cmBNum.SelectedIndex = 0;
            cmBDef1.SelectedIndex = 0;
            cmBDef2.SelectedIndex = 0;
            tBVal1.Text = "";
            tBVal2.Text = "";
            data.ShowDB(mainDGV);
        }

        private void mainDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mainDGV.Columns[e.ColumnIndex].HeaderText == "Удаление" && (e.RowIndex > -1 || e.ColumnIndex > -1))
            {
                data.DeleteRowFromDB(mainDGV, e.RowIndex, e.ColumnIndex);
                data.ShowDB(mainDGV);

            }
        }
    }
}
