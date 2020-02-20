using PokeTypeChart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeTypeChart
{
    partial class ChartDisplay : Form
    {
        public ChartDisplay()
        {
            InitializeComponent();
        }

        //Set copy constructor to set DataGridView.Datasource to TypeChart
        public ChartDisplay(TypeHandler typeDB) : this() 
        {
            //set Data
            this.chartView.DataSource = typeDB.TypeChart;
        }
    }
}
