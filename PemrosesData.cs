using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300046
{
    class PemrosesData
    {


        public static T DapatkanNilaiTerbesar<T>(T data1, T data2, T data3)
        {
            dynamic nilai1 = (dynamic)data1;
            dynamic nilai2 = (dynamic)data2;
            dynamic nilai3 = (dynamic)data3;

            dynamic dataMax = nilai1;


            if (nilai2 > dataMax)
            {
                dataMax = data2;
            } else
            {
                if (nilai3 > dataMax)
                {
                    dataMax = data3;
                }
            }

            return dataMax;
        }


       
    }
}
