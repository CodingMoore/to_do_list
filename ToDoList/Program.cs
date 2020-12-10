using System;
using System.Collections.Generic;

namespace ToDoList.Models
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List.");
      Console.WriteLine("Would you like to add an item to your list or view your list? ['add', 'view']");
      string response = Console.ReadLine().ToLower();

      if (response == "add" || response == "Add")
      {
        Console.WriteLine("What would you like to add?");
        string newChore = Console.ReadLine();
        Item chore = new Item(newChore);
              
      }
      else if (response == "view" || response == "View")
      {
        Console.WriteLine("This is your list so far.");
        foreach (string i in Item)
        {
            Console.WriteLine(Item(i));
        }
      }
      else
      {
        Console.WriteLine("That is not a option!");
      }
      
    Main();     
    }
  }
}