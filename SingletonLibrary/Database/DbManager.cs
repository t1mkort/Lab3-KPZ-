using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SingletonLibrary
{
    public class DbManager
    {
        private static DbManager instance;

        private DataTable subscribers;

        private DbManager()
        {
            subscribers = new DataTable();

            subscribers.Columns.Add("Номер", typeof(string));
            subscribers.Columns.Add("ПІБ", typeof(string));
            subscribers.Columns.Add("Тариф", typeof(string));
        }

        public static DbManager GetInstance()
        {
            if (instance == null)
            {
                instance = new DbManager();
            }

            return instance;
        }

        public void AddSubscriber(string number, string fullName, string tariff)
        {
            if (FindSubscriber(number) != null)
            {
                throw new InvalidOperationException(
                    "Абонент з таким номером уже існує."
                );
            }

            subscribers.Rows.Add(number, fullName, tariff);
        }

        public DataRow FindSubscriber(string number)
        {
            foreach (DataRow row in subscribers.Rows)
            {
                if (row["Номер"].ToString() == number)
                {
                    return row;
                }
            }

            return null;
        }

        public DataTable GetSubscribers()
        {
            return subscribers;
        }
    }
}