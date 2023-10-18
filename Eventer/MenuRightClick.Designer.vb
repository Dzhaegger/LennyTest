<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuRightClick
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuRightClick))
        Me.btnItem1 = New System.Windows.Forms.Button()
        Me.btnItem2 = New System.Windows.Forms.Button()
        Me.btnItem3 = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnItem1
        '
        Me.btnItem1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnItem1.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem1.Location = New System.Drawing.Point(-3, 23)
        Me.btnItem1.Name = "btnItem1"
        Me.btnItem1.Size = New System.Drawing.Size(252, 74)
        Me.btnItem1.TabIndex = 0
        Me.btnItem1.Text = "Abrir"
        Me.btnItem1.UseVisualStyleBackColor = False
        '
        'btnItem2
        '
        Me.btnItem2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnItem2.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem2.Location = New System.Drawing.Point(-3, 103)
        Me.btnItem2.Name = "btnItem2"
        Me.btnItem2.Size = New System.Drawing.Size(252, 73)
        Me.btnItem2.TabIndex = 1
        Me.btnItem2.Text = "Eliminar"
        Me.btnItem2.UseVisualStyleBackColor = False
        '
        'btnItem3
        '
        Me.btnItem3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnItem3.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem3.Location = New System.Drawing.Point(-3, 182)
        Me.btnItem3.Name = "btnItem3"
        Me.btnItem3.Size = New System.Drawing.Size(252, 64)
        Me.btnItem3.TabIndex = 2
        Me.btnItem3.Text = "Ver Propiedades"
        Me.btnItem3.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(12, 252)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(225, 43)
        Me.btncerrar.TabIndex = 3
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'MenuRightClick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(249, 307)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnItem3)
        Me.Controls.Add(Me.btnItem2)
        Me.Controls.Add(Me.btnItem1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuRightClick"
        Me.Text = "MenuRightClick"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnItem1 As Button
    Friend WithEvents btnItem2 As Button
    Friend WithEvents btnItem3 As Button
    Friend WithEvents btncerrar As Button
End Class
