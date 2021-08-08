using System;

namespace composite_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeCategory root = new CompositeCategory("Menu", true);
            
            var item1 = new CompositeCategory("Amazon Basics", false);
            var item2 = new CompositeCategory("Sport", false);
            var item3 = new CompositeCategory("Prime Video", false);
            var item4 = new CompositeCategory("Beauty", false);

            var subitem1 = new CompositeCategory("Computer", false);
            subitem1.Add(new Category("Mouse", false));
            subitem1.Add(new Category("Kabel", false));

            var subitem2 = new CompositeCategory("Home", false);
            subitem2.Add(new Category("Kitchen", false));
            subitem2.Add(new Category("Fitness", false));

            item1.Add(subitem1);
            item1.Add(subitem2);

            item2.Add(new Category("Cycling", false));
            item2.Add(new Category("Camping", false));

            root.Add(item1);
            root.Add(item2);
            root.Add(item3);
            root.Add(item4);

            root.Display();
        }
    }
}
