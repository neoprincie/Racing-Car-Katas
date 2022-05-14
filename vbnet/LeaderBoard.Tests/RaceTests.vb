Imports Xunit

Namespace LeaderBoard.Tests
    Public Class RaceTest
        <Fact>
        Public Sub ShouldCalculateDriverPoints()
            Assert.Equal(25, TestData.Race1.GetPoints(TestData.Driver1))
            Assert.Equal(18, TestData.Race1.GetPoints(TestData.Driver2))
            Assert.Equal(15, TestData.Race1.GetPoints(TestData.Driver3))
        End Sub
    End Class
End Namespace