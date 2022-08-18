using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace fsharp.tests.Attributes
{
    internal class FileDataAttribute : DataAttribute
    {
        private string? _fileName;
        private readonly string? _directoryName;
        private readonly char _delimiter;

        public FileDataAttribute(string? fileName = null, string? directoryName = null, char delimiter = ';')
        {
            _fileName = fileName;
            _directoryName = directoryName;
            _delimiter = delimiter;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod) => throw new NotImplementedException();
    }
}
