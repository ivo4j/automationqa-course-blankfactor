namespace App2.Conditionals
{
    public class Steps
    {
        //public void StepsToCount()
        //{
        //    string input = string.Empty;
        //    int stepsLeft = 10000, steps = 0, goalSteps = 10000;
        //    bool goingHome = false;

        //    do
        //    {
        //        Console.WriteLine("Please enter a number of steps for the day or type 'Going home':");
        //        input = Console.ReadLine();
        //        switch (input)
        //        {
        //            case "Going home": goingHome = true; break;
        //            case string i when (i != "Going home"):
        //                goingHome = false;
        //                steps = 0;
        //                bool res1 = int.TryParse(input, out steps);
        //                stepsLeft = goalSteps - steps;
        //                if (stepsLeft <= 0)
        //                {
        //                    Console.WriteLine("Goal reached! Good job!");
        //                    break;
        //                }
        //                break;
        //            default:
        //                break;
        //        }

        //            //bool res1 = int.TryParse(input, out steps);
        //            //stepsLeft = goalSteps - steps;
        //            //if (stepsLeft <= 0)
        //            //{
        //            //    Console.WriteLine("Goal reached! Good job!");
        //            //    break;
        //            //}


        //    } while (!goingHome || stepsLeft > 0);

        //    Console.WriteLine("Please enter a final number of steps");
        //    bool res2 = int.TryParse(Console.ReadLine(), out steps);
        //    stepsLeft = goalSteps - steps;

        //    switch (stepsLeft)
        //    {
        //        case int i when (i > 0):
        //            Console.WriteLine($"{stepsLeft} more steps to reach goal!"); break;
        //        case int i when (i <= 0):
        //            Console.WriteLine("Goal reached! Good job!"); break;
        //    }
        //}

        public void StepsToCountSolution()
        {
            int countOfSteps = 0;

            Console.Write("Please enter command or 'Going home': ");
            string dailySteps = Console.ReadLine();
            while (dailySteps != "Going home")
            {
                countOfSteps += int.Parse(dailySteps);

                if (countOfSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job");
                    return;
                }

                Console.Write("Please enter command or 'Going home': ");
                dailySteps = Console.ReadLine();
            }

            Console.WriteLine($"{10000 - countOfSteps} more steps to reach goal.");
        }

    }
}
