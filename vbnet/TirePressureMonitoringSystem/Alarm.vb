Namespace TirePressureMonitoringSystem

    Public Class Alarm
        Private Const LowPressureThreshold As Double = 17
        Private Const HighPressureThreshold As Double = 21
        
        Private _sensor As Sensor = New Sensor()
        
        Private _alarmOn As Boolean = False
        Private _alarmCount As Long = 0

        Public Sub Check()
            Dim psiPressureValue As Double = _sensor.PopNextPressurePsiValue()

            If psiPressureValue < LowPressureThreshold OrElse HighPressureThreshold < psiPressureValue Then
                _alarmOn = True
                _alarmCount += 1
            End If
        End Sub

        Public ReadOnly Property AlarmOn As Boolean
            Get
                Return _alarmOn
            End Get
        End Property
    End Class
End NameSpace