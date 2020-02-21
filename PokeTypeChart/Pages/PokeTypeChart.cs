using PokeTypeChart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeTypeChart
{
    public partial class PokeTypeForm : Form
    {

        //intizalize and create type chart
        TypeHandler typeHandler = new TypeHandler(@"Resources\typechart.csv");

        //initialize boolean flag to toggle for single and dual queries
        bool singleTypeQuery = true;

        //form constructor
        public PokeTypeForm()
        {
            //Initialize form components
            InitializeComponent();

            //Add simple error checking (just for thoroughness's sake; will update later) 
            if (typeHandler.TypeChart == null) 
            {
                //If typechart is null, can't proceed; prompt user and return
                MessageBox.Show("Error loading type chart");
                typeDetailBox.Text = "Error loading type chart";
                return; 
            }

            //Wire up combobox datasources of to TypeChart[Key] row names
            type1Box.DataSource = typeHandler.TypeChart.AsEnumerable()
                                    .Select(r => r.Field<string>(typeHandler.Key)).ToList();

            type2Box.DataSource = typeHandler.TypeChart.AsEnumerable()
                                    .Select(r => r.Field<string>(typeHandler.Key)).ToList();

            //Define custom EventHandlers
            //*so WinForms designer won't overwrite them in Designer class
            type1Box.SelectedIndexChanged += new System.EventHandler(SelectedTypeChangedEvent);
            type2Box.SelectedIndexChanged += new System.EventHandler(SelectedTypeChangedEvent);
            enableDualTypeBtn.Click += new System.EventHandler(enableDualTypeBtn_Click);
            enableDualTypeBtn.Click += new System.EventHandler(SelectedTypeChangedEvent);
            viewChartBtn.Click += new System.EventHandler(viewChartBtn_Click);
        }

        //create function to update label everytime type changes in ComboBoxes
        private void DisplayQuery(string typesQueried, Dictionary<string, List<string>> results)
        {
            //initialize variable for type content
            string content = "";

            //Add section to list queried types
            content += ("---" + typesQueried + "---" + "\n");

            //Print dictionary returned from query results
            foreach (KeyValuePair<string, List<string>> x in results) 
            {
                content += x.Key + ": " + String.Join(", ", x.Value) + "\n"; 
            }

            //Set DetailBox text to content string           
            typeDetailBox.Text = content + "\n";
        }

        //Declare event function to handle when new type is selected
        private void SelectedTypeChangedEvent(object sender, EventArgs e) 
        {
            //Display single query if only 1 query is selected or if both boxes show the same type
            if (singleTypeQuery || type1Box.SelectedItem == type2Box.SelectedItem)
            {
                //Display result of query
                DisplayQuery(type1Box.SelectedItem.ToString(), typeHandler.QueryTypes(type1Box.SelectedItem.ToString(), "None"));
            }
            //Display dual query if two types are selected
            else
            {
                //Join names of types for easier display
                string types = String.Join(", ", type1Box.SelectedItem, type2Box.SelectedItem);
                //Display result of query
                DisplayQuery(types
                , typeHandler.QueryTypes(type1Box.SelectedItem.ToString(), type2Box.SelectedItem.ToString()));
            }
        }

        //Declare event function to handle enable/disabling dual type query
        private void enableDualTypeBtn_Click(object sender, EventArgs e)
        {
            //Toggle single and dual types by changing bool flag and enabling/disabling combobox 
            singleTypeQuery = !singleTypeQuery;
            type2Lbl.Enabled = !type2Lbl.Enabled;
            type2Box.Enabled = !type2Box.Enabled;
            enableDualTypeBtn.Text = singleTypeQuery ? "Enable 2nd Type" : "Disable 2nd Type";
        }

        //Declare event function to handle displaying TypeChart
        private void viewChartBtn_Click(object sender, EventArgs e)
        {
            //Declare and show ChartDisplay
            ChartDisplay cd = new ChartDisplay(typeHandler);
            cd.ShowDialog(this);
        }
    }
}


