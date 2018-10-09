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

        public string DocumentBuilder { get; set; }

        // [[str1,str2,str3],[str1,str2,str3],[str1,str2,str3],ect...]
        public List<List<string>> AllColumnsArr { get; set; } = new List<List<string>>();


        public static int DeletedColumnCount { get; set; } = 0;

        public static MainWindow AppWindow;

        public MainWindow()
        {
            InitializeComponent();
            AddHandler(MouseRightButtonDownEvent, new MouseButtonEventHandler(DeleteColumnPrompt), true);
            AppWindow = this;
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
            tb.Text = "option" + Convert.ToString(Container.Children.Count + DeletedColumnCount) + "\n";
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
            ErrorBannerUpdater("");
            //uploads an xml file
            foreach (var doc in new UploadXML().doc)
            {

                //generates the header only once
                if ((Count - DeletedColumnCount) < 1)
                {
                    try
                    {
                        Header = new HeaderGenerator(doc).HeaderToString;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        ErrorBannerUpdater("Did you upload the CBECC XML? The takeoff XML is invalid!");
                        return;
                    }
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

                    ErrorBannerUpdater($"Cannot Upload File {corruptedFileName}, Please send it to IT. ");
                    Console.WriteLine("Invalid XML --- " + exception);
                    continue;
                }



                //Adds current xml to an array containing all of them [currentColumnArr][Values]
                AllColumnsArr.Add(currentColumnArr);

                //WPF App - Adds a column as xml uploaded for visual representation
                WPFColumnUpdater(currentColumnArr);
                //this.Count++
                Count++;

                if ((Count - DeletedColumnCount) >= 10)
                {
                    Console.WriteLine("Limit reached - " + Count);
                    ErrorBannerUpdater("Limit reached (10) - Will increase to 15 in the future");

                    Upload.IsEnabled = false;

                    break;
                }
            }
        }

        private void GenerateDatasheet(object sender, RoutedEventArgs e)
        {
            ErrorBannerUpdater("");
            if (Count - DeletedColumnCount < 1)
            {
                ErrorBannerUpdater("Nothing To Generate");
                return;
            }


            var MainContent = new CellBuilder(AllColumnsArr).MainContentCellsToString;
            var Windows = new WindowBuilder(CurrentColumnValues.windowArray).windowBuild;

            Console.WriteLine("Window Initialized");

            try
            {
                Console.WriteLine("try build");
                DocumentBuilder = new DocumentBuilder(Header, MainContent, Windows).FullXml;

                Console.WriteLine(@"Document Built");



                //error handling prints xml file for easy viewing - fully formatted
                /*string path = @"C:\Users\CLEIT\Downloads\output.xml";

                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();

                    using (TextWriter tw = new StreamWriter(path))
                    {
                        tw.WriteLine(DocumentBuilder);
                    }

                }*/








            }
            catch (Exception exception)
            {
                ErrorBannerUpdater("Something went wrong, Please send the xml files to to IT.");
                Console.WriteLine("Unexpected Error --- Generated DataSheet clicked --- " + exception);
                throw;
            }
            



        }

        private void DeleteColumnPrompt(object sender, MouseButtonEventArgs e)
        {










            ErrorBannerUpdater("");
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
                                    AllColumnsArr.RemoveAt(i);
                                    DeletedColumnCount++;

//                                    CurrentColumnValues.windowArray[0].RemoveAt(i + 1);
//                                    CurrentColumnValues.windowArray[1].RemoveAt(i + 1);
//                                    CurrentColumnValues.windowArray[2].RemoveAt(i + 1);
                                }
                                break;
                            }
                        }
                    }

                    if ((Count - DeletedColumnCount) < 10)
                    {
                        Upload.IsEnabled = true;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Unexpected Error --- " + exception);
                ErrorBannerUpdater("Cannot Delete, if reproduceable please send xml and reproduction steps to IT.");
            }
        }

        private void ResetApplicationState(object sender, RoutedEventArgs e)
        {
            var temp = System.Windows.MessageBox.Show("Reset", "Do you want to reset the application?", MessageBoxButton.YesNo);

            if (temp == MessageBoxResult.Yes)
            {
                //                AllColumnsArr = new List<List<string>>();
                //                CurrentColumnValues.windowArray = new List<List<string>>();
                //                Count = 0;
                //                DeletedColumnCount = 0;
                //
                //                Container.Children.Clear();
                //                Upload.IsEnabled = true;

                System.Windows.Forms.Application.Restart();
                System.Windows.Application.Current.Shutdown();
            }
        }

        public void ErrorBannerUpdater(string errorMessage) {
            ErrorBanner.Text = errorMessage;
            
        }
    }
}
