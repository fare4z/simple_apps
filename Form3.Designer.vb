<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDisplay1D = New System.Windows.Forms.TextBox()
        Me.btnDisplay1D = New System.Windows.Forms.Button()
        Me.btnEnter1D = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(700, 89)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(302, 197)
        Me.txtDisplay.TabIndex = 0
        '
        'btnEnter
        '
        Me.btnEnter.AutoSize = True
        Me.btnEnter.Location = New System.Drawing.Point(700, 312)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(81, 25)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter Temps"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.AutoSize = True
        Me.btnDisplay.Location = New System.Drawing.Point(910, 312)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(92, 25)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Temps"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(700, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Define how many days"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(700, 389)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(302, 23)
        Me.txtDays.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(700, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dynamic Array"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kristen ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(382, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "1 Dimensional Array"
        '
        'txtDisplay1D
        '
        Me.txtDisplay1D.Location = New System.Drawing.Point(371, 89)
        Me.txtDisplay1D.Multiline = True
        Me.txtDisplay1D.Name = "txtDisplay1D"
        Me.txtDisplay1D.Size = New System.Drawing.Size(302, 197)
        Me.txtDisplay1D.TabIndex = 7
        '
        'btnDisplay1D
        '
        Me.btnDisplay1D.AutoSize = True
        Me.btnDisplay1D.Location = New System.Drawing.Point(581, 312)
        Me.btnDisplay1D.Name = "btnDisplay1D"
        Me.btnDisplay1D.Size = New System.Drawing.Size(92, 25)
        Me.btnDisplay1D.TabIndex = 9
        Me.btnDisplay1D.Text = "Display Temps"
        Me.btnDisplay1D.UseVisualStyleBackColor = True
        '
        'btnEnter1D
        '
        Me.btnEnter1D.AutoSize = True
        Me.btnEnter1D.Location = New System.Drawing.Point(371, 312)
        Me.btnEnter1D.Name = "btnEnter1D"
        Me.btnEnter1D.Size = New System.Drawing.Size(81, 25)
        Me.btnEnter1D.TabIndex = 8
        Me.btnEnter1D.Text = "Enter Temps"
        Me.btnEnter1D.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kristen ITC", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(52, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 28)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "2 Dimensional Array"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBox1.Location = New System.Drawing.Point(139, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Select month"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(52, 151)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(45, 15)
        Me.lblOutput.TabIndex = 13
        Me.lblOutput.Text = "Output"
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.Location = New System.Drawing.Point(179, 118)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(81, 25)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 470)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDisplay1D)
        Me.Controls.Add(Me.btnEnter1D)
        Me.Controls.Add(Me.txtDisplay1D)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtDisplay)
        Me.Name = "Form3"
        Me.Text = "Array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDisplay1D As TextBox
    Friend WithEvents btnDisplay1D As Button
    Friend WithEvents btnEnter1D As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnSubmit As Button
End Class
