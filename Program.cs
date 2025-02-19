using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter an integer between 0 and 1,000,000
        Console.WriteLine("Enter an integer between 0 and 1,000,000:");

        // Declare a variable to store user input
        int number;

        // Check if input is valid
        if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 1000000)
        {
            // Convert the number to words and display it
            Console.WriteLine(NumberToWords(number));
        }
        else
        {
            // Display an error message for invalid input
            Console.WriteLine("Invalid input. Please enter an integer between 0 and 1,000,000.");
        }
    }

    static string NumberToWords(int number)
    {
        // Handle special cases
        if (number == 0)
            return "Zero";

        if (number == 1000000)
            return "One Million";

        // Convert the number to words
        return ConvertToWords(number);
    }
 
    static string ConvertToWords(int number)
    {    
        // Handle numbers less than 20
        if (number < 20)
            return new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" }[number - 1] + " ";

        // Handle numbers less than 100
        if (number < 100)
            return new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }[number / 10 - 2] + " " + ConvertToWords(number % 10);

        // Handle numbers less than 1,000
        if (number < 1000)
            return ConvertToWords(number / 100) + " Hundred " + ConvertToWords(number % 100);

        // Handle numbers less than 1,000,000
        if (number < 1000000)
            return ConvertToWords(number / 1000) + " Thousand " + ConvertToWords(number % 1000);

        return "";
    }
}
