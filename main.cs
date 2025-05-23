using System;

class Program
{
    static float SlotMachine(char a, char b, char c, char d, char e, char f, char g, char h)
    {
        char[] possibilities = new char[] { a, b, c, d, e, f };
        Random rnd = new Random();
        int attempts = 0;
        int money = 1000;
        int wins = 0;
        int prize = 175;//(35x)
        int bet = 5;

        char first, second, third;

        do
        {
            attempts++;
            first = possibilities[rnd.Next(possibilities.Length)];
            second = possibilities[rnd.Next(possibilities.Length)];
            third = possibilities[rnd.Next(possibilities.Length)];

            Console.WriteLine($"Attempt {attempts}: [{first}] [{second}] [{third}]");

            if (first != second || second != third)
            {
                money -= bet;
            }
            else
            {
                money -= bet;
                wins++;
                money += prize;
                Console.WriteLine("You won!**************");
            }

        } while (money > 0 && money < 3000);

        if (money <= 0)
        {
            Console.WriteLine($"Attempt {attempts}");
            Console.WriteLine("You went bankrupt! :(");
            Console.WriteLine($"You won: {wins} times");
            Console.WriteLine($"Your money: ${money}.00");
            Console.WriteLine($"Total winnings (but still bankrupt): ${prize * wins}.00");
        }
        else
        {
            Console.WriteLine($"Attempt {attempts}");
            Console.WriteLine("You won in life! :)");
            Console.WriteLine($"You won: {wins} times");
            Console.WriteLine($"Your money: ${money}.00");
            Console.WriteLine($"Total winnings: ${prize * wins}.00");
        }

        return 0.0f;
    }

    static void Main()
    {
        char A = 'A';
        char B = 'B';
        char C = 'C';
        char D = 'D';
        char E = 'E';
        char F = 'F';
        char G = 'G';
        char H = 'H';

        SlotMachine(A, B, C, D, E, F, G, H);
    }
}
