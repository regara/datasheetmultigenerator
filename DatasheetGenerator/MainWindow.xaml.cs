using System;
using System.Collections.Generic;
using System.Windows;

namespace DatasheetGenerator
{
    public partial class MainWindow : Window
    {
        public static int Count { get; set; } = 0;

        public string Header { get; set; }
        public string MainContent { get; set; }
        public string Windows { get; set; }

        public string documentBuilder { get; set; }

        // [[str1,str2,str3],[str1,str2,str3],[str1,str2,str3],ect...]
        public List<List<string>> allColumnsArr { get; set; } = new List<List<string>>();



        



        public MainWindow()
        {
            InitializeComponent();
        }

        private void UploadXMLClicked(object sender, RoutedEventArgs e)
        {
            //uploads an xml file
            var doc = new UploadXML().doc;

            //generates the header only once
            if (Count < 1)
            {
                Header = new HeaderGenerator(doc).HeaderToString;
            }


            // gets usefull values then returns those in an array.
            var currentColumnArr = new CurrentColumnValues(doc).currentColumnValuesArr;




            allColumnsArr.Add(currentColumnArr);

            //this.Count++
            Count++;
        }
        
        private void GenerateDatasheet(object sender, RoutedEventArgs e)
        {

            var MainContent = new CellBuilder(allColumnsArr).MainContentCellsToString;
            var Windows = new WindowBuilder().Windows;

            if (Count < 1)
                Console.WriteLine("Nothing to generate");
            else
                documentBuilder = new DocumentBuilder(Header, MainContent, Windows).fullXML;



        }
    }
}
