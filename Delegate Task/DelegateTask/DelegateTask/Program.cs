using System;
namespace DelegateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Fidash", "Cavid", "Mahmud" };
            CheckingWord(Checking, names);
        }

        public static bool Checking(string names)
        {

            return names != "Cavid";
        }

        public static void CheckingWord(Predicate<string> predicate, List<string> names)
        {
            foreach (string name in names)
            {
                if (predicate(name))
                {
                    Console.WriteLine(name);                }

            }
            
        }
    }
}