using System;

namespace CompositePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Part module_1 = new Part(2, "module 1");
            Part module_2 = new Part(4, "module 2");
            Part module_3 = new Part(6, "module 3");

            CompositePart product_1 = new CompositePart("Product 1");
            product_1.AddComponent(module_1);
            product_1.AddComponent(module_2);
            product_1.AddComponent(module_3);
            product_1.AddComponent(new Part(2, "module 1"));

            CompositePart product_2 = new CompositePart("Product 2");
            product_2.AddComponent(new Part(2, "module 1"));
            product_2.AddComponent(new Part(4, "module 2"));
            product_2.AddComponent(new Part(6, "module 3"));
            product_2.AddComponent(product_1);

            CompositePart product_3 = new CompositePart("Product 3");
            product_3.AddComponent(new Part(4, "module 2"));
            product_3.AddComponent(product_2);

            CompositePart product_4 = new CompositePart("Product 4");
            product_4.AddComponent(new Part(2, "module 1"));
            product_4.AddComponent(new Part(4, "module 2"));
            product_4.AddComponent(new Part(6, "module 3"));

            CompositePart product_5 = new CompositePart("Product 5");
            product_5.AddComponent(product_3);
            product_5.AddComponent(product_4);
            product_5.AddComponent(new Part(6, "module 6"));



            Console.WriteLine("Module 1 price:  " + module_1.GetSalesPrice());
            Console.WriteLine("Module 2 price: " + module_2.GetSalesPrice());
            Console.WriteLine("Module 3 price: " + module_3.GetSalesPrice());

            Console.WriteLine("Product 1 price: " + product_1.GetSalesPrice());
            Console.WriteLine("Product 2 price: " + product_2.GetSalesPrice());
            Console.WriteLine("Product 5 price: " + product_5.GetSalesPrice());

            Console.WriteLine( product_3.PrintComponent());
            Console.WriteLine( product_5.PrintComponent());


        }
    }
}
