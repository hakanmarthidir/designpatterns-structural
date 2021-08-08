namespace facade_pattern
{
    public class OrderFacade
    {
        protected Product _product;
        protected Client _client;
        protected Order _order;

        public OrderFacade()
        {
            this._product = new Product();
            this._client = new Client();
            this._order = new Order();
        }

        public OrderFacade(Product product, Client client, Order order)
        {
            this._product = product;
            this._client = client;
            this._order = order;
        }

        public void CreateOrder()
        {
            this._product.CheckProductAvailability();
            this._client.CheckClientInfo();
            this._order.Create();
        }
    
    }
}
