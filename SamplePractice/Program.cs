using System;               //Main method is a entry point of a program.

namespace SamplePractice    //namespace is used to organize a code and is a collection of classes, interfaces, structs and delegates.
{
    class Program
    {

/*------------------------------------------------------PART 1 (NAMESPACES AND MAIN FUNC)------------------------------------------------------------*/

        static void Main()
        {
            //Console.WriteLine("Hello World!");
            //   Main1();
            //   ReadFromUser();
            //   DataTypes();
            //   EscapeSequences();
            //   Operators();
            //   NullableType();
            NullCoalescing();
        }

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
            if(i==j)
            {
                Console.WriteLine("equals");
            }

            //4.Conditional Operators, (&& ||)
            bool a = true;
            bool b = false;
            if(a==true && b==false)
            {
                Console.WriteLine("Hello");
            }

            //5. Ternary Operator, (?:)
            int number = 15;
            bool isNumber10 = number == 10 ? true : false;
            Console.WriteLine("Number is {0}",isNumber10);
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

            if(isEligible == true)
            {
                Console.WriteLine("Eligible");
            }
            else if(isEligible == false)
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

            if(TicketOnSale == null)
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
    }
}
