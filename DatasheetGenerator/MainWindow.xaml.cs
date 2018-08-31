using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MessageBox = System.Windows.MessageBox;
using TextBox = System.Windows.Controls.TextBox;

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


        public int deletedColumnCount { get; set; } = 0;

        



        public MainWindow()
        {
            InitializeComponent();
            AddHandler(MouseRightButtonDownEvent, new MouseButtonEventHandler(DeleteColumnPrompt), true);
        }

        private void WPFColumnUpdater(List<string> currentColumnArr)
        {

//            <TextBox Grid.Column="1" Grid.Row="0" Margin="3" />

            var tb = new TextBox();

            tb.Height = 680;
            tb.Width = 180;
            tb.IsReadOnly = true;
            tb.Margin = new Thickness(10, 25, 0, 0);
            tb.BorderThickness = new Thickness(3, 3, 3, 3);
            tb.Padding = new Thickness(10, 0, 10, 0);
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Text = "option" + Convert.ToString(Container.Children.Count + deletedColumnCount) + "\n";
            Container.Children.Add(tb);

            tb.BorderBrush = new SolidColorBrush(Colors.Black);
            tb.Foreground = new SolidColorBrush(Colors.Black);
            Canvas.SetLeft(tb, 0);
            Canvas.SetTop(tb, 0);

            for (var t = 0; t < currentColumnArr.Count; t++)
            {
                tb.Text += currentColumnArr[t] + System.Environment.NewLine;
            }
        }

        private void UploadXMLClicked(object sender, RoutedEventArgs e)
        {
            ErrorBanner.Text = "";

            //uploads an xml file
            foreach (var doc in new UploadXML().doc)
            {
                //generates the header only once
                if ((Count - deletedColumnCount) < 1)
                {
                    Header = new HeaderGenerator(doc).HeaderToString;
                }

                


                // gets usefull values then returns those in an array.
                var currentColumnArr = new List<string>();
                try
                {
                    currentColumnArr = new CurrentColumnValues(doc).currentColumnValuesArr;
                }
                catch (Exception exception)
                {
                    string corruptedFileName = Convert.ToString(doc)
                        .Split(new [] { "<ModelFile>" }, StringSplitOptions.None)[1]
                        .Split(new [] { "</ModelFile>" }, StringSplitOptions.None)[0];

                    ErrorBanner.Text += $"Cannot Upload File {corruptedFileName}, Please send it to IT. ";
                    Console.WriteLine("Invalid XML --- " + exception);
                    continue;
                }



                //Adds current xml to an array containing all of them [currentColumnArr][Values]
                allColumnsArr.Add(currentColumnArr);

                //WPF App - Adds a column as xml uploaded for visual representation
                WPFColumnUpdater(currentColumnArr);
                //this.Count++
                Count++;

                if ((Count - deletedColumnCount) >= 10)
                {
                    Console.WriteLine("Limit reached - " + Count);
                    ErrorBanner.Text += "Limit reached (10) - Will increase to 15 in the future";

                    Upload.IsEnabled = false;

                    break;
                }
            }
        }
        
        private void GenerateDatasheet(object sender, RoutedEventArgs e)
        {
            ErrorBanner.Text = "";
            if (Count < 1)
            {
                ErrorBanner.Text = "Nothing To Generate";
                return;
            }


            var MainContent = new CellBuilder(allColumnsArr).MainContentCellsToString;
            var Windows = new WindowBuilder(CurrentColumnValues.windowArray).windowBuild;

            Console.WriteLine("Window Initialized");

            try
            {
                documentBuilder = new DocumentBuilder(Header, MainContent, Windows).FullXml;

                Console.WriteLine(@"Document Built");



                //error handling prints xml file for easy viewing - fully formatted
                /*string path = @"C:\Users\CLEIT\Downloads\output.xml";

                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();

                    using (TextWriter tw = new StreamWriter(path))
                    {
                        tw.WriteLine(documentBuilder);
                    }

                }*/








            }
            catch (Exception exception)
            {
                ErrorBanner.Text = "Something went wrong, Please send the xml files to to IT.";
                Console.WriteLine("Unexpected Error --- Generated DataSheet clicked --- " + exception);
                throw;
            }
            



        }

        private void DeleteColumnPrompt(object sender, MouseButtonEventArgs e)
        {
            ErrorBanner.Text = "";
            try
            {
                string[] SourceSplitTypexName = e.Source.ToString().Split(':');

                if (SourceSplitTypexName[0] == "System.Windows.Controls.TextBox" &&
                    e.Source.ToString().Contains(":"))
                {

                    int selectedNameIndex = Convert.ToInt32(SourceSplitTypexName[1].Split(new string[] {"\r\n", "\n"},
                        StringSplitOptions.None)[0].Split(new string[] {"option"},
                        StringSplitOptions.None)[1]);

                    string selectedName = "option" + selectedNameIndex;


                    for (int i = 0; i < VisualTreeHelper.GetChildrenCount(Container); i++)
                    {
                        Visual childVisual = (Visual)VisualTreeHelper.GetChild(Container, i);
                        if (childVisual is TextBox)
                        {
                            if (childVisual.ToString().Contains(selectedName))
                            {

                                if (MessageBox.Show("Do you want to delete " + selectedName, "Delete Option Prompt", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                                {
                                    Container.Children.RemoveAt(i);
                                    allColumnsArr.RemoveAt(i);
                                    deletedColumnCount++;
                                }
                                break;
                            }
                        }
                    }

                    if ((Count - deletedColumnCount) < 10)
                    {
                        Upload.IsEnabled = true;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Unexpected Error --- " + exception);
                ErrorBanner.Text = "Cannot Delete, if reproduceable please send xml and reproduction steps to IT.";
            }
            
        }

        private void ResetApplicationState(object sender, RoutedEventArgs e)
        {
            var temp = System.Windows.MessageBox.Show("Reset", "Do you want to reset the application?", MessageBoxButton.YesNo);

            if (temp == MessageBoxResult.Yes)
            {
                //                allColumnsArr = new List<List<string>>();
                //                CurrentColumnValues.windowArray = new List<List<string>>();
                //                Count = 0;
                //                deletedColumnCount = 0;
                //
                //                Container.Children.Clear();
                //                Upload.IsEnabled = true;

                System.Windows.Forms.Application.Restart();
                System.Windows.Application.Current.Shutdown();
            }
        }
    }
}
