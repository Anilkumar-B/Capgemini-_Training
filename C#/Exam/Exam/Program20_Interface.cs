using System;

namespace Exam
{
    // The IDiscountStrategy interface defines the method for calculating discounts
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }

    // No Discount Strategy (no discount applied)
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount;
        }
    }

    // Percentage Discount Strategy (applies a percentage discount)
    public class PercentageDiscount : IDiscountStrategy
    {
        private decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - (totalAmount * _percentage / 100);
        }
    }

    // Fixed Amount Discount Strategy (applies a fixed discount amount)
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private decimal _discountAmount;

        public FixedAmountDiscount(decimal discountAmount)
        {
            _discountAmount = discountAmount;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - _discountAmount;
        }
    }
}
