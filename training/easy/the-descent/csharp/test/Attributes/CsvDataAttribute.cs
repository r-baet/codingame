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
        private string? _fileName;
        private readonly string? _directoryName;
        private readonly char _delimiter;
        private readonly bool _hasHeaders;

        public CsvDataAttribute(string? fileName = null, string? directoryName = null, char delimiter = ';', bool hasHeaders = false)
        {
            _fileName = fileName;
            _directoryName = directoryName;
            _delimiter = delimiter;
            _hasHeaders = hasHeaders;            
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod) 
        {
            var parameterTypes = testMethod.GetParameters()?.Select(p => p.ParameterType).ToArray();
            if (_fileName is null)
            {
                _fileName = testMethod.Name;
            }
            if (!_fileName.EndsWith(".csv"))
            {
                _fileName = _fileName + ".csv";
            }
            if (_directoryName is not null)
            {
                _fileName = Path.Combine(_directoryName, _fileName);
            }
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
