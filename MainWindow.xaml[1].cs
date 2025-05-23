using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Windows;

namespace DashboardApp
{
    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection { get; set; }
        public List<MyItem> MyData { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Доход",
                    Values = new ChartValues<double> { 5, 10, 6, 12, 9 }
                }
            };

            MyData = new List<MyItem>
            {
                new MyItem { Name = "Январь", Value = 5000 },
                new MyItem { Name = "Февраль", Value = 7000 }
            };

            DataContext = this;
        }
    }

    public class MyItem
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
