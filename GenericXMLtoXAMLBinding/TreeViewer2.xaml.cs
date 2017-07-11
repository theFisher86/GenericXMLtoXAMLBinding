using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;  
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.IO;
using System.Globalization;

namespace GenericXMLtoXAMLBinding
{ 
    public partial class TreeViewer2 : Window
    {
        public TreeViewer2()
        {
             InitializeComponent();
            var dataProvider = this.FindResource("xmlDataProvider") as XmlDataProvider;
            var doc = new XmlDocument();
            string xmlPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\CRYSTAL_LARGE.SCENE.exml";
            Console.WriteLine("XML Path : " + xmlPath);
            //xmlPath = "D:/Programming/C#/GenericXMLtoXAMLBinding/GenericXMLtoXAMLBinding/GenericXMLtoXAMLBinding/GCAISPACESHIPGLOBALS.GLOBAL.exml";
            doc.LoadXml(File.ReadAllText(xmlPath));
            dataProvider.Document = doc;
        }

    }

    public class IsEqualOrGreaterThanConverter : IValueConverter
    {
        //public static readonly IValueConverter Instance = new IsEqualOrGreaterThanConverter();
        public static readonly IsEqualOrGreaterThanConverter Instance = new IsEqualOrGreaterThanConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int intValue = (int)value;
            int compareToValue = (int)parameter;

            return intValue >= compareToValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class MBINReferenceConverter : IValueConverter
    {
        //public static readonly IValueConverter Instance = new MBINReferenceConverter();
        public static readonly MBINReferenceConverter Instance = new MBINReferenceConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = (string)value;

            return strValue.Contains("MBIN");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
