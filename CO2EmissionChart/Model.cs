using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2EmissionChart
{
    public class Model
    {
        public double CO2_Emissions { get; set; }
        public double Fossil_fuel { get; set; }
        public string Countries { get; set; }

        public Model(string countries, double CO2_emission, double fuel)
        {
            Countries = countries;
            CO2_Emissions = CO2_emission;
            Fossil_fuel = fuel;
        }
    }
}
