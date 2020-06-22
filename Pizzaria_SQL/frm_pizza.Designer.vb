<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pizza
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nova_pizza = New System.Windows.Forms.TextBox()
        Me.btn_nova_pizza = New System.Windows.Forms.Button()
        Me.btn_excluir_pizza = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME"
        '
        'txt_nova_pizza
        '
        Me.txt_nova_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nova_pizza.Location = New System.Drawing.Point(18, 58)
        Me.txt_nova_pizza.Name = "txt_nova_pizza"
        Me.txt_nova_pizza.Size = New System.Drawing.Size(412, 34)
        Me.txt_nova_pizza.TabIndex = 1
        '
        'btn_nova_pizza
        '
        Me.btn_nova_pizza.AutoSize = True
        Me.btn_nova_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nova_pizza.Location = New System.Drawing.Point(18, 117)
        Me.btn_nova_pizza.Name = "btn_nova_pizza"
        Me.btn_nova_pizza.Size = New System.Drawing.Size(142, 37)
        Me.btn_nova_pizza.TabIndex = 2
        Me.btn_nova_pizza.Text = "ADICIONAR"
        Me.btn_nova_pizza.UseVisualStyleBackColor = True
        '
        'btn_excluir_pizza
        '
        Me.btn_excluir_pizza.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir_pizza.Location = New System.Drawing.Point(179, 117)
        Me.btn_excluir_pizza.Name = "btn_excluir_pizza"
        Me.btn_excluir_pizza.Size = New System.Drawing.Size(133, 37)
        Me.btn_excluir_pizza.TabIndex = 3
        Me.btn_excluir_pizza.Text = "EXCLUIR"
        Me.btn_excluir_pizza.UseVisualStyleBackColor = True
        '
        'frm_pizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 191)
        Me.Controls.Add(Me.btn_excluir_pizza)
        Me.Controls.Add(Me.btn_nova_pizza)
        Me.Controls.Add(Me.txt_nova_pizza)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_pizza"
        Me.Text = "NOVA PIZZA "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nova_pizza As TextBox
    Friend WithEvents btn_nova_pizza As Button
    Friend WithEvents btn_excluir_pizza As Button
End Class
