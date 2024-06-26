﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Solutions {
  internal class Solution511 {
    public static void Solution511_1() {
      var count = 0;
      for (var i = 0; i < 100; ++i) {
        if (i % 3 == 0) count++;
      }
      Console.WriteLine(count);
    }

    public static void Solution511_2() {
      var sum = 0;
      while (true) {
        Console.Write("Enter a number or ok: ");
        var userInput = Console.ReadLine();
        if (userInput == "ok") {
          break;
        } else {
          var userValue = int.Parse(userInput);
          sum += userValue;
        }
      }
      Console.WriteLine("Sum: " + sum);
    }

    public static void Solution511_3() {
      Console.Write("Enter a number: ");
      var userInput = Console.ReadLine();
      var number = Convert.ToInt32(userInput);
      var factorial = 1;
      for (var i = 1; i <= number; ++i) {
        factorial *= i;
      }
      Console.WriteLine("Factorial: " + factorial);
    }

    public static void Solution511_4() {
      var random = new Random();
      var randomValue = random.Next(0, 11);
      Console.WriteLine("Selected Random Number: " + randomValue);
      var found = false;
      for (var i = 0; i < 4; ++i) {
        var userInput = Console.ReadLine();
        var userValue = Convert.ToInt32(userInput);
        if (userValue == randomValue) {
          found = true;
          break;
        }
      }
      if (found == true) {
        Console.WriteLine("Yout Won");
      } else {
        Console.WriteLine("You lost");
      }
    }
  }
}
