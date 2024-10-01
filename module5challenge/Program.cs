using System;

class Program
{
    static void Main()
    {
        // 12 Dad Jokes
        string[] dadJokes = new string[]
        {
            "What did the horse say after it tripped? Help! I have fallen and I cannot giddyup!",
            "Why can’t you hear a pterodactyl going to the bathroom? Because the 'P' is silent.",
            "What do you call a well-balanced horse? Stable.",
            "What do you call an angry carrot? A steamed veggie.",
            "Where do polar bears keep their money? In a snowbank.",
            "How do you make an egg-roll? You push it!",
            "What would bears be without bees? Ears.",
            "What do you call a pile of cats? A meow-ntain.",
            "Why do cows wear bells? Because their horns don’t work.",
            "Why did the bicycle fall over? Because it was two tired.",
            "What did the triangle say to the circle? You’re pointless.",
            "RIP, boiling water. You will be mist."
        };

        // Create a Random object
        Random rnd = new Random();
        
        string userResponse = "yes";
        
        // Keep asking if the user wants more jokes until they say "no"
        while (userResponse.ToLower() == "yes")
        {
            // Pick two random jokes
            int joke1 = rnd.Next(0, dadJokes.Length);
            int joke2 = rnd.Next(0, dadJokes.Length);
            
            // Ensure the two jokes are different
            while (joke2 == joke1)
            {
                joke2 = rnd.Next(0, dadJokes.Length);
            }

            // Display the jokes
            Console.WriteLine($"Joke 1: {dadJokes[joke1]}");
            Console.WriteLine($"Joke 2: {dadJokes[joke2]}");

            // Ask the user if they want to hear more jokes
            Console.WriteLine("\nDo you want to hear more Dad Jokes? (yes/no)");
            userResponse = Console.ReadLine();
        }

        // Exit message
        Console.WriteLine("Thanks for enjoying the Dad Jokes! Goodbye!");
    }
}
