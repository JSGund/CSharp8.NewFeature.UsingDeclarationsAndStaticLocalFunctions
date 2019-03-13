using System;
using System.IO;

namespace CSharp8.NewFeature.UsingAndStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Declarations
            using (var fileStream = new FileStream("abcd.json", FileMode.Open))
            {
                //do somthing here
            }// fileStream dispose here
            
            var fileName = "abcd.json";
            if (fileName != null)
            {
                var fileStream1 = new FileStream(fileName, FileMode.Open);
                var fileStream2 = new FileStream(fileName, FileMode.Open);
                var fileStream3 = new FileStream(fileName, FileMode.Open);

                //do somthing here

                //dispose fileStream3
                //dispose fileStream2
                //dispose fileStream1
            }// fileStream dispose here

            //Static Local Function
            var firstName = "Jeetendra";
            var lastName = "Gund";

            Console.WriteLine("My name is " + GetFullName(firstName, lastName));

            static string GetFullName(string firstName, string lastName) => firstName + ' ' + lastName;
        }
    }
}
