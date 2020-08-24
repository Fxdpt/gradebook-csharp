using System.Collections.Generic;

namespace GradeBook
{
    public class Statistics
    {
        public List<double> numberList;
        public double average;
        public double low = double.MaxValue;
        public double high = double.MinValue;

        public Statistics(List<double> numberList)
        {
            this.numberList = numberList;
            this.computeAverage();
            this.computeHighest();
            this.computeLowest();
        }

        private void computeAverage()
        {
            foreach (double number in this.numberList)
            {
                this.average += number;
            }
            this.average /= numberList.Count;
        }

        private void computeHighest()
        {
            foreach (double number in this.numberList)
            {
                if (number > this.high)
                {
                    this.high = number;
                }
            }
        }

        private void computeLowest()
        {
            foreach (double number in this.numberList)
            {
                if (number < this.low)
                {
                    this.low = number;
                }
            }
        }
    }
}