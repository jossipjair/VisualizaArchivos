<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMostraArchivo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMostraArchivo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnMostrarArchivos = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.CboUnidades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.TmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnActualizar)
        Me.GroupBox1.Controls.Add(Me.BtnMostrarArchivos)
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.CboUnidades)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImage = Global.PryVerArchivos.My.Resources.Resources.refrescar
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnActualizar.Location = New System.Drawing.Point(268, 13)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(40, 31)
        Me.BtnActualizar.TabIndex = 1
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnMostrarArchivos
        '
        Me.BtnMostrarArchivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMostrarArchivos.Image = Global.PryVerArchivos.My.Resources.Resources._48px_Crystal_Clear_app_terminal
        Me.BtnMostrarArchivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMostrarArchivos.Location = New System.Drawing.Point(67, 55)
        Me.BtnMostrarArchivos.Name = "BtnMostrarArchivos"
        Me.BtnMostrarArchivos.Size = New System.Drawing.Size(104, 42)
        Me.BtnMostrarArchivos.TabIndex = 2
        Me.BtnMostrarArchivos.Text = "Mostrar"
        Me.BtnMostrarArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMostrarArchivos.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = Global.PryVerArchivos.My.Resources.Resources.logout
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Location = New System.Drawing.Point(177, 55)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(68, 42)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'CboUnidades
        '
        Me.CboUnidades.FormattingEnabled = True
        Me.CboUnidades.Location = New System.Drawing.Point(123, 19)
        Me.CboUnidades.MaxLength = 3
        Me.CboUnidades.Name = "CboUnidades"
        Me.CboUnidades.Size = New System.Drawing.Size(138, 21)
        Me.CboUnidades.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seleccionar Unidad:"
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Location = New System.Drawing.Point(70, 124)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(39, 13)
        Me.LblHora.TabIndex = 4
        Me.LblHora.Text = "Label2"
        '
        'TmrHora
        '
        Me.TmrHora.Enabled = True
        Me.TmrHora.Interval = 1000
        '
        'FrmMostraArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 146)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMostraArchivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MostraArchivos v3.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CboUnidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnMostrarArchivos As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents TmrHora As System.Windows.Forms.Timer

End Class
