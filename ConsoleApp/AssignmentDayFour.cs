using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class AssignmentDayFour
{


    public void ReverseAndNot(int i)
    {
        ///<summary>
        ///Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
        /// </summary>
        /// <example>
        /// ReverseAndNot(123) ➞ "321123"
        /// ReverseAndNot(152) ➞ "251152"
        /// </example>
        /// 
        
        Console.WriteLine("\nQN.: takes integer i and return a string with integer backward followed by original integer \n example: ReverseAndNot(123)==>>>123321");
        Console.WriteLine("\nInteger Value is : {0}", i);
        string intToString = Convert.ToString(i);
        char[] chars = intToString.ToCharArray();
        string reverse = string.Empty;
        for (int j = chars.Length - 1; j >= 0; j--)
        {
            reverse += chars[j];
        }
        //Console.WriteLine(intToString+reverse);
        //using concat funtion
        Console.WriteLine($"ReverseAndNot({i})-->>" + string.Concat(intToString, reverse));

    }
    public void uncensor(string string1, string vowel)
    {
        ///<summary>
        ///Someone has attempted to censor my strings by replacing every vowel with a *, l*k* th*s. Luckily, I've been able to find the vowels that were removed.       
        ///Given a censored string and a string of the censored vowels, return the original uncensored string.
        /// </summary>
        /// <example>
        /// uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo") ➞ "Where did my vowels go?"
        ///uncensor("abcd", "") ➞ "abcd"
        ///uncensor("*PP*RC*S*", "UEAE") ➞ "UPPERCASE"
        /// </example>
        /// 
        Console.WriteLine("\nQN.: In string, every vowel is replaced by '*' and task is to return  original uncensorded string");
        Console.WriteLine("Example: uncensor(\"*PP*RC*S*\", \"UEAE\") ➞ \"UPPERCASE\" ");

        Console.WriteLine("Note: \r\nThe vowels are given in the correct order.");
        Console.WriteLine($"\ntext pass ={string1} and vowel passed={vowel}");
        string uncensorstring = "";
        int vowelIndex = 0;
        for(int i = 0;i < string1.Length; i++)
        {
            if (string1[i] == '*')
            {
             uncensorstring += vowel[vowelIndex];

                vowelIndex++;

            }
            else
            {
                uncensorstring += string1[i];
            }
        }
        Console.WriteLine($"unsensor({string1},{vowel})-->>" +uncensorstring);



    }
    public void FindVertex(double a, double b, double c)
    {
        ///<summary>
        ///Every quadratic curve y = a x² + b x + c has a vertex point: the turning point where the curve stops heading down and starts going up.   
        ///Given the values a, b and c, you need to return the coordinates of the vertex.Return your answers rounded to 2 decimal places.
        /// 
        /// </summary>
        /// <example>
        /// FindVertex(1, 0, 25)  ➞ [0, 25]
        /// The vertex of y=x²+25 is at (0, 25).
        ///FindVertex(-1, 0, 25) ➞ [0, 25]
        // The vertex of y=-x²+25 is at (0, 25).
        /// </example>
        /// 
        Console.WriteLine("\nQn. Given Curve: y = a x² + b x + c. Find the coordinate of Vertex x and y");
        Console.WriteLine($"given value: a={a},b={b},c={c}");
        double x;
        double y;
        var sqrroot = (b * b) - (4 * a * c);
        int Positive;
        int Negative;
        // = ((b * -1) + Math.Sqrt(sqrroot)) / 2 * a;

        if (sqrroot < 0)
        {
            Console.WriteLine("cant perform");

        }
        else
        {
            Negative = Convert.ToInt32(((b * -1) - Math.Sqrt(sqrroot)) / (2 * a));
            //Console.WriteLine(Negative);


            Positive = Convert.ToInt32(((b * -1) + Math.Sqrt(sqrroot)) / (2 * a));
            // Console.WriteLine(Positive);
            if (int.IsPositive(Positive))
            { x = Positive; }
            else
            {
                x = Negative;
            }

            y = a * x * x + b * x + c;
            Console.WriteLine("\nCordinate of vertex :");
            Console.WriteLine($"x={x} " + $"y={y} ");


        }


    }
    public bool IsSmooth(string text)
    {
        ///<summary>
        ///A smooth sentence is one where the last letter of each word is identical to the first letter the following word (and not case sensitive, so "A" would be the same as "a").
        /// The following would be a smooth sentence "Carlos swam masterfully" because "Carlos" ends with an "s" and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".
        ///Create a function that determines whether the input sentence is a smooth sentence, returning a boolean value true if it is, false if it is not.
        /// 
        /// </summary>
        /// <example>
        /// IsSmooth("Someone is outside the doorway") ➞ false

        /// IsSmooth("She eats super righteously") ➞ true
        /// </example>
        /// 
        //string text = "hello orld duu uda";
        
        Console.WriteLine("\nQn. whether the Given sentence is a smooth sentence, returning a boolean value true if it is, false if it is not.");
        Console.WriteLine($"\nGiven Sentence is \"{text}\"");
        Console.WriteLine("\nis It smooth?");

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                if (text[i - 1] != text[i + 1])
                {
                    return false;
                  

                }
            }
        }
        return true;



    }
    public void NextPrime(int num)
    {
        ///<summary>
        ///Given an integer, create a function that returns the next prime. If the number is prime, return the number itself.
        /// 
        /// </summary>
        /// <example>
        /// NextPrime(12) ➞ 13
        /// </example>
        /// 
        Console.WriteLine("\nQn. Given an integer, create a function that returns the next prime. If the number is prime, return the number itself.");
        Console.WriteLine("\nGiven Number is {0}", num);
        int count = 0;

        for (int i = num; i > 0; i++)
        {
            count = 0;


            for (int j = 1; j <= i; j++)
            {

                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("next prime number after {1} is {0}", i, num);
                break;
            }
        }



    }
    public void DuplicateCount(string str)
    {
        ///<summary>
        ///Create a function that takes a string and returns the number of alphanumeric characters that occur more than once.
        /// 
        /// </summary>
        /// <example>
        /// DuplicateCount("abcde") ➞ 0

        //DuplicateCount("aabbcde") ➞ 2
        /// </example>
        /// 
        Console.WriteLine("\nQN. Create a function that takes a string and returns the number of alphanumeric characters that occur more than once\n");
        Console.WriteLine("\nGiven String is {0}", str);


        int count = 0;
        int[] char_counts = new int[128];
        foreach (char c in str)
        {
            // Console.WriteLine("char count" + char_counts[c]);
            char_counts[c]++;
        }

        foreach (int c in char_counts)
        {
            if (c > 1)
            { count++; }
        }
        Console.WriteLine($"Duplicate present in {str} is " + count);

    }

    public int sockpairs(string socks)
    {
        ///<summary>
        ///Write a function that returns the number of sock pairs he has. A sock pair consists of two of the same letter, such as "AA". The socks are represented as an unordered sequence.
        /// </summary>
        /// <example>
        /// SockPairs("CABBACCC") ➞ 4
        /// </example>
        /// 
        Console.WriteLine("\nQn. function that returns the number of sock pairs he has. A sock pair consists of two of the same letter, such as \"AA\". The socks are represented as an unordered sequence\n");
        Console.WriteLine("\nFind the no of sock pairs:");

        int cnt = 0;
        char[] arr = socks.ToCharArray();
        Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
           
            
                if (arr[i] == arr[i-1])
                {
                    cnt++;
                    i++;

                }
            
        }

        return cnt;

    }
    public void TOH()
    {
        Console.WriteLine("\nQn. Tower of Honoi");
        Console.WriteLine("\nNo of Disk is 3\n");
        int numDiscs = 3;
        TowerOfHanoi(numDiscs, 'A', 'C', 'B');
    }

    public void TowerOfHanoi(int numDiscs, char source, char destination, char auxiliary)
    {
        if (numDiscs == 1)
        {
            Console.WriteLine($"Move disk 1 from {source} to {destination}");
            return;
        }

        TowerOfHanoi(numDiscs - 1, source, auxiliary, destination);
        Console.WriteLine($"Move disk {numDiscs} from {source} to {destination}");
        TowerOfHanoi(numDiscs - 1, auxiliary, destination, source);
    }

}

        
        



        


    

