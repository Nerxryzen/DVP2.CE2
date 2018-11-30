using System;

namespace Exercise2
{

        class Validation 
        {

            public static double GetDouble(string message = "Enter a number: ")
            {
                double validatedDouble = 0;
                string input = null;

                do
                {
                    Console.Write(message);
                    input = Console.ReadLine();
                } while (!Double.TryParse(input, out validatedDouble));
                return validatedDouble;

            }
            public static decimal GetDecimal(string message = "Enter a number: ")
            {
                decimal validateddecimal = 0;
                string input = null;

                do
                {
                    Console.Write(message);
                    input = Console.ReadLine();
                } while (!Decimal.TryParse(input, out validateddecimal));
                return validateddecimal;

            }
            //Validation-GetInt
            public static double GetDouble(int min, int max, string message = "Enter a number:  ")
            {
                double validatedDouble = 0;
                string input = null;

                do
                {
                    Console.Write(message);
                    input = Console.ReadLine();
                } while (!(Double.TryParse(input, out validatedDouble) && (validatedDouble >= min && validatedDouble <= max)));
                return validatedDouble;

            }

                public static string GetStringValidation(string message = "Type in here: ")
                {
                    string validatedString = null;
                    do
                    {
                        Console.Write(message);
                        validatedString = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(validatedString));
                    return validatedString;
                }


        //Validation-GetInt
        public static int GetInt(string message = "Enter an integer: ")
            {
                int validatedInt = 0;
                string input = null;

                do
                {
                    Console.Write(message);
                    input = Console.ReadLine();
                } while (!Int32.TryParse(input, out validatedInt));
                return validatedInt;

            }
            //Validation-GetInt
            public static int GetInt(int min, int max, string message = "Enter an integer:  ")
            {
                int validatedInt = 0;
                string input = null;

                do
                {
                    Console.Write(message);
                    input = Console.ReadLine();
                } while (!(Int32.TryParse(input, out validatedInt) && (validatedInt >= min && validatedInt <= max)));
                return validatedInt;

            }
            //Validation-GetInt

            public static bool GetBool(string message = "Enter yes or no: ")
            {
                bool answer = false;
                string input = null;

                bool needAValidResponce = true;

                while (needAValidResponce)
                {
                    Console.Write(message);
                    input = Console.ReadLine().ToLower();

                    switch (input)
                    {
                        case "yes":
                        case "y":
                        case "true":
                        case "t":
                            {
                                answer = true;
                                needAValidResponce = false;
                            }
                            break;
                        case "no":
                        case "n":
                        case "false":
                        case "f":
                            {
                                needAValidResponce = false;

                            }
                            break;

                    }
                }
                return answer;
            }

        }
}
