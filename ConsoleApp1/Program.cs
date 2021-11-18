using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Globalization;


// CTRL X deletes a line!
// cw tab = Console.WriteLine!



class Program
{
    static void Main()
    {
        //IsSymmetrical(3223);

        //double[] theArray = { 1, 2, 3, 4, -10 };
        //CountPosSumNeg(theArray);

        //SortDescending(12345);

        //CheckPerfect(6);

        //FormatNum(12345);

        //IsValidPhoneNumber("(123) 456 7890");

        //FindLargest(new double[][] { new double[] { 4, 2, 7, 1 }, new double[] { 20, 70, 40, 90 }, new double[] { 1, 2, 0 } });

        //RemoveSmallest(new int[] { 1, 2, 3, 4, 5, 1 });

        //GCD(300, 85);

        //Schoty(new string[] { "OOOOO---OOOOO", "---OOOOOOOOOO", "O---OOOOOOOOO", "O---OOOOOOOOO", "---OOOOOOOOOO", "OOOOOOOO---OO", "OO---OOOOOOOO" });

        //LetterDistance("house", "fly"); // result = 11

        //FlipEndChars("Cat, dog, and mouse.");

        //Console.WriteLine("Input string 1: ");
        //string str1 = Console.ReadLine();
        //Console.WriteLine("Input string 2: ");
        //string str2 = Console.ReadLine();
        //IsAnagram(str1, str2);

        //Console.WriteLine("right: ");
        //string right = "right " + Console.ReadLine();
        //Console.WriteLine("left: ");
        //string left = "left " + Console.ReadLine();
        //Console.WriteLine("up: ");
        //string up = "up " + Console.ReadLine();
        //Console.WriteLine("down: ");
        //string down = "down " + Console.ReadLine();
        //TrackRobot (new string[] {right, left, up, down});

        //NumberOfDays(new int[] { 3, 5 });

        //AlternatingCaps("this is a test for Tony");

        //CanFind(new string[] { "oo", "mi", "ki", "la" }, new string[] { "milk", "chocolate", "cooks" });

        //Console.WriteLine("Enter number: ");
        //int n = int.Parse(Console.ReadLine());
        //IsPrime(new int[] { 2, 3, 5, 7, 11, 13, 17 }, n);

        //WeekAfter("12/03/2020");  // day/month/year

        //Uncensor("*PP*RC*S*", "UEAE");

        //CapMe(new string[] { "samuel", "MABELLE", "letitia", "meridith" });

        //Cons(new int[] { 5, 1, 4, 3, 2, 8 });

        //WurstIsBetter("Il n’arrête pas de faire l’andouille");

        //TextToNum("123-647-EYES");

        //ReverseAndNot(123);

        //CupSwapping(new String[] { "BA", "AC", "CA", "BC" });  // result should be A

        //IsSmooth("Marta appreciated deep perpendicular right trapezoids"); // true

        //MysteryFunc("A4B5C2"); // result: AAAABBBBBCC
        //MysteryFuncBetter("A4B5C2");

        //NextPrime(80);

        //DuplicateCount("aabbcde");  // result = 2

        //TrackRobot(new int[] { 20, 30, 10, 40, 15 }); // result -10, 25

        //SockPairs("CABBACCC"); // result == 4

        //IsValidHexCode("#eaecee");

        //NumType(6);

        //LCMofArray(new int[] { 13, 6, 17, 18, 19, 20, 37 });

        //LongestCommonEnding("potent", "tent");

        //Fibonacci(40);

        //AlphabetIndex("Might be fun to write a Coder / Decoder program !");

        //TwoProduct(new int[] { 1, 2, 3, 4, 13, 5 }, 39);

        //DigitCount(136116);
        //Console.WriteLine(DigitCount(136116));

        //ValidateEmail("tony@tiggerhill.com");

        //IsParselTongue("Sshe ssselects to eat those apples."); // should be F

        //DoesRhyme("down by the bay", "where the watermelons grow");

        //Bridges("#########/#       #/#   #   #/#   #   #/#### ####/#   #   #/#   #   #/#       #/#########");

        //SplitCases("Unscrupulous", 12);

        // Time to study Linq!  This one is for SplitCases:
        //if (input.Length % cases != 0)
        //    return new string[] { "Error" };
        //var len = input.Length / cases;
        //return Enumerable.Range(0, cases).Select(n => input.Substring(n * len, len)).ToArray();

        //Collatz(1299299290099998745, 1_546_587_430_000_340_789);

        //GetFrame(20, 25, '+');

        //Gauss(new long[] { 1975, 165 });

        //AlmostPalindrome("abba");

        //MinTurns("4089", "5672");

        //TextToBinary("one Zero zero one zero zero one one one one one zero oNe one one zero one zerO");

        //AverageWordLength("Dude, this is so awesome!");

        MinTurns("4089", "5672");
    }
    




    public static double AverageWordLength(string str)
    {
        string[] words = str.Split(new char[] { ' ' });
        int[] wordLength = new int[words.Length];
        int sum = 0;
        for (int i = 0; i < words.Length; i++)
        {
            foreach (char c in words[i])
            {
                if (Char.IsPunctuation(c))
                {
                    wordLength[i] += 0; // just to put something here
                }
                else
                {
                    wordLength[i] += 1;
                }
            }
        }
               
        for (int i = 0; i < words.Length; i++)
        {
            sum += wordLength[i];
            Console.WriteLine(wordLength[i] + " " + sum);
        }

        double average = Math.Round((double)sum / words.Length, 2);
        Console.WriteLine(average);

        return average;

        //string newstr = Regex.Replace(str, "[^A-Za-z ]", "");
        //double average = newstr.Split(' ').Select(x => x.Length).Average();

        //return Math.Round(average, 2);
    }
    public static string TextToBinary(string str)
    {
        string result = "";
        if (str.Length < 0)
        {
            return result;
        }

        string[] words = str.Split(new char[] { ' ' });
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].ToLower() == "zero") { result += "0"; }
            if (words[i].ToLower() == "one") { result += "1"; }            
        }

        if (result.Length % 8 > 0)
        {
            string temp = "";
            int newLength = (result.Length / 8) * 8;
            for (int i = 0; i < newLength; i++)
            {
                temp += result[i];
            }
            result = temp;
        }
        Console.WriteLine(result);
        return result;
    }
    public static int MinTurns(string current, string target)
    {
        // current: "4089"
        // target:  "5672"

        int start = int.Parse(current); // 4089
        int end = int.Parse(target);    // 5672
        int rotation = 0;
        int input_digit, code_digit;
        int[] turns = new int[4];       // lock is always 4 digits
        int count = 4;

        while (start > 0 || end > 0)
        {
            // get last digit of each
            input_digit = start % 10;
            code_digit = end % 10;

            // find min rotation
            int forwards, backwards, lowest;


            // TODO need an if/then to determine which is forwards and backwards
            forwards = (Math.Abs(input_digit - code_digit));
            backwards = (10 - Math.Abs(input_digit - code_digit));

            lowest = Math.Min(forwards, backwards);
            turns[count - 1] = lowest;

            Console.WriteLine("SHOULD be: 7, 3 / 1, 9 / 4, 6 / 9, 1");
            Console.WriteLine("input digit " + input_digit + ", code digit " + code_digit);
            Console.WriteLine(" ACTUALS forwards " + forwards + ", backwards " + backwards + ", lowest " + lowest);
            Console.WriteLine("");

            // should be 7, 3 / 1, 9 / 4, 6 / 9, 1
            count--;

            rotation += Math.Min(Math.Abs(input_digit - code_digit),
                10 - Math.Abs(input_digit - code_digit));

            start /= 10; end /= 10;
        }
        string justForShitsAndGrins = "";




        return rotation;
    }

    public static bool AlmostPalindrome(string str)
    {
        char[] chArray = str.ToCharArray();
        Array.Reverse(chArray);
        string revString = chArray.ToString();
        if (str == revString)
        {
            Console.WriteLine("false");
            return false;
        }

        //test = "";
        //char[] ch = str.ToCharArray();

        //for (int i = 0; i < ch.Length; i++)
        //{
        //    for (int j = 0; j < ch.Length; j++)
        //    {
        //        ch[i] = ch[j];

        //        for (int k = 0; k < ch.Length; k++)
        //        {
        //            test+= ch[k];
        //        }
        //        if (test.ToCharArray() == test.ToCharArray().Reverse())
        //        {
        //            return true;
        //        }
        //    }
        //}
        return false;
    }

    public static int CalcSnail(int depth)
    {
        // snail can climb 5cm per minute
        // snail can crawl for 30 minutes at a time
        // snail needs a 10 minute rest after 30 minutes
        // snail slides down 30cm during 10 minute rest
        const int perMinute = 5, crawlTime = 30, restTime = 10, downSlide = 30;
        int numberRests = 0;

        if (depth <= crawlTime * perMinute)  // bucket less than 150cm deep
        {
            return (depth / perMinute);
        }

        if ((depth % (crawlTime * perMinute) == 0))
        {
            numberRests = (depth % (crawlTime * perMinute)) - 1;
        }
        else
        {
            numberRests = (depth % (crawlTime * perMinute));
        }

        numberRests = (depth % (crawlTime * perMinute));


        return 0;
    }


    public static long Gauss(long[] arr)
    {
        long start, end, result;
        if (arr.Length == 1)
        {
            start = 1;
            end = arr[0];
        }
        else
        {
            Array.Sort(arr);
            start = arr[0];
            end = arr[1];
        }
        result = ((long)((start + end) * ((end - start + 1) * .5)));
        Console.WriteLine(result);
        return result;
    }
    public static string[] GetFrame(int w, int h, char c)
    {
        string[] result = new string[h];
        string[,] frameRows = new string[h, w];
        if (h < 3 || w < 3)
        {
            result[0] = "invalid";
            Console.WriteLine("invalid");
            return result;
        }
        else
        {
            for (int height = 0; height < h; height++)
            {
                for (int width = 0; width < w; width++)
                {
                    if (width == 0 || width == w - 1)
                    {
                        frameRows[height, width] += c;
                    }
                    else if (height == 0 || height == h - 1)
                    {
                        frameRows[height, width] += c;
                    }
                    else
                    {
                        frameRows[height, width] += "-";
                    }
                }
            }
        }

        // convert [,] to []
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                result[i] += frameRows[i, j];
            }
            Console.WriteLine(result[i]);
        }

        return result;

        //if (w < 3 || h < 3)
        //{
        //    return new string[] { "invalid" };
        //}
        //string[] result = new string[h];
        //result[0] = new string(ch, w);
        //for (int i = 1; i < h - 1; i++)
        //{
        //    result[i] = ch + new string(' ', w - 2) + ch;
        //}
        //result[h - 1] = new string(ch, w);
        //return result;
    }
    public static string Collatz(Int64 a, Int64 b)
    {

        if (CountCollatz(a) < CountCollatz(b))
        {
            Console.WriteLine("a is lower");
            return "a";
        }
        else
        {
            Console.WriteLine("b is lower");
            return "b";
        }

        static int CountCollatz(Int64 calc)
        {
            int count = 0;
            while (calc != 1)
            {
                if (calc % 2 == 0)
                {
                    calc /= 2;
                }
                else
                {
                    calc = (calc * 3) + 1;
                }
                count++;
            }
            Console.WriteLine(count);
            return count;
        }

        //while (true)
        //{
        //    if (a == 1) return "a";
        //    if (b == 1) return "b";
        //    a = a % 2 == 0 ? a / 2 : 3 * a + 1;
        //    b = b % 2 == 0 ? b / 2 : 3 * b + 1;
        //}

    }
    public static string[] SplitCases(string input, int cases)
    {
        string[] result = new string[cases];
        if (input.Length % cases == 0)
        {
            int caseLength = input.Length / cases;
            int count = 0;

            for (int i = 0; i < cases; i++)
            {
                result[i] = input.Substring(count, caseLength);
                count += caseLength;
            }
        }
        else
        {
            result[0] = "Error";
        }

        for (int i = 0; i < result.Length; i++)
        {
            string str = "";
            str += result[i] + "  ";
            Console.Write(str);
        };
        return result;
    }
    public static int Bridges(string str)
    {
        int horizontalBridges = 0, verticalBridges = 0;
        string[] rows = str.Split("/");

        // count horizontal bridges
        for (int i = 0; i < rows.Length; i++)
        {
            if (!rows[i].Contains(' '))
            {
                horizontalBridges++;
            }
        }

        // count vertical bridges        
        for (int i = 0; i < rows[0].Length; i++)
        {
            int temp = 0;
            for (int j = 0; j < rows.Length; j++)
            {
                if (rows[j][i] != ' ')
                {
                    temp++;
                }
            }
            if (temp == rows.Length)
            {
                verticalBridges++;
            }
        }
        Console.WriteLine("vertical " + verticalBridges +", horizontal " 
            + horizontalBridges);

        return verticalBridges + horizontalBridges;
    }
    public static bool DoesRhyme(string str1, string str2)
    {
        string[] str1Arr = str1.Split(' ');
        string[] str2Arr = str2.Split(' ');

        string lastW1 = str1Arr[str1Arr.Length - 1].ToLower();
        string lastW2 = str2Arr[str2Arr.Length - 1].ToLower();

        Console.WriteLine(lastW1 + " " + lastW2);

        List<char> vowelsList = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

        string vowels1 = "", vowels2 = "";

        foreach (char c in lastW1)
        {
            if (vowelsList.Contains(c))
            {
                vowels1 += c;
            }
        }
        foreach (char c in lastW2)
        {
            if (vowelsList.Contains(c))
            {
                vowels2 += c;
            }
        }

        //for (int i = 0; i < lastW1.Length; i++)
        //{
        //    if (lastW2[i] == 'a' || lastW2[i] == 'e' || lastW2[i] == 'i'
        //        || lastW2[i] == 'o' || lastW2[i] == 'u')
        //    {
        //        vowels1 += lastW1[i];
        //    }            
        //}
        //for (int i = 0; i < lastW2.Length; i++)
        //{
        //    if (lastW2[i] == 'a' || lastW2[i] == 'e' || lastW2[i] == 'i'
        //        || lastW2[i] == 'o' || lastW2[i] == 'u')
        //    {
        //        vowels2 += lastW2[i];
        //    }
        //}

        Console.WriteLine(vowels1 + "  " + vowels2);

        char[] vow1 = vowels1.ToCharArray();
        char[] vow2 = vowels2.ToCharArray();
        Array.Sort(vow1);
        Array.Sort(vow2);

        if (vow1.Length != vow2.Length)
        {
            Console.WriteLine("false");
            return false;
        }
        else
        {
            for (int i = 0; i < vow1.Length; i++)
            {
                Console.WriteLine(vow1[i] + "=" + vow2[i]);
                if (vow1[i] != vow2[i])
                {
                    Console.WriteLine("false");
                    return false;
                }
            }
        }
        
        Console.WriteLine("true");
        return true;

        // USING Regex
        //string vowels1 = Regex.Replace(str1.Split().Last().ToLower(), "[^aeiou]", "");
        //string vowels2 = Regex.Replace(str2.Split().Last().ToLower(), "[^aeiou]", "");

        //return vowels1 == vowels2;
    }
    public static bool IsParselTongue(string sentence)
    {
        // Each word in a sentence must contain either:
        // Two or more consecutive instances of the letter "s"
        //    (i.e.must be together ss..), or...
        // Zero instances of the letter "s" by itself.

        sentence = sentence.ToLower();
        string[] words = sentence.Split(' ');
        int[] test = new int[words.Length];

        for (int t = 0; t < words.Length; t++)
        {
            test[t] = 1;
        }
        
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains("s"))
            {
                if (words[i].Contains("ss"))
                { }
                else
                {
                    test[i] = 0;
                }
            }
        }

        int testSum = 0;
        for (int i = 0; i < test.Length; i++)
        {
            Console.WriteLine(test[i]);
            testSum += test[i];
        }

        if (testSum == words.Length)
        {
            Console.WriteLine("true");
            return true;
        }

        Console.WriteLine("false");
        return false;

    }
    //public static string DigitCount(string str)
    //{
    //    int[] orig = new int[str.Length];
    //    for (int i = 0; i < str.Length; i++)
    //    {
    //        orig[i] = Convert.ToInt32(str[i]);
    //    }


    //}
    public static bool ValidateEmail(string str)
    {
        if (str.Split('@').Length !=2)
        {
            Console.WriteLine("false, no @");
            return false;
        }
        string[] parts = str.Split('@');

        if (parts[0].Length < 1)
        {
            Console.WriteLine("false, less than 1 char before @");
            return false;
        }

        if (!parts[1].EndsWith(".com"))
        {
            Console.WriteLine("doesn't end with .com");
            return false;
        }        

        return true;
    }     
    public static bool IsValidPhoneNumber(string str)
    {
        Regex regex = new Regex("^[(][0-9]{3}[)] [0-9]{3}-[0-9]{4}$");
        Console.WriteLine(regex.IsMatch(str));
        return regex.IsMatch(str);

        // Regex.IsMatch(str, @"^\(\d{3}\) \d{3}\-\d{4}$");
    }
    //public static long DigitCount(long num)  //  this one is not working!!!
    //{
    //    Dictionary<char, int> dict = new Dictionary<char, int>();
    //    string numbers = num.ToString();
    //    foreach (char c in numbers)
    //    {
    //        if (!dict.ContainsKey(c))
    //        {
    //            dict.Add(c, 1);
    //        }
    //        else
    //        {
    //            dict[c]++;
    //        }
    //    }

    //    StringBuilder sb = new StringBuilder(numbers);
    //    for (int i = 0; i < sb.Length; i++)
    //    {
    //        var currentChar = sb[i];
    //        foreach (var dictItem in dict)
    //        {
    //            if (currentChar == dictItem.Key)
    //            {
    //                sb.Replace(currentChar, Convert.ToChar(dictItem.Value));
    //            }
    //        }
    //    }

    //    //Int64 answer = int.Parse(sb.ToString());

    //    //Console.WriteLine(int.Parse(sb.ToString()));
    //    return Convert.ToInt64(numbers);
    //}
    public static int[] TwoProduct(int[] arr, int n)
    {
        int[] result = new int[2];
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[i] * arr[j] == n)
                {
                    if (arr[i] < arr[j])
                    {
                        result[0] = arr[i];
                        result[1] = arr[j];
                    }
                    else
                    {
                        result[0] = arr[j];
                        result[1] = arr[i];
                    }
                }
            }
        }

        Console.WriteLine(result[0].ToString());
        Console.WriteLine(result[1].ToString());

        return result;
    }
    public static string AlphabetIndex(string str)
    {
        string lower = str.ToLower();
        string alpha = "abcdefghijklmnopqrstuvwxyz";

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < lower.Length; i++)
        {
            for (int j = 0; j < alpha.Length; j++)
            {
                if (alpha[j] == lower[i] )
                {
                    sb.Append((j + 1) + " ");
                }
            }
        }

        Console.WriteLine(sb.ToString().Trim());
        return sb.ToString().Trim();
    }
    public static string Fibonacci(int n)
    {
        int length = n + 1;
        BigInteger[] term = new BigInteger[length];
        term[0] = 0;
        term[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            term[i] = term[i - 1] + term[i - 2];
        }

        Console.WriteLine(term[n]);
        return term[n].ToString();
    }
    
    public static int LCMofArray(int[] numbers)
    {
        // LCM is the smallest positive number that is divisible by each
        // of the numbers in the array

        int testNum = numbers.Max();    // starting point 
        List<char> LCMlist = new List<char>(numbers.Length);
        for (int i = 0; i < numbers.Length; i++) LCMlist.Add('F');
               
        while (LCMlist.Contains('F'))
        {
            testNum++;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (testNum % numbers[i] != 0)
                {
                    LCMlist[i] = 'F';
                }
                else
                {
                    LCMlist[i] = 'T';
                }
            }
        }
        Console.WriteLine(testNum);
        return testNum;
    }
    public static string LongestCommonEnding(string str1, string str2)
    {
        string answer = "";
        int count = 1;
        
        while ((count <= str1.Length && count <= str2.Length) &&
            str1[str1.Length - count] == (str2[str2.Length - count]))
        {
            answer += str1[str1.Length - count];
            count++;
        }

        char[] ch = answer.ToCharArray();
        Array.Reverse(ch);
        answer = new string(ch);

        Console.WriteLine(answer);
        return answer;
    }
    public static string NumType(int num)
    {
        // Check if Perfect
        int sum = CalcNum(num);
        if (sum == num)
        {
            Console.WriteLine(num + " is perfect");
            return "Perfect";
        }

        // Check if Amicable
        int sum2 = CalcNum(sum);
        if (sum2 == num)
        {
            Console.WriteLine(num + " amicable with " + sum);
            return "Amicable";
        }

        Console.WriteLine("Neither");
        return "Neither";
    }
    private static int CalcNum(int num)
    {
        int sum = 0;
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
    public static bool IsValidHexCode (string str)
    {
        //A hex code must begin with a pound key # and is exactly 6 characters in length.
        //Each character must be a digit from 0-9 or an alphabetic character from A-F.
        //All alphabetic characters may be uppercase or lowercase

        Regex r = new Regex(@"^#[a-f,A-F,0-9]{6}$");
        return NewMethod(str, r);
    }
    private static bool NewMethod(string str, Regex r)
    {
        Console.WriteLine(r.IsMatch(str));
        return r.IsMatch(str);
    }
    public static int SockPairs(string socks)
    {
        int pairs = 0;
        List<char> sockList = new List<char>();
        foreach (char c in socks)
        {
            sockList.Add(c);
        }
        sockList.Sort();

        for (int i = 0; i < sockList.Count; i++)
        {
            if (i + 1 < sockList.Count)
            {
                if (sockList[i] == sockList[i + 1])
                {
                    pairs++;
                    i++;
                }
            }
        }

        Console.WriteLine(pairs);

        return pairs;
    }
    public static int[] TrackRobot(int[] steps)
    {
        int n = 0, e = 0, s = 0, w = 0;

        for (int i = 0; i < steps.Length; i++)
        {
            n += steps[i];
            if (i + 1 < steps.Length)
            {
                e += steps[i + 1];
                i++;
            }
            if (i + 1 < steps.Length)
            {
                s += steps[i + 1];
                i++;
            }
            if (i + 1 < steps.Length)
            {
                w += steps[i + 1];
                i++;
            }
        }

        Console.WriteLine(e - w);
        Console.WriteLine(n - s);

        return new int[] { e-w, n-s };
    }
    public static int DuplicateCount(string str)
    {
        List<char> list = new List<char>();
        foreach (char c in str)
        {
            list.Add(c);
        }

        list.Sort();
        
        int count = 0;

        if (list[0] == list[1])
        {
            count++;
        }

        for (int i = 1; i < str.Length - 1; i++)
        {
            if (list[i] == list[i + 1] && list[i] != list[i - 1])
            {
                count++;
            }
        }
        
        Console.WriteLine(count);

        return count;

        // almost had it with this, except if there were multiples
        // of the same duplicated char!!!!

        //IEnumerable<char> distinctChars = list.AsQueryable().Distinct();
        //int distinctCount = 0;
        //foreach (char c in distinctChars)
        //{
        //    distinctCount++;
        //}

        //Console.WriteLine(str.Length - distinctCount);
        //return str.Length - distinctCount;
    }
    public static int NextPrime(int num)
    {
        int primeNum = 0;
        bool IsPrime = true;
        for (int i = num; i < 100; i++)
        {
            for (int j = 2; j < i / 2; j++)
            {
                if (i % j == 0)
                {
                    IsPrime = false;
                    break;
                }
                else { primeNum = i; IsPrime = true; }
            }
            if (IsPrime == true)
            {
                Console.WriteLine(primeNum);
                return primeNum;
            }
        }
        return 0;

        //for (int i = 2; i < num; i++)
        //{
        //    if (num % i == 0) { num++; i = 2; }
        //}
        //return num;
    }
    public static string MysteryFunc(string str)
    {
        // looks like repeat the letter by the int afterwards
        char[] chars = str.ToCharArray();

        char[] letters = new char[str.Length / 2];
        int[] numbers = new int[str.Length / 2];
        int lettersCount = 0, numbersCount = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (i % 2 == 0)
            {
                letters[lettersCount] = chars[i];
                lettersCount++;
            }
            else if (i % 2 != 0)
            {
                numbers[numbersCount] = int.Parse(chars[i].ToString());
                numbersCount++;
            }
        }

        string returnStr = "";
        for (int i = 0; i < str.Length / 2; i++)
        {
            for (int j = 0; j < numbers[i]; j++)
            {
                returnStr += letters[i];
            }
        }

        Console.WriteLine(returnStr);

        return returnStr;
    }
    public static string MysteryFuncBetter(string str)
    {
        string returnStr = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                int a = int.Parse(str[i].ToString());
                for (int j = 0; j < a; j++)
                {
                    returnStr += str[i - 1];
                }
            }
        }
        Console.WriteLine(returnStr);

        return returnStr;
    }
    public static string ReverseOdd(string str)
    {
        string[] words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length % 2 != 0)
            {
                char[] letters = words[i].ToCharArray();
                Array.Reverse(letters);
                words[i] = new string(letters);
            }
        }

        return String.Join(" ", words);


    }
    public static bool IsSmooth(string sentence)
    {
        //A smooth sentence is one where the last letter of each word is identical
        //to the first letter the following word(and not case sensitive,
        //so "A" would be the same as "a").

        sentence = sentence.ToLower();
        string[] words = sentence.Split(' ');
        string letter = words[0].Substring(words[0].Length - 1);
        

        for (int i = 1; i < words.Length; i++)
        {
            Console.WriteLine(letter);
            if (letter != words[i].Substring(0, 1))
            {
                return false;
            }
            else
            {
                letter = words[i].Substring(words[i].Length - 1);
            }            
        }
        
        return true;


    }
    public static string CupSwapping(string[] swaps)
    {
        char ball = 'B';  // starting location
        for (int i = 0; i < swaps.Length; i++)
        {
            char[] ch = swaps[i].ToCharArray();
            if (ch[0] == ball)
            {
                ball = ch[1];
            }
            else if (ch[1] == ball)
            {
                ball = ch[0];
            }
            Console.WriteLine(ball);
        }
        Console.WriteLine(ball);
        return ball.ToString();

        //char ball = 'B';
        //foreach (string move in swaps)
        //    if (move[0] == ball)
        //        ball = move[1];
        //    else if (move[1] == ball)
        //        ball = move[0];
        //return ball.ToString();
    }
    public static string Interview(int[] arr, int tot)
    {
        string answer = "qualified";
        int[] timeLimits = { 5, 5, 10, 10, 15, 15, 20, 20 };
        if (tot > 120)
        {
            answer = "disqualified";
        }
        if (arr.Length < 8)
        {
            answer = "disqualified";
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > timeLimits[i])
            {
                answer = "disqualified";
            }
        }

        return answer;
    }
    public static string ReverseAndNot(int i)
    {
        char[] chars = i.ToString().ToCharArray();
        Array.Reverse(chars);
        string returnStr = new string(chars) + i.ToString();
        Console.WriteLine(returnStr);
        return returnStr;

        // using linq
        // return $"{String.Concat(i.ToString().Reverse())}{i}";
    }
    public static string TextToNum(string phone)
    {
        phone = Regex.Replace(phone, "[ABC]", "2");
        phone = Regex.Replace(phone, "[DEF]", "3");
        phone = Regex.Replace(phone, "[GHI]", "4");
        phone = Regex.Replace(phone, "[JKL]", "5");
        phone = Regex.Replace(phone, "[MNO]", "6");
        phone = Regex.Replace(phone, "[PQRS]", "7");
        phone = Regex.Replace(phone, "[TUV]", "8");
        phone = Regex.Replace(phone, "[WXYZ]", "9");

        Console.WriteLine(phone);
        return phone;
    }
    public static string WurstIsBetter(string str)
    {
        var list = new List<string>()
        { "kielbasa", "chorizo", "moronga", "salami", "sausage", "andouille",
        "naem", "merguez", "gurka", "snorkers", "pepperoni"};
        string retStr = str;
        foreach (var word in list)
        {
            //retStr = retStr.Replace(word, "Wurst");
            retStr = Regex.Replace(retStr, word, "Wurst", RegexOptions.IgnoreCase);
        }
 
        Console.WriteLine(retStr);
        return retStr;
    }
    public static bool Cons(int[] arr)
    {
        //Create a function that determines whether elements in an array
        //can be re - arranged to form a consecutive list of numbers
        //where each number appears exactly once.
        Array.Sort(arr);
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.WriteLine(arr[i]);
            int next = int.Parse(arr[i].ToString()) + 1;
            if (arr[i + 1] != next)
            {
                Console.WriteLine(arr[i + 1] + "   " + next);
                return false;
            }
        }

        return true;
    }
    public static string[] CapMe(string[] arr)
    {
        string[] retArr = new string[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            char[] charArr = arr[i].ToCharArray();  // grabs name
            charArr[0] = char.ToUpper(charArr[0]);  // first character to upper
            for (int j = 1; j < charArr.Length; j++) // gets length of name
            {                
                charArr[j] = char.ToLower(charArr[j]); // remaining characters to lower                
            }
            retArr[i] = String.Join("", charArr);
            Console.WriteLine(retArr[i].ToString());
        }
        return retArr;

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = arr[i].Substring(0, 1).ToUpper() +
        //        arr[i].Substring(1).ToLower();
        //}
        //return arr;
    }
    public static string Uncensor(string txt, string vowels)
    {
        string uncensored = "";
        int count = 0;
        foreach (char c in txt)
        {
            if (c == '*')
            {
                uncensored += vowels[count];
                count++;
            }
            else { uncensored += c; }
        }

        Console.WriteLine(uncensored);

        return uncensored;
    }
    public static string WeekAfter(string date)
    {
        // using System.Globalization;  return as day/month/year
        CultureInfo culture = CultureInfo.InvariantCulture;
        DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", culture);
        Console.WriteLine(dt.ToString());
        dt = dt.AddDays(7);
        string revisedDate = dt.ToShortDateString();
        string[] split = revisedDate.Split("/");
        revisedDate = split[1] + "/" + split[0] + "/" + split[2];
        Console.WriteLine(revisedDate);
        return revisedDate;

        //DateTime oldDate = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        //DateTime newDate = oldDate.AddDays(7);
        //return newDate.ToString("dd/MM/yyyy");
    }
    public static string IsPrime(int[] primes, int num)
    {
        // this is not working YET!!!!!!

        // use binary search algorithm
        int half;
        if (primes.Length % 2 == 0)
        {
            half = primes.Length / 2;
        }
        else { half = (primes.Length / 2) + 1; }

        if (half == 1)
        {
            if (primes[0] == num)
            {
                return "yes";
            }
            else { return "no"; }
        }

        if (num == primes[half])
        {
            Console.WriteLine("yes");
            return "yes";
        }
        if (num < primes[half])
        {
            int[] primesLower = new int[half];
            for (int j = 0; j < primesLower.Length; j++)
            {
                primesLower[j] = primes[j];
            }
            IsPrime(primesLower, num);
        }
        else if (num > primes[half])
        {
            int[] primesHigher = new int[half];
            for (int k = half; k >= 0; k--)
            {
                primesHigher[k] = primes[k];
            }
            IsPrime(primesHigher, num);
        }

        Console.WriteLine("no");
        return "no";
    }
    public static bool CanFind(string[] bigrams, string[] words)
    {
        bool[] results = new bool[bigrams.Length];
        for (int i = 0; i < bigrams.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].Contains(bigrams[i]))
                {
                    results[i] = true;
                }
                else
                {
                    results[i] = false;
                }
            }
        }

        foreach (var item in results)
        {
            if (item == false)
            {
                return false;
            }
        }

        return true;
    }
    public static string AlternatingCaps(string str)
    {
        char[] chars = str.ToCharArray();
        string returnStr = "";
        int spaces = 0;
        returnStr += char.ToUpper(chars[0]);
        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i] == ' ')
            {
                spaces++;
            }
            if ((i - spaces) % 2 == 0)
            {
                returnStr += char.ToUpper(chars[i]);
            }
            else
            {
                returnStr += char.ToLower(chars[i]);
            }
        }
        Console.WriteLine(returnStr);
        return returnStr;
    }
    public static bool isFactorial(int n)
    {
        int sum = 1;
        for (int i = 1; i < n; i++)
        {
            if (sum == n) { return true; }
            else { sum *= i; }
        }
        return false;
    }
    public static int SumPrimes(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int divisors = 0;
            for (int j = arr[i]; j > 0; j--)
            {
                if (arr[i] % j == 0)
                {
                    divisors++;
                }
            }
            if (divisors == 2) { sum += arr[i]; }
        }

        return sum;
    }
    public static int NumberOfDays(int[] coordinates)
    {
        int days = 0, restday = 0;
        int ttlMoves = Math.Abs(coordinates[0] + coordinates[1]);
        for (int i = 1; i <= ttlMoves; i++)
        {
            days = i;
            if ((i - 1) % 5 == 0)
            {
                restday++;
            }
        }
        Console.WriteLine(ttlMoves);
        Console.WriteLine(days);
        Console.WriteLine(restday);

        return days + restday - 1;

        // https://edabit.com/challenge/hmt8k8oq3a83QznjJ
        //int travelDays = Math.Abs(coordinates[0] + coordinates[1]);
        //int restDays = (travelDays - 1) / 5;
        //return travelDays + restDays;
    }
    public static int[] TrackRobot(string[] instructions)
    {
        int[] result = new int[2];
        
        for (int i = 0; i < instructions.Length; i++)
        {
            string[] split = instructions[i].Split(' ');
            if (split[0] == "left")         { result[0] -= int.Parse(split[1]); }
            else if (split[0] == "right")   { result[0] += int.Parse(split[1]); }
            else if (split[0] == "up")      { result[1] += int.Parse(split[1]); }
            else if (split[0] == "down")    { result[1] -= int.Parse(split[1]); }
        }
        Console.WriteLine(result[0].ToString() + " " + result[1].ToString());
        return result;
    }
    public static bool IsAnagram(string str1, string str2)
    {
        char[] arr1 = str1.ToLower().ToCharArray();
        char[] arr2 = str2.ToLower().ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        str1 = new string(arr1);
        str2 = new string(arr2);
        Console.WriteLine(str1.Equals(str2));
        return str1.Equals(str2);

        //var str1Array = str1.ToLower().ToCharArray();
        //var str2Array = str2.ToLower().ToCharArray();

        //Array.Sort(str1Array);
        //Array.Sort(str2Array);

        //return str1Array.SequenceEqual(str2Array);

    }
    public static string FlipEndChars(object str)
    {
        Type type = str.GetType();
        if (type.Equals(typeof(string)))
        {
            string tempStr = str.ToString();
            if (tempStr.Length < 2)
            { return "Incompatible."; }

            else if (tempStr[0] == tempStr[tempStr.Length - 1])
            { return "Two's a pair."; }

            else
            {
                string returnStr = tempStr.Substring(1, tempStr.Length - 2);
                returnStr = (tempStr[tempStr.Length - 1]) + returnStr + (tempStr[0]);
                Console.WriteLine(returnStr);
                return returnStr;
                // return $"{text[text.Length-1]}{text.Substring(1,text.Length-2)}{text[0]}";
            }
        }
        return "Incompatible.";
    }
    public static string OddishOrEvenish(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        if (sum % 2 == 0)
        {
            return "Evenish";
        }
        else
        {
            return "Oddish";
        }
    }
    public static int LetterDistance(string str1, string str2)
    {
        int length = 0;
        int sum = Math.Abs(str1.Length - str2.Length);
        if (str2.Length <= str1.Length)
        {
            length = str2.Length;
        }
        else
        {
            length = str1.Length;
        }
        for (int i = 0; i < length; i++)
        {
            sum += Math.Abs(((int)str1[i] - (int)str2[i]));
        }
        Console.WriteLine(str1.Length);
        Console.WriteLine(str2.Length);
        Console.WriteLine(sum);
        return sum;
    }
    public static int MajorSum(int[] arr)
    {
        //Create a function that takes an integer array
        //and return the biggest between positive sum,
        //negative sum, or 0s count.
        //The major is understood as the greatest absolute.

        int sumPos = 0, sumNeg = 0, ctZero = 0;
        foreach (var num in arr)
        {
            if (num > 0) { sumPos += num; }
            if (num < 0) { sumNeg += num; }
            if (num == 0) { ctZero++; }
        }

        int max;
        if (sumPos > ctZero)
        {
            max = sumPos;
        }
        else { max = ctZero; }

        if (Math.Abs(sumNeg) > max)
        {
            max = sumNeg;
        }

        return max;
    }
    public static string Reverse5orMore(string str)
    {
        string[] words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 4)
            {
                char[] charArr = words[i].ToCharArray();
                Array.Reverse(charArr);
                string wordRev = "";
                foreach (char ch in charArr)
                {
                    wordRev += ch;
                }
                words[i] = wordRev;
            }
        }
        return string.Join(" ", words);
    }
    public static string SevenBoom(int[] arr)
    {
        foreach (var seven in arr)
        {
            string num = seven.ToString();
            if (num.Contains('7'))
            {
                return "Boom!";
            }
        }
        return "there is no 7 in the array";
    }
    public static int Schoty(string[] frame)
    {
        // 7 strings  and  10 beads
        //List<int> numbers = new List<int>();
        string numberStr = "";
        
        // there's always 3 '---' to represent space on the wire
        for (int i = 0; i < frame.Length; i++)
        {
            string[] split = frame[i].Split('-');
            numberStr += split[0].Length;
        }
        Console.WriteLine(numberStr);
        
        return Int32.Parse(numberStr);
    }
    public static int LargestGap(int[] arr)
    { // https://edabit.com/challenge/AyCKKtuhYjNo9eYwJ
        
        Array.Sort(arr);
        int gap = 0, testGap = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            testGap = arr[i + 1] - arr[i];
            if (testGap > gap)
            {
                gap = testGap;
            }
        }
        return gap;
    }
    public static string Accum(string str)
    {
        // https://edabit.com/challenge/djCa8yiv5kYPhvcAZ

        string returnStr = "";
        int count = 0;
        char[] chars = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            returnStr += char.ToUpper(chars[i]);
            for (int j = 1; j <= count; j++)
            {
                returnStr += char.ToLower(chars[i]);
            }
            returnStr += "-";
            count++;
        }
        return returnStr.Remove(returnStr.Length - 1);
    }
    public static bool KtoK(string n, int k)
    {
        double num = Double.Parse(n);
        return Math.Pow(k, k) == num;
    }
    public static int MysteryFunc(int num) // reverse coding exercise
    {
        int sum = 1, remainder;
        while (num != 0)
        {
            remainder = num % 10;
            num /= 10;
            sum *= remainder;
        }
        return sum;
        // returns the sum of all digits multiplied
    }
    public static string MakeTitle(string str) // capitalize 1st letter of each word
    {
        string strReturn = "";
        string[] words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();
            words[i] = char.ToUpper(chars[0]) + words[i].Substring(1);
            strReturn += words[i] + " ";
        }
        return strReturn.Trim();
    }
    public static int GCD(int n1, int n2)  //greatest common divisor
    {
        int dividend, divisor, quotient, remainder;
        if (n1 > n2)
        {
            dividend = Math.Abs(n1);
            divisor = Math.Abs(n2);
        }
        else
        {
            dividend = Math.Abs(n2);
            divisor = Math.Abs(n1);
        }
        quotient = dividend / divisor;
        remainder = dividend % divisor;

        while (remainder != 0)
        {
            dividend = divisor;
            divisor = remainder;
            remainder = dividend % divisor;
        }

        string str = "GCD of " + n1 + " and " + n2 + " = " + divisor;
        Console.WriteLine(str);

        return divisor;

        //if (b == 0)
        //    return a;
        //else
        //    return gcd(b, a % b);

    }
    public static bool IsPalindrome(string str)
    {
        str = str.ToLower();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if ((str[i] >= '0' && str[i] <='9')
                || str[i] >= 'a' && str[i] <= 'z')
            {
                sb.Append(str[i]);
            }
        }
        str = sb.ToString();
        string strRev = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            strRev += str[i];
        }

        if (str == strRev)
        {
            return true;
        }
        return false;
    }
    public static int[,] SquarePatch(int n)
    {
        int[,] result = new int[n,n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i,j] = n;
            }
        }
        return result;
    }
    public static string GetCentury(int year)
    {
        int yr;
        if (year % 100 == 0)
        {
            yr = year / 100;
        }
        else
        {
            yr = (year / 100) + 1;
        }

        if (yr == 21)
        {
            return yr.ToString() + "st century";
        }
        
        return yr.ToString() + "th century";

        //int num = year % 100 == 0 ? year / 100 : year / 100 + 1;
        //return num > 20 ? num + "st century" : num + "th century";
    }
    public static int[] RemoveSmallest(int[] values)
    {
        if (values.Length == 0) { return Array.Empty<int>(); }
        List<int> result = values.ToList();
        int smallest = result.Min();        
        result.Remove(smallest);
        int[] arr = result.ToArray();
        string str = "";
        for (int i = 0; i < arr.Length; i++)
        {
            str += arr[i];
        }
        Console.WriteLine(str);
        return result.ToArray();
    }
    public static double[] FindLargest(double[][] values)
    {
        List<double> result = new List<double>(values.Length);
        string largestStr = "";
        for (int i = 0; i < values.Length; i++)
        {
            double largest = 0;
            for (int j = 0; j < values[i].Length; j++)
            {
                Array.Sort(values[i]);
                //if (values[i][j] > largest)
                //{
                //    largest = values[i][j];
                //}
                largest = values[i].Length - 1;
            }
            result.Add(largest);
            largestStr += largest.ToString();
        }
        Console.WriteLine(largestStr);
        return result.ToArray();

        //var outputArr = new double[values.Length];
        //for (int i = 0; i < values.Length; i++)
        //{
        //    outputArr[i] = values[i].Max();
        //}
        //return outputArr;
    }
    public static int GuessSequence(int num)
    {
        int[] quad = new int[num + 1];
        quad[0] = 90;
        int sequence = 0;

        if (num > 1)
        {
            for (int i = 1; i <= num; i++)
            {
                quad[i] = quad[i - 1] + 150 + (sequence * 60);
                sequence++;
            }
        }

        return quad[num - 1];

        //https://edabit.com/challenge/gnmjJ9aomQJvzTR8N

        // turn that into:
        // return (30*num*num)+(60*num);

    }
    public static string NoYelling(string phrase)
    {
        if (phrase.EndsWith("!"))
        {
            return phrase.TrimEnd('!') + "!";
        }

        if (phrase.EndsWith("?"))
        {
            return phrase.TrimEnd('?') + "?";
        }

        return phrase;
    }
    public static string FindNemo(string sentence)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == "Nemo")
            {
                return "I found Nemo at " + (i + 1) + "!";
            }
        }
        return "I can't find Nemo :(";

        //var index = Array.IndexOf(sentence.Split(' '), "Nemo");
        //if (index < 0) return "I can't find Nemo :(";
        //return $"I found Nemo at {index + 1}!";
    }
    public static string FormatNum(int num)
    {
        Console.WriteLine(String.Format("{0:n0}", num));
        return String.Format("{0:n0}", num);
    }
    public static bool CheckPerfect(int num)
    {
        List<int> list = new List<int>();
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                list.Add(i);
            }
        }

        int sum = 0;
        int[] arr = list.ToArray();
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum == num;

        //int total = 0;
        //for (int i = 1; i <= num / 2; i++)
        //    if (num % i == 0)
        //        total += i;
        //return total == num;
    }
    public static string ToScottishScreaming(string str)
    {
        //A strong Scottish accent makes every vowel similar to an "e",
        //so you should replace every vowel with an "e".
        //Additionally, it is being screamed, so it should be in block capitals.

        str = str.ToUpper();
        str = str.Replace('A', 'E').Replace('I', 'E').Replace('O', 'E').Replace('U', 'E');

        return str;

        //return Regex.Replace(str.ToUpper(), "[AIOU]", "E");
    }
    public static int CountPotatoes(string potato)
    {
        return Regex.Matches(potato, "potato").Count;
    }
    public static string HighLow(string str)
    {
        string[] numArr = str.Split(' ');
        int[] intArr = new int[numArr.Length];

        for (int i = 0; i < numArr.Length; i++)
        {
            intArr[i] = int.Parse(numArr[i]);
        }

        Array.Sort(intArr);
        return intArr[intArr.Length - 1].ToString() + " " + intArr[0].ToString();

        // using Linq
        // var arr = str.Split(' ').Select(int.Parse).ToArray();
        // return arr.Max() + " " + arr.Min();
    }
    public static int SortDescending(int num)
    {
        var x = num.ToString().ToList();
        x.Sort();
        x.Reverse();
        string rev = String.Empty;

        foreach (var n in x)
        {
            rev += n;
        }

        Console.WriteLine(Convert.ToInt32(rev));
        return Convert.ToInt32(rev);

    }
    public static int[] FilterArray(object[] arr)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].GetType().ToString() != "System.String")
            {
                list.Add((int)arr[i]);
            }
        }
        return list.ToArray();

        // using System.Linq;
        // return arr.OfType<int>().ToArray();
    }
    public static int[] CountPosSumNeg(double[] arr)
    {
        int[] returnArr = new int[2];
        double count = 0, sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                count++;
            }
            else
            {
                sum += arr[i];
            }
        }
        returnArr[0] = (int)Math.Round(count);
        returnArr[1] = (int)Math.Round(sum);

        Console.WriteLine(returnArr[0]);
        Console.WriteLine(returnArr[1]);

        return returnArr;

        //int[] arrs = Array.ConvertAll(arr, Convert.ToInt32);
        //return new int[] {
        //        arrs.Where(d => d > 0).Count(),
        //        arrs.Where(d => d < 0).Sum()
        //    };
    }
    public static int SumSmallest(int[] values)
    {
        Array.Sort(values);
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] >= 0)
            {
                int[] positiveValues = new int[values.Length - i];
                Array.Copy(values, i, positiveValues, 0, values.Length - i);
                return positiveValues[0] + positiveValues[1];
            }
        }
        return 0;

    }
    public static bool IsSymmetrical(int num)
    {
        // convert num to string
        string numStr = num.ToString();
        // reverse string
        char[] array = numStr.ToCharArray();
        Array.Reverse(array);
        string newStr = new string(array);

        return numStr == newStr;
    }
}
