Public Class criar_contas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txt_senha.Text <> txt_repetir.Text Then
                MsgBox("Senhas não conferem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso!")
                Exit Sub
            End If
            If txt_nome.Text = "" Or
               txt_senha.Text = "" Or
               txt_repetir.Text = "" Or
               txt_email.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If

            ' ATUALIZAR DADOS
            sql = " select * from tb_usuario where nome = '" & txt_nome.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = " update tb_usuario set senha= '" & txt_senha.Text & "' , " &
                                             "perfil='" & txt_perfil.Text & "', " &
                                             "status='" & txt_status.Text & "', " &
                                             "email='" & txt_email.Text & "'
                                        where nome = '" & txt_nome.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
                Me.Hide()
                carregar_dados()

                ' GRAVAR NOVO CADASTRO
            Else
                sql = "insert into tb_usuario values ( '" & txt_nome.Text & "', " &
                                                       "'" & txt_senha.Text & "' , " &
                                                       "'" & txt_perfil.Text & "' ," &
                                                       "'" & txt_status.Text & "' ," &
                                                       "'" & txt_email.Text & "' )"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro realizado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
                Me.Hide()
                carregar_dados()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub
    Private Sub criar_contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tipo()
    End Sub
    Private Sub chk_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_senha.CheckedChanged
        If chk_senha.Checked = True Then
            txt_senha.PasswordChar = ""
            txt_repetir.PasswordChar = ""
        Else
            txt_senha.PasswordChar = "x"
            txt_repetir.PasswordChar = "x"
        End If
    End Sub

End Class