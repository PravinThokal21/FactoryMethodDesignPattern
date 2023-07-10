using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal interface IWriterFactoryMethod
    {
        public IWriter GetWriterInstance(string writterType);
    }
}
