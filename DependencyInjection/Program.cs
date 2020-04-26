using System;

namespace DependencyInjectionWithoutSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.Save();
        }
    }

    class EFProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with Ef");
        }
    }

    class ProductManager
    {
        public void Save()
        {

            //Business Code
            EFProductDal productDal = new EFProductDal();
            productDal.Save();
        }
    }

}
