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
    public class Cars : Vechiles
    {
        /// <summary>
        /// Название легкового автомобиля
        /// </summary>
        public CarNames Name { get; set; }

        public Cars()
        {
            DefectsDescription = new List<string>();
        }

        public override string ToString()
        {
            return Name + " " + Model;
        }
    }
}
