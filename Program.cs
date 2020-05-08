// // Uncomment exercises below to run! // //

using System;

namespace ControlFlowExercises1
{
  class Program
  {

    // /*
    //  Write a program and ask the user to enter a number.The number should be
    //  between 1 to 10.If the user enters a valid number, display "Valid" on the
    //  console.Otherwise, display "Invalid". (This logic is used a lot in
    //  applications where values entered into input boxes need to be validated.)
    //  */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter a number: ");
    //   var number = Convert.ToInt32(Console.ReadLine());
    //
    //   if (number >= 1 && number <= 10)
    //   {
    //     Console.WriteLine("Valid");
    //   }
    //   else
    //   {
    //     Console.WriteLine("Invalid");
    //   }
    // }


    // /*
    // Write a program which takes two numbers from the console and displays the
    // maximum of the two. 
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter the first number: ");
    //   var number1 = Convert.ToInt32(Console.ReadLine());

    //   Console.Write("Please enter the second number: ");
    //   var number2 = Convert.ToInt32(Console.ReadLine());

    //   if (number1 > number2)
    //   {
    //     Console.WriteLine($"The max of the two numbers is {number1}");
    //   }
    //   else
    //   {
    //     Console.WriteLine($"The max of the two numbers is {number2}");
    //   }
    // }


    // /*
    // Write a program and ask the user to enter the width and height of an image.
    // Then tell if the image is landscape or portrait.
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter the width of the image: ");
    //   var width = Convert.ToInt32(Console.ReadLine());

    //   Console.Write("Please enter the height of the image: ");
    //   var height = Convert.ToInt32(Console.ReadLine());

    //   if (width > height)
    //   {
    //     Console.WriteLine("The image is a landscape.");
    //   }
    //   else
    //   {
    //     Console.WriteLine("The image is a portrait.");
    //   }
    // }


    // /*
    // Your job is to write a program for a speed camera. For simplicity, ignore
    // the details such as camera, sensors, etc and focus purely on the logic.
    // Write a program that asks the user to enter the speed limit. Once set, the
    // program asks for the speed of a car. If the user enters a value less than
    // the speed limit, program should display Ok on the console. If the value is
    // above the speed limit, the program should calculate the number of demerit
    // points. For every 5km/hr above the speed limit, 1 demerit points should be
    // incurred and displayed on the console. If the number of demerit points is
    // above 12, the program should display License Suspended.
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("What is the speed limit?: ");
    //   var speedLimit = Convert.ToInt32(Console.ReadLine());

    //   Console.Write("How fast is the car going?: ");
    //   var speedCar = Convert.ToInt32(Console.ReadLine());

    //   if (speedCar <= speedLimit)
    //   {
    //     Console.WriteLine("Ok.");
    //   }
    //   else
    //   {
    //     decimal speedDifference = speedCar - speedLimit;
    //     int demeritPoints = (int)Math.Floor(speedDifference / 5);
    //     if (demeritPoints < 12)
    //     {
    //       Console.WriteLine($"{demeritPoints} demerit points");
    //     }
    //     else
    //     {
    //       Console.WriteLine($"License Suspended");
    //     }
    //   }
    // }


    // /*
    // Write a program to count how many numbers between 1 and 100 are divisible by
    // 3 with no remainder. Display the count on the console.
    // */
    // static void Main(string[] args)
    // {
    //   var count = 0;
    //   for (var i = 1; i <= 100; i++)
    //   {
    //     if (i % 3 == 0)
    //     {
    //       count++;
    //     }
    //   }
    //   Console.WriteLine(count);
    // }


    // /*
    // Write a program and continuously ask the user to enter a number or "ok" to
    // exit. Calculate the sum of all the previously entered numbers and display it
    // on the console.
    // */
    // static void Main(string[] args)
    // {
    //   string input;
    //   var total = 0;
    //   do
    //   {
    //     Console.Write("Please enter a number or enter \"ok\" to exit: ");
    //     input = Console.ReadLine();
    //     total += input != "ok" ? (Convert.ToInt32(input)) : 0;
    //     Console.WriteLine($"Current sum is {total}");
    //   } while (input != "ok");
    // }


    // /*
    // Write a program and ask the user to enter a number. Compute the factorial of
    // the number and print it on the console. For example, if the user enters 5,
    // the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter a number: ");
    //   var number = Convert.ToInt32(Console.ReadLine());
    //   var factorial = number;
    //   for (var i = number - 1; i > 0; i--)
    //   {
    //     factorial *= i;
    //   }
    //   Console.WriteLine($"{number}! = {factorial}");
    // }


    // /*
    // Write a program that picks a random number between 1 and 10. Give the user 4
    // chances to guess the number. If the user guesses the number, display “You
    // won"; otherwise, display “You lost". (To make sure the program is behaving
    // correctly, you can display the secret number on the console first.)
    // */
    // static void Main(string[] args)
    // {
    //   Random random = new Random();
    //   var randomNumber = random.Next(1, 10);
    //   Console.WriteLine($"Keep this on the DL... but the random number is: {randomNumber}");
    //   Console.Write("What number am I thinking of between 1 and 10?: ");
    //   var guessedNumber = Convert.ToInt32(Console.ReadLine());
    //   if (randomNumber == guessedNumber)
    //   {
    //     Console.WriteLine("You won");
    //   }
    //   else
    //   {
    //     Console.WriteLine("You lost");
    //   }
    // }


    // /*
    // Write a program and ask the user to enter a series of numbers separated by
    // comma. Find the maximum of the numbers and display it on the console. For
    // example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter a series of numbers separated by a comma: ");
    //   var inputString = Console.ReadLine();
    //   string[] splitNumbers = inputString.Split(',');
    //   foreach (string number in splitNumbers)
    //   {
    //     Console.WriteLine(number.Trim());
    //   }
    // }
  }
}