using System;

namespace Lesson4.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalValue);
    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal _discountSize;

        public DefaultDiscountHelper(decimal discountSize)
        {
            _discountSize = discountSize;
        }
        public decimal ApplyDiscount(decimal totalValue)
        {
            return (totalValue - (_discountSize / 100m * totalValue));
        }
    }
}