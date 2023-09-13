using System;
using System.Collections;
using System.Collections.Generic;

class Program {

    static bool isRunning = true;

    static void Main() {

        while (isRunning) {

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose your operation (or 999 to quit): ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {

                case 1:

                   var sum = Calculator.Add(num1, num2);
                    Console.WriteLine($"The sum is {sum}");

                break;

                case 2:

                   var difference = Calculator.Subtract(num1, num2);
                    Console.WriteLine($"The difference is {difference}");

                break;

                case 3:

                   var product = Calculator.Multiply(num1, num2);
                    Console.WriteLine($"The product is {product}");

                break;

                case 4:

         

                        var quotient = Calculator.Divide(num1, num2);
                        Console.WriteLine($"The quotient is {quotient}.");

                break;

                case 999:

                    isRunning = false;

                    break;

                default:
                    Console.WriteLine("Error: Not a valid option. Try again.");
                break;

            }


        }

    }

}

struct Calculator {

    #region ADD_OVERLOADS

    /// <summary>
    /// Adds two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The sum of the two operands</returns>
    public static int     Add(int x, int y) => x + y;

    /// <summary>
    /// Adds two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The sum of the two operands</returns>
    public static float   Add(float x, float y) => x + y;

    /// <summary>
    /// Adds two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The sum of the two operands</returns>
    public static long    Add(long x, long y) => x + y;

    /// <summary>
    /// Adds two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The sum of the two operands</returns>
    public static double  Add(double x, double y) => x + y;

    /// <summary>
    /// Adds two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The sum of the two operands</returns>
    public static decimal Add(decimal x, decimal y) => x + y;

    #endregion

    #region SUBTRACT_OVERLOADS

    /// <summary>
    /// Subtracts the second number from the first number
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The difference of the two operands</returns>
    public static int     Subtract(int x, int y) => x - y;

    /// <summary>
    /// Subtracts the second number from the first number
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The difference of the two operands</returns>
    public static float   Subtract(float x, float y) => x - y;

    /// <summary>
    /// Subtracts the second number from the first number
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The difference of the two operands</returns>
    public static long    Subtract(long x, long y) => x - y;

    /// <summary>
    /// Subtracts the second number from the first number
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The difference of the two operands</returns>
    public static double  Subtract(double x, double y) => x - y;

    /// <summary>
    /// Subtracts the second number from the first number
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The difference of the two operands</returns>
    public static decimal Subtract(decimal x, decimal y) => x - y;

    #endregion

    #region MULTIPLY_OVERLOADS

    /// <summary>
    /// Multiplies two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The product of the two operands</returns>
    public static int Multiply(int x, int y) => x * y;

    /// <summary>
    /// Multiplies two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The product of the two operands</returns>
    public static float Multiply(float x, float y) => x * y;

    /// <summary>
    /// Multiplies two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The product of the two operands</returns>
    public static long Multiply(long x, long y) => x * y;

    /// <summary>
    /// Multiplies two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The product of the two operands</returns>
    public static double  Multiply(double x, double y) => x * y;

    /// <summary>
    /// Multiplies two operands together
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>The product of the two operands</returns>
    public static decimal Multiply(decimal x, decimal y) => x * y;

    #endregion

    #region DIVIDE_REGION

        /// <summary>
        /// Divides the dividend by the divisor
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns>The quotient of the two operands</returns>
        public static int Divide(int dividend, int divisor) {

        try {

            return dividend / divisor;

        } catch (System.DivideByZeroException exception) {

            Console.WriteLine("You can't divide by 0.");

        }

        return 0;

    }

    /// <summary>
    /// Divides the dividend by the divisor
    /// </summary>
    /// <param name="dividend"></param>
    /// <param name="divisor"></param>
    /// <returns>The quotient of the two operands</returns>
    public static float Divide(float dividend, float divisor) {

        if (divisor == 0.0f) {
            Console.WriteLine("You can't divide by 0.");
            return 0.0f; // or return a special value or throw an exception as needed
        }

        return dividend / divisor;
    }

    /// <summary>
    /// Divides the dividend by the divisor
    /// </summary>
    /// <param name="dividend"></param>
    /// <param name="divisor"></param>
    /// <returns>The quotient of the two operands</returns>
    public static long Divide(long dividend, long divisor) {
        if (divisor == 0.0f) {
            Console.WriteLine("You can't divide by 0.");
            return 0; // or return a special value or throw an exception as needed
        }

        return dividend / divisor;
    }

    /// <summary>
    /// Divides the dividend by the divisor
    /// </summary>
    /// <param name="dividend"></param>
    /// <param name="divisor"></param>
    /// <returns>The quotient of the two operands</returns>
    public static double Divide(double dividend, double divisor) {
        if (divisor == 0.0) {
            Console.WriteLine("You can't divide by 0.");
            return 0.0f; // or return a special value or throw an exception as needed
        }

        return dividend / divisor;
    }

    /// <summary>
    /// Divides the dividend by the divisor
    /// </summary>
    /// <param name="dividend"></param>
    /// <param name="divisor"></param>
    /// <returns>The quotient of the two operands</returns>
    public static decimal Divide(decimal dividend, decimal divisor) {
        if (divisor == 0) {
            Console.WriteLine("You can't divide by 0.");
            return 0; // or return a special value or throw an exception as needed
        }

        return dividend / divisor;
    }

    #endregion

}