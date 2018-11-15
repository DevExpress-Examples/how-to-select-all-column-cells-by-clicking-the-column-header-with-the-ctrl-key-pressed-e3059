<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/GridColumnOnClickSelection/MainPage.xaml) (VB: [MainPage.xaml.vb](./VB/GridColumnOnClickSelection/MainPage.xaml.vb))
* [MainPage.xaml.cs](./CS/GridColumnOnClickSelection/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/GridColumnOnClickSelection/MainPage.xaml.vb))
<!-- default file list end -->
# How to select all column cells by clicking the column header with the Ctrl key pressed


<p>Implement a TableView descendant. In the descendant, override the OnColumnHeaderClick method. The last step is to call the SelectCell method for the necessary column  while iterating through visible rows.</p>

<br/>


