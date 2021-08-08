using System;
using System.Collections.Generic;

namespace composite_pattern
{
    public class CompositeCategory : ICompositeCategory
    {
        public string Name { get; set; }
        public bool IsRoot { get; set; } = true;

        private readonly IList<ICategory> subCategories = new List<ICategory>();

        public CompositeCategory(string name, bool isRoot)
        {
            this.Name = name;
            this.IsRoot = isRoot;
        }

        public int Count()
        {
            return subCategories.Count;
        }

        public void Add(ICategory item)
        {
            this.subCategories.Add(item);
        }

        public void Remove(ICategory item)
        {
            this.subCategories.Remove(item);
        }

        public void Display()
        {
            Console.WriteLine($"{Name} - {this.Count()}");

            foreach (var category in subCategories)
            {
                category.Display();
            }
        }
    }




}
