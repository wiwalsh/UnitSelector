using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitsSelector
{
    public partial class Form1 : Form
    {
        private BindingSource source;
        private SelectedUnits sl;

        public Form1()
        {
            InitializeComponent();
            bindDataGridView();

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        private void bindDataGridView()
        {
            sl = new SelectedUnits();

            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "Product ID";
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            cmb.HeaderText = "Select Data";
            cmb.Name = "cmb";
            dataGridView1.Columns.Add(cmb);
            for (int i = 0; i < sl.QuantityTypes.Count; i++)
            {
                DataGridViewRow row1 = new DataGridViewRow();
                row1.Cells.Add(new DataGridViewTextBoxCell() {Value = sl.QuantityTypes[i].ToString()});
                List<string> tempString = new List<string>();

                for (int j = 0; j < sl.UnitsList[i].Count; j++)
                {
                    tempString.Add(sl.UnitsList[i][j].Abbreviation);
                }
                
                row1.Cells.Add(new DataGridViewComboBoxCell() {DataSource = tempString,Value = 1});
                dataGridView1.Rows.Add(row1);
                
            }
        }
    }

}
