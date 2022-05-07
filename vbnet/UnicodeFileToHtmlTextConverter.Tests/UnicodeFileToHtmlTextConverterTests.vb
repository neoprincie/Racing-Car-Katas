Imports Xunit

Namespace UnicodeFileToHtmlTextConverter.Tests
    Public Class UnicodeFileToHtmlTextConverterTests
        <Fact>
        Public Sub Foobar()
            Dim converter = New UnicodeFileToHtmlTextConverter("foobar.txt")
            Assert.Equal("fixme", converter.GetFilename())
        End Sub
    End Class
End Namespace
