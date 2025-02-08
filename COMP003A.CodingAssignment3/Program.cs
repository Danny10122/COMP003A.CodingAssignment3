// Author: Daniel Juarez
// Course: COMP-003A
// Factuly: Jonahtan Cruz
// Purpose: Budget managemnet application demostrating control flow
namespace COMP003A.CodingAssignment3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Prompt for the Budget Management
            Console.WriteLine("Welcome to the Budget Management Tool!");
           
            double monthlyIncome = 0;
            string expense1 = "";
            string expense2 = "";
            string expense3 = "";
            string expense4 = "";
            string expense5 = "";
            double expenseAmount1 = 0;
            double expenseAmount2 = 0;
            double expenseAmount3 = 0;
            double expenseAmount4 = 0;
            double expenseAmount5 = 0;

            List<(string name, double amount)> expenses = new List<(string, double)>();
           
            // Monthly income
            Console.Write("\nEnter your monthly income: ");
            monthlyIncome = double.Parse(Console.ReadLine());

            int choice;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                // Menu opotion 1
                if (choice == 1)
                {
                    Console.Write("\nEnter the expense name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the expense amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    expenses.Add((name, amount));
                    Console.WriteLine("Expense added successfully!");

                }
                // Menu opotion 2
                else if (choice == 2)
                {
                    double totalExpenses = 0;

                    Console.WriteLine("\nExpenses:");
                    foreach (var expense in expenses)
                    {
                        Console.WriteLine($"{expense.name}: ${expense.amount}");
                        totalExpenses += expense.amount;
                    }
                    //Calculate the Expenses
                    Console.WriteLine($"Total Expenses: ${totalExpenses}");
                    Console.WriteLine($"Remaining Budget: ${monthlyIncome - totalExpenses}");
                }
                // Menu opoition 3
                else if (choice == 3)
                {
                    Console.WriteLine("Enter expense to remove: ");
                    string userInput = Console.ReadLine();

                    // normalize the user input either by using ToLower() or ToUpper()
                    if (userInput.ToLower() == expense1.ToLower())
                    {
                        expense1 = "";
                        expenseAmount1 = 0;
                        Console.WriteLine($"Successfully removed {userInput}");
                    }
                    else if (userInput.ToLower() == expense2.ToLower())
                    {
                        expense2 = "";
                        expenseAmount2 = 0;
                        Console.WriteLine($"Successfully removed {userInput}");
                    }
                    else if (userInput.ToLower() == expense3.ToLower())
                    {
                        expense3 = "";
                        expenseAmount3 = 0;
                        Console.WriteLine($"Successfully removed {userInput}");
                    }
                    else if (userInput.ToLower() == expense4.ToLower())
                    {
                        expense4 = "";
                        expenseAmount4 = 0;
                        Console.WriteLine($"Successfully removed {userInput}");
                    }
                    else if (userInput.ToLower() == expense5.ToLower())
                    {
                        expense5 = "";
                        expenseAmount5 = 0;
                        Console.WriteLine($"Successfully removed {userInput}");
                    }
                    else
                    {
                        Console.WriteLine("Expense not found!");
                    }
                }

                // Menu opotion 4
                else if (choice == 4)
                {
                    Console.WriteLine("\nGoodbye!");

                }
                else
                {
                    // Display a message and retry again
                    Console.WriteLine("Invalid choice. Please try again.");

                }
            } while (choice != 4);


        }
    }
}
