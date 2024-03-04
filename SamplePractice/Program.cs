using System;               //Main method is a entry point of a program.

namespace SamplePractice    //namespace is used to organize a code and is a collection of classes, interfaces, structs and delegates.
{
    class Program
    {

        /*------------------------------------------------------PART 1 (NAMESPACES AND MAIN FUNC)------------------------------------------------------------*/


        static void Main1()
        {
            Console.WriteLine("hello 1");
        }

        /* ------------------------------------------------------PART 2 (READ AND WRITE)----------------------------------------------------------*/

        static void ReadFromUser()
        {
            Console.WriteLine("Enter your name : ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Hello " + UserName);         //concatenation method
            Console.WriteLine("Hello {0}", UserName);       //Placeholder syntax  --> MOST PREFERRED

            Console.WriteLine("Enter your First name : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last name : ");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}", FirstName, LastName);
        }

        /* ------------------------------------------------------PART 3 (DATATYPES)----------------------------------------------------------*/

        static void DataTypes()
        {
            bool b = true; //boolean -> True/False(Only)
            //b = 123; //throw error as boolean data type doesnot take any other type(not even 0 as false and any number as true)
            int i = 0; //int, uint, long, ulong

            Console.WriteLine("Min {0}", int.MinValue);
            Console.WriteLine("Max {0}", int.MaxValue);

            double f = 24.657788995; // float and double
            Console.WriteLine(f);

            //decimal and string

            string name = "shreya";
            Console.WriteLine(name);
        }

        /* ------------------------------------------------------PART 4 (DATATYPES CONTINUED + ESCAPE SEQUENCES + VERBATIM LITERAL)----------------------------------------------------------*/


        static void EscapeSequences()
        {
            string newLine = "Name\nPlace\nAnimal\nThing"; // \n -> newline
            Console.WriteLine(newLine);
            /*
                    \a	Bell (alert)
                    \b	Backspace
                    \f	Form feed
                    \n	New line
                    \r	Carriage return
                    \t	Horizontal tab
                    \v	Vertical tab
                    \'	Single quotation mark
                    \"	Double quotation mark
                    \\	Backslash
             */

            string place = "\"uttrakhand\""; // \"	Double quotation mark
            Console.WriteLine(place);

            //verbatim literals is a string with prefix @. e.g - @"Hello"
            //verbatim literals treats escape sequences as a normal print text

            string path = "C:\\Dev\\U4SM\\Docs"; //without verbatim literal -> less Readable
            Console.WriteLine(path);

            string path1 = @"C:\\Dev\\U4SM\\Docs"; //with verbatim literal -> Better Readable
            Console.WriteLine(path1);
        }


        /* ------------------------------------------------------PART 5 (OPERATORS) ----------------------------------------------------------*/

        static void Operators()
        {
            //1. Assignment Operator, (=)
            int i = 10; // assigning value 10 to variable i;
            int j = 2;

            //2.Arithmetic Operator, (+ - * / %)
            int Divide = i / j; // returns qoutient;
            int Remainder = i % j; // returns remainder;

            Console.WriteLine("Quotient and remainder is {0} {1}", Divide, Remainder);

            //3.Comparison Operator, (== != > >= < <=)
            if (i == j)
            {
                Console.WriteLine("equals");
            }

            //4.Conditional Operators, (&& ||)
            bool a = true;
            bool b = false;
            if (a == true && b == false)
            {
                Console.WriteLine("Hello");
            }

            //5. Ternary Operator, (?:)
            int number = 15;
            bool isNumber10 = number == 10 ? true : false;
            Console.WriteLine("Number is {0}", isNumber10);
        }


        /* ------------------------------------------------------PART 6 (NULLABLE TYPES) ----------------------------------------------------------*/

        /*
                                                            Types in c#
                                                           /           \
                                                          /             \
                                                         /               \
                                                        /                 \
                                                Value types             Reference types
                            (int float double struct enum etc)       (Interface class string delegates arrays etc)
                                    (default value = 0 )                     (default value = null)

            By default, value types are not Nullable, to make them nullable use '?'
            e,g : int i = null (this is give compiler error)
                  int? i = null (with the use of ?, i have made it nullable int)
         */

        //6. Nullable types

        static void NullableType()
        {
            bool? isEligible = null;

            if (isEligible == true)
            {
                Console.WriteLine("Eligible");
            }
            else if (isEligible == false)
            {
                Console.WriteLine("Not Eligible");
            }
            else
            {
                Console.WriteLine("Not Answered");
            }
        }

        //7. null coalescing operator

        static void NullCoalescing()
        {
            int? TicketOnSale = 50;
            int AvailableTickets;

            if (TicketOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                //AvailableTickets = TicketOnSale;                  //there is no impicit conversion between a non nullable type to nullable type.
                AvailableTickets = (int)TicketOnSale;               //explicit conversion
                AvailableTickets = TicketOnSale.Value;
            }

            Console.WriteLine("Available tickets = {0}", AvailableTickets);


            int AvailTickets = TicketOnSale ?? 0; // NULL COALESCING OPERATOR (If TicketOnSale is Null return 0 otherwise return the value TicketOnSale contains)

            Console.WriteLine("Available tickets = {0}", AvailTickets);

        }

        /* --------------------------------------------------------------PART 7 (DATA TYPES CONVERSION) ------------------------------------------------------------------*/


        static void Conversion()
        {
            //implicit conversion - it is done by the compiler
            int i = 50;
            float f = i;
            Console.WriteLine(f);
            // converting an int to a float will not loose any data and no exception will be thrown, hence an implicit conversion can be done.

            // where as when converting a float to an int, we loose the fractional part and also a possibility of overflow exception. hence, in this case as explicit conversion is required.
            // For explicit conversion we can use cast operator or the convert class in c#

            float f1 = 123.45f;
            int i1 = (int)f1;                   //typecast () operator
            int i2 = Convert.ToInt32(f1);       //convert class

            Console.WriteLine("conversion of float into int explicitly, using cast operator = {0} and using convert class = {1}", i1, i2);

            //float f2 = 43564747848446474.7464f;
            //int i3 = (int)f2;                 // f2 value is greater than the int range
            //Console.WriteLine("i3 = {0}",i3);


        }

        static void ParseAndTryParse()
        {
            /*
             If the number is in string format  - to convert it into a integer use - Parse/TryParse

            Parse - returns the value otherwise throws exception
            TryParse - returns boolean value indicating whether its succeeded(True) or failed(False).
             */

            string strNumber = "1243";
            int i = int.Parse(strNumber);
            Console.WriteLine("convert string to integer = {0}", i);

            string str1Number = "1234F";
            int result = 0;
            bool printTheTryParse = int.TryParse(str1Number, out result);

            if (printTheTryParse)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("The enter valid number !");
            }

            // use PARSE if you are sure the value will be valid otherwise use TRYPARSE

        }

        /* --------------------------------------------------------------PART 8 (ARRAYS) ------------------------------------------------------------------*/

        //An array is a collection of similar datatypes.
        //Advantage - strongly typed(Int arrays can store integers)
        //Disadvantage - can not grow size once initiated.
        static void Array()
        {
            int[] StudentsScore = new int[3];

            StudentsScore[0] = 40;
            StudentsScore[1] = 50;
            StudentsScore[2] = 60;

            Console.WriteLine("Scores of student - {0}, {1}, {2}", StudentsScore[0], StudentsScore[1], StudentsScore[2]);
        }

        /* --------------------------------------------------------------PART 9 (Comments, XML Documentation Comments) ------------------------------------------------------------------*/
        //comment - ctrl + KC
        // uncomment - ctrl + KU
        // XML Documentation comments - ///

        /// <summary>
        /// This is a Sample Class and the XML Sample documentation
        /// </summary>
        public class SampleClass
        {

        }


        /* -----------------------------------------------------------------------------PART 10 (If Statements) --------------------------------------------------------------------------------*/

        static void IfStatement()
        {
            Console.WriteLine("Enter the number : ");
            int Number = int.Parse(Console.ReadLine());

            if(Number == 1)
            {
                Console.WriteLine("1");
            }
            if(Number == 2)
            {
                Console.WriteLine("2");
            }
            if(Number == 3)
            {
                Console.WriteLine("3");
            }
            if(Number!=1 && Number!=2 && Number!=3)
            {
                Console.WriteLine("Number entered is not 1, 2 and 3");
            }
            
        }

        static void IfElseStatement()
        {
            Console.WriteLine("Enter The number : ");
            int number1 = int.Parse(Console.ReadLine());
            if(number1 == 2)
            {
                Console.WriteLine("Number entered is 2");
            }
            else
            {
                Console.WriteLine("Number entered is other than 2");
            }
        }

        // && => (Condition1 && Condition2) -> if condition1 is false then doesn't check for condition2
        // & => (Condition1 & Condition2) -> checks both the conditions even if condition1 is false
        // || => (Condition1 || Condition2) -> if condition1 is true then it doesn't check for condition2.
        // | => (Condition1 | Condition2) -> checks both the conditions even if condition1 is false

        // recommmended to use && and || as it is time saving.


        /* -----------------------------------------------------------------------------PART 11 (Switch Statements) --------------------------------------------------------------------------------*/

        static void Switch()
        {
            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            //switch(num)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break; 
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break; 
            //    case 30:
            //        Console.WriteLine("Number is 30");
            //        break; 
            //    case 40:
            //        Console.WriteLine("Number is 40");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10, 20, 30 and 40");
            //        break;
            //}

            switch(num)
            {
                case 10:
                case 20:
                case 30:
                case 40:
                    Console.WriteLine("The number entered is {0}", num);
                    break;
                default:
                    Console.WriteLine("the number is not 10, 20, 30 and 40");
                    break;
            }
        }

        /* -----------------------------------------------------------------------------PART 12 (Switch Statements continued) -------------------------------------------------------------------------*/


        static void CoffeeOrder()
        {
            int TotalAmount = 0;
        start: //label
            Console.WriteLine("Menu :  1.Small - $1\n\t2.Medium - $2\n\t3.Large - $3\n Enter the size of the coffee you want to order : ");
            int size = int.Parse(Console.ReadLine());
            
            switch(size)
            {
                case 1:
                    TotalAmount += 1;
                    break; // BREAK STATEMENT : It is used inside the switch statement, the control will leave the switch statement.
                case 2:
                    TotalAmount += 2;
                    break;
                case 3:
                    TotalAmount += 3;
                    break;
                default:
                    Console.WriteLine("Invalid Choice!! Please try Ordering Again :");
                    goto start; // GOTO STATEMENT : it is used to jump to specific case statement or a specific LABEL.(Using goto is a bad programming language becoz debugging of the program will be extremely complex)
            }
            middle: // label
            Console.WriteLine("Do you want to order again ? press YES or NO");
            string UserChoice = Console.ReadLine();
            switch(UserChoice.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Invalid choice!! Please enter the valid choice");
                    goto middle; //(Instead of GOTO statement we can use LOOPS)
            }

            Console.WriteLine("Thank you for shopping with us !!");
            Console.WriteLine("Your total bill is {0}.",TotalAmount);
        }


        /* -----------------------------------------------------------------------------PART 13 (While loop in c#) -------------------------------------------------------------------------*/
        static void WhileLoop()
        {
            //  WHILE LOOP 1st check the condition then executes the statement(if condition is true)
            //print the even number till the nth
            Console.WriteLine("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            int start = 0;
            while(start <= number)
            {
                Console.WriteLine("Even numbers are : {0}", start);
                start += 2; //Update the variable participating in the condition, so loop can end at some point.
                
            }


        }

        /* -----------------------------------------------------------------------------PART 14 (Do While loop in c#) -------------------------------------------------------------------------*/

        static void DoWhile()
        {

        }

        /* -----------------------------------------------------------------------------PART 15 (For and For each loop in c#) -------------------------------------------------------------------------*/
       
        static void For()
        {
            int[] Numbers = new int[4];
            Numbers[0] = 102;
            Numbers[1] = 103;
            Numbers[2] = 104;
            Numbers[3] = 105;

            //For Loop : It is very similar to while loop, in while loop intialization, condition and mdification is at different places but in for loop it is at one place

            for(int i=0; i<Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }

            //Foreach loop is used to iterate through the items in a collection.
            foreach(int k in Numbers)
            {
                Console.WriteLine(k);
            }

        }
        //Break Statement jumps out from the loop
        static void breakstat()
        {
            for(int i=0; i<=20; i++)
            {
                Console.Write(i + " ");
                if(i==10)
                {
                    break; // Terminates the loop
                }
            }
            Console.WriteLine("\n");
        }

        //Continue Statement skips the 
        static void continuestat()
        {
            for (int i=0;i<=20;i++)
            {
                if(i%2 ==1)
                {
                    continue; // skips the below code and returns back to loop
                }
                Console.Write(i + " ");
            }
        }
        /* -----------------------------------------------------------------------------PART 16 (Methods in c#) -------------------------------------------------------------------------*/

        //Methods are also known as functions, it is very useful as we can use a particular logic manytimes without writing same logic code again and again.

        /*
         Static method - when a method declaration have "static" modifier then it is a static method otherwise method is a instance method

        Static method is invoked using a class name whereas instance method is invoked using an instance of a class.
        
        No instances of the static method is created,we can invoke only that one definition of the method
        Multiple instances of a class can be created and each instance have its own separate method.
        */

        //Example : - 
        static void Add()
        {
            Console.WriteLine("Static Method");
        }

        public void Sub()
        {
            Console.WriteLine("Instance Method");
        }


        /* -----------------------------------------------------------------------------PART 17 (Method parameters in c#) -------------------------------------------------------------------------*/

        // 1.Value Parameter - creates a copy of the parameter passed so modification does not affect each other.
        static void Val(int j)
        {
            j = 101;
        }
        // 2.Reference Parameter - the ref keyword refers to the same variable that was passed in the method.
        // Any changes made to the parameter in that method will be reflected in that variable when control passes back to the calling method.
        static void Refernc(ref int k)
        {
            k = 201;
        }

        // 3.Out parameter - use when you want a method to return more than one value.
        static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }

        // 4.Parameter Arrays - 

        /* -----------------------------------------------------------------------------PART 18 (Namespaces in c#) -------------------------------------------------------------------------*/
        static void Main()
        {
            //Console.WriteLine("Hello World!");
            //   Main1();
            //   ReadFromUser();
            //   DataTypes();
            //   EscapeSequences();
            //   Operators();
            //   NullableType();
            //   NullCoalescing();
            //   Conversion();
            //   ParseAndTryParse();
            //   Array();
            //   SampleClass(); -> hover in it, it will show the xml documentation comment
            //   IfStatement();
            //   IfElseStatement();
            //   Switch();
            //   CoffeeOrder();
            //   WhileLoop();
            //   DoWhile();


            //  -For();
            //   breakstat();
            //   continuestat();


            //   Add();
            //   Program p = new Program(); // instance of a class
            //   p.Sub(); //invoking instance method using instance of a class

          
            int i = 0;
            Val(i);
            Console.WriteLine(i); // prints 0;
            Refernc(ref i);
            Console.WriteLine(i);
            int Total = 0;
            int Product = 0;
            Calculate(10,20,out Total, out Product);
            Console.WriteLine("Sum = {0} and Product = {1}",Total,Product);





        }
    }
}
