using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] studentInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                string[] workerInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    Student student = new Student(studentInput[0], studentInput[1], studentInput[2]);

                Worker worker = new Worker(workerInput[0], workerInput[1], decimal.Parse(workerInput[2]), decimal.Parse(workerInput[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}