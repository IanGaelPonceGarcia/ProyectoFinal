<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Clientes_Altas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.txt_Domicilio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_whatsapp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Descuento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Iva = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(104, 6)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(366, 22)
        Me.txt_Nombre.TabIndex = 1
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Location = New System.Drawing.Point(314, 190)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 2
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(395, 190)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 3
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'txt_Domicilio
        '
        Me.txt_Domicilio.Location = New System.Drawing.Point(104, 34)
        Me.txt_Domicilio.Name = "txt_Domicilio"
        Me.txt_Domicilio.Size = New System.Drawing.Size(366, 22)
        Me.txt_Domicilio.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Domicilio"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(104, 62)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(366, 22)
        Me.txt_Telefono.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefono"
        '
        'txt_whatsapp
        '
        Me.txt_whatsapp.Location = New System.Drawing.Point(104, 90)
        Me.txt_whatsapp.Name = "txt_whatsapp"
        Me.txt_whatsapp.Size = New System.Drawing.Size(366, 22)
        Me.txt_whatsapp.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Whatsapp"
        '
        'txt_Descuento
        '
        Me.txt_Descuento.Location = New System.Drawing.Point(104, 118)
        Me.txt_Descuento.Name = "txt_Descuento"
        Me.txt_Descuento.Size = New System.Drawing.Size(366, 22)
        Me.txt_Descuento.TabIndex = 11
        Me.txt_Descuento.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Descuento"
        '
        'txt_Iva
        '
        Me.txt_Iva.Location = New System.Drawing.Point(104, 146)
        Me.txt_Iva.Name = "txt_Iva"
        Me.txt_Iva.Size = New System.Drawing.Size(366, 22)
        Me.txt_Iva.TabIndex = 13
        Me.txt_Iva.Text = "16"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "IVA"
        '
        'frm_Clientes_Altas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 233)
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
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Clientes_Altas"
        Me.Text = "Alta de Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents txt_Domicilio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Telefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_whatsapp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Descuento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Iva As TextBox
    Friend WithEvents Label6 As Label
End Class
