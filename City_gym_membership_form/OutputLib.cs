using System;
using System.IO;

namespace City_gym_membership_form
{
    class OutputLib
    {
        public static void WriteInvoice(string Fname, string Lname, double extraFees, string Membership)
        {
            
            
                // Using statement for proper resource management
                using (TextWriter wr = new StreamWriter("C:/Users/nikof/OneDrive/Desktop/city_gym_membership.txt"))
                {
                    wr.WriteLine("Thank you for your membership!");
                    wr.WriteLine("");
                    wr.WriteLine("");
                    wr.WriteLine("*************Invoice*************");
                    wr.WriteLine("");
                    wr.WriteLine("");
                    wr.WriteLine($"Name: {Fname} {Lname}");
                    wr.WriteLine($"extras: {extraFees}");
                    wr.WriteLine($"Membership fee: {Membership}");
                    wr.Close();
                }

            
        }
    }
}



