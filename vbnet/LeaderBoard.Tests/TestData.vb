Namespace LeaderBoard.Tests
    Public Class TestData
        Public Shared Driver1 As Driver
        Public Shared Driver2 As Driver
        Public Shared Driver3 As Driver
        Public Shared Driver4 As SelfDrivingCar
        Public Shared Race1 As Race
        Public Shared Race2 As Race
        Public Shared Race3 As Race
        Public Shared Race4 As Race
        Public Shared Race5 As Race
        Public Shared Race6 As Race
        Public Shared SampleLeaderboard1 As Leaderboard
        Public Shared SampleLeaderboard2 As Leaderboard

        Shared Sub New()
            Driver1 = New Driver("Nico Rosberg", "DE")
            Driver2 = New Driver("Lewis Hamilton", "UK")
            Driver3 = New Driver("Sebastian Vettel", "DE")
            Driver4 = New SelfDrivingCar("1.2", "Acme")
            Race1 = New Race("Australian Grand Prix", Driver1, Driver2, Driver3)
            Race2 = New Race("Malaysian Grand Prix", Driver3, Driver2, Driver1)
            Race3 = New Race("Chinese Grand Prix", Driver2, Driver1, Driver3)
            Race4 = New Race("Fictional Grand Prix 1", Driver1, Driver2, Driver4)
            Race5 = New Race("Fictional Grand Prix 2", Driver4, Driver2, Driver1)
            Driver4.AlgorithmVersion = "1.3"
            Race6 = New Race("Fictional Grand Prix 3", Driver2, Driver1, Driver4)
            SampleLeaderboard1 = New Leaderboard(Race1, Race2, Race3)
            SampleLeaderboard2 = New Leaderboard(Race4, Race5, Race6)
        End Sub
    End Class
End Namespace
