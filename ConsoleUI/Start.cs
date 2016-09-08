﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LZWAlgorithm.Core;

namespace ConsoleUI
{
    public class Start
    {
        public static void Main(string[] args)
        {

            Algorithm algorithm = new Algorithm("hello world");

            algorithm.InitializeDictionary();

            Console.WriteLine(algorithm.Calculate());
            Console.ReadLine();

        }
    }
}
