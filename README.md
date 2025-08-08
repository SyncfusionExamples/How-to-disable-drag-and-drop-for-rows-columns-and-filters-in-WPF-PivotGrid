# How to disable drag and drop for rows columns and filters in WPF PivotGridControl?

In [WPF PivotGridControl](https://www.syncfusion.com/wpf-controls/pivot-grid), drag-and-drop functionality for rows, columns, and filters can be disabled by setting the AllowDrop property to false within the [GroupingBar](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Controls.PivotGrid.PivotGridGroupingBar.html) Loaded event.

```csharp
pivotGrid.Loaded += OnLoaded; 

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
```

![DragDrop](DragDrop.gif)

Take a moment to peruse the [WPF PivotGridControl - GroupingBar](https://help.syncfusion.com/wpf/pivot-grid/grouping-bar-context-menu) documentation, where you can find about the GroupingBar with code examples. 
