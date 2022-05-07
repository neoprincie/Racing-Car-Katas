Imports System.Runtime.InteropServices

Namespace TirePressureMonitoringSystem

    Public Class Sensor
        Const Offset As Double = 16

        Public Function PopNextPressurePsiValue() As Double
            Dim pressureTelemetryValue As Double
            SamplePressure(pressureTelemetryValue)
            
            Return Offset + pressureTelemetryValue
        End Function

        Private Shared Sub SamplePressure(<Out> ByRef pressureTelemetryValue As Double)
            ' placeholder implementation that simulate a real sensor in a real tire
            Dim basicRandomNumbersGenerator = New Random()
            pressureTelemetryValue = 6 * basicRandomNumbersGenerator.NextDouble() * basicRandomNumbersGenerator.NextDouble()
        End Sub
    End Class
End NameSpace