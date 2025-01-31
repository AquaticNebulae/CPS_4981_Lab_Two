
using System.Collections;

namespace LabTwoLib
{//Lab Two - Chris/Eris/Aqua Jacinto - Kean ID: 001214974
    public class LabTwo
    {
        public static double FindMax(double num1, double num2, double num3 = 0)
        {
            double maxNum = 0;

            if (num1 >= num2)
            {
                maxNum = num1;
            }
            else
            {
                maxNum = num2;
            }


            if (num3 >= maxNum)
            {
                maxNum = num3;
            }
            return maxNum;
        }

        public static double FindMax(double[] numlist)
        {
            double maxNum = 0;

            foreach (double num in numlist)
            {
                if (num >= maxNum) { maxNum = num; }
            }
            return maxNum;
        }

        public static double FindMax(List<double> numlist)
        {
            double[] arrayNum = numlist.ToArray();

            return FindMax(arrayNum);
        }

    }
}
