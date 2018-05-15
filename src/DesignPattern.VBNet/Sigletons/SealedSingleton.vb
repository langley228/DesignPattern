
Namespace DesignPattern.VBNet.Sigletons
    '率先實體化 VB.Net
    Public NotInheritable Class SealedSingleton
        Private Shared instance As SealedSingleton = New SealedSingleton()
        Private Sub New()
        End Sub
        Public Shared Function GetInstance() As SealedSingleton
            Return instance
        End Function
    End Class
End Namespace


