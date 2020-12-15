using System;

namespace LawnApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const int fee1 = 25;
            const int fee2 = 35;
            const int fee3 = 50;
            const int totalWeek = 20;
            const int serviceFee_2 = 5;
            const int serviceFee_20 = 3;
            const int payment1 = 1;
            const int payment2 = 2;
            const int payment3 = 20;
            
            double length;
            double width;
            double area;
            double totalFee = 0;
            double paymentPerTime;
            int paymentNum;

            Console.WriteLine("Please enter the length of lawn in feet: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the width of lawn in feet: ");
            width = Convert.ToDouble(Console.ReadLine());

            area = length * width;
            
            if (area < 400)
            {
                totalFee = fee1 * totalWeek;
                Console.WriteLine($"The weekly lawn mowing fee is {fee1:c}.");
            }
            else if (area >= 400 && area <= 600)
            {
                totalFee = fee2 * totalWeek;
                Console.WriteLine($"The weekly lawn mowing fee is {fee2:c}.");
            }
            else if(area > 600)
            {
                totalFee = fee3 * totalWeek;
                Console.WriteLine($"The weekly lawn mowing fee is {fee3:c}.");
            }

            Console.WriteLine("How many payments do you want to make per season? 1)Once 2)Twice 3)20 time(s) per season?");
            paymentNum = Convert.ToInt32(Console.ReadLine());

            if (paymentNum == payment1)
            {
                paymentPerTime = totalFee;
                Console.WriteLine($"The total fee is {totalFee:c} for the season. {paymentPerTime:c} per each payment. Total {payment1} payment.");
            }
            else if (paymentNum == payment2)
            {
                paymentPerTime = (totalFee / payment2) + serviceFee_2;
                totalFee = paymentPerTime * payment2;
                Console.WriteLine($"The total fee is {totalFee:c} for the season. {paymentPerTime:c} per each payment. Total {payment2} payments.");
            }
            else 
            {
                paymentPerTime = (totalFee / payment3) + serviceFee_20;
                totalFee = paymentPerTime * payment3;
                Console.WriteLine($"The total fee is {totalFee:c} for the season. {paymentPerTime:c} per each payment. Total {payment3} payments.");
            }

            Console.ReadKey();
        }
    }
}
