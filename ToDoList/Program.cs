using System;
using System.Collections.Generic;
using ToDoList.Models;
using System.Linq;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      AddDescription();
    }

    public static void AddDescription()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View");
      string response = Console.ReadLine().ToUpper();
      if (response == "ADD")
      {
        Console.WriteLine("Please enter the description for the new item.");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        Main();
      }
      else if (response == "VIEW")
      {
        foreach (Item newToDoList in Item.GetAll())
        {
          Console.WriteLine(newToDoList.Description);
        }
        Main();
      }
    }
  }
}