
Namespace DesignPattern.VbDotNet.Sigletons
    '延遲延遲實體化  VB.Net
    Public Class Singleton
        Private Shared singleton As Singleton
        Private Sub New()

        End Sub
        Public Shared Function GetInstance() As Singleton
            If singleton Is Nothing Then
                singleton = New Singleton()
            End If
            Return singleton
        End Function
    End Class

End Namespace
