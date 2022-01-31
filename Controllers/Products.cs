using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoppingCart.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var list = new List<Product>();

            list.Add(new Product() { Id = 1, Title = "First product", Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 2, Title = "Second product", Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", UnitPrice = 20.00M });
            list.Add(new Product() { Id = 3, Title = "Third product", Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", UnitPrice = 10.50M }); 
            list.Add(new Product() { Id = 4, Title = "Fourth product", Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 5, Title = "Fifth product", Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 6, Title = "Sixth product", Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 7, Title = "Seventh product", Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", UnitPrice = 1.50M });
            list.Add(new Product() { Id = 8, Title = "Product 8", Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 9, Title = "Backpack", Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", UnitPrice = 12.50M });
            list.Add(new Product() { Id = 10, Title = "Sun glasses", Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg" });
            list.Add(new Product() { Id = 11, Title = "Fruits", Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", UnitPrice = 13.00M });
            list.Add(new Product() { Id = 12, Title = "French fries", Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", UnitPrice = 14.75M });
            
            return list.ToArray();
        }
    }
}
