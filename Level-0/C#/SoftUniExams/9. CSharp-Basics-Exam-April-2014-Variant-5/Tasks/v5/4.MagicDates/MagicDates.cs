using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());  
        int endYear = int.Parse(Console.ReadLine());
        int magicWeigth = int.Parse(Console.ReadLine()); ;

        string date = "";
        int sum = 0;
        int digit = 1;
        bool hasFound = false;

        for (int year = startYear; year <= endYear; year++)
        {
            for (int month = 1; month <= 12; month++)
            {
                for (int day = 1; day <= 31; day++)
                {
                    if (month < 10 && day >= 10)
                    {
                        date = "" + day + "0" + month + year;
                    }
                    if (day < 10 && month >= 10)
                    {
                        date = "" + "0" + day + month  + year;
                    }
                    if (day < 10 && month < 10)
                    {
                        date = "" + "0" + day + "0" + month + year;
                    }
                    if (day >= 10 && month >= 10)
                    {
                        date = "" + day + month + year;
                    }

                    sum = 0;
                    digit = 1;
                    for (int mult = 0; mult < date.Length; mult++)
                    {
                        for (int num = digit; num < date.Length; num++)
                        {
                            sum += (int)char.GetNumericValue(date[mult]) * (int)char.GetNumericValue(date[num]);
                            if (sum == magicWeigth && digit == date.Length - 1 )
                            {
                                if (month < 10 && day >= 10)
                                {
                                    date = "" + day + "-" + "0" + month + "-" + year;
                                }
                                if (day < 10 && month >= 10)
                                {
                                    date = "" + "0" + day + "-" + month + "-" + year;
                                }
                                if (day < 10 && month < 10)
                                {
                                    date = "" + "0" + day + "-" + "0" + month + "-" + year;
                                }
                                if (day >= 10 && month >= 10)
                                {
                                    date = "" + day + "-" + month + "-" + year;
                                }
                                Console.WriteLine(date);
                                //duh = "" + "0" + day + "-" + "0" + month + "-" + year;
                                hasFound = true;
                            }
                        }
                        digit++;
                    }
                }
            }
        }
        if (!hasFound)
        {
            Console.WriteLine("No");
        }
    }
}