Imports System
Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Public Class Form1
    Dim btApp As BarTender.Application
    Dim btFormat As BarTender.Format
    Dim btMsgs As BarTender.Messages
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btFormat = btApp.Formats.Open("C:\Users\Thinkpad\Desktop\test.btw") 'set loc for your btw file
        btFormat.SetNamedSubStringValue("name", "aaweee") 'the name datasource must be same in bartender file
        btFormat.SetNamedSubStringValue("dob", "DOB: " & "1990-12-01") 'the name datasource must be same in bartender file
        btFormat.SetNamedSubStringValue("barcode", "12345678") 'the name datasource must be same in bartender file
        btFormat.SetNamedSubStringValue("number", "12345678") 'the name datasource must be same in bartender file
        btFormat.Print("Job1", False, -1, btMsgs)

        btFormat.Close(BarTender.BtSaveOptions.btSaveChanges)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btApp = New BarTender.Application()
    End Sub

End Class
