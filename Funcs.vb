Public Class Funcs

    Public Shared Function verificaPendencia(ByVal cliente As clientesVO) As String
        Dim pendencia = ""

        If (cliente.token = 0) Or (cliente.ct_integra = 0) Then
            pendencia = "1"
        End If
        If (cliente.cert_fim.Year.Equals(1)) Then
            pendencia += "2"
        End If
        If (cliente.ct_fiscal = 0) Or IsDBNull(cliente.ipi_padrao) Then
            pendencia += "3"
        End If


        Return pendencia
    End Function

    Public Shared Function retornaTemplate(ByVal pendencia As String) As templateVO

        Dim template = New templateVO

        Select Case pendencia

            Case "1"
                'id template etapa 1
                template = templatesDao.obterTemplates(54)
            Case "2"
                'id template etapa 2
                template = templatesDao.obterTemplates(55)
            Case "3"
                'id template etapa 3
                template = templatesDao.obterTemplates(56)
            Case "12"
                'id template etapa 1 e 2
                template = templatesDao.obterTemplates(57)
            Case "13"
                'id template etapa 1 e 3
                template = templatesDao.obterTemplates(58)
            Case "23"
                'id template etapa 2 e 3
                template = templatesDao.obterTemplates(59)
            Case "123"
                'id template etapa 1, 2 e 3
                template = templatesDao.obterTemplates(60)
            Case "4"
                'id template etapa 1, 2 e 3
                template = templatesDao.obterTemplates(61)

        End Select

        Return template
    End Function
End Class
