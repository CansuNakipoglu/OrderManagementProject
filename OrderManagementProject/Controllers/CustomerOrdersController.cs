using Microsoft.AspNetCore.Mvc;
using OrderManagementProject.Models;
using OrderManagementProject.Models.ViewModels;

namespace OrderManagementProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        private static int LastOrderId = 1;
        private static int LastCustomerId = 1;
        public IActionResult Index()
        {
            var customerOrders = new List<CustomerOrder>
            {

               new() {
                   Customer = CreateCustomer("Cansu", "Esergün", "cansuesergun@gmail.com"),
                   Orders =
                   [
                       CreateOrder("Telefon", 8800, 1),
                       CreateOrder("Bilgisayar", 75000, 1)
                   ]
               },

               new() {
                  Customer = CreateCustomer("Ezgi", "Nakip", "ezginakip@gmail.com"),
                  Orders =
                  [
                      CreateOrder("Kalem", 100, 15),
                      CreateOrder("Bant", 40, 2),
                      CreateOrder("Makas", 80, 1)
                  ]
               },

               new() {
                  Customer = CreateCustomer("Irmak", "Nakip", "irmaknakip@gmail.com"),
                  Orders =
                  [
                      CreateOrder("Kalem", 100, 15)
                  ]
               }

            };

            return View(customerOrders);
        }

        private Order CreateOrder(string productName, decimal price, int quantity)
        {
            var order = new Order
            {
                Id = LastOrderId++,
                ProductName = productName,
                Price = price,
                Quantity = quantity
            };

            return order;
        }
        private Customer CreateCustomer(string firstName, string lastName, string email)
        {
            var customer = new Customer
            {
                Id = LastCustomerId++,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            return customer;
        }
    }
}
