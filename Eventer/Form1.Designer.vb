<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnTestClick = New System.Windows.Forms.Button()
        Me.Lenny = New System.Windows.Forms.TextBox()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnminimizar = New System.Windows.Forms.Button()
        Me.PanelSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTestClick
        '
        Me.btnTestClick.Font = New System.Drawing.Font("Magneto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestClick.Location = New System.Drawing.Point(150, 91)
        Me.btnTestClick.Name = "btnTestClick"
        Me.btnTestClick.Size = New System.Drawing.Size(266, 92)
        Me.btnTestClick.TabIndex = 0
        Me.btnTestClick.Text = "Test Click"
        Me.btnTestClick.UseVisualStyleBackColor = True
        '
        'Lenny
        '
        Me.Lenny.Font = New System.Drawing.Font("Ebrima", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lenny.Location = New System.Drawing.Point(99, 203)
        Me.Lenny.Multiline = True
        Me.Lenny.Name = "Lenny"
        Me.Lenny.Size = New System.Drawing.Size(358, 198)
        Me.Lenny.TabIndex = 1
        Me.Lenny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.DimGray
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Controls.Add(Me.btncerrar)
        Me.PanelSuperior.Controls.Add(Me.btnminimizar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(585, 56)
        Me.PanelSuperior.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EventTester"
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderSize = 0
        Me.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.Location = New System.Drawing.Point(520, 0)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(65, 56)
        Me.btncerrar.TabIndex = 1
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnminimizar
        '
        Me.btnminimizar.FlatAppearance.BorderSize = 0
        Me.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimizar.Image = Global.Eventer.My.Resources.Resources._211863_minus_round_icon
        Me.btnminimizar.Location = New System.Drawing.Point(451, 0)
        Me.btnminimizar.Name = "btnminimizar"
        Me.btnminimizar.Size = New System.Drawing.Size(65, 56)
        Me.btnminimizar.TabIndex = 0
        Me.btnminimizar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(585, 429)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Controls.Add(Me.Lenny)
        Me.Controls.Add(Me.btnTestClick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTestClick As Button
    Friend WithEvents Lenny As TextBox
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btncerrar As Button
    Friend WithEvents btnminimizar As Button
    Friend WithEvents Label1 As Label
End Class
