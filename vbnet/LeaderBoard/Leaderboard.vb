Imports System.Collections.Generic

Namespace LeaderBoard
    Public Class Leaderboard
        Private ReadOnly _races As List(Of Race) = New List(Of Race)()

        Public Sub New(ParamArray races As Race())
            _races.AddRange(races)
        End Sub

        Public Function DriverResults() As Dictionary(Of String, Integer)
            Dim results = New Dictionary(Of String, Integer)()

            For Each race In _races
                For Each driver In race.Results
                    Dim driverName = race.GetDriverName(driver)
                    Dim points = race.GetPoints(driver)

                    If results.ContainsKey(driverName) Then
                        results(driverName) = results(driverName) + points
                    Else
                        results.Add(driverName, 0 + points)
                    End If
                Next
            Next

            Return results
        End Function

        Public Function DriverRankings() As List(Of String)
            Dim results = DriverResults()
            Dim resultsList = New List(Of String)(results.Keys)
            resultsList.Sort()
            Return resultsList
        End Function
    End Class
End Namespace
