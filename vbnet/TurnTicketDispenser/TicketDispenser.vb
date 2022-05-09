Namespace TurnTicketDispenser
    Public Class TicketDispenser
        Public Function GetTurnTicket() As TurnTicket
            Dim newTurnNumber As Integer = TurnNumberSequence.GetNextTurnNumber()
            Dim newTurnTicket = New TurnTicket(newTurnNumber)
            
            Return newTurnTicket
        End Function
    End Class
End Namespace
