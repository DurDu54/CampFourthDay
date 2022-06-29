using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampFourthDay_OOP_
{
    class ProductManager
    {
        public void Add(Product product)
        {
            //referans tip Burada yaptığımız değişiklikler heapde olduğu için program.cs de de değişir
            //değer tip olsaydı sadece sadece bu metot içinde değişiklik olacaktı program.cs de bişey değişmeyecekti

            Console.WriteLine(product.ProductName + " eklendi.");

        }
        public void update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }
    }
}
