class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\t* Welcome to my project *\n      --- IELTS Score Calculator ---\nEnter your scores >>> ");
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("Writing(ball): ");
            double WritingScore = Convert.ToDouble(Console.ReadLine());
            Console.Write("Reading(ball): ");
            double ReadingScore = Convert.ToDouble(Console.ReadLine());
            Console.Write("Listening(ball): ");
            double ListeningScore = Convert.ToDouble(Console.ReadLine());
            Console.Write("Speaking(ball): ");
            double SpeakingScore = Convert.ToDouble(Console.ReadLine());

            double OverallScore = (WritingScore + ReadingScore + ListeningScore + SpeakingScore) / 4;
            double floatScore = OverallScore - (int)OverallScore;

            if (floatScore < 0.25)
                floatScore = 0;
            else if (floatScore >= 0.25 && floatScore <= 0.5)
                floatScore = 0.5;
            else if (floatScore > 0.5)
                floatScore = 1;

            OverallScore = (int)OverallScore + floatScore;
            Console.WriteLine($"Dear {name}!");
            Console.WriteLine($"\tOverall Score >>> {OverallScore}");
            switch(OverallScore)
            {
                case 9:
                case 8.5:
                    Console.WriteLine("\t\tExpert!");
                    break;
                case 8:
                case 7.5:
                    Console.WriteLine("\t\tVery Good!");
                    break;
                case 7:
                case 6.5:
                    Console.WriteLine("\t\tGood!");
                    break;
                case 6:
                case 5.5:
                    Console.WriteLine("\t\tCompetent!");
                    break;
                case 5:
                    Console.WriteLine("\t\tModest");
                    break;
            }
            Console.WriteLine("Do you want to recalculate? (1-Yes, 0-No): ");
            int retry = Convert.ToInt32(Console.ReadLine());
            if (retry == 0)
            {
                Console.Clear();
                Console.WriteLine($"Thanks, {name}! Bye!");
                break;
            }
        }
    }
}
