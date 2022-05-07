Imports System.IO

Namespace UnicodeFileToHtmlTextConverter
    Public Class UnicodeFileToHtmlTextConverter
        Private _fullFilenameWithPath As String

        Public Sub New(fullFilenameWithPath As String)
            _fullFilenameWithPath = fullFilenameWithPath
        End Sub

        Public Function GetFilename() As String
            Return _fullFilenameWithPath
        End Function

        Public Function ConvertToHtml() As String
            Using unicodeFileStream As TextReader = File.OpenText(_fullFilenameWithPath)
                Dim html As String = String.Empty
                Dim line As String = unicodeFileStream.ReadLine()

                While line IsNot Nothing
                    html += HttpUtility.HtmlEncode(line)
                    html += "<br />"
                    line = unicodeFileStream.ReadLine()
                End While

                Return html
            End Using
        End Function
    End Class

    Class HttpUtility
        Public Shared Function HtmlEncode(line As String) As String
            line = line.Replace("<", "&lt;")
            line = line.Replace(">", "&gt;")
            line = line.Replace("&", "&amp;")
            line = line.Replace("""", "&quot;")
            line = line.Replace("'", "&quot;")
            Return line
        End Function
    End Class
End Namespace
