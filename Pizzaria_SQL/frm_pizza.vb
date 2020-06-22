Public Class frm_pizza
    Private Sub btn_nova_pizza_Click(sender As Object, e As EventArgs) Handles btn_nova_pizza.Click
        Try
            sql = "insert into tb_pizza values ( '" & txt_nova_pizza.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Cadastro realizado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
            txt_nova_pizza.Focus()
            txt_nova_pizza.Clear()
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Private Sub btn_excluir_pizza_Click(sender As Object, e As EventArgs) Handles btn_excluir_pizza.Click
        Try
            sql = "delete from tb_pizza where sabor = '" & txt_nova_pizza.Text & "'"
            rs = db.Execute(sql)
            MsgBox("Pizza excluída", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, " Aviso")
            txt_nova_pizza.Focus()
            txt_nova_pizza.Clear()
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub
End Class