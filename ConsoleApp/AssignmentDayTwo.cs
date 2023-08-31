

using System.Threading.Channels;

public class AssignmentDayTwo
{
    ///<summary>
    ///Convert Number to Corresponding Month Name
    ///Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
    /// </summary>
    /// <example>
    /// For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.
    /// </example>
    /// 
    public void ReturnMonth(int month)
    {
        Console.WriteLine("1. Returning Month Name");
        /*
        switch (month)
        {
            case 1:
                Console.WriteLine("The Month is January");
                break;
            case 2:
                Console.WriteLine("The Month is February");
                break;
            case 3:
                Console.WriteLine("The Month is March");
                break;
            case 4:
                Console.WriteLine("The Month is April");
                break;
            case 5:
                Console.WriteLine("The Month is May");
                break;
            case 6:
                Console.WriteLine("The Month is june");
                break;
            case 7:
                Console.WriteLine("The Month is july");
                break;
            case 8:
                Console.WriteLine("The Month is August");
                break;
            case 9:
                Console.WriteLine("The Month is october");
                break;
            case 10:
                Console.WriteLine("The Month is November");
                break;
            case 11:
                Console.WriteLine("The Month is December");
                break;
            default:
                Console.WriteLine("invalid option");
                break;
        }
        */
        //using switch expression
        var number = month switch
        {
            1 => "January",
            2 => "febraury",
           3 => "March",
            4 => "April",
           5 =>"May",
            6 => "June",
            7 => "july",
            8 => "August",
            9 => "Setember",
            10 => "October",
            11 => "November",
            12 => "December",
            _ => "Invalid imput"
        } ;
        Console.WriteLine(number);
    }

    ///<summary>
    ///Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.
    /// </summary>
    /// <example>
    /// FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]

    ///FindMinMax([2334454, 5]) ➞ [5, 2334454]
    ///FindMinMax([1]) ➞ [1, 1]
    /// </example>
    /// 
    public void FindMinMax(int[] num)
    {
        Console.WriteLine("\n2. finding min max from array");
        


        Array.Sort(num);
        Console.WriteLine("maximum num=" + num[num.Length-1]);
        Console.WriteLine("manimum num=" + num[0]);







    }

    ///<summary>
    ///Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
    /// </summary>
    /// <example>
    /// getAbsSum([2, -1, 4, 8, 10]) ➞ 25
    /// getAbsSum([-1]) ➞ 1
    /// 
    /// </example>
    /// 
    public void getAbsSum(int[] num)
    {
        int sum = 0;

        foreach (var item in num)
        {


            sum += Math.Abs(item);


        }
        Console.WriteLine("3. sum of absolute value of each element in array");
        Console.WriteLine(" Sum=={0}", sum);

    }
    ///<summary>
    ///Create a function that takes a base number and an exponent number and returns the calculation.
    /// </summary>
    /// <example>
    /// СalculateExponent(5, 5) ➞ 3125

    /// СalculateExponent(10, 10) ➞ 10000000000

    /// </example>
    /// 
    public void CalExponent(int basee, int power)
    {
        Console.WriteLine("\n4. Exponent");
        Console.WriteLine($"CalExponent({basee},{power})=" + Math.Pow(basee,power));
    }
    ///<summary>
    ///Create a function to multiply all of the values in an array by the amount of values in the given array.
    /// </summary>
    /// <example>
    /// MultiplyByLength([2, 3, 1, 0]) ➞ [8, 12, 4, 0]

    /// MultiplyByLength([4, 1, 1]) ➞ ([12, 3, 3])
    /// </example>
    /// 
    public void MultiplybyLength(int[] num)
    {
        var result = 0;
        Console.WriteLine("\n5.MultiplyByLength");
        Console.Write("{ ");
        foreach (var item in num)
        {
            result = item * num.Length;
            Console.Write(+result + "  ");

        }
        Console.Write(" }");


    }
    ///<summary>
    ///Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
    /// </summary>
    /// <example>
    /// NameShuffle("Donald Trump") ➞ "Trump Donald"
    /// </example>
    /// 

    public void NameShuffle(string name)
    {
        Console.WriteLine("\n6.Swapping");
        Console.WriteLine("\nbefore Swapping");
        Console.WriteLine(name);
        Console.WriteLine("\nafter Swapping");

        string[] split = name.Split(' ');
        Console.WriteLine(split[1] + " " + split[0]);



    }
    ///<summary>
    ///Create a function that returns the smaller number.
    /// </summary>
    /// <example>
    /// smallerNum("21", "44") ➞ "21"
    /// </example>
    /// 
    public void smallerNum(string num1, string num2)
    {
        Console.WriteLine("\n7.return smaller number from string");
        int inum1 = Convert.ToInt32(num1);
        int inum2 = Convert.ToInt32(num2);
        Console.Write($"smallerNUm({num1},{num2}) ::");
        if (inum1 == inum2 || inum1 < inum2)
        {
            Console.WriteLine("smaller num is " + inum1);
        }
        else
        {
            Console.WriteLine("smaller num is " + inum2);

        }

    }
    ///<summary>
    ///Create a function that takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.
    /// </summary>
    /// <example>
    /// Factorial(3) ➞ 6
    /// </example>
    /// note: Assume all inputs are greater than or equal to 0.
    /// 

    public void Factorial(int n)
    {
        Console.WriteLine("\n8. return factorial");
        int fact = 1;
        int temp = n;
        while (n > 0)
        {
            fact *= n;
            n--;

        }
        Console.WriteLine($"Factorial of {temp} = " + fact);
    }
    ///<summary>
    ///Create a function that takes an array of numbers and returns a new array, sorted in ascending order (smallest to biggest).
    /// </summary>
    /// <example>
    /// SortNumsAscending([80, 29, 4, -95, -24, 85]) ➞ [-95, -24, 4, 29, 80, 85]

    ///SortNumsAscending(null) ➞ []
    /// </example>
    /// 
    public void SortAscending(int[] array)
    {
        Console.WriteLine("\n9. Sorting in ascending order");
        Console.WriteLine("\nBefore sorting");
        Console.Write("{ ");
        foreach (int item in array)
        {
            Console.Write(item+" ");
        }
        Console.Write(" }");
        Console.WriteLine("\nAfter sorting");
        Array.Sort(array);
        Console.Write("{ ");

        foreach (int item in array)
        {
            Console.Write( item+ " ");
        }
        Console.Write(" } \n");

        Console.WriteLine();

    }
    ///<summary>
    ///Create a function that takes a string and returns the number (count) of vowels contained within it
    /// </summary>
    /// <example>
    /// CountVowels("Celebration") ➞ 5

    /// CountVowels("Palm") ➞ 1
    /// 
    /// </example>
    /// 
    public void countvowel(string word)
    {
        Console.WriteLine("10. count vowel");
        int count = 0;
        char[] chars = word.ToCharArray();
        for(int i= 0; i < chars.Length; i++)
        {
            if (chars[i] == 'a'|| chars[i] == 'e' || chars[i] == 'i' || chars[i] == 'o' || chars[i] == 'u')
            {
                count++;
            }
        }
        Console.WriteLine("number of vowel in word {0}",word);
        Console.WriteLine(count+"\n");

    }
    

}



