using System;
using System.Collections.Generic;
using TodoFunctions;

namespace literate_eureka
{
    class Program
    {
        public static List<string> todoList = new List<string>();

        static void Main()
        {
            Functions.Write("Welcome to your todo console application");
            Handler();
        }
        static void Handler()
        {
            Functions.Write("What would you like to do?");

            Functions.Write("1. Add | 2. Delete | 3. List");

            string todoOption = Console.ReadLine();
            TodoOptions(todoOption);
        }

        static void TodoOptions(string option)
        {
            switch(option)
            {
                case "Add":
                    Functions.Write("Type in the same of the item you would like to add: ");

                    string todoItem = Console.ReadLine();
                    AddItem(todoItem);
                    Handler();
                    break;

                case "Delete":
                    Functions.Write("Which item would you like to delete?");
                    Handler();
                    break;

                case "List":
                    Functions.Write("=========================");
                    Functions.Write("Item in your todos:");
                    foreach (var item in todoList)
                    {
                        Functions.Write(item);
                    }

                    Handler();
                    break;

                default:
                    Functions.Write("You need to choose something");
                    break;
            } 
        }

        //static void Write(string debugString)
        //
        //   Console.WriteLine(debugString);
        //

        static void AddItem(string itemName)
        {
            todoList.Add(itemName);
        }


    }
}
