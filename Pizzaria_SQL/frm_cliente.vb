Public Class frm_cliente
    Private Sub btn_cadastrar_cliente_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_cliente.Click
        Try
            If txt_bairro.Text = "" Or
               txt_cep.Text = "" Or
               txt_cidade.Text = "" Or
               txt_comp.Text = "" Or
               txt_endereco.Text = "" Or
               txt_nome_cliente.Text = "" Or
               txt_telefone.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            End If

            sql = " select * from tb_clientes where telefone = '" & txt_telefone.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = " update tb_clientes set nome= '" & txt_nome_cliente.Text & "' , " &
                                                 "cep='" & txt_cep.Text & "', " &
                                                 "endereco='" & txt_endereco.Text & "', " &
                                                 "comp='" & txt_comp.Text & "', " &
                                                 "bairro='" & txt_bairro.Text & "', " &
                                                 "cidade='" & txt_cidade.Text & "'
                                            where telefone = '" & txt_telefone.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
                Me.Hide()
                carregar_clientes()
            Else
                sql = "insert into tb_clientes values ( '" & txt_telefone.Text & "', " &
                                                       "'" & txt_nome_cliente.Text & "' , " &
                                                       "'" & txt_cep.Text & "' ," &
                                                       "'" & txt_endereco.Text & "' ," &
                                                       "'" & txt_comp.Text & "' ," &
                                                       "'" & txt_bairro.Text & "' ," &
                                                       "'" & txt_cidade.Text & "' )"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro realizado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
                Me.Hide()
                carregar_clientes()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub
    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "Select * from tb_cep where cep = '" & txt_cep.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_comp.Focus()
            Else
                MsgBox("Cep não localizado!" + vbExclamation, MsgBoxStyle.OkOnly, "Atenção!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar consulta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub
End Class