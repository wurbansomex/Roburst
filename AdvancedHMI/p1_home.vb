Imports System.Xml
Imports System.IO

Public Class p1_home


    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '*******************************************************************************
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If components IsNot Nothing Then
            Dim drv As Drivers.IComComponent
            '*****************************
            '* Search for comm components
            '*****************************
            For i As Integer = 0 To components.Components.Count - 1
                If components.Components(i).GetType.GetInterface("Drivers.IComComponent") IsNot Nothing Then
                    drv = components.Components.Item(i)
                    '* Stop/Start polling based on form visibility
                    drv.DisableSubscriptions = Not Me.Visible
                End If
            Next
        End If
    End Sub



    Private Sub ReturnToMainButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MainForm.Show()
        Me.Visible = False
    End Sub

    Private Sub PgOpenRecipeButton_Click(sender As Object, e As EventArgs) Handles PgOpenRecipeButton.Click
        base_load.Show()
        Me.Visible = False
    End Sub

    Private Sub PgOpenHomeButton_Click(sender As Object, e As EventArgs) Handles PgOpenHomeButton.Click
        base_load.Show()
        Me.Visible = False
    End Sub

    Private Sub PgOpenStatusButton_Click(sender As Object, e As EventArgs) Handles PgOpenStatusButton.Click
        base_home.Show()
        Me.Visible = False
    End Sub

    Private Sub PgOpenManualButton_Click(sender As Object, e As EventArgs) Handles PgOpenManualButton.Click
        MainForm.Show()
        Me.Visible = False
    End Sub

    Private Sub PgOpenSettingsButton_Click(sender As Object, e As EventArgs) Handles PgOpenSettingsButton.Click
        MainForm.Show()
        Me.Visible = False
    End Sub

    Private Sub PgOpenResultsButton_Click(sender As Object, e As EventArgs) Handles PgOpenResultsButton.Click
        MainForm.Show()
        Me.Visible = False
    End Sub

    Private Sub PgOpenAlarmsButton_Click(sender As Object, e As EventArgs) Handles PgOpenAlarmsButton.Click
        MainForm.Show()
        Me.Visible = False
    End Sub

    Private Sub BasicLabel1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub p1_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AppExit_Click(sender As Object, e As EventArgs) Handles AppExit.Click
        Application.Exit()
        End
    End Sub

    Private Sub BasicLabel2_Click(sender As Object, e As EventArgs) Handles BasicLabel2.Click

    End Sub

    Private Sub TestEntImp_Click(sender As Object, e As EventArgs) Handles TestEntImp.Click

    End Sub


    Private Sub GenExampleXml(sender As Object, e As EventArgs)
        Dim filename As String
        filename = TextBox1.Text + ".xml"
        Dim writer As New XmlTextWriter(filename, System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Table")
        createNode(1, "Product 1", "1001", writer)
        createNode(2, "Product 2", "2000", writer)
        createNode(3, "Product 3", "3000", writer)
        createNode(4, "Product 4", "4000", writer)
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
    End Sub

    Private Sub createNode(ByVal pID As String, ByVal pName As String, ByVal pPrice As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Product")
        writer.WriteStartElement("Product_id")
        writer.WriteString(pID)
        writer.WriteEndElement()
        writer.WriteStartElement("Product_name")
        writer.WriteString(pName)
        writer.WriteEndElement()
        writer.WriteStartElement("Product_price")
        writer.WriteString(pPrice)
        writer.WriteEndElement()
        writer.WriteEndElement()
    End Sub

    Private Sub WriteTestBtn_click(sender As Object, e As EventArgs) Handles WriteTestBtn.Click
        Dim filename As String
        filename = TextBox1.Text + ".xml"
        Dim x As New XmlTextWriter(filename, System.Text.Encoding.UTF8)

        x.WriteStartDocument(True)
        x.Formatting = Formatting.Indented
        x.Indentation = 3

        x.WriteStartElement("test")

        x.WriteStartElement("test_number")
        x.WriteString("123")
        x.WriteEndElement()

        x.WriteStartElement("break")
        x.WriteString("yes")
        x.WriteEndElement()

        'x.WriteStartElement("profile") XML to CSV converter can't do nested tags
        x.WriteStartElement("profile_name")
        x.WriteString("Pepsi")
        x.WriteEndElement()
        x.WriteStartElement("container_type")
        x.WriteString("Bottle")
        x.WriteEndElement()
        x.WriteStartElement("container_height")
        x.WriteString("Bottle")


        x.WriteEndElement()

        x.WriteEndDocument()
        x.Close()

    End Sub

    Private Sub MergeTestBtn_Click(sender As Object, e As EventArgs) Handles MergeTestBtn.Click

        Dim dailypath As String
        
        dailypath = "C:\Results\" + CStr(Today.Year) + "-" + CStr(Today.DayOfYear) + ".xml" 'Filepath to the XML file for each day's data, e.g. 2015-101.xml

        'If the daily file has not been created, just copy it from the single result file
        If Not File.Exists(dailypath) Then
            File.Copy("C:\Results\single.xml", dailypath)

            'Otherwise merge the daily file with the single result file
        Else
            Dim xmlreader1 As New XmlTextReader(dailypath)
            Dim xmlreader2 As New XmlTextReader("C:\Results\single.xml")

            Dim ds1 As New DataSet()
            Try
                ds1.ReadXml(xmlreader1)

                Dim ds2 As New DataSet()
                ds2.ReadXml(xmlreader2)

                ds1.Merge(ds2)
                ds1.WriteXml("C:\Results\temp_daily.xml", XmlWriteMode.IgnoreSchema)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            xmlreader1.Close()
            xmlreader2.Close()

            File.Copy("C:\Results\temp_daily.xml", dailypath, True)
            File.Delete("C:\Results\temp_daily.xml")

        End If


    End Sub
End Class