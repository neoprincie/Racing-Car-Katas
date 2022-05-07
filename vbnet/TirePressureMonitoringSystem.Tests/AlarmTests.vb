Imports Xunit

Namespace TirePressureMonitoringSystem.Tests

    Public Class AlarmTests
        <Fact>
        Public Sub Foo()
            Dim alarm As Alarm = New Alarm()
            
            Assert.False(alarm.AlarmOn)
        End Sub
    End Class
End NameSpace