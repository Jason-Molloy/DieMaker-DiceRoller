using System;
//import or require


//controlling access amongst files (namespace)
namespace helloworld
{
  class Program    //object definition (instantiation and running)
  {
    static void Main(string[] args)
    {
      Console.Clear();
      //   Console.Write("What is your name: ");
      //   string name = Console.ReadLine();
      //   Console.WriteLine("Hello " + name);
      //   System.Console.Write("How old are you: ");
      //   string strAge = Console.ReadLine();
      //   int age;
      //   if (Int32.TryParse(strAge, out age))
      //   {
      //     System.Console.WriteLine($"In 10 years you will be {age + 10}");
      //   }
      //   else
      //   {
      //     Console.Beep();
      //     System.Console.WriteLine("ERROR YOU BROKE IT!!!");
      //   }
      //   Console.WriteLine("Hello World!");
      //   string name = "Jason";
      //   //Console.WriteLine($"{name} Rocks");
      //   int age = 24+15;
      //   bool alive = true;

      //if (alive), will work; if (name != null), will work; if(name), will not - no truthy/falsey

      // switch (name)
      // {
      //     case "Jason":
      //     System.Console.WriteLine("You Rock!!");
      //       break;
      //   }
      //   for ( int i = 0; i < 10;  i++)
      // }
      // if(i % 2 === 0 )
      // {
      //     Console.WriteLine('i');

      // given a user input of a die number and sides, roll the dice...
      System.Console.WriteLine("Welcome to die roller5000");
      bool rolling = true;
      Random rnd = new Random();
      while (rolling)
      {
        System.Console.Write("ENTER DICE :");
        String input = Console.ReadLine().ToLower();
        string[] arrInputs = input.Split('d');
        int rolls;
        int sides;
        if (arrInputs.Length < 1 || !Int32.TryParse(arrInputs[0], out rolls) || !Int32.TryParse(arrInputs[1], out sides))
        {
          Console.WriteLine("I DON'T WORK WITH BAD DATA!!!");
          continue;
        }
        int[] results = new int[rolls];
        int total = 0;
        for (int i = 0; i < rolls; i++)
        {
          int number = rnd.Next(1, sides + 1);
          results[i] = number;
          Console.Write(number + " ");
          total += number;
        }
        Console.WriteLine(Environment.NewLine);
        System.Console.WriteLine($"TOTAL: {total}");
      }
    }
  }
}
