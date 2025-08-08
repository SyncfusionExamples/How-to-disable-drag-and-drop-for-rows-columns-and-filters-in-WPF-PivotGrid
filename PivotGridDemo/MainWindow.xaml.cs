using System.Windows;

namespace PivotGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pivotGrid.ItemSource = ProductSales.GetSalesData();          
            pivotGrid.Loaded += OnLoaded;           
        }
   
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            //Event subscription
            pivotGrid.GroupingBar.Loaded += OnGroupingBarLoaded;
        }

        // Event customization
        private void OnGroupingBarLoaded(object sender, RoutedEventArgs e)
        {
            // To disable drag and drop for the rows on RowHeaderArea
            pivotGrid.GroupingBar.RowHeaderArea.AllowDrop = false;
            // To disable drag and drop for the columns on ColumnHeaderArea
            pivotGrid.GroupingBar.ColumnHeaderArea.AllowDrop = false;
            // To disable drag and drop for the data on DataHeaderArea
            pivotGrid.GroupingBar.DataHeaderArea.AllowDrop = false;
            // To disable drag and drop on FilterHeaderArea
            pivotGrid.GroupingBar.FilterHeaderArea.AllowDrop = false;
        }
    }
}