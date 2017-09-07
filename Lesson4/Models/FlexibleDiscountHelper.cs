using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson4.Models
{
    public class FlexibleDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalValue)
        {
            decimal discount = totalValue > 100 ? 70 : 25;
            return (totalValue - (discount / 100m * totalValue));
        }
    }
}