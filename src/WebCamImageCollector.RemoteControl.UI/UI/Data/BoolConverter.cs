﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace WebCamImageCollector.RemoteControl.UI.Data
{
    public class BoolConverter : IValueConverter
    {
        [DefaultValue(true)]
        public bool Test { get; set; } = true;
        public object TrueValue { get; set; }
        public object FalseValue { get; set; }
        
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool? boolValue = value as bool?;
            if (boolValue == null)
                boolValue = false;

            if (Test == boolValue.Value)
                return TrueValue;

            return FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
