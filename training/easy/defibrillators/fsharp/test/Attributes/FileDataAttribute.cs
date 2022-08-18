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

        public FileDataAttribute(string? fileName = null, string? directoryName = null)
        {
            _fileName = fileName;
            _directoryName = directoryName;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if (testMethod is null)
            {
                throw new ArgumentNullException(nameof(testMethod));
            }

            var parameterTypes = testMethod.GetParameters().Select(p => p.ParameterType).ToArray();
            if (_fileName is null)
            {
                _fileName = testMethod.Name;
            }
            if (!_fileName.EndsWith(".csv"))
            {
                _fileName += ".csv";
            }
            if (_directoryName is not null)
            {
                _fileName = Path.Combine(_directoryName, _fileName);
            }
            var objectList = new List<object>();
            using (var file = new StreamReader(_fileName))
            {
                string? line;
                foreach (var parameter in testMethod.GetParameters())
                {
                    if (parameter.IsDefined(typeof(ParamArrayAttribute), inherit: false))
                    {
                        var list = new List<string>();
                        while (!String.IsNullOrEmpty(line = file.ReadLine()))
                        {
                            objectList.Add(line);
                        }
                    }
                    else
                    {
                        objectList.Add(file.ReadLine()!);
                    }
                }
            }
            yield return objectList.ToArray();
        }

        private static object ConvertParameter(object parameter, Type parameterType)
        {
            return parameterType == typeof(int) ? Convert.ToInt32(parameter) : parameter;
        }
    }
}
