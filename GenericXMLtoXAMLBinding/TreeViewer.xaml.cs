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
using System.Xml.Linq;
using System.IO;

namespace GenericXMLtoXAMLBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TreeViewer : Window
    {
        public TreeViewer()
        {
            InitializeComponent();
            string xmlPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\GenericXML1.xml";
            Console.WriteLine("XML Path : " + xmlPath);
            xmlPath = "D:/Programming/C#/GenericXMLtoXAMLBinding/GenericXMLtoXAMLBinding/GenericXMLtoXAMLBinding/GenericXML1.xml";
            XDocument doc = XDocument.Parse(File.ReadAllText(xmlPath));
            _treeView.DataContext = doc;
        }
    }
}
