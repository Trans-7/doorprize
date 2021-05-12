Public Class Participant
    Public nik As String
    Public name As String
    Public prize As String

    Public Function getNik()
        Return nik
    End Function
    Public Sub setNik(ByVal nik1)
        nik = nik1
    End Sub

    Public Function getName()
        Return name
    End Function
    Public Sub setName(ByVal name1)
        name = name1
    End Sub

    Public Function getPrize()
        Return prize
    End Function
    Public Sub setPrize(ByVal prize1)
        prize = prize1
    End Sub

End Class
