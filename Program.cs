namespace AgeValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            do
            {
                Console.WriteLine("Enter valid age");
            }while (!int.TryParse(Console.ReadLine(), out age));

            if(age < 0 || age > 120)
            {
                Console.WriteLine("This is not a valid age for person");
            }else if(age < 18)
            {
                Console.WriteLine("The person is a minor");
            }else 
            {
                Console.WriteLine("The person is an adult");
            }
        }
    }
}
