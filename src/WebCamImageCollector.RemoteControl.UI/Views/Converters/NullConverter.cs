﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace WebCamImageCollector.RemoteControl.Views.Converters
{
    public class NullConverter : IValueConverter
    {
        public object TrueValue { get; set; }
        public object FalseValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                return TrueValue;

            if (value is string)
            {
                string stringValue = value as string;
                if (stringValue == String.Empty)
                    return TrueValue;
            }

            return FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
