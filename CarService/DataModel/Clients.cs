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
            Cars = null;
            Trucks = null;
        }

        public override string ToString()
        {
            string result = "ФИО: " + Name + ";\nНомер телефона: " + Number + ";\nДата заказа: " + OrderDate + ";";
            result += "\nМарка и модель автомобилей: ";
            if (Cars != null)
            {
                foreach (var e in Cars)
                    result += e.Name + " " + e.Model + "; ";
            }
            if (Trucks != null)
            {
                foreach (var e in Trucks)
                    result += e.Name + " " + e.Model + "; ";
            }
            return OrderDone == true ? result + "\nСтатус заказа: выполнен" : result + "\nСтатус заказа: не выполнен";
        }

        //public override bool Equals(object obj)
        //{
        //    var element = obj as Clients;
        //    return element.Name == Name && element.Number == Number;
    }
    /// <summary>
    /// Класс, созданный для преобразования введённого номера телефона
    /// в любом формате в единый общепринятый формат. На данный момент
    /// класс недоработан. Создан ради интереса :)
    /// </summary>
    public class PhoneNumber
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
