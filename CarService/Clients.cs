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
    class ClientBase
    {
        public List<Clients> Base = new List<Clients>();
    }

    class Clients
    {
        /// <summary>
        /// ФИО клиента
        /// </summary>
        public string Name;
        /// <summary>
        /// Телефон
        /// </summary>
        public PhoneNumber Number;
        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime OrderDate;
        /// <summary>
        /// Список легковых и грузовых автомобилей клиента (в случае, если у клиента несколько транспортных средств)
        /// </summary>
        public List<Cars> Cars;
        public List<Trucks> Trucks;
        /// <summary>
        /// Выполнение заказа клиента. Выполнен, или нет
        /// </summary>
        public bool OrderDone;

        public Clients(string name, PhoneNumber number, DateTime date, List<Cars> cars = null, List<Trucks> trucks = null)
        {
            Name = name;
            Cars = cars;
            Trucks = trucks;
            Number = number;
            OrderDate = date;
            OrderDone = false;
        }

        public override string ToString()
        {
            return OrderDone == true ? Name + ", заказ выполнен" : Name + ", заказ не выполнен";
        }

        public override bool Equals(object obj)
        {
            var element = obj as Clients;
            return element.Name == Name && element.Number == Number;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
    /// <summary>
    /// Класс, созданный для преобразования введённого номера телефона
    /// в любом формате в единый общепринятый формат. На данный момент
    /// класс недоработан. Создан ради интереса :)
    /// </summary>
    class PhoneNumber
    {
        private string Number;
        public PhoneNumber(string number)
        {
            var fixedNumber = "";
            var stringsArray = number.Split(' ');

            foreach (var e in stringsArray)
                fixedNumber += e;

            Number = fixedNumber;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}
