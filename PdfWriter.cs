﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class PdfWriter : IWriter
    {
        public void Write(string value)
        {
            Console.WriteLine(value);
        }
    }
}
