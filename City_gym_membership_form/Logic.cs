 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City_gym_membership_form
{
    class Logic
    {
        public static double memDetLog(bool threemo, bool twelvemo, bool Bas, bool Reg, bool Acc, bool Ptr, bool Dt, bool Onl)
        {
            double fee;

            if (threemo)
            {
                if (Bas)
                {
                    fee = 12 * 10.00;// per week
                }
                else if (Reg)
                {
                    fee = 12 * 15.00;
                }
                else
                {
                    fee = 12 * 20.00;
                }

            }
            else if (twelvemo)
                if (Bas)
                {
                    fee = 52 * 8.00; //per week
                }
                else if (Reg)
                {
                    fee = 52 * 13.00;  
                }
                else
                {
                    fee = 52 * 18.00;
                }
            else
            {
                if (Bas)
                {
                    fee = 104 * 5.00; //per week
                }
                else if (Reg)
                {
                    fee = 104 * 10.00; 
                }
                else
                {
                    fee = 104 * 15.00;
                }

            }
            // Calculate additional fees for extras
            double extraFees = 0.0;

            if (Ptr) // Personal Trainer
            {
                extraFees += 20.00; // Fixed fee for personal trainer
            }

            if (Dt) // Dietitian
            {
                extraFees += 20.00; // Fixed fee for dietitian
            }

            if (Onl) // Online Workouts
            {
                extraFees += 2.00; // Fixed fee for online workouts
            }
            
            if (Acc) //24hr Access
            {
                extraFees += 1.00; // Fixed fee for 24hr Access
            }

            return fee + extraFees;

            
        }
    }

}

