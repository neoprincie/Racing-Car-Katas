Namespace LeaderBoard
    Public Class Driver
        Public Sub New(name As String, country As String)
            Me.Name = name
            Me.Country = country
        End Sub

        Public ReadOnly Property Name As String
        Public ReadOnly Property Country As String

        Public Overrides Function GetHashCode() As Integer
            Return Name.GetHashCode() * 31 + Country.GetHashCode()
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            If Me = obj Then
                Return True
            End If

            If Not (TypeOf obj Is Driver) Then
                Return False
            End If

            Dim other = CType(obj, Driver)
            Return Name.Equals(other.Name) AndAlso Country.Equals(other.Country)
        End Function
    End Class
End Namespace
