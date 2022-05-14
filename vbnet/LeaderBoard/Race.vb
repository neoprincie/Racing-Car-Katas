Imports System.Collections.Generic

Namespace LeaderBoard
    Public Class Race
        Private Shared ReadOnly Points As Integer() = {25, 18, 15}
        Private ReadOnly _driverNames As Dictionary(Of Driver, String) = New Dictionary(Of Driver, String)()
        Private ReadOnly _name As String

        Public Sub New(name As String, ParamArray drivers As Driver())
            _name = name
            Results = New List(Of Driver)()
            Results.AddRange(drivers)

            For Each driver In Results
                Dim driverName = driver.Name
                Dim drivingCar = TryCast(driver, SelfDrivingCar)

                If drivingCar IsNot Nothing Then
                    driverName = "Self Driving Car - " & drivingCar.Country & " (" + drivingCar.AlgorithmVersion & ")"
                End If

                _driverNames.Add(driver, driverName)
            Next
        End Sub

        Public ReadOnly Property Results As List(Of Driver)

        Public ReadOnly Property DriverNames As Dictionary(Of Driver, String)
            Get
                Return _driverNames
            End Get
        End Property

        Public Function Position(driver As Driver) As Integer
            Return Results.FindIndex(Function(d) Equals(d, driver))
        End Function

        Public Function GetPoints(driver As Driver) As Integer
            Return Points(Position(driver))
        End Function

        Public Function GetDriverName(driver As Driver) As String
            Return DriverNames(driver)
        End Function

        Public Overrides Function ToString() As String
            Return _name
        End Function
    End Class
End Namespace
