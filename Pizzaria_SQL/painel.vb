Public Class painel
    Private Sub painel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
        carregar_parametro()
        mostrar_usuario()
        txt_busca_painel.Select()
    End Sub
    Private Sub btn_criar_conta_Click(sender As Object, e As EventArgs) Handles btn_criar_conta.Click
        With criar_contas
            .Show()
            .txt_nome.Text = ""
            .txt_repetir.Text = ""
            .txt_senha.Text = ""
            .txt_email.Text = ""
        End With
    End Sub
    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            aux = .CurrentRow.Cells(0).Value

            ' BLOQUEAR CONTA 
            If .CurrentRow.Cells(5).Selected = True Then
                resp = MsgBox("Deseja realmente BLOQUEAR" + vbNewLine &
                                  "a conta de: " & aux & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                If resp = MsgBoxResult.Yes Then
                    sql = " select * from tb_usuario where nome = '" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        ativar = "bloqueada"
                        sql = " update tb_usuario set status = '" & ativar & "' 
                                        where nome = '" & aux & "'"
                        rs = db.Execute(UCase(sql))
                        ' MsgBox("Conta BLOQUEADA", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
                        carregar_dados()
                    End If
                End If

                ' ATIVAR CONTA
            ElseIf .CurrentRow.Cells(6).Selected = True Then
                resp = MsgBox("Deseja realmente ATIVAR" + vbNewLine &
                                  "a conta de: " & aux & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                If resp = MsgBoxResult.Yes Then
                    sql = " select * from tb_usuario where nome = '" & aux & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        ativar = "ativa"
                        sql = " update tb_usuario set status = '" & ativar & "' 
                                        where nome = '" & aux & "'"
                        rs = db.Execute(UCase(sql))
                        '  MsgBox("Conta ATIVA", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
                        carregar_dados()
                    End If
                End If

                ' EDITAR CONTA
            ElseIf .CurrentRow.Cells(7).Selected = True Then
                sql = "select * from tb_usuario where nome= '" & aux & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    criar_contas.Show()
                    With criar_contas
                        .txt_nome.Text = rs.Fields(0).Value
                        .txt_email.Text = rs.Fields(4).Value
                        .txt_perfil.Text = rs.Fields(2).Value
                        .txt_repetir.Text = rs.Fields(1).Value
                        .txt_senha.Text = rs.Fields(1).Value
                        .txt_status.Text = rs.Fields(3).Value
                    End With
                End If

                ' EXCLUIR CONTA
            ElseIf .CurrentRow.Cells(8).Selected = True Then
                resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                              "a conta de: " & aux & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_usuario where nome = '" & aux & "'"
                    rs = db.Execute(sql)
                    ' MsgBox("Conta excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
                    carregar_dados()
                End If
            End If
        End With
    End Sub

    Private Sub txt_busca_painel_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_painel.TextChanged
        With dgv_dados
            sql = "select * from tb_usuario where " & txt_parametro.Text & " like '" & txt_busca_painel.Text & "%' "
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value,
                          rs.Fields(4).Value,
                          rs.Fields(1).Value,
                          rs.Fields(2).Value,
                          rs.Fields(3).Value,
                          Nothing, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub
    Private Sub painel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With main
            .Show()
            .txt_usuario.Select()
            .txt_usuario.Text = ""
            .txt_senha.Text = ""
            .CheckBox1.Checked = False
        End With
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        tela_main.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_pizza.Show()
    End Sub
End Class