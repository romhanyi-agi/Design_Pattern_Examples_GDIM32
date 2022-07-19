using System;
using System.Collections.Generic;

namespace CompositePattern
{
    // Composite class
    public class CompositePart : IComponent
    {
        private List<IComponent> componentList = new List<IComponent>();
        private float price;
        private string name;

        public CompositePart(string name)
        {
            this.name = name;
        }

        public void AddComponent(IComponent component)
        {
            componentList.Add(component);
        }

        public void RemoveHerd(IComponent component)
        {
            componentList.Remove(component);
        }

        public float GetSalesPrice()
        {
            price = 0;
            foreach (IComponent component in componentList)
            {
               price += component.GetSalesPrice();
            }
            return price;
        }

        public string PrintComponent()
        {
            string components = "";
            foreach (IComponent component in componentList)
            {
                components += component.PrintComponent();
            }
            return name + " [" + components + "]";
        }
    }
}