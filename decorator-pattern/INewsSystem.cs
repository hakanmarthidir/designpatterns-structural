namespace decorator_pattern
{
    public interface INews
    {
        int Id { get; set; }
        string Title { get; set; }
        string Content { get; set; }
        void Publish();
    }




}
