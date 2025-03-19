using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300046
{
    class SimpleDataBase<T>
    {
        //inisialisasi property storedData dan inputDates
        private List<T> storedData;
        private List<DateTime> inputDates;

        //kontruktor
        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        //method AddNewData
        public void AddNewData(T data1)
        {
            //menambah data baru bertipe T ke dalam list
            this.storedData.Add(data1);

            //menambah waktu saat ini
            this.inputDates.Add(DateTime.Now);
        }

        //method PrintAllData
        public void PrintAllData()
        {
            //mengoutput seluruh data yang tersimpan pada storedData dan inputdates
            int i = 1;
            foreach (var item in storedData)
            {
                Console.WriteLine($"Data {i} berisi: {item}, yang disimpan pada waktu {inputDates[i-1]}");

            }
        }
    }
}
