namespace Household
{
    public class CoffeeMachine
    {
        public int water_Amount;
        public int coffee_Amount;
        public string brand;
        public const int water_Limit = 1000;
        public const int coffee_Limit = 500;
        public const int grounds_Limit = 100;
        public int grounds_Amount;

        public CoffeeMachine(string Brand)
        {
            this.brand = Brand;

            if (string.IsNullOrEmpty(Brand))
            {
                throw new ArgumentException("Brand cannot be empty or null.");
            }
        }

        public void AddWater(int amount_w)
        {
            if (amount_w <= 0)
            {
                throw new ArgumentException("Amount accepts only positive amount of water");
            }

            if (water_Amount + amount_w > water_Limit)
            {
                throw new ArgumentException("You cannot add more water than the limit");
            }

            water_Amount += amount_w;
        }

        public void AddCoffee(int amount_c)
        {
            if (amount_c <= 0)
            {
                throw new ArgumentException("Coffee amount accepts only positive amount of coffee");
            }
            if (coffee_Amount + amount_c > coffee_Limit)
            {
                throw new ArgumentException("You cannot add more coffee than the limit");
            }

            coffee_Amount += amount_c;
        }

        public void MakeEspresso()
        {
            const int waterAmount = 25;
            const int coffeeAmount = 15;
            const int groundsAmount = 15;

            if (water_Amount < waterAmount || coffee_Amount < coffeeAmount)
            {
                throw new InvalidOperationException("Not enough coffee or water");
            }

            if (grounds_Amount + groundsAmount > grounds_Limit)
            {
                throw new InvalidOperationException("No more espresso can be made, limit of the grounds is reached!!!");
            }

            this.water_Amount -= waterAmount;
            this.coffee_Amount -= coffeeAmount;
            this.grounds_Amount += groundsAmount;
        }

        public void EmptyGrounds()
        {
            grounds_Amount = 0;
        }

    }

}