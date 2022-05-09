Namespace TurnTicketDispenser
    Module TurnNumberSequence
        Private _turnNumber As Integer = 0

        Function GetNextTurnNumber() As Integer
            Dim nextTurnNumber = _turnNumber
            _turnNumber = _turnNumber + 1
            
            Return nextTurnNumber
        End Function
    End Module
End Namespace
