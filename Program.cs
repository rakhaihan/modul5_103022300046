﻿using System;

namespace modul5_103022300046
{

    class Program
    {
        static void Main(string[] args)
        {

            int terbesar = PemrosesData.DapatkanNilaiTerbesar(10, 30, 22);

            Console.WriteLine(terbesar);

           

            SimpleDataBase<int> db = new SimpleDataBase<int>();
            //NIM 103022300046
            db.AddNewData(30);
            db.AddNewData(00);
            db.AddNewData(46);

            db.PrintAllData();


        }
    }
}
