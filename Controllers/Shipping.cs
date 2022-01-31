using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoppingCart.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly ILogger<ShippingController> _logger;

        public ShippingController(ILogger<ShippingController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ShippingCalculations Post([FromBody] Product[] productsInCart)
        {
            decimal returnValue = 0M;
            decimal totalOrderValue = 0M;

            for (int i = 0; i < productsInCart.Length; i++) {
                totalOrderValue += productsInCart[i].UnitPrice;
            }

            if (totalOrderValue >= 50M)
                returnValue = 20M;
            else if (totalOrderValue > 0M)
                returnValue = 10M;

            return new ShippingCalculations () { ShippingCost = returnValue};   
        }
    }

    public class ShippingCalculations {
        public decimal ShippingCost { get; set; }
    }
}