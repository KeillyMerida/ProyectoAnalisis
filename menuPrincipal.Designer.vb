<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CrearUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaContableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasPorPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logout = New System.Windows.Forms.Label()
        Me.nombreUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuarioToolStripMenuItem, Me.BancoToolStripMenuItem, Me.SistemaContableToolStripMenuItem, Me.TransaccionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1059, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CrearUsuarioToolStripMenuItem
        '
        Me.CrearUsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuarioToolStripMenuItem1, Me.ModificarUsuarioToolStripMenuItem, Me.EliminarUsuarioToolStripMenuItem})
        Me.CrearUsuarioToolStripMenuItem.Name = "CrearUsuarioToolStripMenuItem"
        Me.CrearUsuarioToolStripMenuItem.Size = New System.Drawing.Size(179, 31)
        Me.CrearUsuarioToolStripMenuItem.Text = "Crear Usuario"
        '
        'CrearUsuarioToolStripMenuItem1
        '
        Me.CrearUsuarioToolStripMenuItem1.Name = "CrearUsuarioToolStripMenuItem1"
        Me.CrearUsuarioToolStripMenuItem1.Size = New System.Drawing.Size(298, 32)
        Me.CrearUsuarioToolStripMenuItem1.Text = "Crear Usuario"
        '
        'ModificarUsuarioToolStripMenuItem
        '
        Me.ModificarUsuarioToolStripMenuItem.Name = "ModificarUsuarioToolStripMenuItem"
        Me.ModificarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.ModificarUsuarioToolStripMenuItem.Text = "Modificar Usuario"
        '
        'EliminarUsuarioToolStripMenuItem
        '
        Me.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem"
        Me.EliminarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(298, 32)
        Me.EliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario"
        '
        'BancoToolStripMenuItem
        '
        Me.BancoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearCuentasToolStripMenuItem, Me.VerCuentasToolStripMenuItem})
        Me.BancoToolStripMenuItem.Name = "BancoToolStripMenuItem"
        Me.BancoToolStripMenuItem.Size = New System.Drawing.Size(99, 31)
        Me.BancoToolStripMenuItem.Text = "Banco"
        '
        'CrearCuentasToolStripMenuItem
        '
        Me.CrearCuentasToolStripMenuItem.Name = "CrearCuentasToolStripMenuItem"
        Me.CrearCuentasToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.CrearCuentasToolStripMenuItem.Text = "Crear cuentas"
        '
        'VerCuentasToolStripMenuItem
        '
        Me.VerCuentasToolStripMenuItem.Name = "VerCuentasToolStripMenuItem"
        Me.VerCuentasToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.VerCuentasToolStripMenuItem.Text = "Ver Cuentas"
        '
        'SistemaContableToolStripMenuItem
        '
        Me.SistemaContableToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuentasPorPagarToolStripMenuItem, Me.CuentasPorCobrarToolStripMenuItem})
        Me.SistemaContableToolStripMenuItem.Name = "SistemaContableToolStripMenuItem"
        Me.SistemaContableToolStripMenuItem.Size = New System.Drawing.Size(228, 31)
        Me.SistemaContableToolStripMenuItem.Text = "Sistema Contable"
        '
        'CuentasPorPagarToolStripMenuItem
        '
        Me.CuentasPorPagarToolStripMenuItem.Name = "CuentasPorPagarToolStripMenuItem"
        Me.CuentasPorPagarToolStripMenuItem.Size = New System.Drawing.Size(319, 32)
        Me.CuentasPorPagarToolStripMenuItem.Text = "Cuentas por pagar"
        '
        'CuentasPorCobrarToolStripMenuItem
        '
        Me.CuentasPorCobrarToolStripMenuItem.Name = "CuentasPorCobrarToolStripMenuItem"
        Me.CuentasPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(319, 32)
        Me.CuentasPorCobrarToolStripMenuItem.Text = "Cuentas por cobrar"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(188, 31)
        Me.TransaccionesToolStripMenuItem.Text = "Transacciones"
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.Location = New System.Drawing.Point(890, 3)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(159, 27)
        Me.logout.TabIndex = 2
        Me.logout.Text = "Cerrar Sesion"
        '
        'nombreUsuario
        '
        Me.nombreUsuario.AutoSize = True
        Me.nombreUsuario.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreUsuario.Location = New System.Drawing.Point(12, 66)
        Me.nombreUsuario.Name = "nombreUsuario"
        Me.nombreUsuario.Size = New System.Drawing.Size(0, 39)
        Me.nombreUsuario.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(218, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 39)
        Me.Label2.TabIndex = 4
        '
        'menuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto.My.Resources.Resources.LIBERTY
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1059, 586)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombreUsuario)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menuPrincipal"
        Me.Text = "menuPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BancoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemaContableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasPorPagarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasPorCobrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents logout As Label
    Friend WithEvents nombreUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CrearUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUsuarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ModificarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUsuarioToolStripMenuItem As ToolStripMenuItem
End Class
