using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class Vechiles
    {
        /// <summary>
        /// ВИН код автотранспорта
        /// </summary>
        public string VIN { get; set; }
        /// <summary>
        /// Модель автотранспорта
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Объём двигателя автотранспорта
        /// </summary>
        public double EngineVolume { get; set; }
        /// <summary>
        /// Год выпуска автотранспорта
        /// </summary>
        public DateTime ManufactureYear { get; set; }
        /// <summary>
        /// Список неисправностей автотранспорта
        /// </summary>
        public List<string> DefectsDescription;
    }
}
