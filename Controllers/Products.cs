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

            list.Add(new Product() { Id = 1, Title = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 LaptopsFirst product", Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 2, Title = "Mens Casual Premium Slim Fit T-ShirtsSecond product", Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", UnitPrice = 20.00M });
            list.Add(new Product() { Id = 3, Title = "Mens Cotton Jacket", Image = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg", UnitPrice = 10.50M }); 
            list.Add(new Product() { Id = 4, Title = "Mens Casual Slim Fit", Image = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 5, Title = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet", Image = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 6, Title = "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5", Image = "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 7, Title = "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive", Image = "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg", UnitPrice = 1.50M });
            list.Add(new Product() { Id = 8, Title = "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats", Image = "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg", UnitPrice = 10.50M });
            list.Add(new Product() { Id = 9, Title = "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA)", Image = "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg", UnitPrice = 12.50M });
            list.Add(new Product() { Id = 10, Title = "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s", Image = "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg", UnitPrice = 7.95M });
            list.Add(new Product() { Id = 11, Title = "Rain Jacket Women Windbreaker Striped Climbing Raincoats", Image = "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg", UnitPrice = 13.00M });
            list.Add(new Product() { Id = 12, Title = "DANVOUY Womens T Shirt Casual Cotton Short", Image = "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg", UnitPrice = 14.75M });
            
            return list.ToArray();
        }
    }
}
