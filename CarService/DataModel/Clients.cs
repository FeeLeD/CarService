using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    /// <summary>
    /// База клиентов. В базу будет добавляться каждый новый клиент
    /// </summary>
    public class ClientBase
    {
        public List<Clients> List = new List<Clients>();
    }

    public class Clients
    {
        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public PhoneNumber Number { get; set; }
        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Список легковых и грузовых автомобилей клиента (в случае, если у клиента несколько транспортных средств)
        /// </summary>
        public List<Cars> Cars;
        public List<Trucks> Trucks;
        /// <summary>
        /// Выполнение заказа клиента. Выполнен, или нет
        /// </summary>
        public bool OrderDone = false;

        public Clients()
        {
            Cars = new List<Cars>();
            Trucks = new List<Trucks>();
        }

        public override string ToString()
        {
            return OrderDone == true ? Name + " (" + Number + ") | Статус заказа: выполнен" :
                Name + " (" + Number + ") | Статус заказа: не выполнен";
        }
    }
    /// <summary>
    /// Класс, созданный для преобразования введённого номера телефона
    /// в любом формате в единый общепринятый формат. На данный момент
    /// класс недоработан. Создан ради интереса :)
    /// </summary>
    public class PhoneNumber
    {
        public string Number { get; set; }

        public override string ToString()
        {
            if (Number != "")
            {
                var fixedNumber = "";
                var stringsArray = Number.Split(' ');

                foreach (var e in stringsArray)
                    fixedNumber += e;

                Number = fixedNumber;
            }
            return Number;
        }
    }
}
