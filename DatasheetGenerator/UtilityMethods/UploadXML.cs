using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.Win32;

namespace DatasheetGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class UploadXML
    {
        public List<XDocument> doc { get; set; } = new List<XDocument>();

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
           

            foreach (string filename in cbeccxml.FileNames)
            {

                doc.Add(XDocument.Load(filename));
            }
        }
    }
}