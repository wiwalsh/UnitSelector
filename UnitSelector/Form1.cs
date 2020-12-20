using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitsSelector
{
    public partial class Form1 : Form
    {
        private SelectedUnits units;
        private BindingSource source1;
        private BindingSource source2;

        public Form1()
        {
            InitializeComponent();
            units = new SelectedUnits();


            bindDataGridView();

        }

        private void bindDataGridView()
        {
            source2 = new BindingSource();//units.SelectedUnitIndex.ToArray(), null);
            dataGridView1.AutoGenerateColumns = true;
            source2.DataSource = units.SelectedUnitIndex;
            dataGridView1.DataSource = source2;
        }   
        
     

    }
}
