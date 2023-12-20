using System.Reflection;

namespace CO2EmissionChart
{
    public class ViewModel
    {
        private List<Model>? co2_Emission_Fuel_Consumption;
        public List<Model>? CO2_Emission_Fuel_Consumption
        {
            get { return co2_Emission_Fuel_Consumption; }
            set
            {
                co2_Emission_Fuel_Consumption = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ViewModel()
        {
            CO2_Emission_Fuel_Consumption = new List<Model>(ReadCSV());
        }

        public IEnumerable<Model> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream? inputStream = executingAssembly.GetManifestResourceStream("CO2EmissionChart.Resources.Raw.fuel_co2_emission.csv");

            string? line;
            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            lines.RemoveAt(0);
            return lines.Select(line =>
            {
                string[] data = line.Split(',');

                return new Model(data[0].ToString(), Convert.ToDouble(data[1]), Convert.ToDouble(data[2]));
            });
        }
    }
}
