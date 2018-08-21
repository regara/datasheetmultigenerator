using System.Xml.Linq;
using Microsoft.Win32;

namespace DatasheetGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class UploadXML
    {
        public XDocument doc { get; set; }

        public UploadXML()
        {

            /*********************** btn on click upload XML ***********************/

            OpenFileDialog cbeccxml = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml",
                FilterIndex = 1,
                Multiselect = true
            };
            bool? result = cbeccxml.ShowDialog();

            if (result != true)
                return;

            string filename = cbeccxml.FileName;

            doc = XDocument.Load(filename);
        }
    }
}