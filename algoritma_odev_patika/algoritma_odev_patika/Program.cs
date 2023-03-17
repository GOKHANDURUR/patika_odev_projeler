using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritma_odev_patika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ******* BİRİNCİ SORU ******
            Console.Write("Kaç pozitif sayı gireceksin: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int [] Sayilar=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("sayı giriniz: ");
                Sayilar[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("yazdığınız çift sayılar: ");
            foreach (int i in Sayilar)
            {
                if (i % 2 == 0)
                {
                    
                    Console.Write(i+"-");
                }
            }
            ******* İKİNCİ SORU ******
            Console.Write("Kaç pozitif sayı gireceksin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("MOD: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] Sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("sayı giriniz: ");
                Sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            foreach (int i in Sayilar)
            {
               
                    Console.Write("{0} sayısının {1} sayısına göre kalan: ",i,m);
                    Console.WriteLine(i%m);
                
            }
             *******ÜÇÜNCÜ SORU ******
             
            Console.Write("Kaç kelime gireceksin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            string[] Sayilar = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("kelimeyi giriniz: ");
                Sayilar[i] =(Console.ReadLine());
            }
                        
            for (int i = Sayilar.Length-1; i >=0; i--)
            {
                Console.WriteLine(Sayilar[i]);
            }

            *******DÖRDÜNCÜ SORU ******

            Console.WriteLine("BİR CÜMLE YAZINIZ: ");
            string [] Cumle=Console.ReadLine().Split(' ');
            Console.WriteLine("kelime sayısı: "+Cumle.Length);
            int harfsayisi=0;
            foreach(string s in Cumle)
            {
                int b = s.Length;
                harfsayisi=harfsayisi+b;
            }
            Console.WriteLine("harf sayısı: "+harfsayisi);
            
            Console.ReadKey();

            */

        }
    }
}
