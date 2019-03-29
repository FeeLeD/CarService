using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    /// <summary>
    /// Грузовые автомобили
    /// </summary>
    class Trucks : Vechiles
    {
        /// <summary>
        /// Название грузового автомобиля
        /// </summary>
        public TruckNames Name;

        public Trucks(TruckNames name, string vin, string model, double engine, DateTime year)
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
