﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShakirovRR.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            do
            {
                sumSeries = sumSeries + (Math.Cos(startValue) * (1 / 2));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
