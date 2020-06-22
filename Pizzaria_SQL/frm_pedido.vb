Public Class frm_pedido
    Private Sub frm_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_pizzas()
        carregar_lbl_cliente()
        carregar_qtd()
        carregar_pedidos()
    End Sub
    'ADICIONAR PIZZA AO PEDIDO
    Private Sub btn_add_pizza_Click(sender As Object, e As EventArgs) Handles btn_add_pizza.Click
        Try
            sql = "insert into tb_frm_pedido  values ('" & cmb_pizzas.Text & "' , '" & cmb_qtd.Text & "')"
            db.Execute(UCase(sql))
            ' MsgBox("Item Adicionado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso!")
            carregar_pedidos()
            cmb_pizzas.Select()
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    'EMITIR PEDIDO
    Private Sub btn_emitir_pedido_Click(sender As Object, e As EventArgs) Handles btn_emitir_pedido.Click
        Try
            sqx = "truncate table tb_frm_pedido "
            db.Execute(sqx)
            MsgBox("Pedido realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    'EXCLUIR PIZZA DO PEDIDO
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedido.CellContentClick
        Try
            With dgv_pedido
                aux = .CurrentRow.Cells(1).Value
                If .CurrentRow.Cells(2).Selected = True Then
                    'resp = MsgBox("Deseja realmente excluir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                    'If resp = MsgBoxResult.Yes Then
                    sql = "delete from tb_frm_pedido where sabor = '" & aux & "'"
                    rs = db.Execute(sql)
                    'MsgBox("Pizza excluída", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
                    carregar_pedidos()
                    'End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Private Sub cmb_qtd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_qtd.SelectedIndexChanged
        btn_add_pizza.Select()
    End Sub

    Private Sub cmb_pizzas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_pizzas.SelectedIndexChanged
        btn_add_pizza.Select()
    End Sub
End Class