using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This will be on line");
            Console.WriteLine("Skies are blue \n roses are red \n i love you");
            Console.WriteLine("Hi, my name is \"(Oratile)\"");

            //declaration
            string firstname = "John";
            string lastname = "Owens";
            Console.WriteLine(firstname + " " + lastname); // this is used to concatinate

            Console.WriteLine("The length of the name is " + firstname.Length);//functions on strings
            //change name to uppercase, change lastname to lowercase
            Console.WriteLine("Name as upper case " + firstname.ToUpper());
            Console.WriteLine("last name  as lower case " + lastname.ToLower());
            Console.WriteLine("Does firstname contain he " + firstname.Contains("he"));
            Console.WriteLine("The first letter of the name is " + firstname[0]);
            Console.WriteLine("The index of h is " + firstname.IndexOf("h"));
            Console.WriteLine("The substring from 2 " + lastname.Substring(2));
            Console.WriteLine("The substring from 0 to 4 " + lastname.Substring(0,4));

            //freeze console
            Console.ReadLine();
        }
    }
}
