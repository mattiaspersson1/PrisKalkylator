using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            // Display the main menu
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1: Ticket price (youth/senior)");
            Console.WriteLine("2: Group ticket calculator");
            Console.WriteLine("3: Repeat text 10 times");
            Console.WriteLine("4: Extract third word");
            Console.WriteLine("0: Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    running = false;
                    break;

                case "1":
                    // Get valid age input
                    int age = GetValidInt("Enter age: ");
                    if (age < 5 || age > 100)
                        Console.WriteLine("Free ticket!");
                    else if (age < 20)
                        Console.WriteLine("Youth price: 80kr");
                    else if (age > 64)
                        Console.WriteLine("Senior price: 90kr");
                    else
                        Console.WriteLine("Standard price: 120kr");
                    break;

                case "2":
                    int groupSize = GetValidInt("How many people in the group? ");
                    int total = 0;
                    for (int i = 0; i < groupSize; i++)
                    {
                        int personAge = GetValidInt($"Enter age of person {i + 1}: ");
                        if (personAge < 5 || personAge > 100)
                            total += 0;
                        else if (personAge < 20)
                            total += 80;
                        else if (personAge > 64)
                            total += 90;
                        else
                            total += 120;
                    }
                    Console.WriteLine($"Total people: {groupSize}");
                    Console.WriteLine($"Total cost: {total}kr");
                    break;

                case "3":
                    Console.Write("Enter text to repeat: ");
                    string input = Console.ReadLine();
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($"{i}. {input} ");
                    }
                    Console.WriteLine();
                    break;

                case "4":
                    Console.Write("Enter a sentence (at least 3 words): ");
                    string sentence = Console.ReadLine();
                    string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length >= 3)
                        Console.WriteLine("Third word: " + words[2]);
                    else
                        Console.WriteLine("Not enough words! Please enter at least 3.");
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    // Helper method to get a valid integer from the user
    static int GetValidInt(string prompt)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
                return result;

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}