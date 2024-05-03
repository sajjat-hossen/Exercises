using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Solutions {
  internal class Solution66 {
    public static void Solution66_1() {
      Console.Write("Enter your friends names in one line: ");
      var friendsName = Console.ReadLine();
      var names = friendsName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      var nameList = new List<string>(names);
      var numberOfFriends = nameList.Count;
      Console.WriteLine(numberOfFriends);
      if (numberOfFriends == 1) {
        Console.WriteLine("{0} likes your post", nameList[0]);
      } else if (numberOfFriends == 2) {
        Console.WriteLine("{0} and {1} like your post", nameList[0], nameList[1]);
      } else {
        Console.WriteLine("{0}, {1} and {2} others like your post", nameList[0], nameList[2], numberOfFriends - 2);
      }
    }
    public static void Solution66_2() {
      Console.Write("Enter your name: ");
      var userUnput = Console.ReadLine();
      var name = userUnput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      var nameList = new List<string>(name);
      var nameLength = nameList.Count;
      nameList.Reverse();
      var reverseName = string.Join(" ", nameList);
      Console.WriteLine(reverseName);
    }
    public static void Solution66_3() {
      int count = 1;
      var numbers = new List<int>();
      while (count <= 5) {
        var valid = false;
        while (!valid) {
          Console.Write("Enter number {0}: ", count);
          var value = int.Parse(Console.ReadLine());
          var found = false;
          foreach (var n in numbers) {
            if (n == value) {
              found = true;
              break;
            }
          }
          if (!found) {
            valid = true;
            count++;
            numbers.Add(value);
          }
        }
      }
      numbers.Sort();
      foreach (var n in numbers) {
        Console.WriteLine(n);
      }
    }
    public static void Solution66_4() {
      var numbers = new List<int>();
      while (true) {
        Console.Write("Enter a number of Quit: ");
        var userInput = Console.ReadLine();
        if (userInput == "Quit") {
          break;
        }
        var value = Convert.ToInt32(userInput);
        numbers.Add(value);
      }
      numbers.Sort();
      if (numbers.Count > 0) {
        Console.WriteLine(numbers[0]);
        var length = numbers.Count;
        for (var i = 1; i < length; i++) {
          if (numbers[i] != numbers[i - 1]) {
            Console.WriteLine(numbers[i]);
          }
        }
      }
    }

  }
}
