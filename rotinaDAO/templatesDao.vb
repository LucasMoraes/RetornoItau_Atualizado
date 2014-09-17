Imports retornoItau

Public Class templatesDao

    Public Shared Function obterTemplates(ByVal id As Integer) As templateVO
        Dim ht As New Hashtable
        ht.Add("id", id)

        Return IBatis.Instance.QueryForObject("obtertemplates", ht)

    End Function

End Class
