public class ProductModelConstants
{
    public class Common
    {
        public const int Zero = 0;
        public const int MinNameLength = 2;
        public const int MaxNameLength = 50;
        public const int MinDescriptionLength = 2;
        public const int MaxDescriptionLength = 500;
        public const decimal MinPriceAmount = 0.01m; // Assuming a minimum price of $0.01
        public const double MinWeightValue = 0.01; // Assuming a minimum weight of 0.01 units
    }

    public class Price
    {
        public const int MaxAmountDigits = 10; // Assuming a maximum of 10 digits for the price amount
        public const int MaxCurrencyLength = 3; // Assuming a maximum currency code length of 3 characters
    }

    public class Weight
    {
        public const int MaxValueDigits = 10; // Assuming a maximum of 10 digits for the weight value
        public const int MaxUnitLength = 10; // Assuming a maximum length of 10 characters for the weight unit
    }
}