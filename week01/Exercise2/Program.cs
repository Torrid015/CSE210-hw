using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        if (grade >= 90)
            if (grade >= 97)
            {
                Console.WriteLine("Your grade is A+");
            }
            else
            {
                Console.WriteLine("Your grade is A");
            }
        else if (grade >= 80)
            if (grade >= 87)
            {
                Console.WriteLine("Your grade is B+");
            }
            else
            {
                Console.WriteLine("Your grade is B");
            }
        else if (grade >= 70)
            if (grade >= 77)
            {
                Console.WriteLine("Your grade is C+");
            }
            else
            {
                Console.WriteLine("Your grade is C");
            }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
    }
         
    
}