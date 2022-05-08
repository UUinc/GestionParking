Imports System.Text.RegularExpressions

Public Module Tools
    Public Function IsAplha(ByVal str As String) As Boolean
        Dim alpha As Regex = New Regex("[^a-zA-Z]")

        If alpha.IsMatch(str) Then
            Return False
        End If
        Return True
    End Function

    Public Function IsNumeric(ByVal str As String) As Boolean
        Dim numeric As Regex = New Regex("[^0-9]")

        If String.IsNullOrWhiteSpace(str) Then
            Return False
        End If

        Return Not numeric.IsMatch(str)
    End Function

    Public Function ContainNumeric(ByVal str As String) As Boolean
        For index = 0 To str.Length - 1
            If Char.IsDigit(str(index)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function IsAlphaNumeric(ByVal str As String) As Boolean
        Dim alphaNumeric As Regex = New Regex("[^a-zA-Z0-9]")

        If alphaNumeric.IsMatch(str) Then
            Return False
        End If
        Return True
    End Function
End Module
