﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber_Workshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Workshop program for harmonic number");
            HarmonicNumber harmonicNumber = new HarmonicNumber();
            harmonicNumber.Harmonic();
        }
    }
}