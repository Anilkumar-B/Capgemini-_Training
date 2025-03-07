using Exam;
using System;

namespace Exam
{
    // ShoppingCart class that uses different discount strategies
    public class ShoppingCart
    {
        private decimal _totalAmount;
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(decimal totalAmount)
        {
            _totalAmount = totalAmount;
        }

        // Set the discount strategy dynamically
        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        // Calculate the total amount after applying the selected discount
        public decimal CalculateTotal()
        {
            return _discountStrategy.ApplyDiscount(_totalAmount);
        }
    }
}
