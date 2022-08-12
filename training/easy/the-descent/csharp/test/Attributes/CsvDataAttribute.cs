using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace csharp.tests.Attributes
{
    internal class CsvDataAttribute : DataAttribute
    {
        public CsvDataAttribute(string fileName, bool hasHeaders = false)
        {
            FileName = fileName;
            HasHeaders = hasHeaders;
        }

        public string FileName { get; }
        public bool HasHeaders { get; }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod) 
        {
            return new List<object[]>
            {
                new object[] { 0, 9, 8, 7, 6, 5, 4, 3, 2 }
            };
        }
    }
}
