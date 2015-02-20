using System;

class FruitMarket
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string dayOfWeek = Console.ReadLine();

        decimal quantity1 = decimal.Parse(Console.ReadLine());
        string product1 = Console.ReadLine();

        decimal quantity2 = decimal.Parse(Console.ReadLine());
        string product2 = Console.ReadLine();

        decimal quantity3 = decimal.Parse(Console.ReadLine());
        string product3 = Console.ReadLine();

        decimal price = productPrice(quantity1, product1, dayOfWeek) + productPrice(quantity2, product2, dayOfWeek) + productPrice(quantity3, product3, dayOfWeek);

        Console.WriteLine("{0:F2}", price);
    }

    private static decimal productPrice(decimal quantity, string product, string dayOfWeek)
    {
        decimal banana = 1.80m;
        decimal cucumber = 2.75m;
        decimal tomato = 3.20m;
        decimal orange = 1.60m;
        decimal apple = 0.86m;
        decimal sum = 0;

        switch (product)
        {
            case "banana":
                sum = banana;
                break;
            case "cucumber":
                sum = cucumber;
                break;
            case "tomato":
                sum = tomato;
                break;
            case "orange":
                sum = orange;
                break;
            case "apple":
                sum = apple;
                break;
            default:
                break;
        }

        switch (dayOfWeek)
        {
            case "Monday":
                sum = sum * quantity;
                break;
            case "Tuesday":
                if (product == "banana" || product == "orange" || product == "apple")
                {
                    sum = sum * quantity * 0.80m;
                }
                else
                {
                    sum = sum * quantity;
                }
                break;
            case "Wednesday":
                if (product == "tomato" || product == "cucumber")
                {
                    sum = sum * quantity * 0.90m;
                }
                else
                {
                    sum = sum * quantity;
                }
                break;
            case "Thursday":
                if (product == "banana")
                {
                    sum = sum * quantity * 0.70m;
                }
                else
                {
                    sum = sum * quantity;
                }
                break;
            case "Friday":
                sum = sum * quantity * 0.90m;
                break;
            case "Saturday":
                sum = sum * quantity;
                break;
            case "Sunday":
                sum = sum * quantity * 0.95m;
                break;
            default:
                break;
        }

        return sum;
    }
}