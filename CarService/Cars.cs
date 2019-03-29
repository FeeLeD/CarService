using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    /// <summary>
    /// Легковые автомобили
    /// </summary>
    class Cars : Vechiles
    {
        /// <summary>
        /// Название легкового автомобиля
        /// </summary>
        public CarNames Name;

        public Cars(CarNames name, string vin, string model, double engine, DateTime year)
        {
            Name = name;
            VIN = vin;
            Model = model;
            EngineVolume = engine;
            ManufactureYear = year;
            DefectsDescription = new List<string>();
        }

        public override string ToString()
        {
            return Name + " " + Model;
        }
    }
}
