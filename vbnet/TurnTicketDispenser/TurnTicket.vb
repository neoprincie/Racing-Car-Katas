Namespace TurnTicketDispenser
    Public Class TurnTicket
        Private ReadOnly _turnNumber As Integer

        Public Sub New(turnNumber As Integer)
            _turnNumber = turnNumber
        End Sub

        Public ReadOnly Property TurnNumber As Integer
            Get
                Return _turnNumber
            End Get
        End Property
    End Class
End Namespace
