using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeKamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double dolarDun = 27.85;
            //double dolarBugun = 27.85;

            //if (dolarDun<dolarBugun)
            //{
            //    Console.WriteLine("Dolar Arttı");
            //}
            //else if (dolarDun>dolarBugun)
            //{
            //    Console.WriteLine("Dolar Düştü");
            //}
            //else
            //{
            //    Console.WriteLine("Kur Değişmedi");


            //}

            //Console.ReadLine();
            string[] gezilecekYerler = new string[] {"İzmir","İstanbul","Muğla","Kastamonu","Samsun","Kars",
            "Kırşehir","Çorum","Adana"};

            for (int i = 0; i < gezilecekYerler.Length; i++) 
            {

                Console.WriteLine(gezilecekYerler[i]);

            }
            Console.WriteLine("-------  for bitti  ------");

            foreach (string gezilecekYer in gezilecekYerler)
            {
                Console.WriteLine(gezilecekYer);
            }


            Console.WriteLine( "Yeni Yerlere Bakalım ^_^ " );

            Console.ReadLine();


        }
    }
}
