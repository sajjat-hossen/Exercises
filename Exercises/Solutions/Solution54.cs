using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Solutions {
  internal class Solution54 {
    public static void Solution54_1() {
      var userInput = Console.ReadLine();
      var length = userInput.Length;
      var valid = true;
      var number = 0;
      foreach ( var chr in userInput ) {
        if ( chr >= '0' && chr <='9') {
          var d = chr - '0';
          number *= 10;
          number += d;
        } else {
          valid = false;
          break;
        }
      }
      if (number < 0 || number > 10) valid = false;
      if (valid) Console.WriteLine("Valid");
      else Console.WriteLine("Invalid");
    }

    public static void Solution54_2() {
      var userInput1 = Console.ReadLine();
      var userInput2 = Console.ReadLine();

      var number1 = Convert.ToInt32(userInput1);
      var number2 = Convert.ToInt32(userInput2);

      var maxNumber = number1 > number2 ? number1 : number2;
      Console.WriteLine(maxNumber);
    }

    public static void Solution54_3() {
      Console.Write("Enter the width of the image: ");
      var width = int.Parse(Console.ReadLine());
      Console.Write("Enter the height of the image: ");
      var height = int.Parse(Console.ReadLine());

      if (width > height) Console.WriteLine("The image is landscape");
      else if (height > width) Console.WriteLine("The image is rotate");
      else Console.WriteLine("The image is square");
    }

    public static void Solution54_4() {
      Console.Write("Please Enter the Speed Limit: ");
      var speedLimit = int.Parse(Console.ReadLine());
      Console.Write("Please inter the speed of a car: ");
      var carSpeed = int.Parse(Console.ReadLine());
      if (carSpeed < speedLimit) {
        Console.WriteLine("OK");
      } else {
        var demerits = (carSpeed - speedLimit) / 5;
        Console.WriteLine("Demerits Points: " + demerits);
        if (demerits > 12) Console.WriteLine("License Suspended");
      }
    }
  }
}
