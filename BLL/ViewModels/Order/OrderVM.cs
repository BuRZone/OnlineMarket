namespace OnlineMarket.BLL.ViewModels.Order
{
    internal class OrderVM
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public byte[]? ProductPhoto { get; set; }

        public string Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string DateCreate { get; set; }
    }
}
