Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel.Constants

Public Class Form1
    Dim oleDbConn As OleDbConnection
    Dim oleDbDA As OleDbDataAdapter
    Dim defaultFilePath As String = "    << Click here to select file >>"
    Dim FilePath1 As String = "OpenFileDialog1"
    Dim FilePath2 As String = "OpenFileDialog2"
    Dim defaultStartBtn As String = "Start"
    Dim randomParticipant As New List(Of Participant)
    Dim winnerList As New List(Of Participant)
    Dim status As Integer = 0
    Dim random As New Random
    Dim prizes

    Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=db_doorprize;Integrated Security=True"
    'Dim connectionString As String = "Data Source=172.16.20.179,1433;Initial Catalog=db_doorprize;User ID=doorprize;Password=doorprizet7"
    Dim conn1 As New SqlConnection
    Dim sqlDA As New SqlDataAdapter
    Dim dtParticipant As New DataTable
    Dim dtPrize As New DataTable
    Dim dtWinner As New DataTable
    Dim dtRandom As New DataTable
    Dim SQL

    Private Sub TextBox_FilePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_FilePath.Click
        conn1 = New SqlConnection(connectionString)
        DataGridView1.ReadOnly = True
        BtnImport.Enabled = True

        Try
            Dim sqlDel As String = "Delete from Participants"
            'Dim cmdDel As SqlCommand
            sqlDA.DeleteCommand = New SqlCommand(sqlDel, conn1)
            conn1.Open()
            sqlDA.DeleteCommand.ExecuteNonQuery()
            conn1.Close()

            If (dtParticipant.Rows.Count > 0) Then
                dtParticipant.Clear()
                DataGridView1.Columns.Clear()
                DataGridView1.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        OpenFileDialog1.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        TextBox_FilePath.Text = OpenFileDialog1.FileName
        
    End Sub

    Private Sub TextBox_FilePath2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_FilePath2.Click
        conn1 = New SqlConnection(connectionString)
        DataGridView2.ReadOnly = True
        BtnImport2.Enabled = True

        Try
            Dim sqlDel As String = "Delete from Prize"
            sqlDA.DeleteCommand = New SqlCommand(sqlDel, conn1)
            conn1.Open()
            sqlDA.DeleteCommand.ExecuteNonQuery()
            conn1.Close()

            If (dtPrize.Rows.Count > 0) Then
                dtPrize.Clear()
                DataGridView2.DataSource = Nothing
                DataGridView2.Columns.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        OpenFileDialog2.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"
        OpenFileDialog2.ShowDialog()
        TextBox_FilePath2.Text = OpenFileDialog2.FileName
    End Sub

    Private Sub BtnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImport.Click
        If String.Compare(TextBox_FilePath.Text, defaultFilePath) = 0 Then
            MessageBox.Show("Please select file before upload data !")
            Exit Sub
        End If

        If TextBox_FilePath.Text.Equals(FilePath1) Then
            MessageBox.Show("Please select file before upload data!")
            Exit Sub
        End If

        'CONN = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" &
        '          "data source='" & OpenFileDialog1.FileName & "';Extended Properties=Excel 8.0;")
        oleDbConn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" &
                   "data source='" & OpenFileDialog1.FileName & "';Extended Properties=Excel 12.0;")
        Try
            oleDbDA = New OleDbDataAdapter("select * from [Sheet1$]", oleDbConn)

            oleDbConn.Open()
            oleDbDA.Fill(dtParticipant)
            DataGridView1.DataSource = dtParticipant
            oleDbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Using connection As New SqlConnection(connectionString)

            Dim cmdText As String = "INSERT INTO Participants (ParticipantNik, ParticipantName, ParticipantStatus) VALUES (@ParticipantNik, @ParticipantName, @ParticipantStatus)"
            Dim command As New SqlCommand(cmdText, connection)
            command.Parameters.Add(New SqlParameter("@ParticipantNik", SqlDbType.VarChar))
            command.Parameters.Add(New SqlParameter("@ParticipantName", SqlDbType.VarChar))
            command.Parameters.Add(New SqlParameter("@ParticipantStatus", SqlDbType.Int))
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()
            command.Transaction = transaction

            Try
                For i As Integer = 0 To DataGridView1.Rows.Count - 2
                    command.Parameters("@ParticipantNik").Value = DataGridView1.Rows(i).Cells(0).FormattedValue
                    command.Parameters("@ParticipantName").Value = DataGridView1.Rows(i).Cells(1).FormattedValue
                    command.Parameters("@ParticipantStatus").Value = status
                    command.ExecuteNonQuery()
                Next i

                transaction.Commit()
                MessageBox.Show("Success save Participant")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Try
                    transaction.Rollback()
                Catch rollBackEx As Exception
                    MessageBox.Show(rollBackEx.Message)
                End Try
            End Try
        End Using

        If (DataGridView1.Rows.Count > 0) Then
            BtnImport.Enabled = False
        End If
    End Sub

    Private Sub BtnImport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImport2.Click
        If String.Compare(TextBox_FilePath2.Text, defaultFilePath) = 0 Then
            MessageBox.Show("Please select file before upload data !")
            Exit Sub
        End If

        If TextBox_FilePath2.Text.Equals(FilePath2) Then
            MessageBox.Show("Please select file before upload data!")
            Exit Sub
        End If

        'CONN = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" &
        '           "data source='" & OpenFileDialog2.FileName & "';Extended Properties=Excel 8.0;")
        oleDbConn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" &
                   "data source='" & OpenFileDialog2.FileName & "';Extended Properties=Excel 12.0;")
        oleDbDA = New OleDbDataAdapter("select * from [Sheet1$]", oleDbConn)

        Try
            oleDbConn.Open()
            oleDbDA.Fill(dtPrize)
            DataGridView2.DataSource = dtPrize
            oleDbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Using connection As New SqlConnection(connectionString)

            Dim cmdText As String = "INSERT INTO Prize (PrizeName, PrizeQty, PrizeId) VALUES (@PrizeName, @PrizeQty, @PrizeId)"
            Dim command As New SqlCommand(cmdText, connection)
            command.Parameters.Add(New SqlParameter("@PrizeName", SqlDbType.VarChar))
            command.Parameters.Add(New SqlParameter("@PrizeQty", SqlDbType.Int))
            command.Parameters.Add(New SqlParameter("@PrizeId", SqlDbType.Int))
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()
            command.Transaction = transaction

            Try
                For i As Integer = 0 To DataGridView2.Rows.Count - 2
                    command.Parameters("@PrizeName").Value = DataGridView2.Rows(i).Cells(0).FormattedValue
                    command.Parameters("@PrizeQty").Value = DataGridView2.Rows(i).Cells(1).FormattedValue
                    command.Parameters("@PrizeId").Value = i + 1
                    command.ExecuteNonQuery()
                Next i

                transaction.Commit()
                MessageBox.Show("Success save Prize")
            Catch ex As Exception
                MsgBox(ex.Message)

                Try
                    transaction.Rollback()
                Catch rollBackEx As Exception
                    MessageBox.Show(rollBackEx.Message)
                End Try
            End Try
        End Using

        If (DataGridView2.Rows.Count > 0) Then
            BtnImport2.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        defaultFilePath = TextBox_FilePath.Text
        Timer1.Interval = 50
        BtnSvWinner.Enabled = False

        dtParticipant.Columns.Add("NIK")
        dtParticipant.Columns.Add("Name")
        DataGridView1.DataSource = dtParticipant

        dtPrize.Columns.Add("Name")
        dtPrize.Columns.Add("Qty")
        DataGridView2.DataSource = dtPrize

        dtRandom.Columns.Add("NIK")
        dtRandom.Columns.Add("Name")
        dtRandom.Columns.Add("Prize")
        DataGridView3.DataSource = dtRandom
        Form2_display.DataGridView1.DataSource = dtRandom

        dtWinner.Columns.Add("NIK")
        dtWinner.Columns.Add("Name")
        dtWinner.Columns.Add("Prize")
        DataGridView4.DataSource = dtWinner

        Dim deleteItem As String
        conn1 = New SqlConnection(connectionString)
        deleteItem = "Delete from Claim"
        sqlDA.DeleteCommand = New SqlCommand(deleteItem, conn1)
        conn1.Open()
        sqlDA.DeleteCommand.ExecuteNonQuery()
        conn1.Close()
    End Sub

    Private Sub BtnshowOutput_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnshowOutput.Click
        If Form2_display.Visible Then
            Form2_display.Hide()
        Else
            Form2_display.Show()
            fitTo1stMon()
        End If
    End Sub

    Private Sub fitTo1stMon()
        Dim screens() As Screen = Screen.AllScreens
        Form2_display.Width = 500
        Form2_display.Height = 600
        Form2_display.Top = screens(0).WorkingArea.Top
        Form2_display.Left = screens(0).WorkingArea.Left
    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim totalRequest As Integer = NumericUpDown1.Value
        ''''''''''''''''''''''''''''''''''''''''''''''''

        If (dtRandom.Rows.Count > 0) Then
            dtRandom.Clear()
        End If
        Dim winnerIdx As ArrayList = New ArrayList()
        While (winnerIdx.Count < totalRequest)
            Dim randomedIdx = -1
            Do
                randomedIdx = random.Next(0, DataGridView1.Rows.Count - 1)
            Loop Until (Not winnerIdx.Contains(randomedIdx))
            winnerIdx.Add(randomedIdx)
        End While

        For Each row As Integer In winnerIdx
            'Dim p As New Participant
            'p.nik = DataTableP.Rows(row)(0)
            'p.name = DataTableP.Rows(row)(1)
            'p.prize = prize.name
            'randomParticipant.Add(p)
            Dim prize
            Dim occupiedCount
            Do
                Dim prizes = dtPrize.AsEnumerable().[Select](Function(x) New With {
                    Key .name = x.Item("Name"),
                    Key .qty = x.Item("Qty")
                }).Where(Function(s) s.qty > 0).ToList()

                Dim prizeIdx = random.Next(0, prizes.Count)
                prize = prizes(prizeIdx)
                occupiedCount = dtRandom.AsEnumerable().[Select](Function(x) New With {
                    Key .prize = x.Item("Prize")
                }).Where(Function(s) s.prize.Equals(prize.name)).ToList().Count
            Loop While (prize.qty <= occupiedCount)

            dtRandom.Rows.Add(dtParticipant.Rows(row)(0), dtParticipant.Rows(row)(1), prize.name)

        Next
        Form2_display.DataGridView1.DataSource = dtRandom

        '        For Each rowPart As Participant In randomParticipant
        '            'Dim counRandWinner As Integer = 0
        '            prizes = DT2.AsEnumerable().[Select](Function(x) New With {
        '                   Key .name = x.Field(Of String)("Name"),
        '                   Key .qty = x.Field(Of Double)("Qty")
        '               }).Where(Function(s) s.qty > 0).ToList()

        'forcerandom:
        '            randomedIdx = random.Next(0, prizes.Count)
        '            'Dim prizename As String = Me.DataGridView2.Rows(randomedIdx).Cells("name").Value
        '            Dim prizename As String = prizes(randomedIdx).name

        '            Dim counRandWinner As Integer = 0

        '            For Each rowPart2 As Participant In randomParticipant
        '                If rowPart2.prize = prizename Then
        '                    counRandWinner += 1
        '                End If
        '            Next

        '            If counRandWinner < Me.DataGridView2.Rows(Me.getRowIndex(Me.DataGridView2, "name", prizename)).Cells("qty").Value Then
        '                rowPart.prize = prizes(randomedIdx).name
        '            Else
        '                GoTo forcerandom
        '            End If
        '        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Function getRowIndex(ByVal dgv As DataGridView, ByVal coloumnName As String, ByVal coloumnValue As String) As Integer
        For i As Integer = 0 To dgv.Rows.Count - 1
            If dgv.Rows(i).Cells(coloumnName).Value = coloumnValue Then
                Return i
            End If
        Next
    End Function

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        If String.Compare(TextBox_FilePath.Text, defaultFilePath) = 0 Then
            MessageBox.Show("Please select file before loading data!")
            Exit Sub
        End If

        If dtParticipant.Rows.Count = 0 Then
            MessageBox.Show("Please upload data Participant!")
            Exit Sub
        End If

        If dtPrize.Rows.Count = 0 Then
            MessageBox.Show("Please upload data Prize!")
            Exit Sub
        End If

        Dim totalRequest As Integer
        totalRequest = NumericUpDown1.Value

        If (totalRequest = 0) Then
            MsgBox("Please input quantity!")
            Exit Sub
        End If

        'hitung sum(qty) prize 
        Dim qtyPrize = DataGridView2.Rows.Cast(Of DataGridViewRow).Sum(Function(r) Val(r.Cells(1).Value))

        If (qtyPrize = 0) Then
            MsgBox("Prize is not available !")

            NumericUpDown1.Value = 0
            Exit Sub
        End If

        If (NumericUpDown1.Value > qtyPrize) Then
            MsgBox("Available quantity is " & qtyPrize)

            NumericUpDown1.Value = qtyPrize
        End If

        If String.Compare(BtnStart.Text, defaultStartBtn) = 0 Then
            BtnStart.Text = "Stop"
            Timer1.Start()
            BtnSvWinner.Enabled = False
        Else
            BtnStart.Text = defaultStartBtn
            Timer1.Stop()
            BtnSvWinner.Enabled = True

            ''''''''''''''''''''''''''''
            'Dim newTable As New DataTable

            'newTable.Columns.Add("Nik")
            'newTable.Columns.Add("Name")
            'newTable.Columns.Add("Prize")
            'For Each p As Participant In randomParticipant
            '    newTable.Rows.Add(p.nik, p.name, p.prize)
            'Next
            'DataGridView3.DataSource = newTable
            'DataGridView3.ReadOnly = True
            Form2_display.DataGridView1.DataSource = dtRandom
            'Next
        End If
    End Sub

    Private Sub BtnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExport.Click
        If winnerList.Count > 0 Then
            winnerList.Clear()
        End If

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim resourcesFolder = IO.Path.GetFullPath(Application.StartupPath)
        Dim fileName = "result.xlsx"
        Dim currRow As Integer = 0

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)

        xlWorkSheet = xlWorkBook.Worksheets.Add()
        xlWorkSheet.Name = "Winner"

        Dim formatRange As Excel.Range
        formatRange = xlWorkSheet.Range("A1", "C1")
        formatRange.Font.Size = 12
        formatRange.Font.Bold = True
        formatRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray)
        formatRange.HorizontalAlignment = 3
        formatRange.VerticalAlignment = 3

        formatRange = xlWorkSheet.Range("B1", "B1")
        formatRange.EntireColumn.ColumnWidth = 33

        formatRange = xlWorkSheet.Range("C1", "C1")
        formatRange.EntireColumn.ColumnWidth = 22

        xlWorkSheet.Cells(1, 1) = "NIK"
        xlWorkSheet.Cells(1, 2) = "Name"
        xlWorkSheet.Cells(1, 3) = "Prize"
        currRow = 2

        For i As Integer = 0 To DataGridView4.Rows.Count - 2
            Dim nik As String
            nik = DataGridView4.Rows(i).Cells(0).Value
            Dim name As String
            name = DataGridView4.Rows(i).Cells(1).Value
            Dim prize As String
            prize = DataGridView4.Rows(i).Cells(2).Value

            Dim newParticipantWinner As New Participant
            newParticipantWinner.nik = nik
            newParticipantWinner.name = name
            newParticipantWinner.prize = prize
            winnerList.Add(newParticipantWinner)
        Next
        
        For Each p As Participant In winnerList
            xlWorkSheet.Cells(currRow, 1) = p.nik
            xlWorkSheet.Cells(currRow, 2) = p.name
            xlWorkSheet.Cells(currRow, 3) = p.prize
            currRow += 1
        Next

            xlWorkSheet.SaveAs(resourcesFolder & "\result.xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("Export succes to " & resourcesFolder & "\result.xlsx")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub BtnShowAllWinner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowAllWinner.Click
        Form2_display.DataGridView1.DataSource = dtWinner
        Form2_display.DataGridView1.ReadOnly = True
    End Sub

    Private Sub BtnSvWinner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSvWinner.Click
        For Each row As DataRow In dtRandom.AsEnumerable
            Dim prizename = row.Item("Prize")
            Dim rowToUpdateData = dtPrize.AsEnumerable().[Select](Function(x) New With {
               Key .name = x.Item("Name"),
               Key .qty = x.Item("Qty")
            }).Where(Function(s) s.name.Equals(prizename)).FirstOrDefault()

            Dim rowToUpdate = dtPrize.AsEnumerable().Where(Function(r) r.Item("Name").Equals(prizename)).FirstOrDefault()
            rowToUpdate.SetField("Qty", rowToUpdateData.qty - 1)

            dtWinner.Rows.Add(row.Item("NIK"), row.Item("Name"), row.Item("Prize"))
        Next

        For i As Integer = 0 To dtRandom.Rows.Count - 1
            Try
                Dim nik = dtRandom.Rows(i)(0)
                Dim name = dtRandom.Rows(i)(1)
                Dim prizeName = dtRandom.Rows(i)(2)
                Dim SqlInsertClaim As String
                Dim claimStatus As String = "CLAIM"
                SqlInsertClaim = "Insert into Claim (ClaimNik, ClaimName, ClaimPrize, ClaimStatus) Values ('" & nik & "','" & Name & "','" & prizename & "', '" & claimStatus & "')"
                sqlDA.InsertCommand = New SqlCommand(SqlInsertClaim, conn1)
                conn1.Open()
                sqlDA.InsertCommand.ExecuteNonQuery()
                conn1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        'delete participant from dgv
        Dim rowDelParticipant As New List(Of DataRow)
        For Each row As DataRow In dtRandom.AsEnumerable
            Dim records = dtParticipant.AsEnumerable.Where(Function(r) r.Item("NIK").ToString.Equals(row.Item("NIK"))).FirstOrDefault()
            rowDelParticipant.Add(records)
        Next

        For Each row As DataRow In rowDelParticipant
            row.Delete()
        Next
        dtParticipant.AcceptChanges()

        dtRandom.Clear()
        DataGridView4.ReadOnly = True

        If (dtRandom.Rows.Count = 0) Then
            BtnSvWinner.Enabled = False
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim confirm As Boolean = True
        If dtWinner.Rows.Count > 0 Then
            confirm = False
            Dim result As Integer = MsgBox("There is unsaved Winner list, are you sure ? ", MsgBoxStyle.YesNo, "Closing")
            If result = MsgBoxResult.Yes Then
                confirm = True
            End If
        End If

        If Not confirm Then
            e.Cancel = True
        End If
    End Sub
End Class
