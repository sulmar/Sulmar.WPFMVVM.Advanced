using Sulmar.WPFMVVM.Advanced.WPFClient.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Sulmar.WPFMVVM.Advanced.WPFClient.Converters
{
    public class StatusConverter : BaseValueConverter<StatusConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((Status)value)
            {
                case Status.Created: return Brushes.Blue;
                case Status.InProgress: return Brushes.Red;
                case Status.Completed: return Brushes.Green;

                default:
                    Debugger.Break();
                    throw new NotSupportedException();
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
