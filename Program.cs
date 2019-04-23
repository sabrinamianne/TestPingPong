// Range of numbers from 1 to the user input : ok
// The program must exhibit a number or "ping", "pong", "pingpong" depends to the number
using System;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to the Ping Pong game. Please enter a number: ");
    string userNumberStr = Console.ReadLine();
    int userNumber = int.Parse(userNumberStr);

    for (int i=1; i<=userNumber; i++)
    {
      if (i%15 == 0)
      {
      Console.WriteLine("ping-pong");
      }
      else if (i%5 ==0)
      {
        Console.WriteLine("pong");
      }
      else if (i%3 == 0)
      {
        Console.WriteLine("ping");
      }
      else
      {
      Console.WriteLine(i);
      }
    }
  }
}
