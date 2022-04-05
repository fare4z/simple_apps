<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Chapter3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaseStatementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEnter.Location = New System.Drawing.Point(15, 71)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(136, 21)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter your name : "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(157, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(232, 29)
        Me.txtName.TabIndex = 1
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(157, 103)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(75, 23)
        Me.btnClick.TabIndex = 2
        Me.btnClick.Text = "Click Here"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOutput.Location = New System.Drawing.Point(15, 162)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(62, 22)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Result : "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Chapter3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(418, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Chapter3ToolStripMenuItem
        '
        Me.Chapter3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaseStatementToolStripMenuItem, Me.LoopToolStripMenuItem, Me.ArrayToolStripMenuItem})
        Me.Chapter3ToolStripMenuItem.Name = "Chapter3ToolStripMenuItem"
        Me.Chapter3ToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.Chapter3ToolStripMenuItem.Text = "Chapter 3"
        '
        'CaseStatementToolStripMenuItem
        '
        Me.CaseStatementToolStripMenuItem.Name = "CaseStatementToolStripMenuItem"
        Me.CaseStatementToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CaseStatementToolStripMenuItem.Text = "Case Statement"
        '
        'LoopToolStripMenuItem
        '
        Me.LoopToolStripMenuItem.Name = "LoopToolStripMenuItem"
        Me.LoopToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoopToolStripMenuItem.Text = "Do Loop"
        '
        'ArrayToolStripMenuItem
        '
        Me.ArrayToolStripMenuItem.Name = "ArrayToolStripMenuItem"
        Me.ArrayToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArrayToolStripMenuItem.Text = "Array"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 330)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Input box"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnter As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnClick As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Chapter3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaseStatementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrayToolStripMenuItem As ToolStripMenuItem
End Class
