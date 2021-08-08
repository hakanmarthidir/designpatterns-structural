using System;

namespace composite_pattern
{
    public class Category : ICategory
    {
        public string Name { get; set; }
        public bool IsRoot { get; set; } = false;

        public Category(string name, bool isRoot)
        {
            this.Name = name;
            this.IsRoot = isRoot;
        }

        public void Display()
        {
            Console.WriteLine("\t"+this.Name);
        }
    }




}
