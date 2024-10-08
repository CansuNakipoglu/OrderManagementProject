namespace OrderManagementProject.Models.ViewModels
{
    public class CustomerOrder
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
