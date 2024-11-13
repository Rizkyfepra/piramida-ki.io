using System;  // Rizky Febriansyah Pratama 

public class Exercise20  // Declaration of the Exercise20 class
{  
    public static void Main()  // Main method, entry point of the program
    {
        int i, j, n;  // Declaration of variables of type integer
        char continueChoice;  // Variable to store user's choice to continue or not

        do  // Start of the loop to allow repeated execution
        {
            Console.Write("\n\n");  // Displaying new lines
            Console.Write("Display the pattern like pyramid containing odd number of asterisks:\n");  // Displaying the purpose of the program
            Console.Write("----------------------------------------------------------------------");  // Displaying a separator
            Console.Write("\n\n");

            Console.Write("Masukkan Angka Untuk Piramid :");  // Prompting the user to input the number of rows for the pattern
            n = Convert.ToInt32(Console.ReadLine());    // Reading the number of rows entered by the user

            // Loop to print the pattern
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)  // Loop to print spaces before the asterisks
                    Console.Write(" ");

                for (j = 1; j <= 2 * i + 1; j++)  // Loop to print asterisks (corrected to ensure odd count)
                    Console.Write("*");

                Console.Write("\n");  // Moving to the next line after printing each row of the pattern
            }

            // Ask the user if they want to continue
            Console.Write("Mau Buat Piramid lagi (y/n): ");
            continueChoice = Console.ReadKey().KeyChar;  // Read the user's choice
            Console.WriteLine();  // Move to the next line for better readability

        } while (char.ToLower(continueChoice) == 'y');  // Continue if the user enters 'y' or 'Y'

        Console.WriteLine("terima kasih");  // Exit message
    }
}