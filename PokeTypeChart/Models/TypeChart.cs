using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTypeChart.Models
{
    class TypeChart
    {
        public string Key { get; set; }
        public DataTable Chart { get; set; }

        public TypeChart() 
        {
            Key = "";
            Chart = new DataTable();
        }
    }
}
