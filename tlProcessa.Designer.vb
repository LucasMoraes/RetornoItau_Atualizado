﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tlProcessa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnProcBoleto = New System.Windows.Forms.Button()
        Me.btnProcRetorno = New System.Windows.Forms.Button()
        Me.btnParaProc = New System.Windows.Forms.Button()
        Me.btnProcRotina = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProcBoleto
        '
        Me.btnProcBoleto.Location = New System.Drawing.Point(92, 12)
        Me.btnProcBoleto.Name = "btnProcBoleto"
        Me.btnProcBoleto.Size = New System.Drawing.Size(72, 35)
        Me.btnProcBoleto.TabIndex = 0
        Me.btnProcBoleto.Text = "Processar Boleto"
        Me.btnProcBoleto.UseVisualStyleBackColor = True
        '
        'btnProcRetorno
        '
        Me.btnProcRetorno.Location = New System.Drawing.Point(14, 12)
        Me.btnProcRetorno.Name = "btnProcRetorno"
        Me.btnProcRetorno.Size = New System.Drawing.Size(72, 35)
        Me.btnProcRetorno.TabIndex = 1
        Me.btnProcRetorno.Text = "Processar Franquias"
        Me.btnProcRetorno.UseVisualStyleBackColor = True
        '
        'btnParaProc
        '
        Me.btnParaProc.Location = New System.Drawing.Point(170, 53)
        Me.btnParaProc.Name = "btnParaProc"
        Me.btnParaProc.Size = New System.Drawing.Size(72, 35)
        Me.btnParaProc.TabIndex = 2
        Me.btnParaProc.Text = "Iniciar Processos"
        Me.btnParaProc.UseVisualStyleBackColor = True
        '
        'btnProcRotina
        '
        Me.btnProcRotina.Location = New System.Drawing.Point(170, 12)
        Me.btnProcRotina.Name = "btnProcRotina"
        Me.btnProcRotina.Size = New System.Drawing.Size(72, 35)
        Me.btnProcRotina.TabIndex = 3
        Me.btnProcRotina.Text = "Processar Rotina Bkp"
        Me.btnProcRotina.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Notificar Trials"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tlProcessa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 122)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnProcRotina)
        Me.Controls.Add(Me.btnParaProc)
        Me.Controls.Add(Me.btnProcRetorno)
        Me.Controls.Add(Me.btnProcBoleto)
        Me.Name = "tlProcessa"
        Me.Text = "Processamentos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProcBoleto As System.Windows.Forms.Button
    Friend WithEvents btnProcRetorno As System.Windows.Forms.Button
    Friend WithEvents btnParaProc As System.Windows.Forms.Button
    Friend WithEvents btnProcRotina As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
