namespace Assm5_c_
{
    internal class Program
    {



        static void Main()
        {
            Console.WriteLine("Hello, World!");
            //Q1();
            //Q2();
            //Q3();
            //Q4();
            //Q5();
            //Q6();
            //Q7();
            //Q8(); 
        }

        #region ------Q1-----

        /*
         Passing by Value: When you pass a value type parameter by value,
        a copy of the actual parameter's value is passed to the function.
        Changes made to the parameter inside the function do not affect the original variable.
         Passing by Reference: When you pass a value type parameter by reference,
        you pass a reference to the actual parameter,
        meaning any changes made to the parameter inside the function will affect the original variable.
         */
        static void Q1()
        {
            int a = 5;
            int b = 5;

            Console.WriteLine("Before PassByValue: a = " + a);
            PassByValue(a);
            Console.WriteLine("After PassByValue: a = " + a);

            Console.WriteLine("Before PassByReference: b = " + b);
            PassByReference(ref b);
            Console.WriteLine("After PassByReference: b = " + b);
        }

        static void PassByValue(int x)
        {
            x = 10;
            Console.WriteLine("Inside PassByValue: x = " + x);
        }

        static void PassByReference(ref int x)
        {
            x = 10;
            Console.WriteLine("Inside PassByReference: x = " + x);
        }

        #endregion

        #region -------Q2-----
        /*
         Passing by Value (Reference Type): When you pass a reference type parameter by value,
        a copy of the reference to the object is passed to the method.
        The method can modify the object that the reference points to,
        but it cannot change the reference itself to point to a different object.
        Passing by Reference (Reference Type): When you pass a reference type parameter by reference,
        a reference to the reference is passed.
        This means the method can modify the object and also change the reference itself to point to a different object.
         */

        static void Q2()
        {

            MyClass obj1 = new MyClass();
            obj1.Value = 10;
            Console.WriteLine("Before PassByValue: " + obj1.Value);
            PassByValue(obj1);
            Console.WriteLine("After PassByValue: " + obj1.Value);


            MyClass obj2 = new MyClass();
            obj2.Value = 10;
            Console.WriteLine("Before PassByReference: " + obj2.Value);
            PassByReference(ref obj2);
            Console.WriteLine("After PassByReference: " + obj2.Value);
        }

        static void PassByValue(MyClass obj)
        {
            obj.Value = 20;
            obj = new MyClass();
            obj.Value = 30;
        }

        static void PassByReference(ref MyClass obj)
        {
            obj.Value = 20;
            obj = new MyClass();
            obj.Value = 30;
        }


        class MyClass
        {
            public int Value { get; set; }
        }

        #endregion

        #region -------Q3------

        static void Q3()
        {
            Console.WriteLine("Enter the first number for summation:");
            double sumNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number for summation:");
            double sumNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the first number for subtraction:");
            double subNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number for subtraction:");
            double subNum2 = Convert.ToDouble(Console.ReadLine());

            (double sumResult, double subResult) = Calculate(sumNum1, sumNum2, subNum1, subNum2);

            Console.WriteLine($"The result of summation is: {sumResult}");
            Console.WriteLine($"The result of subtraction is: {subResult}");
        }

        static (double, double) Calculate(double sumNum1, double sumNum2, double subNum1, double subNum2)
        {
            double sumResult = sumNum1 + sumNum2;
            double subResult = subNum1 - subNum2;

            return (sumResult, subResult);
        }

        #endregion

        #region -----Q4-----
        static void Q4()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sumOfDigits = CalculateSumOfDigits(number);

            Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigits}");
        }

        static int CalculateSumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        #endregion

        #region ------Q5------
        static void Q5()
        {
            Console.WriteLine("Enter a number to check if it is prime:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = IsPrime(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        #endregion

        #region ------Q6-----
        static void Q6()
        {
            int[] numbers = { 3, 5, 7, 2, 8, -1, 4, 10, 12 };

            int minValue, maxValue;
            MinMaxArray(numbers, out minValue, out maxValue);

            Console.WriteLine($"The minimum value in the array is: {minValue}");
            Console.WriteLine($"The maximum value in the array is: {maxValue}");
        }

        static void MinMaxArray(int[] array, out int min, out int max)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            min = array[0];
            max = array[0];

            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
        }
        #endregion

        #region -----Q7-----
        static void Q7()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorialResult = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is: {factorialResult}");
        }

        static long CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion

        #region ----Q8----
        static void Q8()
        {
            Console.WriteLine("Enter a string:");
            string originalString = Console.ReadLine();

            Console.WriteLine("Enter the position of the character to change (0-based):");
            int position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the new character:");
            char newChar = Convert.ToChar(Console.ReadLine());

            string modifiedString = ChangeChar(originalString, position, newChar);

            Console.WriteLine($"The modified string is: {modifiedString}");
        }

        static string ChangeChar(string input, int position, char newChar)
        {
            if (position < 0 || position >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position must be within the bounds of the string.");
            }

            char[] charArray = input.ToCharArray();
            charArray[position] = newChar;

            return new string(charArray);
        }
        #endregion

    }
}


