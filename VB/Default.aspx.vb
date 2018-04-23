Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Web
Imports System.Web.Services
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Class Product
	Public Property ProductID() As Integer
	Public Property ProductName() As String
	Public Sub New()
	End Sub

	Public Sub New(ByVal id As Integer, ByVal name As String)
		ProductID = id
		ProductName = name
	End Sub
End Class

Partial Public Class _Default
	Inherits System.Web.UI.Page

	<WebMethod()>
	Public Shared Function GetData() As IEnumerable(Of Product)
        Dim returnList = New List(Of Product)
        returnList.Add(New Product(10010, "Toys"))
        returnList.Add(New Product(10020, "Books"))
        returnList.Add(New Product(10030, "Cars"))
        returnList.Add(New Product(10040, "Cars2"))
        returnList.Add(New Product(10050, "Cars3"))
        returnList.Add(New Product(10060, "Trucks"))
        returnList.Add(New Product(10070, "Bikes"))
        returnList.Add(New Product(20000, "Pets"))
        returnList.Add(New Product(20002, "Dogs"))
        returnList.Add(New Product(20004, "Cats"))
        returnList.Add(New Product(20006, "Fish"))

        For i As Integer = 0 To 9999
            returnList.Add(New Product(i, "John Doe" & i))
            i += 1
            returnList.Add(New Product(i, "Jane Doe" & i))
            i += 1
            returnList.Add(New Product(i, "Michael Doe" & i))
            i += 1
            returnList.Add(New Product(i, "Lana Doe" & i))
        Next i
        Return returnList
	End Function

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	<WebMethod()>
	Public Shared Function GetFilteredData(ByVal str As String) As List(Of Product)
		If Not String.IsNullOrEmpty(str) Then
			Return GetData().Where(Function(p) p.ProductName.ToLower().Contains(str.ToLower())).Take(10).ToList()
		Else
			Return Nothing
		End If
	End Function
End Class