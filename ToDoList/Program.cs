using System;
using System.Collections.Generic;

namespace ToDoList
{

  public class Program
  {
    public static void Main()
    {
      List<Item> newList = new List<Item> { };
      
      static void Ui()
      {
        Console.WriteLine("Welcome to the To Do List.");
        Console.WriteLine("Would you like to add an item to your list or view your list? ['add', 'view']");
        string response = Console.ReadLine();

        if (response == "add" || response == "Add")
        {
          Console.WriteLine("What would you like to add?")
          string chore = Console.ReadLine();
          Item chore = new Item(chore);
          chore.Add();

        }
        else if (response == "view" || response == "View")
        {

        }
        else
        {
          Console.WriteLine("That is not a option!");
        }




        DllNotFoundException Add
      }
    }
  }
}
  string descritpion01 = "Walk the dog";
  // string descritpion02 = "Wash the dishes";
  Item newItem1 = new Item(descritpion01);
     // Item newItem2 = new Item(descritpion02);