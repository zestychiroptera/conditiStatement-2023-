//// 1. Write a program to accept two integers and check whether they are equal or not.

//Console.WriteLine("Please enter two integers to determine if they are equal to one another or not.");
//Console.WriteLine();
//Console.WriteLine("Please enter an integer: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//Console.WriteLine("Please enter a second integer: ");
//int b = Convert.ToInt32(Console.ReadLine());

//if (a == b)
//{
//    Console.WriteLine($"You entered {a} and {b}");
//    Console.WriteLine("They are equal to one another.");
//}
//else
//{
//    Console.WriteLine($"You entered {a} and {b}");
//    Console.WriteLine("They are not equal to one another.");
//}

//// 2. Write a program to check whether a given number is even or odd.

//Console.WriteLine("Please enter an integer to determine if it is even or odd.");
//Console.WriteLine();
//Console.WriteLine("Please enter an integer: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//if (a / 2 != a * 0.5)
//{
//    Console.WriteLine($"You entered {a}.");
//    Console.WriteLine("That is considered an odd number.");
//}
//else
//{
//    Console.WriteLine($"You entered {a}.");
//    Console.WriteLine("That is considered an even number.");
//}

//// 3. Write a program to check whether a given number is positive or negative.

//Console.WriteLine("Please enter an integer to determine if it is even or odd.");
//Console.WriteLine();
//Console.WriteLine("Please enter an integer: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//if (a >= 0)
//{
//    Console.WriteLine($"You entered {a}.");
//    Console.WriteLine("That is considered a positive number.");
//}
//else
//{
//    Console.WriteLine($"You entered {a}.");
//    Console.WriteLine("That is considered a negative number.");
//}

//// 4. Write a program to determine whether a given year is a leap year or not.

//Console.WriteLine("Please enter a year of your choosing to determine if it is a leap year or not.");
//Console.WriteLine();
//Console.WriteLine("Please enter a year : ");
//int inputYear = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//if ((inputYear % 400) == 0)
//{
//    Console.WriteLine($"{inputYear} is a leap year.\n");
//}
//else if ((inputYear % 100) == 0)
//{
//    Console.WriteLine($"{inputYear} is not leap year.\n");
//}
//else if ((inputYear % 4) == 0)
//{
//    Console.WriteLine($"{inputYear} is a leap year.\n");
//}
//else
//{
//    Console.WriteLine($"{inputYear} is not leap year.\n");
//}

//// 5. Write a program to read the age of a candidate and determine whether they are eligible to cast their vote in an election (USA).

//Console.WriteLine("Please enter your age to determine if you are eligible to vote in this year's election(s). \n");
//int ofAge = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//if (ofAge >= 18)
//{
//    Console.WriteLine($"You have indicated that you are {ofAge} years old.\n");
//    Console.WriteLine("You are eligible to vote in this year's election cycle! :)");
//}
//else
//{
//    Console.WriteLine($"You have indicated that you are {ofAge} years old.\n");
//    Console.WriteLine("You are sadly ineligible to vote in this year's election cycle...");
//}

//// 6. Write a program to read the value of an integer 'm' and display the value of 'n' as 1 (when 'm' is larger than 0), 0 when 'm' is 0 and -1 when 'm' is less than 0. 

//Console.WriteLine("Please enter an integer value for 'm' to then determine the corresponding value of 'n.'\n");
//int n;
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//if (m > 0)
//{
//    n = 1;
//}
//else if (m == 0)
//{
//    n = 0;
//}
//else
//{
//    n = -1;
//}
//Console.WriteLine($"The value for m is {m}.");
//Console.WriteLine($"The value for n is {n}.");

//// 7. Write a program to accept a person's height in centimeters and categorize them according to their height.

//Console.WriteLine("What is your sex? (Male or Female).\n");
//string userSex = Console.ReadLine();
//Console.WriteLine();
//Console.WriteLine("Please enter your height in centimeters to determine your height classification.\n");
//double userHeight = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//if (userSex == "Male" || userSex == "male" || userSex == "M" || userSex == "m")
//{
//    if (userHeight > 171)
//    {
//        Console.WriteLine($"You have indicated that you are {userHeight} centimeters tall.\n");
//        Console.WriteLine("That's considered an above-average height for a male.");
//    }
//    else if (userHeight <= 171 && userHeight >= 122)
//    {
//        Console.WriteLine($"You have indicated that you are {userHeight} centimeters tall.\n");
//        Console.WriteLine("That's considered an average height for a male.");
//    }
//    else
//    {
//        Console.WriteLine($"You have indicated that you are {userHeight} centimeters tall.\n");
//        Console.WriteLine("That's considered a below-average height for a male. Medically this would be classified as 'dwarfism.'");
//    }
//}
//else if (userSex == "Female" || userSex == "female" || userSex == "F" || userSex == "f")
//{
//    if (userHeight > 159.5)
//    {
//        Console.WriteLine($"You have indicated that you are {userHeight} centimeters tall.\n");
//        Console.WriteLine("That's considered an above-average height for a female.");
//    }
//    else if (userHeight <= 159.5 && userHeight >= 122)
//    {
//        Console.WriteLine($"You have indicated that you are {userHeight} centimeters tall.\n");
//        Console.WriteLine("That's considered an average height for a female.");
//    }
//    else
//    {
//        Console.WriteLine($"You have indicated that you are {userHeight} centimeters tall.\n");
//        Console.WriteLine("That's considered a below-average height for a female. Medically this would be classified as 'dwarfism.'");
//    }
//}
//else
//{
//    Console.WriteLine($"You have entered {userHeight}.\n");
//    Console.WriteLine("That is not a valid input.");
//}

//// 8. Write a program to find the largest of three numbers.

//Console.WriteLine("Please enter three numbers to determine which of them is the largest that was input.\n");
//double num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//double num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//double num3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//if (num1 > num2 && num1 > num3)
//{
//    Console.WriteLine($"You have entered {num1}.\n");
//    Console.WriteLine($"You have entered {num2}.\n");
//    Console.WriteLine($"You have entered {num3}.\n");
//    Console.WriteLine($"The first of the values entered, {num1}, is the greatest numerically.");
//}
//else if (num2 > num1 && num2 > num3)
//{
//    Console.WriteLine($"You have entered {num1}.\n");
//    Console.WriteLine($"You have entered {num2}.\n");
//    Console.WriteLine($"You have entered {num3}.\n");
//    Console.WriteLine($"The first of the values entered, {num2}, is the greatest numerically.");
//}
//else if (num3 > num1 && num3 > num2)
//{
//    Console.WriteLine($"You have entered {num1}.\n");
//    Console.WriteLine($"You have entered {num2}.\n");
//    Console.WriteLine($"You have entered {num3}.\n");
//    Console.WriteLine($"The first of the values entered, {num3}, is the greatest numerically.");
//}
//else
//{
//    Console.WriteLine($"You have entered {num1}.\n");
//    Console.WriteLine($"You have entered {num2}.\n");
//    Console.WriteLine($"You have entered {num3}.\n");
//    Console.WriteLine("This is not a valid entry as you have entered three values that are equal to one another. Please read the directions and try again.");
//}

// 9. Write a program to accept a coordinate pair (x,y) and then determine which quadrant the coordinate lies on.

