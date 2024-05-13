using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace _1Assighnment1
{
    internal class Program
    {

        static List<Task> Task = new List<Task>();
        static void Main(string[] args)
        {
            Console.WriteLine("1 Add a Task 2: View a task 3: Update a Task 4: Remove Task 5: Exit");
            Menu();
        }
        static void Menu() {

            int num = Convert.ToInt32(Console.ReadLine());
        switch (num) {
                case 1 : Add();       break; //Create
                case 2: View(); break; //Read
                case 3 : Update(); break; //update
                case 4: Remove(); break;    //Delete
                case 5: Exit(); break;       //Close
            }
            Menu(); 
        }
        static void Add() {
            Console.WriteLine(" 1: Add a Title 0: Back to Menu ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value == 1)
            {
                Console.WriteLine(" Enter the Title ");
                string title = Console.ReadLine();
                

                Console.WriteLine("Enter the Description ");

                string description = Console.ReadLine();
                Task.Add(new Task()
                { Title = title, Description = description }
                );

                Add();
            }
            else if (value == 0)
            {
                // Console.WriteLine("1 Add a Task 2: Update a Task 3: View a Task 4: Remove Task 5: Exit");
                Console.WriteLine("1 Add a Task 2: View a task 3: Update a Task 4: Remove Task 5: Exit");

                Menu();
            }
            else
            {
                Console.WriteLine("Enter Valid Input");
                Menu();
            }
           
            
        }
        static void Update() { 
        Console.WriteLine("Update Task");
            Console.WriteLine("1: Enter the Value 2: Back to Menu");

            int value = Convert.ToInt32(Console.ReadLine());
           // List<Task> templist = new List<Task>();
            if (value == 1)
            {
                for (int i = 0; i < Task.Count; i++)
                {
                    Console.WriteLine((i + 1) + "Title: " + Task[i].Title + "\nDescription: " + Task[i].Description);
                }
                Console.WriteLine("Enter the updated Task");
                int update = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Title");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the Description");
                string description = Console.ReadLine();
                
                Task[update-1].Title = title;
                Task[update-1].Description = description;
               
                View();
            }
            else if(value ==2)
            {
                Console.WriteLine("1 Add a Task 2: View a task 3: Update a Task 4: Remove Task 5: Exit");
                Menu();
            }

        }
        static void Remove() {
            Console.WriteLine("1: Remove a Task 2: View Menu");
            int value = Convert.ToInt32(Console.ReadLine());
                 if(value == 1)
            {
                for (int i = 0; i < Task.Count; i++)
                {
                    Console.WriteLine((i + 1) +"Title: "+ Task[i].Title +"\nDescription: "+ Task[i].Description);
                }
                int index = Convert.ToInt32(Console.ReadLine());
                Task.RemoveAt(index-1);
                Console.WriteLine("Task Deleted");
                Console.WriteLine("1 Add a Task 2: View a task 3: Update a Task 4: Remove Task 5: Exit");

                Menu();
            }
            else
            {
                Console.WriteLine("1 Add a Task 2: View a task 3: Update a Task 4: Remove Task 5: Exit");
                Menu();
            }

        }
        static void View()
        {
            Console.WriteLine("View Task");

            if (Task.Count > 0)
            {
                for (int i = 0; i < Task.Count; i++)
                {
                    Console.WriteLine((i + 1) + "Title: " + Task[i].Title + "\nDescription: " + Task[i].Description);
                }
            }
            else
            {
                Console.WriteLine("Data Not Found");
            }
            Console.WriteLine("1 Add a Task 2: View a task 3: Update a Task 4: Remove Task 5: Exit");
            Menu();
     
        }
        static void Exit() { 
        Console.Clear();
        }
    }


}
