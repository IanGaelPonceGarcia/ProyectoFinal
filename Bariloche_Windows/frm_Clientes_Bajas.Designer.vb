<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Clientes_Bajas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_Iva = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Descuento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_whatsapp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Domicilio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_ClienteID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Iva
        '
        Me.txt_Iva.Location = New System.Drawing.Point(104, 370)
        Me.txt_Iva.Name = "txt_Iva"
        Me.txt_Iva.ReadOnly = True
        Me.txt_Iva.Size = New System.Drawing.Size(366, 22)
        Me.txt_Iva.TabIndex = 27
        Me.txt_Iva.Text = "16"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "IVA"
        '
        'txt_Descuento
        '
        Me.txt_Descuento.Location = New System.Drawing.Point(104, 342)
        Me.txt_Descuento.Name = "txt_Descuento"
        Me.txt_Descuento.ReadOnly = True
        Me.txt_Descuento.Size = New System.Drawing.Size(366, 22)
        Me.txt_Descuento.TabIndex = 25
        Me.txt_Descuento.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Descuento"
        '
        'txt_whatsapp
        '
        Me.txt_whatsapp.Location = New System.Drawing.Point(104, 314)
        Me.txt_whatsapp.Name = "txt_whatsapp"
        Me.txt_whatsapp.ReadOnly = True
        Me.txt_whatsapp.Size = New System.Drawing.Size(366, 22)
        Me.txt_whatsapp.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Whatsapp"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(104, 286)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.ReadOnly = True
        Me.txt_Telefono.Size = New System.Drawing.Size(366, 22)
        Me.txt_Telefono.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Telefono"
        '
        'txt_Domicilio
        '
        Me.txt_Domicilio.Location = New System.Drawing.Point(104, 258)
        Me.txt_Domicilio.Name = "txt_Domicilio"
        Me.txt_Domicilio.ReadOnly = True
        Me.txt_Domicilio.Size = New System.Drawing.Size(366, 22)
        Me.txt_Domicilio.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Domicilio"
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(395, 414)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 17
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(314, 414)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 16
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(104, 230)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(366, 22)
        Me.txt_Nombre.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(776, 150)
        Me.DataGridView1.TabIndex = 28
        '
        'txt_ClienteID
        '
        Me.txt_ClienteID.Location = New System.Drawing.Point(104, 202)
        Me.txt_ClienteID.Name = "txt_ClienteID"
        Me.txt_ClienteID.ReadOnly = True
        Me.txt_ClienteID.Size = New System.Drawing.Size(366, 22)
        Me.txt_ClienteID.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "ClienteID"
        '
        'frm_Clientes_Bajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_ClienteID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_Iva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Descuento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_whatsapp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Telefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Domicilio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Clientes_Bajas"
        Me.Text = "frm_Clientes_Bajas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Iva As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Descuento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_whatsapp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Telefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Domicilio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_ClienteID As TextBox
    Friend WithEvents Label7 As Label
End Class
