Module Module1

    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public cont As Integer


    Public sql, sqx, ativar, Status, aux, aux_nome, resp As String

    'CONECTAR COM SQL-SERVER
    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.connection")
            db.Open("Provider = SQLOLEDB;Data Source= LAPTOP-F9R7ORS0; Initial Catalog = pizzaria; trusted_connection=yes;")
            '  MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    'ITENS DO FORMULARIO DE CRIAR CONTAS DE USUARIOS 
    Sub carregar_tipo()
        With criar_contas.txt_perfil.Items
            .Add("ADMINISTRADOR")
            .Add("USUARIO")
        End With
        criar_contas.txt_perfil.SelectedIndex = 1

        With criar_contas.txt_status.Items
            .Add("ATIVA")
            .Add("BLOQUEADA")
        End With
        criar_contas.txt_status.SelectedIndex = 0
    End Sub

    'DATA-GRID-VIEW DO PAINEL DE USUARIOS
    Sub carregar_dados()
        With painel.dgv_dados
            sql = "select * from tb_usuario order by nome asc "
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

    'COMBO-BOX DE BUSCA NO PAINEL DE USUARIOS
    Sub carregar_parametro()
        With painel.txt_parametro.Items
            .Add("Nome")
            .Add("Email")
        End With
        painel.txt_parametro.SelectedIndex = 0
    End Sub

    'EXIBIR USUARIO NA LABEL 
    Sub mostrar_usuario()
        tela_main.lbl_login_tela_main.Text = main.txt_usuario.Text
        painel.lbl_usuario.Text = main.txt_usuario.Text
    End Sub

    'DATA-GRID-VIEW DE CLIENTES
    Sub carregar_clientes()
        With tela_main.dgv_clientes
            sql = "select * from tb_clientes order by nome asc "
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

    'PIZZAS DO BANCO NO COMBO-BOX DO FORMULÁRIO DE PEDIDOS
    Sub carregar_pizzas()
        With frm_pedido.cmb_pizzas.Items
            sql = "select sabor from tb_pizza"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Add(rs.Fields(0).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    'CARREGA NOME E TELEFONE DO DATA-GRID-VIEW DE CLIENTES -> PARA O FORMULÁRIO DE PEDIDOS
    Sub carregar_lbl_cliente()
        frm_pedido.lbl_cliente.Text = tela_main.dgv_clientes.CurrentRow.Cells(1).Value
        frm_pedido.lbl_telefone.Text = tela_main.dgv_clientes.CurrentRow.Cells(0).Value
    End Sub

    'COMBO-BOX: QUANTIDADE DE PIZZAS (FORMULÁRIO DE PEDIDOS)
    Sub carregar_qtd()
        With frm_pedido.cmb_qtd.Items
            .Add("1/2")
            .Add("1")
            .Add("2")
            .Add("3")
            .Add("4")
            .Add("5")
            .Add("6")
            .Add("7")
            .Add("8")
            .Add("9")
            .Add("10")
            frm_pedido.cmb_qtd.SelectedIndex = 1
        End With
    End Sub

    'DATA-GRID-VIEW DO FORMULÁRIO DE PEDIDOS
    Sub carregar_pedidos()
        With frm_pedido.dgv_pedido
            .Rows.Clear()
            sql = "select * from tb_frm_pedido order by qtd asc "
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value,
                          rs.Fields(0).Value,
                           Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    'VERIFICAR SENHA NO FORMULÁRIO DE LOGIN
    Sub verificar_senha()
        ativar = "ativa"
        Status = "administrador"
        sql = " select * from tb_usuario where nome = '" & main.txt_usuario.Text & "'
                                            and senha = '" & main.txt_senha.Text & "'
                                            and status = '" & ativar & "'
                                            and perfil = '" & Status & "' "
        rs = db.Execute(sql)
        If rs.EOF = False Then
            main.btn_gerenciar.Show()
            main.btn_gerenciar.Select()
        Else
            main.btn_gerenciar.Visible = False
        End If
    End Sub
End Module
