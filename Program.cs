namespace DailyChoresApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to your Daily Chores App!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.WriteLine("Please select a day you would like to see:");
            Console.WriteLine();
            List<string> weeklyDays = new List<string>
            {
                "1. Monday!", "2. Tuesday!", "3. Wednesday!", "4. Thursday!", "5. Friday!", "6. Saturday!", "7. Sunday!"
            };

            foreach(var days in weeklyDays)
            {
                Console.WriteLine(days);
            }
            var userResponse = Console.ReadLine();
            Console.WriteLine();

           Console.WriteLine("Thank you. Now loading your answer!");
           for(int i = 0; i < 10; i++)
           {
                Console.Write(".");
                Thread.Sleep(300);
           }
            Console.WriteLine();


            Console.WriteLine("Here are the things that need to be done today!");
            List<string> dailyToDo = new List<string>
            {
                "Sweep kitchen floor" , "Make up beds", "Do dishes", "Wash laundry", "Fold laundry", "Kids clean up their bedrooms", "Vacuum all floors", "Mop kitchen", "Clean bathroom", "Gather all trash", "Dust", "Clean up porch", "Cat litter box", "Mop bathroom floor", "Clean electronic screens", "Clean tub", "Vacuum base boards", "Windex windows/Front door", "LAZY DAY!!", "General space cleaning"
            };
       

            switch (userResponse)
            {
                case "1":
                    Console.WriteLine("Mondays chores are: Wash laundry, Fold laundry, Windex windows & Front door glass!");
                    break;
                case "2":
                    Console.WriteLine("Tuesdays chores are: Sweep Kitchen, Mop kitchen, Mop bathroom floor, Clean tub!");
                    break;
                case "3":
                    Console.WriteLine("Wednesdays chores are: Do dishes, Make up beds, Dust, Clean tub!");
                    break;
                case "4":
                    Console.WriteLine("Thursdays chores are: Kids clean up their bedrooms, Vacuum all floors, Clean bathrooms!");
                    break;
                case "5":
                    Console.WriteLine("Fridays chores are: Trash, Cat litter box, Clean porch");
                    break;
                case "6":
                    Console.WriteLine("Vacuum base boards, General space cleaning, Clean electronic screens");
                    break;
                case "7":
                    Console.WriteLine("LAZY DAY!!");
                    break;
            }
                
        }
    }
}