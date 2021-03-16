using System;
using System.Globalization;
using System.Windows.Data;

namespace Converters
{
    public class ArithmeticOperationConverter : IValueConverter
    {
        public enum Operations
        {
            Multiplication,
            Division,
            Subtraction,
            Addition
        }

        public Operations Operation { get; set; }
        public double Number { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var givenValue = (double)(value ?? 0);

            var result = Operation switch
            {
                Operations.Multiplication => givenValue * Number,
                Operations.Division => givenValue / Number,
                Operations.Subtraction => givenValue - Number,
                Operations.Addition => givenValue + Number,
                _ => throw new Exception($"Please Select Operation {nameof(Operation)}")
            };

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
