using System;
using System.Collections.Generic;
using System.Linq;

namespace BBSgauge
{
    class Tests
    {
        private List<long> sequense;
        private double expectedValue;
        private long[] values;
        private double[] probabilities;
        private int countSequence;
        private int n;

        public Tests(List<long> sequence, int N)
        {
            this.sequense = sequence;
            expectedValue = 0;
            values = new long[10];
            probabilities = new double[10];
            countSequence = sequence.Count();
            n = N;
            CreateArrays();
        }

        private void CreateArrays()
        {
            int[] bounds = new int[11];
            for (int i = 0; i < 10; i++)
            {
                probabilities[i] = 0;
                bounds[i] = i * n / 10;
                values[i] = (i * n / 10 + (i + 1) * n / 10) / 2;
            }
            bounds[10] = n;
            foreach (long element in sequense)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (element > bounds[i] && element < bounds[i + 1])
                    {
                        probabilities[i]++;
                    }
                }
            }
        }

        public double CalculateExpectedValue()
        {
            for (int i = 0; i < 9; i++)
            {
                expectedValue += values[i] * probabilities[i] / countSequence;
            }
            return expectedValue;
        }

        public double CalculateDispersion()
        {
            double dispersion = 0;
            for (int i = 0; i < 9; i++)
            {
                dispersion += (probabilities[i] / countSequence) * (values[i] - expectedValue);
            }
            return dispersion / ((countSequence - 1));
        }

        public double CalculateXi()
        {
            double Xi = 0;
            for (int i = 0; i < 9; i++)
            {
                double temp = (countSequence + 1) / 10f;
                Xi += ((probabilities[i] - temp) * (probabilities[i] - temp)) / ((countSequence + 1) / 10f);
            }
            return Xi;
        }

        public void CreateChart()
        {
            ChartForm chf = new ChartForm();
            chf.chart1.Series["Series1"].Points.DataBindXY(values, probabilities);
            chf.Show();
        }
    }
}
