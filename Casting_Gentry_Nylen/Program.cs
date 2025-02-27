namespace Casting_Gentry_Nylen
{
    internal class Program
    {
        static void Main()
        {
            // Step 1: Ask the user to input a whole number
            Console.Write("Please enter a whole number: ");
            int userNumber = int.Parse(Console.ReadLine()); // Convert the input to an integer

            // Step 2: Print a message that includes the user's number
            Console.WriteLine($"Your favorite number is {userNumber}!"); // Print out the number in a message

            // Step 3: Ask the user a yes or no question and assign it to a boolean variable
            Console.Write("Do you like video games? (Please answer 'true' or 'false'): ");
            string isTrueInput = Console.ReadLine(); // Get the user's input as a string

            // Step 4: Convert the string input to a boolean
            bool isTrue;
            if (isTrueInput.ToLower() == "true") // Check if the user entered 'true' (case-insensitive)
            {
                isTrue = true; // Set isTrue to true if the input was 'true'
            }
            else if (isTrueInput.ToLower() == "false") // Check if the user entered 'false' (case-insensitive)
            {
                isTrue = false; // Set isTrue to false if the input was 'false'
            }
            else
            {
                isTrue = false; // Default to false if invalid input is provided
                Console.WriteLine("Invalid input. Please enter 'true' or 'false'."); // Handle invalid input
            }

            // Step 5: Print out the boolean response
            Console.WriteLine($"It is {isTrue} that I like video games!"); // Output the boolean result
        }
    }
}
