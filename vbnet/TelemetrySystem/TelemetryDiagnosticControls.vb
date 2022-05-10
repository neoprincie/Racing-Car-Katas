Imports System

Namespace TelemetrySystem
    Public Class TelemetryDiagnosticControls
        Private Const DiagnosticChannelConnectionString As String = "*111#"
        Private ReadOnly _telemetryClient As TelemetryClient
        Private _diagnosticInfo As String = String.Empty

        Public Sub New()
            _telemetryClient = New TelemetryClient()
        End Sub

        Public Property DiagnosticInfo As String
            Get
                Return _diagnosticInfo
            End Get
            Set
                _diagnosticInfo = value
            End Set
        End Property

        Public Sub CheckTransmission()
            _diagnosticInfo = String.Empty
            _telemetryClient.Disconnect()
            Dim retryLeft = 3

            While _telemetryClient.OnlineStatus = False AndAlso retryLeft > 0
                _telemetryClient.Connect(DiagnosticChannelConnectionString)
                retryLeft -= 1
            End While

            If _telemetryClient.OnlineStatus = False Then
                Throw New Exception("Unable to connect.")
            End If

            _telemetryClient.Send(TelemetryClient.DiagnosticMessage)
            _diagnosticInfo = _telemetryClient.Receive()
        End Sub
    End Class
End Namespace