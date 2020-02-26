using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;

        public string Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 98.0:
                        return "A+";
                    case var d when d >= 95.0:
                        return "A";
                    case var d when d >= 90.0:
                        return "A-";
                        
                    case var d when d >= 88.0:
                        return "B+";
                    case var d when d >= 85.0:
                        return "B";
                    case var d when d >= 80.0:
                        return "B-";

                    case var d when d >= 78.0:
                        return "C+";
                    case var d when d >= 75.0:
                        return "C";
                    case var d when d >= 70.0:
                        return "C-";

                    case var d when d >= 68.0:
                        return "D+";
                    case var d when d >= 65.0:
                        return "D";
                    case var d when d >= 60.0:
                        return "D-";

                    default:
                        return "F";
                }
            }
        }

        public double Sum;
        public int Count;

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}