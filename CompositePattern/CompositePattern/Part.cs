using System;
namespace CompositePattern
{
    public class Part : IComponent
    {
        private float price;
        private string name;

        public Part(float price, string n)
        {
            this.price = price;
            name = n;
        }

        public float GetSalesPrice() {
            return price;
        }

        public string PrintComponent()
        {
            return name + ", ";
        }
    }
}
