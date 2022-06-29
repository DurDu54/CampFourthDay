using System.Collections.Generic;

namespace Colections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Mücahit", "Hakan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //isimler[3] = "Celil";
            //Console.WriteLine(isimler[3]);
                //***burada program çalışmaz çünkü bizim dizimiz 3 elemanlı olaarka oluşturuldu ve eleman sayısı sonradan depiştirilemez
            
            
            List<string> isimler2 = new List<string>() { "Mücahit", "Hakan"};
            
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Engin");
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Celil");
            Console.WriteLine(isimler2[3]);
                //***liste oluşturulurken boyut istenmez bu sayede sonradan eleman ekleme işleminde sorun çıkmaz
                //istediğiimiz elemanı istediğimiz yerde istediğimiz kadar ekleyebiliriz 

        }
    }
}