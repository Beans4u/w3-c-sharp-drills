using System;
using static System.Console;

namespace w3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            // Write a C# Sharp program to print Hello and your name in a separate line
            // WriteLine("Hello \nCarina Garrity");

            // #2
            // Write a C# Sharp program to print the sum of two numbers
            // WriteLine($"The sum of two numbers, 3 and 4 is {3 + 4}");

            // #3
            // Write a C# Sharp program to print the result of dividing two numbers
            // int num1 = 40;
            // int num2 = 2;
            // WriteLine(num1 / num2);

            // #4
            // Write a C# Sharp program to print the result of the specified operations.
            /*
            Test data:
            -1 + 4 * 6
            ( 35+ 5 ) % 7
            14 + -4 * 6 / 11
            2 + 15 / 6 * 1 - 7 % 2
            Expected Output:
            23
            5
            12
            3
             */

            //  WriteLine(-1 + 4 * 6);
            //  WriteLine((35 + 5) % 7);
            //  WriteLine(14 + -4 * 6 / 11);
            //  WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            
            // #5
            // Write a C# Sharp program to swap two numbers
            /*
            Test Data:
            Input the First Number : 5
            Input the Second Number : 6
            Expected Output:
            After Swapping :
            First Number : 6
            Second Number : 5 */

            // int num1 = 6;
            // int num2 = 5;

            // int numTemp = num1;
            // num1 = num2;
            // num2 = numTemp;
            // WriteLine($"num1 was 6 but now is {num1}\nnum2 was 5 but now is {num2}");

            // #6
            // Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user
            /*
            Test Data:
            Input the first number to multiply: 2
            Input the second number to multiply: 3
            Input the third number to multiply: 6
            Expected Output:
            2 x 3 x 6 = 36
            */

            // WriteLine("Enter firt number to be multiplied by 2");
            // int userInputOne = int.Parse(ReadLine());
            // WriteLine("Enter firt number to be multiplied by 3");
            // int userInputTwo = int.Parse(ReadLine());
            // WriteLine("Enter firt number to be multiplied by 6");
            // int userInputThree = int.Parse(ReadLine());

            // WriteLine($"2 x {userInputOne} is {userInputOne * 2}");
            // WriteLine($"2 x {userInputTwo} is {userInputTwo * 3}");
            // WriteLine($"2 x {userInputThree} is {userInputThree * 6}");

            // 7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 
            // Test Data:
            // Input the first number: 25
            // Input the second number: 4
            // Expected Output:
            // 25 + 4 = 29
            // 25 - 4 = 21
            // 25 x 4 = 100
            // 25 / 4 = 6
            // 25 mod 4 = 1

            // int userImp1 = 0;
            // int userImp2 = 0;
          
            // WriteLine("Enter number");
            // userImp1 = int.Parse(ReadLine());

            // WriteLine("Enter number again");
            // userImp2 = int.Parse(ReadLine());
                      
            //     WriteLine($"{userImp1} + {userImp2} = {userImp1 + userImp2}");
            //     WriteLine($"{userImp1} - {userImp2} = {userImp1 - userImp2}");
            //     WriteLine($"{userImp1} x {userImp2} = {userImp1 * userImp2}");
            //     WriteLine($"{userImp1} / {userImp2} = {userImp1 / userImp2}");
            //     WriteLine($"{userImp1} mod {userImp2} = {userImp1 % userImp2}");
                    
            //     WriteLine("Thank you for participating!");
                
            // 8. Write a C# Sharp program that takes a number as input and print its multiplication table. 
            // Test Data:
            // Enter the number: 5
            // Expected Output:
            // 5 * 0 = 0
            // 5 * 1 = 5
            // 5 * 2 = 10
            // 5 * 3 = 15
            // ....
            // 5 * 10 = 50

            // 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
            // Test Data:
            // Enter the First number: 10
            // Enter the Second number: 15
            // Enter the third number: 20
            // Enter the four number: 30

            // Expected Output:
            // The average of 10 , 15 , 20 , 30 is: 18

            // WriteLine("enter first number:");
            // int firstNum = int.Parse(ReadLine());

            // WriteLine("enter second number:");
            // int secondNum = int.Parse(ReadLine());
            
            // WriteLine("enter third number:");
            // int thirdNum = int.Parse(ReadLine());
            
            // WriteLine("enter fourth number:");
            // int fourthNum = int.Parse(ReadLine());

            // WriteLine($"The average of {firstNum}, {secondNum}, {thirdNum}, and {fourthNum} is {(firstNum + secondNum + thirdNum + fourthNum)/4}");

            // 10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. 
            // Test Data:
            // Enter first number - 5
            // Enter second number - 6
            // Enter third number - 7

            // Expected Output:
            // Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72

           
            // 11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". 
            // Test Data:
            // Enter your age - 25
            // Expected Output:
            // You look older than 25

            // WriteLine("Hello, darling. How old are you?");
            // int userAge = int.Parse(ReadLine());
            // WriteLine($"Oh wow, you look younger than {userAge}..."); //because common... let's be polite! :)

            // 12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. 
            // Test Data:
            // Enter a digit: 25
            // Expected Output:
            // 25 25 25 25
            // 25252525
            // 25 25 25 25
            // 25252525
            // WriteLine("enter a number and I'll do something nice with it.");
            // int sNice = int.Parse(ReadLine());

            // WriteLine("{0}{0}{0}{0}", sNice);
            // WriteLine("{0} {0} {0} {0}", sNice);
            // WriteLine("{0}{0}{0}{0}", sNice);
            // WriteLine("{0} {0} {0} {0}", sNice);


            // 13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit. 
            // Test Data:
            // Enter a number: 5
            // Expected Output:
            // 555
            // 5 5
            // 5 5
            // 5 5
            // 555

            // WriteLine("enter a number and I'll do something nice with it.");
            // int sNice = int.Parse(ReadLine());

            // WriteLine("{0}{0}{0}", sNice);
            // WriteLine("{0} {0}", sNice);
            // WriteLine("{0} {0}", sNice);
            // WriteLine("{0} {0}", sNice);
            // WriteLine("{0}{0}{0}", sNice);

            // 14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
            // Test Data:
            // Enter the amount of celsius: 30
            // Expected Output:
            // Kelvin = 303
            // Fahrenheit = 86
            // WriteLine("enter degrees in celcius and I'll convert it for you.");
            // float userTemp = float.Parse(ReadLine());

            // WriteLine($"the temperature in Fahrenheit is {(userTemp * 9/5) + 32}");
            // WriteLine($"the temperature in Kelvin is {userTemp + 273.15}");
/**********************************************

WHERE I LEFT OFF



**********************************************/
            // 15. Write a C# program remove specified a character from a non-empty string using index of a character. 
            // Test Data:
            // w3resource
            // Sample Output:
            // wresource
            // w3resourc
            // 3resource

            // 16. Write a C# program to create a new string from a given string where the first and last characters will change their positions. 
            // Test Data:
            // w3resource
            // Python
            // Sample Output:
            // e3resourcw
            // nythoP
            // x

            // 17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back. 
            // Sample Output:
            // Input a string : The quick brown fox jumps over the lazy dog.
            // TThe quick brown fox jumps over the lazy dog.T

            // 18. Write a C# program to check two given integers and return true if one is negative and one is positive. 
            // Sample Output:
            // Input first integer:
            // -5
            // Input second integer:
            // 25
            // Check if one is negative and one is positive:
            // True

            // 19. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum. 

            // 20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number. 

            // 21. Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20. 

            // 22. Write a C# program to check if an given integer is within 20 of 100 or 200. 
            // Sample Output:
            // Input an integer:
            // 25
            // False

            // 23. Write a C# program to convert a given string into lowercase. 
            // Sample Output:
            // write a c# sharp program to display the following pattern using the alphabet.

            // 24. Write a C# program to find the longest word in a string. 
            // Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
            // Sample Output:
            // following

            // 25. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line. 
            // Sample Output:
            // Odd numbers from 1 to 99. Prints one number per line.
            // 1
            // 3
            // 5
            // 7
            // 9
            // ...
            // 95
            // 97
            // 99

            // 26. Write a C# program to compute the sum of the first 500 prime numbers. 
            // Sample Output:
            // Sum of the first 500 prime numbers:
            // 3682913

            // 27. Write a C# program and compute the sum of the digits of an integer. 
            // Sample Output:
            // Input a number(integer): 12
            // Sum of the digits of the said integer: 3

            // 28. Write a C# program to reverse the words of a sentence. 
            // Sample Output:
            // Original String: Display the pattern like pyramid using the alphabet.
            // Reverse String: alphabet. the using pyramid like pattern the Display

            // 29. Write a C# program to find the size of a specified file in bytes. 
            // Sample Output:
            // Size of a file: 31

            // 30. Write a C# program to convert a hexadecimal number to decimal number. 
            // Sample Output:
            // Hexadecimal number: 4B0
            // Convert to-
            // Decimal number: 1200

            // 31. Write a C# program to multiply corresponding elements of two arrays of integers. 
            // Sample Output:
            // Array1: [1, 3, -5, 4]
            // Array2: [1, 4, -5, -2]
            // Multiply corresponding elements of two arrays:
            // 1 12 25 -8

            // 32. Write a C# program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one. 
            // Sample Output:
            // Input a string : The quick brown fox jumps over the lazy dog.
            // dog.dog.dog.dog.

            // 33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. 
            // Sample Output:
            // Input first integer:
            // 15
            // True

            // 34. Write a C# program to check if a string starts with a specified word. 
            // Note: Suppose the sentence starts with "Hello"
            // Sample Data: string1 = "Hello how are you?"
            // Result: Hello.
            // Sample Output:
            // Input a string : Hello how are you?
            // True

            // 35. Write a C# program to check two given numbers where one is less than 100 and other is greater than 200. 
            // Sample Output:
            // Input a first number(<100): 75
            // Input a second number(>100): 250
            // True

            // 36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10. 
            // Sample Output:
            // Input a first number: -5
            // Input a second number: 8
            // True

            // 37. Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP". 
            // Test Data: PHP Tutorial
            // Sample Output:
            // P Tutorial

            // 38. Write a C# program to get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH". 
            // Test Data: PHP
            // Sample Output:
            // PH

            // 39. Write a C# program to find the largest and lowest values from three integer values. 
            // Test Data:
            // Input first integer:
            // 15
            // Input second integer:
            // 25
            // Input third integer:
            // 30
            // Sample Output
            // Largest of three: 30
            // Lowest of three: 15

            // 40. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same. 
            // Test Data:
            // Input first integer:
            // 15
            // Input second integer:
            // 12
            // Sample Output
            // 15

            // 41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times. 
            // Test Data:
            // Input a string (conatins at least one 'w' char) : w3resource
            // Test the string contains 'w' character between 1 and 3 times:
            // Sample Output
            // True

            // 42. Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case. 
            // Test Data:
            // Input a string: w3r
            // Sample Output
            // W3R

            // 43. Write a C# program to check if a given string starts with "w" and immediately followed by two "ww". 
            // Test Data:
            // Input a string : www
            // Sample Output
            // False

            // 44. Write a C# program to create a new string of every other character (odd position) from the first position of a given string. 
            // Test Data:
            // Input a string : w3resource
            // Sample Output
            // wrsuc

            // 45. Write a C# program to count a specified number in a given array of integers. 
            // Test Data:
            // Input an integer: 5
            // Sample Output
            // Number of 5 present in the said array: 2

            // 46. Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more. 
            // Test Data:
            // Input an integer: 25
            // Sample Output
            // False

            // 47. Write a C# program to compute the sum of all the elements of an array of integers. 
            // Test Data:
            // Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            // Sample Output
            // Sum: 69

            // 48. Write a C# program to check if the first element and the last element are equal of an array of integers and the length is 1 or more. 
            // Test Data:
            // Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            // Sample Output
            // True

            // 49. Write a C# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal. 
            // Test Data:
            // Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
            // Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
            // Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.
            // Sample Output
            // True

            // 50. Write a C# program to rotate an array (length 3) of integers in left direction. 
            // Test Data:
            // Array1: [1, 2, 8]
            // After rotating array becomes: [2, 8, 1]

            // 51. Write a C# program to get the larger value between first and last element of an array (length 3) of integers. 
            // Test Data:
            // Array1: [1, 2, 5, 7, 8]
            // Highest value between first and last values of the said array: 8

            // 52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers. 
            // Test Data:
            // Array1: [1, 2, 5]
            // Array2: [0, 3, 8]
            // Array3: [-1, 0, 2]
            // New array: [2, 3, 0]

            // 53. Write a C# program to check if an array contains an odd number. 
            // Test Data:
            // Original array: [2, 4, 7, 8, 6]
            // Check if an array contains an odd number? True

            // 54. Write a C# program to get the century from a year. 

            // 55. Write a C# program to find the pair of adjacent elements that has the largest product of an given array which is equal to a given value. 

            // 56. Write a C# program to check if a given string is a palindrome or not. 
            // Sample Example:
            // For 'aaa' the output should be true
            // For 'abcd' the output should be false

            // 57. Write a C# program to find the pair of adjacent elements that has the highest product of an given array of integers. 

            // 58. Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range. 
            // Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list. So output will be 4.

            // 59. Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array. 

            // 60. Write a C# program to calculate the sum of all the intgers of a rectangular matrix except those integers which are located below an intger of value 0. 
            // Sample Example:
            // matrix = [[0, 2, 3, 2],
            // [0, 6, 0, 1],
            // [4, 0, 3, 0]]
            // Eligible integers which will be participated to calculate the sum -
            // matrix = [[X, 2, 3, 2],
            // [X, 6, X, 1],
            // [X, X, X, X]]
            // Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14

            // 61. Write a C# program to sort the integers in ascending order without moving the number -5. 

            // 62. Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string. 





        }
    }
}
