namespace facade_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();
            product.CheckProductAvailability();

            Client client = new Client();
            client.CheckClientInfo();

            Order order = new Order();
            order.Create();

            //FACADE USAGE
            //Instead of this u can use the Facade approach 

            OrderFacade orderFacade = new OrderFacade(new Product(), new Client(), new Order());
            orderFacade.CreateOrder();

            OrderFacade orderFacade2 = new OrderFacade();
            orderFacade2.CreateOrder();

        }
    }
}
