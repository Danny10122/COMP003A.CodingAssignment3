// Author: Daniel Juarez
// Course: COMP-003A
// Factuly: Jonahtan
// Purpose: Budget managemnet application demostrating control flow
namespace COMP003A.CodingAssignment3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Management Tool!");
            double monthlyIncome = 0;

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
                    Console.WriteLine($"{expense.name}: ${expense.amount:F2}");
                    totalExpenses += expense.amount;
                    }
                    //Calculate the Expenses
                    Console.WriteLine($"Total Expenses: ${totalExpenses:F2}");
                    Console.WriteLine($"Remaining Budget: ${monthlyIncome - totalExpenses:F2}");
                }
                // Menu opoition 3
                else if (choice == 3)
                {
                    Console.Write("Enter the name of the expense to remove: ");
                    string expenseToRemove = Console.ReadLine();
                    var expenseItem = expenses.Find(e => e.name.Equals(expenseToRemove, StringComparison.OrdinalIgnoreCase));
                    if (expenseItem != default)
                    {
                    expenses.Remove(expenseItem);
                    Console.WriteLine("Expense removed successfully!");
                    }
                    else
                    {
                    Console.WriteLine("Expense not found.");
                    }
                }
                // Menu opotion 4
                else if (choice == 4)
                {
                Console.WriteLine("Goodbye!");
                }
                else
                {
                Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (choice != 4);


        }
    }
}
