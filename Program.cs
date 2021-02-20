using System;



namespace higher_lower_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string answer;
            string again;
            double cash = 0;
            bool loop = true;
            double bet = 0;
           


            // Hier word de naam gebruiker en spel regels uitgeprint


            Console.WriteLine("Welcome to the higher or lower game");
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hi there, " + name);
            Console.WriteLine($"How much money do you want {name}?");
           

            do
            {
                try
                {
                    cash = Convert.ToDouble(Console.ReadLine());
                    loop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fill in a number");
                }


            } while (loop == true);

            Console.WriteLine("The rules of the game are as follow: ");
            Console.WriteLine("You will see a random card and you have to try to guess whether the next card will be higher or lower.");
            Console.WriteLine("Go for it!");


            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J ", "Q ", "K ", "A " };
            cards[9] = "J";
            cards[10] = "Q";
            cards[11] = "K";
            cards[12] = "A";

            //random kaart kiezen
            Random rnd = new Random();
            int getal = rnd.Next(cards.Length);
            Console.WriteLine("The first number is " + getal);




            Console.WriteLine("How much money do you want to bet?");
            loop = true;
            do
            {
                try
                {
                    bet = Convert.ToDouble(Console.ReadLine());
                    loop = false;
                    cash = cash - bet;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fill in a number");
                }


            } while (loop == true);



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
                    bet = bet * 2;
                    cash = cash + bet;
                    Console.WriteLine($"You now have {cash}");
                }


            }
            if (answer.Equals("lower"))
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

            // hier owrd er gevraagd of je nog een keer wilt spelen


            Console.WriteLine(" Do you want to play again?");
            again = Console.ReadLine();



            if (again == "yes")
            {
                Console.WriteLine("play the game again");



                string[] kaarten = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J ", "Q ", "K ", "A " };
                cards[9] = "J";
                cards[10] = "Q";
                cards[11] = "K";
                cards[12] = "A";



                //random kaart kiezen
                Random random = new Random();
                int getal3 = rnd.Next(cards.Length);
                Console.WriteLine("The first number is " + getal);



                Console.WriteLine("Will the next card be higher or lower? ");
                answer = Console.ReadLine();



                Random numm = new Random();
                int n = nmr.Next(cards.Length);
                Console.WriteLine(nummer);
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
                if (answer.Equals("lower"))
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
            else if (again == "no")
            {
                Console.WriteLine("tab enter");
            }



        }
    }
}

