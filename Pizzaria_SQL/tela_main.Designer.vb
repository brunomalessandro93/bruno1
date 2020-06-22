<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tela_main
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tela_main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_busca_cliente = New System.Windows.Forms.TextBox()
        Me.btn_novo_cadastro = New System.Windows.Forms.Button()
        Me.btn_pedidos_andamento = New System.Windows.Forms.Button()
        Me.lbl_login_tela_main = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_buscar_telefone = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLIENTES"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column7, Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_clientes.Location = New System.Drawing.Point(0, 0)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersWidth = 51
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.Size = New System.Drawing.Size(1126, 540)
        Me.dgv_clientes.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "TELEFONE"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 110
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 78
        '
        'Column3
        '
        Me.Column3.HeaderText = "ENDEREÇO"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 114
        '
        'Column7
        '
        Me.Column7.HeaderText = "COMPLEMENTO"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 144
        '
        'Column4
        '
        Me.Column4.HeaderText = "NOVO PEDIDO"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "EDITAR DADOS"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 105
        '
        'Column6
        '
        Me.Column6.HeaderText = "EXCLUIR CADASTRO"
        Me.Column6.Image = CType(resources.GetObject("Column6.Image"), System.Drawing.Image)
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 137
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 443)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOME: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "TELEFONE: "
        '
        'txt_busca_cliente
        '
        Me.txt_busca_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busca_cliente.Location = New System.Drawing.Point(108, 440)
        Me.txt_busca_cliente.Name = "txt_busca_cliente"
        Me.txt_busca_cliente.Size = New System.Drawing.Size(368, 30)
        Me.txt_busca_cliente.TabIndex = 4
        '
        'btn_novo_cadastro
        '
        Me.btn_novo_cadastro.AutoSize = True
        Me.btn_novo_cadastro.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_novo_cadastro.Location = New System.Drawing.Point(482, 400)
        Me.btn_novo_cadastro.Name = "btn_novo_cadastro"
        Me.btn_novo_cadastro.Size = New System.Drawing.Size(176, 70)
        Me.btn_novo_cadastro.TabIndex = 6
        Me.btn_novo_cadastro.Text = "NOVO CADASTRO"
        Me.btn_novo_cadastro.UseVisualStyleBackColor = True
        '
        'btn_pedidos_andamento
        '
        Me.btn_pedidos_andamento.AutoSize = True
        Me.btn_pedidos_andamento.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pedidos_andamento.Location = New System.Drawing.Point(681, 400)
        Me.btn_pedidos_andamento.Name = "btn_pedidos_andamento"
        Me.btn_pedidos_andamento.Size = New System.Drawing.Size(253, 70)
        Me.btn_pedidos_andamento.TabIndex = 7
        Me.btn_pedidos_andamento.Text = "PEDIDOS EM ANDAMENTO"
        Me.btn_pedidos_andamento.UseVisualStyleBackColor = True
        '
        'lbl_login_tela_main
        '
        Me.lbl_login_tela_main.AutoSize = True
        Me.lbl_login_tela_main.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_tela_main.Location = New System.Drawing.Point(637, 488)
        Me.lbl_login_tela_main.Name = "lbl_login_tela_main"
        Me.lbl_login_tela_main.Size = New System.Drawing.Size(78, 27)
        Me.lbl_login_tela_main.TabIndex = 8
        Me.lbl_login_tela_main.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(552, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Log-in:"
        '
        'txt_buscar_telefone
        '
        Me.txt_buscar_telefone.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar_telefone.Location = New System.Drawing.Point(143, 400)
        Me.txt_buscar_telefone.Name = "txt_buscar_telefone"
        Me.txt_buscar_telefone.Size = New System.Drawing.Size(333, 34)
        Me.txt_buscar_telefone.TabIndex = 10
        '
        'tela_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 544)
        Me.Controls.Add(Me.txt_buscar_telefone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_login_tela_main)
        Me.Controls.Add(Me.btn_pedidos_andamento)
        Me.Controls.Add(Me.btn_novo_cadastro)
        Me.Controls.Add(Me.txt_busca_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tela_main"
        Me.Text = "PEDIDOS"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_busca_cliente As TextBox
    Friend WithEvents btn_novo_cadastro As Button
    Friend WithEvents btn_pedidos_andamento As Button
    Friend WithEvents lbl_login_tela_main As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents txt_buscar_telefone As MaskedTextBox
End Class
