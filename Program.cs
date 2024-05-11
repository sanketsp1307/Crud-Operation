using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a List 
            List<string> subjects = new List<string>() { "Math", "History", "Geography", "Biology", "English", "Physics", "Chemistry" };
         
            //Access/Read the List
            foreach (string Read in subjects)
            {
                Console.WriteLine(Read);
                Console.WriteLine(" ");
            }
            //Update
            string old = "History";
            string updated = "Social Science";
            for(int i = 0; i < subjects.Count; i++)
            {
                if (subjects[i] == old)
                {
                    subjects[i] = updated;
                }
            }
            foreach (string Update in subjects)
            {
                Console.WriteLine(Update);
                Console.WriteLine(" ");

            }
            //Delete 
           
            for(int i = 0;i < subjects.Count; i++)
            {
                if (subjects[i] == "Physics")
                {
                   subjects.RemoveAt(i);
                }
            }
            foreach (string Delete in subjects)
            {
                Console.WriteLine(Delete);
                Console.WriteLine(" ");

            }
            Console.ReadLine();
        }
    }
}
