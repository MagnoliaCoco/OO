﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class HC : Chart
    {
        public HC()
        {
            Console.WriteLine("create HC");
        }

        public void Display()
        {
            Console.WriteLine("display HC");
        }
    }
}
