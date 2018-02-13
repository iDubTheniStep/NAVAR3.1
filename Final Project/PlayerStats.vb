Public Class PlayerStats
    Public Shared numHealth As Double = 100
    Public Sub YouSuck()
        If PlayerStats.numHealth <= 90 Then death.Show()
    End Sub
End Class
