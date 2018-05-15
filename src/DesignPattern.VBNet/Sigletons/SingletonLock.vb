
Namespace DesignPattern.VBNet.Sigletons
    '雙重上鎖 VB.Net
    Public Class SingletonLock
        Private Shared instance As SingletonLock
        Private Shared ReadOnly syncRoot As Object = New Object()
        Private Sub New()
        End Sub
        Public Shared Function GetInstance() As SingletonLock
            If instance Is Nothing Then
                SyncLock syncRoot
                    If instance Is Nothing Then
                        instance = New SingletonLock()
                    End If
                End SyncLock
            End If
            Return instance
        End Function
    End Class

End Namespace
