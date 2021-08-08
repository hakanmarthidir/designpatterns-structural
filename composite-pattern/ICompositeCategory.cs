namespace composite_pattern
{
    public interface ICompositeCategory : ICategory
    {
        int Count();
        void Add(ICategory item);
        void Remove(ICategory item);
       
    }
}
