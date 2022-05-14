Namespace LeaderBoard
    Public Class SelfDrivingCar
        Inherits Driver

        Public Sub New(algorithmVersion As String, company As String)
            MyBase.New(algorithmVersion, company)
            AlgorithmVersion = algorithmVersion
        End Sub

        Public Property AlgorithmVersion As String
    End Class
End Namespace
