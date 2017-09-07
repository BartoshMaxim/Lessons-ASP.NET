using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper _discounter;
        private static int counter = 0;

        public LinqValueCalculator(IDiscountHelper discounter)
        {
            _discounter = discounter;
            System.Diagnostics.Debug.WriteLine(string.Format("Экземпляр класса LinqValueCalculator №{0} создан", ++counter));
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return _discounter.ApplyDiscount(products.Sum(p =>p.Price ));
        }
    }
}