using System;



namespace higher_lower_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string answer;



            Console.WriteLine("Welcome to the higher or lower game");
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hi there, " + name);
            Console.WriteLine("The rules of the game are as follow: ");
            Console.WriteLine("You will see a random card and you have to try to guess whether the next card will be higher or lower.");
            Console.WriteLine("Go for it!");





            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11 ", "12 ", "13 ", "14 " };
            cards[9] = "J";
            cards[10] = "Q";
            cards[11] = "K";
            cards[12] = "A";


            Random rnd = new Random();
            int getal = rnd.Next(cards.Length);
            Console.WriteLine("The first number is " + getal);



            Console.WriteLine("Will the next card be higher or lower? ");
            answer = Console.ReadLine();



            Random nmr = new Random();
            int nummer = nmr.Next(cards.Length);
            Console.WriteLine(nummer);



            //geef aan of nummer goed of fout is
            if (answer.Equals("higher"))
            {
                if (nummer < getal)
                {
                    Console.WriteLine("Wrong!");
                }
                else
                {
                    Console.WriteLine("Good");
                }
            }

            if (answer.Equals("Lower"))
            {
                if (nummer > getal)
                {
                    Console.WriteLine("Wrong!");
                }



                else
                {
                    Console.WriteLine("Good");
                }

            }

        }
    }
}
