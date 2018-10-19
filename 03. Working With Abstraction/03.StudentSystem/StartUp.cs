using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();
            while (true)
            {
                studentSystem.ParseCommand();
            }
        }
    }
}