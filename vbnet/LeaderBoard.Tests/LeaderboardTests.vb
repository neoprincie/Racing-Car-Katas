Imports System.Collections.Generic
Imports Xunit

Namespace LeaderBoard.Tests
    Public Class LeaderboardTest
        <Fact>
        Public Sub ShouldSumThePoints()
            Dim results = TestData.SampleLeaderboard1.DriverResults()
            Assert.[True](results.ContainsKey("Lewis Hamilton"))
            Assert.Equal(18 + 18 + 25, results("Lewis Hamilton"))
        End Sub

        <Fact>
        Public Sub ShouldFindTheWinner()
            Assert.Equal("Lewis Hamilton", TestData.SampleLeaderboard1.DriverRankings()(0))
        End Sub

        <Fact>
        Public Sub ShouldKeepAllDriversWhenSamePoints()
            Dim winDriver1 = New Race("Australian Grand Prix", TestData.Driver1, TestData.Driver2, TestData.Driver3)
            Dim winDriver2 = New Race("Malaysian Grand Prix", TestData.Driver2, TestData.Driver1, TestData.Driver3)
            Dim exEquoLeaderBoard = New Leaderboard(winDriver1, winDriver2)
            
            Dim rankings = exEquoLeaderBoard.DriverRankings()
            
            Assert.Equal(New List(Of String) From {
                            TestData.Driver2.Name,
                            TestData.Driver1.Name,
                            TestData.Driver3.Name
                            }, rankings)
        End Sub
    End Class
End Namespace
