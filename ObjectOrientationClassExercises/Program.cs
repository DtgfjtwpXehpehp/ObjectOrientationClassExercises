using ObjectOrientationClassExercises.Encapsulation;

namespace ObjectOrientationClassExercises
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DateTime expiryDate = new DateTime(2030, 10, 31);
            BankAccount bankAccount = new BankAccount(12345, "John Doe",AccountType.Savings, 680000, 6789, expiryDate);

        }
    }
}
