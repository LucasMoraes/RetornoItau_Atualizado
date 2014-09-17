Public Class clientesVO

    Private _idEmpresa, _ct_fiscal, _ct_integra, _idLogin, _idRelLogin As Integer
    Private _cnpj, _nomeEmp, _token, _nomeUser, _sobrenome, _email, _ipi_padrao As String

    Private _cert_fim, _data_inc As Date


    Public Property idEmpresa() As Integer
        Get
            Return _idEmpresa
        End Get
        Set(ByVal value As Integer)
            _idEmpresa = value
        End Set
    End Property

    Public Property ct_fiscal() As Integer
        Get
            Return _ct_fiscal
        End Get
        Set(ByVal value As Integer)
            _ct_fiscal = value
        End Set
    End Property

    Public Property ct_integra() As Integer
        Get
            Return _ct_integra
        End Get
        Set(ByVal value As Integer)
            _ct_integra = value
        End Set
    End Property


    Public Property idLogin() As Integer
        Get
            Return _idLogin
        End Get
        Set(ByVal value As Integer)
            _idLogin = value
        End Set
    End Property

    Public Property idRelLogin() As Integer
        Get
            Return _idRelLogin
        End Get
        Set(ByVal value As Integer)
            _idRelLogin = value
        End Set
    End Property

    Public Property cnpj() As String
        Get
            Return _cnpj
        End Get
        Set(ByVal value As String)
            _cnpj = value
        End Set
    End Property

    Public Property nomeEmp() As String
        Get
            Return _nomeEmp
        End Get
        Set(ByVal value As String)
            _nomeEmp = value
        End Set
    End Property

    Public Property token() As String
        Get
            Return _token
        End Get
        Set(ByVal value As String)
            _token = value
        End Set
    End Property

    Public Property nomeUser() As String
        Get
            Return _nomeUser
        End Get
        Set(ByVal value As String)
            _nomeUser = value
        End Set
    End Property

    Public Property sobrenome() As String
        Get
            Return _sobrenome
        End Get
        Set(ByVal value As String)
            _sobrenome = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property ipi_padrao() As String
        Get
            Return _ipi_padrao
        End Get
        Set(ByVal value As String)
            _ipi_padrao = value
        End Set
    End Property

    Public Property cert_fim() As Date
        Get
            Return _cert_fim
        End Get
        Set(ByVal value As Date)
            _cert_fim = value
        End Set
    End Property

    Public Property data_inc() As Date
        Get
            Return _data_inc
        End Get
        Set(ByVal value As Date)
            _data_inc = value
        End Set
    End Property

End Class
