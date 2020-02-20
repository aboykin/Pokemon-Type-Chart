using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PokeTypeChart.Models
{
    class TypeHandler
    {
        //Initialize 
        public string Key { get; private set; }
        public DataTable TypeChart { get; set; }

        //Declare property with backing field to set CSV file for handler
        //*Resets TypeChart when directory is added 
        private string _csvFile;
        public string CSVFile
        {
            get
            {
                return _csvFile;
            }
            set
            {
                _csvFile = value;
                RefreshTypeChart();
            }
        }

        //Declare constructor
        public TypeHandler(string _csvFile)
        {
            //Set CSV file
            CSVFile = _csvFile;
        }

        //Create private function to generate TypeChart
        private DataTable GenerateTypeChart(string path)
        {
            //Declare return value
            DataTable tc = new DataTable("Type Chart");

            try 
            {
                //Begin StreamReader
                using (StreamReader sr = new StreamReader(path))
                {
                    //Read in first row of csv and add as column headers
                    string[] headers = sr.ReadLine().Split(',');
                    //Set Key to type names under first column
                    Key = headers[0];
                    //Add columns to DataTable
                    foreach (string header in headers)
                    {
                        tc.Columns.Add(header);
                    }

                    //Begin loop to read rest of file
                    while (!sr.EndOfStream)
                    {
                        //Read in new row
                        string[] rows = sr.ReadLine().Split(',');
                        //Create new data row
                        DataRow row = tc.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            //Set value to 1 if value read is blank or null
                            if (rows[i] == "" || rows[i] == null)
                            {
                                row[i] = "1";
                            }
                            //Add value to row[column]
                            else
                            {
                                row[i] = rows[i];
                            }
                        }
                        //Add row to RowCollection
                        tc.Rows.Add(row);
                    }
                }

                //Set PrimaryKey of table to DataColumn at Key index 
                tc.PrimaryKey = new DataColumn[] { tc.Columns[Key] };
            }
            catch(FileNotFoundException e) 
            {
                tc = null;
            }

            return tc;
        }

        //Declare helper function to load/refresh TypeChart
        public void RefreshTypeChart() 
        {
            //If chart has been initialized, clear it
            if (TypeChart != null)
            {
                TypeChart.Clear();
            }
      
            //Load/reload TypeChart
            TypeChart = GenerateTypeChart(CSVFile);
        }

        //Declare function to return Dictionary containing information of select types
        public Dictionary<string, List<string>> QueryTypes(string type1, string type2) 
        {
            //Initialize retval
            Dictionary<string, List<string>> matchupInfo;

            //If only 1 type is selected, format dictionary for single-type query details
            if (type2 == "None")
            {
                //Return dictionary of type details
                matchupInfo = new Dictionary<string, List<string>>()
                {
                    {"Strengths", QueryTypeStrengths(type1, type2) },
                    {"Weaknesses (2x)", QueryTypeEffectiveness(type1, type2, Effectiveness.SingleWeakness) },
                    {"Resistances (0.5x)", QueryTypeEffectiveness(type1, type2, Effectiveness.SingleResistance) },
                    {"Immunities", QueryTypeEffectiveness(type1, type2, Effectiveness.Immunity) }
                };
            }
            //If 2 types are selected, format dictionary for dual-type query
            else 
            {
                //Return dictionary of type details
                matchupInfo = new Dictionary<string, List<string>>()
                {
                    {"Strengths", QueryTypeStrengths(type1, type2) }, 
                    {"Weaknesses (2x)", QueryTypeEffectiveness(type1, type2, Effectiveness.SingleWeakness) },
                    {"Weaknesses (4x)", QueryTypeEffectiveness(type1, type2, Effectiveness.DoubleWeakness)},
                    {"Resistances (0.5x)", QueryTypeEffectiveness(type1, type2, Effectiveness.SingleResistance) },
                    {"Resistances (0.25x)", QueryTypeEffectiveness(type1, type2, Effectiveness.DoubleResistance) }, 
                    {"Immunities", QueryTypeEffectiveness(type1, type2, Effectiveness.Immunity) }
                };
            }
            
            return matchupInfo;
        }

        //Create method to query type effectiveness
        private List<string> QueryTypeEffectiveness(string type1, string type2, double effectiveness) 
        {
            //For all rows in the chart...
            //...where computed values (single value for 1 type, valueA * valueB for dual type) match desired effectiveness...
            //...return those row names
            List<string> retVal = (from DataRow r in TypeChart.AsEnumerable()
                                where (type2 == "None" ? (Convert.ToDouble(r[type1])) : (Convert.ToDouble(r[type1]) * Convert.ToDouble(r[type2]))) == effectiveness
                                select r[Key].ToString()).ToList<string>();

            //Check and indicate if no types are returned from query
            retVal = CheckIfEmpty(retVal);
            return retVal;
        }

        //Create small helper function to check if a query returns empty and replace it with "None" 
        private List<string> CheckIfEmpty(List<string> query)
        {
            if (!query.Any()) 
            {
                query.Add("None");
            }
            return query;
        }

        //Create function to query types (seperate from others at it queries columns by row instead of rows by columns)
        private List<string> QueryTypeStrengths(string type1, string type2)
        {
            //Query for single-type strengths
            List<string> strengths = (from DataColumn c in TypeChart.Columns                      //for all columns...
                                      where TypeChart.Rows.Find(type1)[c.ColumnName].Equals("2")   //...find the columns in this type's row that equal 2...
                                      select c.ColumnName).ToList<string>();
            //Query for 2nd type strengths if second type is selected
            if (type2 != "None")
            {
                List<string> type2Strengths = (from DataColumn c in TypeChart.Columns                      //for all columns...
                                           where TypeChart.Rows.Find(type2)[c.ColumnName].Equals("2")   //...find the columns in this type's row that equal 2...
                                           select c.ColumnName).ToList<string>();                              //...and return the name of those columns

                //Union strengths of two types
                strengths = strengths.Union(type2Strengths).ToList<string>();
            }

            //Check and indicate if no types are returned from query
            strengths = CheckIfEmpty(strengths);

            //return strengths list
            return strengths;
        }
    
        //Create struct to define effectiveness values
        public struct Effectiveness 
        {
            //Define effectiveness values 
            public const double DoubleResistance = 0.25;
            public const double SingleResistance = 0.5;
            public const double Immunity = 0;
            public const double Normal = 1;
            public const double SingleWeakness = 2;
            public const double DoubleWeakness = 4;
        }

    }
}