<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrnMenuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.PacienteToolStripMenuItem, Me.OtrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(603, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarPacienteToolStripMenuItem, Me.IngresarConsultaToolStripMenuItem, Me.ModificarConsultaToolStripMenuItem, Me.EliminarConsultaToolStripMenuItem})
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeConsultaToolStripMenuItem, Me.EspecialidadToolStripMenuItem})
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.OtrosToolStripMenuItem.Text = "Otros"
        '
        'ConsultarPacienteToolStripMenuItem
        '
        Me.ConsultarPacienteToolStripMenuItem.Name = "ConsultarPacienteToolStripMenuItem"
        Me.ConsultarPacienteToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.ConsultarPacienteToolStripMenuItem.Text = "Consultar Paciente"
        '
        'IngresarConsultaToolStripMenuItem
        '
        Me.IngresarConsultaToolStripMenuItem.Name = "IngresarConsultaToolStripMenuItem"
        Me.IngresarConsultaToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.IngresarConsultaToolStripMenuItem.Text = "Ingresar Consulta"
        '
        'ModificarConsultaToolStripMenuItem
        '
        Me.ModificarConsultaToolStripMenuItem.Name = "ModificarConsultaToolStripMenuItem"
        Me.ModificarConsultaToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.ModificarConsultaToolStripMenuItem.Text = "Modificar Consulta"
        '
        'EliminarConsultaToolStripMenuItem
        '
        Me.EliminarConsultaToolStripMenuItem.Name = "EliminarConsultaToolStripMenuItem"
        Me.EliminarConsultaToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.EliminarConsultaToolStripMenuItem.Text = "Eliminar Consulta"
        '
        'TipoDeConsultaToolStripMenuItem
        '
        Me.TipoDeConsultaToolStripMenuItem.Name = "TipoDeConsultaToolStripMenuItem"
        Me.TipoDeConsultaToolStripMenuItem.Size = New System.Drawing.Size(188, 24)
        Me.TipoDeConsultaToolStripMenuItem.Text = "Tipo de consulta"
        '
        'EspecialidadToolStripMenuItem
        '
        Me.EspecialidadToolStripMenuItem.Name = "EspecialidadToolStripMenuItem"
        Me.EspecialidadToolStripMenuItem.Size = New System.Drawing.Size(188, 24)
        Me.EspecialidadToolStripMenuItem.Text = "Especialidad"
        '
        'FrnMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 333)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrnMenuPrincipal"
        Me.Text = "FrnMenuPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarPacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EspecialidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
