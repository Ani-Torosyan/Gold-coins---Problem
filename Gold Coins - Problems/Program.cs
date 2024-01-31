namespace Gold_Coins___Problems
{
    internal class Program
    {
        static char GetAnswer()
        {
            char answer;
            do
            {
                Console.WriteLine("Please enter (Y/N).");
                answer = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }
            while (answer != 'Y' && answer != 'N');

            return answer;
        }

        static void Main(string[] args)
        {
            char answer;

            Console.WriteLine("There are 12 gold coins.");
            Console.WriteLine("11 of them are real and weight the same, 1 is fake and weights either lighter or heavier.");
            Console.WriteLine("Choose the fake coin and whether it is lighter or heavier.");

            Console.WriteLine("First weighing:");
            Console.WriteLine("Are 1, 2, 3, 4 coins equal to 5, 6, 7, 8?");
            answer = GetAnswer();

            if (answer == 'Y')
                WeighingY();
            else
                WeighingN();
        }

        static void WeighingY()
        {
            char answer;

            Console.WriteLine("Second weighing:");
            Console.WriteLine("Is 9, 10 equal to 1, 2? ");
            answer = GetAnswer();

            if (answer == 'Y')
            {
                Console.WriteLine("Third weighing:");
                Console.WriteLine("Is 11 equal to 1? ");
                answer = GetAnswer();
                Console.WriteLine(answer == 'Y' ? "Coin number 12 is the fake coin!" : "Coin number 11 is the fake coin!");
            }
            else
            {
                Console.WriteLine("Third weighing:");
                Console.WriteLine("Is 9 equal to 1? ");
                answer = GetAnswer();
                Console.WriteLine(answer == 'Y' ? "Coin number 10 is the fake coin!" : "Coin number 9 is the fake coin!");
            }
        }

        static void WeighingN()
        {
            char answer;

            Console.WriteLine("Is 1, 2, 3, 4 heavier than 5, 6, 7, 8? ");
            answer = GetAnswer();

            if (answer == 'Y')
                WeighingN_Y();
            else
                WeighingN_N();
        }

        static void WeighingN_Y()
        {
            char answer;

            Console.WriteLine("Second weighing:");
            Console.WriteLine("Is 5, 9, 10, 11 equal to 1, 6, 7, 8? ");
            answer = GetAnswer();

            if (answer == 'Y')
                WeighingN_Y_Y();
            else
                WeighingN_Y_N();
        }

        static void WeighingN_Y_Y()
        {
            char answer;

            Console.WriteLine("Third weighing:");
            Console.WriteLine("Is 2 equal to 3? ");
            answer = GetAnswer();
            Console.WriteLine(answer == 'Y' ? "Coin number 4 is the fake coin!" : "Is 2 heavier than 3? " + (GetAnswer() == 'Y' ? "Coin number 2 is the fake coin!" : "Coin number 3 is the fake coin!"));
        }

        static void WeighingN_Y_N()
        {
            char answer;

            Console.WriteLine("Is 5, 9, 10, 11 heavier than 1, 6, 7, 8? ");
            answer = GetAnswer();

            if (answer == 'Y')
                WeighingN_Y_N_Y();
            else
                WeighingN_Y_N_N();
        }

        static void WeighingN_Y_N_Y()
        {
            char answer;

            Console.WriteLine("Third weighing:");
            Console.WriteLine("Is 6 equal to 7? ");
            answer = GetAnswer();
            Console.WriteLine(answer == 'Y' ? "Coin number 8 is the fake coin!" : "Is 6 heavier than 7? " + (GetAnswer() == 'Y' ? "Coin number 7 is the fake coin!" : "Coin number 6 is the fake coin!"));
        }

        static void WeighingN_Y_N_N()
        {
            char answer;

            Console.WriteLine("Third weighing:");
            Console.WriteLine("Is 1 equal to 9? ");
            answer = GetAnswer();
            Console.WriteLine(answer == 'Y' ? "Coin number 5 is the fake coin!" : "Coin number 1 is the fake coin!");
        }

        static void WeighingN_N()
        {
            char answer;

            Console.WriteLine("Second weighing:");
            Console.WriteLine("Is 1, 9, 10, 11 equal to 2, 3, 4, 5? ");
            answer = GetAnswer();

            if (answer == 'Y')
                WeighingN_N_Y();
            else
                WeighingN_N_N();
        }

        static void WeighingN_N_Y()
        {
            char answer;

            Console.WriteLine("Third weighing:");
            Console.WriteLine("Is 6 equal to 7? ");
            answer = GetAnswer();
            Console.WriteLine(answer == 'Y' ? "Coin number 8 is the fake coin!" : "Is 6 heavier than 7? " + (GetAnswer() == 'Y' ? "Coin number 7 is the fake coin!" : "Coin number 6 is the fake coin!"));
        }

        static void WeighingN_N_N()
        {
            char answer;

            Console.WriteLine("Is 1, 9, 10, 11 heavier than 2, 3, 4, 5? ");
            answer = GetAnswer();

            if (answer == 'Y')
                WeighingN_N_N_Y();
            else
                WeighingN_N_N_N();
        }

        static void WeighingN_N_N_Y()
        {
            char answer;

            Console.WriteLine("Third weighing:");
            Console.WriteLine("Is 2 equal to 3? ");
            answer = GetAnswer();
            Console.WriteLine(answer == 'Y' ? "Coin number 4 is the fake coin!" : "Is 2 heavier than 3? " + (GetAnswer() == 'Y' ? "Coin number 3 is the fake coin!" : "Coin number 3 is the fake coin!"));
        }

        static void WeighingN_N_N_N()
        {
            char answer;

            Console.WriteLine("Third weighing:");
            Console.WriteLine("Is 5 equal to 9? ");
            answer = GetAnswer();
            Console.WriteLine(answer == 'Y' ? "Coin number 1 is the fake coin!" : "Coin number 5 is the fake coin!");
        }
    }
}
