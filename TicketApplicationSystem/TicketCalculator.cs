using System;

namespace TicketApplicationSystem
{
    public static class TicketCalculator
    {
        public static double CalculatePrice(int age, double distance, int categoryIndex, bool isFemale)
        {
            if (age < 0)
                throw new ArgumentOutOfRangeException(nameof(age));

            if (distance < 0)
                throw new ArgumentOutOfRangeException(nameof(distance));

            if (categoryIndex < 0 || categoryIndex > 2)
                throw new ArgumentOutOfRangeException(nameof(categoryIndex));

            if (age < 12)
                return 0;

            double rate = categoryIndex switch
            {
                0 => 20,
                1 => 35,
                2 => 50,
                _ => throw new ArgumentException("Invalid category index")
            };

            double price = rate * distance;

            if (isFemale)
                price *= 0.5;

            return price;
        }
    }
}