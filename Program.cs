using System;

namespace CSharp_introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print of Console
            /* Multiline comment */
            Console.WriteLine("Hello World");
            //Types Data
            int number = 20;
            long longNumber = 2020020202009389438;
            string str = "Hello world";
            bool boolean = true;
            bool boolean2 = false;
            double double1 = 2.3;
            float float1 = 2.5f;
            decimal decimal1 = 2.7m;
            short smallNumber = 2;
            char letter = 'J';

            /*
             * -sbyte:0 of 255
             * -byte: -127 a 128
             */
            int person1 = 20, person2 = 18, person3 = 19;
            int age1, age2, age3, age4;
            age1 = age2 = age3 = age4 = 18;
            age4 = 20;

            //Constants

            const String nameAuthor = "John Gualteros";//Not are mutables

            //Var and Dynamic
            //Don't need especify type of variable
            var peso = 20;//cant't change of type data - not is mutable
            dynamic name = "Oscar";//cant change type data - is mutable

            //Casting
            //Implicit

            sbyte a = 15;
            int c = a;

            //Explicit

            int i = 123;
            sbyte x = (sbyte)i;

            String num = "678";
            int convert = int.Parse(num);

            String u = "56";
            double d = double.Parse(u);
            //or
            double myDouble = Convert.ToDouble(u);

            //Operators maths
            Console.WriteLine(18 + 13);
            Console.WriteLine(18 - 13);
            Console.WriteLine(18 * 13);
            Console.WriteLine(18 / 13);
            Console.WriteLine(18 % 13);

            //increase
            int number1 = 02;
            number++;
            //decrement
            int number2 = 2;
            number--;
            Console.WriteLine(number1++);//Post increase
            Console.WriteLine(++number2);//Pre increase

            //Conditional
            bool true_example = true;
            bool false_example = false;

            if (true_example && false_example)
            {
                Console.WriteLine("Is True both");
            }
            else if (true_example || false_example)
            {
                Console.WriteLine("Any is True");
            }
            else if (!false_example == true_example)
            {
                Console.WriteLine("True");
            }
            else if (false_example ^ true_example)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Nothing true");
            }

            //Operators comparatives

            /*
            * <
            * >
            * <=
            * >=
            * ==
            * !=
            */
            int number_equals_1 = 13, number_equals_2 = 13;
            if (number_equals_1.Equals(number_equals_2))
            {
                Console.WriteLine("Is equal number" + number_equals_1 + "and" + number_equals_2);
            }

            //Operator terniary
            int ageChildren = 17;

            var isOldMayor = ageChildren >= 18 ? "Is Old Mayor" : "Not Is Old Mayor";
            Console.WriteLine(isOldMayor);

            //Function default and sizeOf
            Console.WriteLine(default(DateTime));

            //return the number of bytes
            Console.WriteLine(sizeof(bool));

            //Class Math
            const double pi = Math.PI;
            Console.WriteLine(pi);

            Console.WriteLine(Math.Max(28, 29));
            Console.WriteLine(Math.Min(28, 29));

            Console.WriteLine(Math.Pow(8, 4));//Elevate 8 of cube
            Console.WriteLine(Math.Sqrt(17));//Elevate 17 of square

            double number_double = 3.4661;
            Console.WriteLine(Math.Round(number_double));//Round the number
            Console.WriteLine(Math.Ceiling(number_double));//Round up
            Console.WriteLine(Math.Floor(number_double));//Round Down

            Console.WriteLine(Math.Abs(-1212));

            //Concat
            int age_ = 17;
            String name_ = "John";

            Console.WriteLine("My Name is " + name_ + " And my age is " + age_);

            String res = "My Name is " + name_ + " And my age is " + age_;
            Console.WriteLine(res);

            String myText;
            myText = String.Concat(age_, name_);

            String textOne = "Hello";
            String textTwo = "World";

            String myText2 = $"{textOne} {textTwo}";

            String myText3 = String.Format(myText, myText2);

            Console.WriteLine(String.Format("{0}{1}", textOne, textTwo));

            //Abreviature
            Console.WriteLine("Hi my name is : {0}\nand my age is : {1}", name_, age_);

            //Reading data of console
            String name_entry_console;
            Console.WriteLine("Enter your fullName");
            name_entry_console = Console.ReadLine();

            Console.WriteLine("Longitude: {0}", name_entry_console.Length);

            int edad;
            Console.WriteLine("Enter your age");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(edad + 5);

            double salary;
            Console.WriteLine("Enter your salary");
            salary = Convert.ToDouble(Console.ReadLine());
            double totalSalary = salary * 12;
            Console.WriteLine(totalSalary);

            //Function typeof 

            Console.WriteLine(typeof(String));
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(double));
            Console.WriteLine(typeof(bool));

            //Function nameof
            String txt;
            String exampleNameOf = nameof(txt);
            Console.WriteLine(nameof(txt));
            Console.WriteLine(exampleNameOf);
            //Operator Coalesencia
            String e = null;
            Console.WriteLine("El string inicado es: " + (e ?? "No provisto"));

            double? num1 = null;
            double num2 = 5.874;
            double num3;

            num3 = num1 ?? 26.61;
            Console.WriteLine(num3);

            //Verbating strings Literals

            String texto = $@"Paragraph of several lines 1 - 2 - {5 - 2} 
                            this is a new line 
                            and it is other";
            Console.WriteLine(texto);
            String texto2 = "\"No estoy de acuerdo\",ella menciono";
            //Other Form
            String texto22 = @"""No estoy de acuerdo"",ella menciono";
            String url = @"c:\temp\nuevo_arhcivo.txt";
            Console.WriteLine(texto2);

            //While
            int counter = 0;
            Console.WriteLine("Enter the number");
            number = (int)Convert.ToDouble(Console.ReadLine());

            while (number > 0)
            {
                Console.WriteLine("Enter the number");
                number = (int)Convert.ToDouble(Console.ReadLine());
                counter++;
            }
            Console.WriteLine(counter);
            //Do While
            int acumulator = 0;
            int number_do_while;
            do
            {
                Console.WriteLine("Enter One number");
                number_do_while = int.Parse(Console.ReadLine());
                acumulator += number_do_while;

            } while (number_do_while > 20 && number_do_while <= 50);
            Console.WriteLine("The total number regstered are: {0}", acumulator);
            //FOR
            for (i = 1; i < 11; i++)
            {
                String tableMath = $@"5 x {i} = { 5 * i}";
                Console.WriteLine(tableMath);
            }
            /*
             * Infinite for
             *for(; ;){
             *  Console.WriteLine("hi");
             *}
             */

            //Break-Continue
            for (int j = 16; j < 35; j++)
            {
                Console.WriteLine("Actual Value: {0}", j);

                if ((j % 7) == 0)
                {
                    Console.WriteLine("The first multiple are : {0}", j);
                    break;
                }
                else
                {
                    continue;
                }
            }
            int contador = 0;
            do
            {
                contador++;
                if ((contador % 5) == 0)
                {
                    continue;
                }
                Console.WriteLine(contador);
            } while (contador <= 30);

            //Vector unidimentional

            int[] ages = new int[5];
            // double ages=new double[3] {2.2,5.3,6.5};
            // ages[0]=4;
            for (int z = 0; z < ages.Length; z++)
            {
                Console.WriteLine("Enter a number with vector: ");
                ages[z] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int age in ages)
            {
                Console.WriteLine($"{age}");
            }
            //Paralell vectors

            String[] nombres = new String[3];
            int[] edades = new int[3];
            double[] estaturas = new double[3];

            for (a = 0; a < 3; a++)
            {
                Console.WriteLine("Enter a name {0}: ", (a + 1));
                nombres[a] = Console.ReadLine();
                Console.WriteLine("Enter a age {0}: ", (a + 1));
                edades[a] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a height {0}: ", (a + 1));
                estaturas[a] = Convert.ToDouble(Console.ReadLine());
            }
            for (int b = 0; b < 3; b++)
            {
                Console.WriteLine("person {0} \nname: {1} \nage: {2} \n height: {3}",
                    (b+1),nombres[b],edades[b],estaturas[b]);
            }
        }
    }
}


















