
using System;
using System.Globalization;
using System.Text;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Console.Write("What is your name? ");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");

            bool canIVote = true;

            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);

            Console.WriteLine("Biggest Double : {0}", Double.MaxValue);

            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);


            // ---------- DATA TYPE CONVERSION ----------

            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            string strVal = dblFromStr.ToString();

            Console.WriteLine($"Data type : {strVal.GetType()}");

            double dblNum = 12.345;
            Console.WriteLine($"Integer : {(int)dblNum}");

            int intNum = 10;
            long longNum = intNum;

            // ---------- FORMATTING OUTPUT ----------

            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);
            Console.WriteLine("Commas : {0:n4}", 2300);

            // ---------- STRINGS ----------
            string randString = "This is a string";
            Console.WriteLine("String Length : {0}", randString.Length);
            Console.WriteLine("String Contains is : {0}",
                randString.Contains("is"));
            Console.WriteLine("Index of is : {0}",
                randString.IndexOf("is"));
            Console.WriteLine("Remove string : {0}",
                randString.Remove(10, 6));
            Console.WriteLine("Insert String : {0}",
                randString.Insert(10, "short "));
            Console.WriteLine("Replace String : {0}",
                randString.Replace("string", "sentence"));

            Console.WriteLine("Compare A to B : {0}",
                String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("A = a : {0}",
                String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));


            Console.WriteLine("Pad Left : {0}",
                randString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0} Stuff",
                randString.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}",
                randString.Trim());
            Console.WriteLine("Uppercase : {0}",
                randString.ToUpper());
            Console.WriteLine("Lowercase : {0}",
                randString.ToLower());
            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field");

            Console.Write(newString + "\n");
            Console.WriteLine(@"Exactly What I Typed\n");

            // ------ ARRAYS ------
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);
            string[] customers = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine("randomArray 0 : {0}",
                randomArray[0].GetType());
            Console.WriteLine("Array Size : {0}",
                randomArray.Length);

            for (int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Array {0} : Value : {1}",
                j, randomArray[j]);
            }

            int[] randNums = { 1, 4, 9, 2 };

            Array.Sort(randNums);

            Array.Reverse(randNums);

            Console.WriteLine("1 at index : {0} ",
                Array.IndexOf(randNums, 1));

            // ----- IF / ELSE / -----

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else if ((age > 13) && (age < 19))
            {
                Console.WriteLine("Go to high school");
            }
            else
            {
                Console.WriteLine("Go to college");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));
            bool canDrive = age >= 16 ? true : false;
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to Day Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to Preschool");
                    break;
                case 5:
                    Console.WriteLine("Go to Kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another school");
                    goto OtherSchool;
            }

        OtherSchool:
            Console.WriteLine("Elementary, Middle, High School");
            string name2 = "Derek";
            string name3 = "Derek";

            if (name2.Equals(name3, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are Equal");
            }

            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }

                if (i == 9) break;

                Console.WriteLine(i);
                i++;
            }

            // ----- DO WHILE LOOP ----
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num : ", secretNumber);

            do
            {
                Console.Write("Enter a number between 1 & 10 : ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it is was {0}",
                secretNumber);

            Console.Read();
        }
    }
}