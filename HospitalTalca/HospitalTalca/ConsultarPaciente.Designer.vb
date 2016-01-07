<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarPaciente
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
        Me.PruebaDataBaseDataSet = New HospitalTalca.PruebaDataBaseDataSet()
        Me.PruebaDataBaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvPaciente = New System.Windows.Forms.DataGridView()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        CType(Me.PruebaDataBaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PruebaDataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PruebaDataBaseDataSet
        '
        Me.PruebaDataBaseDataSet.DataSetName = "PruebaDataBaseDataSet"
        Me.PruebaDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PruebaDataBaseDataSetBindingSource
        '
        Me.PruebaDataBaseDataSetBindingSource.DataSource = Me.PruebaDataBaseDataSet
        Me.PruebaDataBaseDataSetBindingSource.Position = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvPaciente)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 50)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(937, 295)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de pacientes"
        '
        'DgvPaciente
        '
        Me.DgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPaciente.Location = New System.Drawing.Point(5, 21)
        Me.DgvPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvPaciente.Name = "DgvPaciente"
        Me.DgvPaciente.RowTemplate.Height = 24
        Me.DgvPaciente.Size = New System.Drawing.Size(925, 270)
        Me.DgvPaciente.TabIndex = 0
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(413, 380)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(149, 57)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'ConsultarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 486)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ConsultarPaciente"
        Me.Text = "ConsultarPaciente"
        CType(Me.PruebaDataBaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PruebaDataBaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PruebaDataBaseDataSet As HospitalTalca.PruebaDataBaseDataSet
    Friend WithEvents PruebaDataBaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvPaciente As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
End Class
