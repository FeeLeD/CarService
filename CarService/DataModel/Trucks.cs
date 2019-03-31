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
    public class Trucks : Vechiles
    {
        /// <summary>
        /// Название грузового автомобиля
        /// </summary>
        public TruckNames Name { get; set; }

        public Trucks()
        {
            DefectsDescription = new List<string>();
        }

        public override string ToString()
        {
            return Name + " " + Model;
        }
    }
}
