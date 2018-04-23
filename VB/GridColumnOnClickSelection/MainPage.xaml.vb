Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid

Namespace GridColumnOnClickSelection
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			Dim list As New List(Of TestData)()
			For i As Integer = 0 To 99
				list.Add(New TestData() With {.Text = "Row" & i, .Number1 = i, .Number2 = i + 2, .Number3 = i + 4})
			Next i
			DataContext = list
		End Sub
	End Class

	Public Class TestData
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateNumber1 As Integer
		Public Property Number1() As Integer
			Get
				Return privateNumber1
			End Get
			Set(ByVal value As Integer)
				privateNumber1 = value
			End Set
		End Property
		Private privateNumber2 As Integer
		Public Property Number2() As Integer
			Get
				Return privateNumber2
			End Get
			Set(ByVal value As Integer)
				privateNumber2 = value
			End Set
		End Property
		Private privateNumber3 As Integer
		Public Property Number3() As Integer
			Get
				Return privateNumber3
			End Get
			Set(ByVal value As Integer)
				privateNumber3 = value
			End Set
		End Property
	End Class

	Public Class MyTableView
		Inherits TableView
		Protected Overrides Sub OnColumnHeaderClick(ByVal column As ColumnBase, ByVal isShift As Boolean, ByVal isCtrl As Boolean)
			If isCtrl Then
				BeginSelection()
				For i As Integer = 0 To Grid.VisibleRowCount - 1
					SelectCell(i, TryCast(column, GridColumn))
				Next i
				EndSelection()
				Return
			End If
			MyBase.OnColumnHeaderClick(column, isShift, isCtrl)
		End Sub
	End Class

End Namespace
