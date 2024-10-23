public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(0); // This should output: "Your number is negative"
        FindMinimum(3,2,1);
        // DisplayDayOfWeek(0); // This should output: "Thursday"
        FindMaximum(3,2,1);
        IsDivisibleBy5(6);
        CheckEvenOrOdd(3);
        CheckVowelOrConsonant('S');
        DisplayDayOfWeek(6);
    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:

    public static void CheckForPositiveNegativeZero(int number)
    {

        if (number > 0)
        {
            Console.WriteLine("your number is positive!");
        }
        else if (number == 0)
        {
            Console.WriteLine("your number is zero!");
        }
        else
        {
            Console.WriteLine("your number is negative!");
        }
    }

    public static void FindMinimum(int num1, int num2, int num3)
    {
        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine(num1 + " is the minimum number.");
        }
        else if (num2 < num1 && num2 < num3)
        {
            Console.WriteLine(num2 + " is the minimum number.");
        }
        else if (num3 < num1 && num3 < num2)
        {
            Console.WriteLine(num3 + " is the minimum number.");
        }
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine(num1 + " is the maximum number.");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine(num2 + " is the maximum number.");
        }
        else if (num3 > num1 && num3 > num2)
        {
            Console.WriteLine(num3 + " is the maximum number.");
        }
    }

    public static void IsDivisibleBy5(int num1)
    {
        int DivNum = num1 % 5;
        if(DivNum == 0)
        {
            Console.WriteLine($"{num1} is divisible by 5.");
        }
        else
        {
            Console.WriteLine($"{num1} is not divisible by 5.");
        }
    }

    public static void CheckEvenOrOdd(int num1)
    {
        int DivNum = num1 % 2;
        if(DivNum == 0)
        {
            Console.WriteLine($"{num1} is even.");
        }
        else
        {
            Console.WriteLine($"{num1} is odd.");
        }
    }

    public static void CheckVowelOrConsonant(char letter1)
    {
        switch(letter1)
        {
            case 'a':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'e':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'i':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'o':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'u':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'y':
            Console.WriteLine($"{letter1} is sometimes a vowel.");
            break;
            case 'A':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'E':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'I':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'O':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'U':
            Console.WriteLine($"{letter1} is a vowel.");
            break;
            case 'Y':
            Console.WriteLine($"{letter1} is sometimes a vowel.");
            break;
            default:
            Console.WriteLine($"{letter1} is a consonant.");
            break;

        }
    }

    public static void DisplayDayOfWeek(int day)
    {
        switch(day) 
        {
            case 0:
            Console.WriteLine("Sunday");
            break;
            case 1:
            Console.WriteLine("Monday");
            break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            case 3:
            Console.WriteLine("Wednesday");
            break;
            case 4:
            Console.WriteLine("Thursday");
            break;
            case 5:
            Console.WriteLine("Friday");
            break;
            case 6:
            Console.WriteLine("Saturday");
            break;
        }
    }

}
