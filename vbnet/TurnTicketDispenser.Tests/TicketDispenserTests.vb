Imports RacingCarKatas.TurnTicketDispenser
Imports Xunit

Public Class TicketDispenserTests
    <Fact>
    Public Sub Foo()
        Dim ticketDispenser = New TicketDispenser()
        Dim turnTicket = ticketDispenser.GetTurnTicket()
    End Sub
End Class