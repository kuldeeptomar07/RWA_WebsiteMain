Imports System.Web.Mvc

Namespace Controllers
    Public Class RegisterController
        Inherits Controller

        ' GET: Register
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace