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
        private readonly string _fileName;
        private readonly char _delimiter;
        private readonly bool _hasHeaders;

        public CsvDataAttribute(string fileName, string? directoryName = null, char delimiter = ';', bool hasHeaders = false)
        {
            if (fileName is null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }
            _fileName = fileName;
            if (!fileName.EndsWith(".csv"))
            {
                _fileName = _fileName + ".csv";
            }
            if (directoryName is not null)
            {
                _fileName = directoryName + "\\" + _fileName;
            }
            _delimiter = delimiter;
            _hasHeaders = hasHeaders;            
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod) 
        {
            var parameterTypes = testMethod.GetParameters()?.Select(p => p.ParameterType).ToArray();
            var result = new List<object[]>();
            using (var csvFile = new StreamReader(_fileName))
            {
                if (_hasHeaders)
                {
                    csvFile.ReadLine();
                }
                string? line;
                while (!String.IsNullOrEmpty(line = csvFile.ReadLine()))
                {
                    var row = line.Split(_delimiter);
                    yield return ConvertParameters(row, parameterTypes);
                }
            }
        }
        private static object[] ConvertParameters(IReadOnlyList<object> values, IReadOnlyList<Type>? parameterTypes)
        {
            if (parameterTypes is null)
            {
                throw new ArgumentNullException(nameof(parameterTypes));
            }
            var result = new object[parameterTypes.Count];
            for (var idx = 0; idx < parameterTypes.Count; idx++)
            {
                result[idx] = ConvertParameter(values[idx], parameterTypes[idx]);
            }

            return result;
        }

        private static object ConvertParameter(object parameter, Type parameterType)
        {
            return parameterType == typeof(int) ? Convert.ToInt32(parameter) : parameter;
        }
    }
}
