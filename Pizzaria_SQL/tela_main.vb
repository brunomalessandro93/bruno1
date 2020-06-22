Public Class tela_main
    Private Sub btn_novo_cadastro_Click(sender As Object, e As EventArgs) Handles btn_novo_cadastro.Click
        With frm_cliente
            .Show()
            .txt_nome_cliente.Text = ""
            .txt_bairro.Text = ""
            .txt_cep.Text = ""
            .txt_cidade.Text = ""
            .txt_comp.Text = ""
            .txt_telefone.Text = ""
            .txt_endereco.Text = ""

        End With
    End Sub
    Private Sub tela_main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        With main
            .Show()
            .txt_usuario.Select()
            .txt_senha.Text = ""
            .txt_usuario.Text = ""
            .CheckBox1.Checked = False
        End With
    End Sub

    Private Sub tela_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_usuario()
        carregar_clientes()
        txt_buscar_telefone.Select()

    End Sub

    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        With dgv_clientes
            aux = .CurrentRow.Cells(0).Value
            aux_nome = .CurrentRow.Cells(1).Value
            If .CurrentRow.Cells(4).Selected = True Then
                frm_pedido.Show()
                carregar_pedidos()
            ElseIf .CurrentRow.Cells(5).Selected = True Then
                sql = "select * from tb_clientes where telefone = '" & aux & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    frm_cliente.Show()
                    With frm_cliente
                        .txt_telefone.Text = aux
                        .txt_nome_cliente.Text = rs.Fields(1).Value
                        .txt_bairro.Text = rs.Fields(5).Value
                        .txt_cep.Text = rs.Fields(2).Value
                        .txt_cidade.Text = rs.Fields(6).Value
                        .txt_comp.Text = rs.Fields(4).Value
                        .txt_endereco.Text = rs.Fields(3).Value
                    End With
                End If

            ElseIf .CurrentRow.Cells(6).Selected = True Then
                resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                              "a conta de: " & aux_nome & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_clientes where telefone = '" & aux & "'"
                    rs = db.Execute(sql)
                    'MsgBox("Conta excluída com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
                    carregar_clientes()
                End If
            End If


        End With
    End Sub

    Private Sub txt_busca_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_cliente.TextChanged
        With dgv_clientes
            sql = "select * from tb_clientes where nome like '" & txt_busca_cliente.Text & "%' "
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value,
                          rs.Fields(1).Value,
                          rs.Fields(3).Value,
                          rs.Fields(4).Value,
                          Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub
    Private Sub txt_buscar_telefone_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_telefone.TextChanged
        With dgv_clientes
            sql = "select * from tb_clientes where telefone like '" & txt_buscar_telefone.Text & "%' "
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value,
                          rs.Fields(1).Value,
                          rs.Fields(3).Value,
                          rs.Fields(4).Value,
                          Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

End Class