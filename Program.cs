using System;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("what type of worker do you choice?");
            string Choice = Console.ReadLine();
            Worker worker = new Worker();
            worker = ChoiceOfWorker(Choice);
            worker.Work(worker.Name,worker.Cost);
        }

        private static Worker ChoiceOfWorker(string choice)
        {
            Worker worker = new Worker();

            if (choice == "Chippy" || choice == "Carpenter")
            {
                worker = new Plumby();
            }
            if (choice == "Plumby" || choice == "Plumber")
            {
                worker = new Plumby();
            }
            if (choice == "Sparky" || choice == "Electrition")
            {
                worker = new Plumby();
            }

            return worker;
        }
    }
}
