using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    class Vechiles
    {
        /// <summary>
        /// ВИН код автотранспорта
        /// </summary>
        public string VIN;
        /// <summary>
        /// Модель автотранспорта
        /// </summary>
        public string Model;
        /// <summary>
        /// Объём двигателя автотранспорта
        /// </summary>
        public double EngineVolume;
        /// <summary>
        /// Год выпуска автотранспорта
        /// </summary>
        public DateTime ManufactureYear;
        /// <summary>
        /// Список неисправностей автотранспорта
        /// </summary>
        public List<string> DefectsDescription;
    }
}
