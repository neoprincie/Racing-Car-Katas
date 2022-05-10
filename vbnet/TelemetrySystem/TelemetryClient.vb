Imports System

Namespace TelemetrySystem
    Public Class TelemetryClient
        Public Const DiagnosticMessage As String = "AT#UD"
        Private _onlineStatus As Boolean
        Private _diagnosticMessageResult As String = String.Empty
        Private ReadOnly _connectionEventsSimulator As Random = New Random(42)

        Public ReadOnly Property OnlineStatus As Boolean
            Get
                Return _onlineStatus
            End Get
        End Property

        Public Sub Connect(telemetryServerConnectionString As String)
            If String.IsNullOrEmpty(telemetryServerConnectionString) Then
                Throw New ArgumentNullException()
            End If

            Dim success As Boolean = _connectionEventsSimulator.[Next](1, 10) <= 8
            _onlineStatus = success
        End Sub

        Public Sub Disconnect()
            _onlineStatus = False
        End Sub

        Public Sub Send(message As String)
            If String.IsNullOrEmpty(message) Then
                Throw New ArgumentNullException()
            End If

            If message = DiagnosticMessage Then
                _diagnosticMessageResult = 
                    "LAST TX rate................ 100 MBPS" & vbCrLf & 
                    "HIGHEST TX rate............. 100 MBPS" & vbCrLf & 
                    "LAST RX rate................ 100 MBPS" & vbCrLf & 
                    "HIGHEST RX rate............. 100 MBPS" & vbCrLf & 
                    "BIT RATE.................... 100000000" & vbCrLf & 
                    "WORD LEN.................... 16" & vbCrLf & 
                    "WORD/FRAME.................. 511" & vbCrLf & 
                    "BITS/FRAME.................. 8192" & vbCrLf & 
                    "MODULATION TYPE............. PCM/FM" & vbCrLf & 
                    "TX Digital Los.............. 0.75" & vbCrLf & 
                    "RX Digital Los.............. 0.10" & vbCrLf & 
                    "BEP Test.................... -5" & vbCrLf & 
                    "Local Rtrn Count............ 00" & vbCrLf & 
                    "Remote Rtrn Count........... 00"
                Return
            End If
        End Sub

        Public Function Receive() As String
            Dim message As String

            If String.IsNullOrEmpty(_diagnosticMessageResult) = False Then
                message = _diagnosticMessageResult
                _diagnosticMessageResult = String.Empty
            Else
                message = String.Empty
                Dim messageLenght As Integer = _connectionEventsSimulator.[Next](50, 110)

                For i = messageLenght To 0
                    message += ChrW(_connectionEventsSimulator.[Next](40, 126))
                Next
            End If

            Return message
        End Function
    End Class
End Namespace
