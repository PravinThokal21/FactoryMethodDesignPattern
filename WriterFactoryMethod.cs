using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    internal class WriterFactoryMethod : IWriterFactoryMethod
    {
        public IWriter GetWriterInstance(string writerType)
        {
            IWriter writer = null;

            switch (writerType)
            {
                case "PDF":
                    writer = new PdfWriter();
                    break;

                case "CSV":
                    writer = new CsvWriter();
                    break;
            }

            return writer;
        }
    }
}
