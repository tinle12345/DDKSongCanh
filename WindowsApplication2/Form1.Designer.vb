<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.oklb = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ronglb = New System.Windows.Forms.Label()
        Me.dailb = New System.Windows.Forms.Label()
        Me.daylb = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.same = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'oklb
        '
        Me.oklb.BackColor = System.Drawing.Color.Lime
        Me.oklb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oklb.Location = New System.Drawing.Point(85, 324)
        Me.oklb.Name = "oklb"
        Me.oklb.Size = New System.Drawing.Size(250, 100)
        Me.oklb.TabIndex = 27
        Me.oklb.Text = "KHÁC KHỔ"
        Me.oklb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(891, 381)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 41)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Hủy Kết Nối"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(792, 39)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "CHƯƠNG TRÌNH ĐIỀU KHIỂN MÁY SONG CẠNH"
        '
        'ronglb
        '
        Me.ronglb.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ronglb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ronglb.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ronglb.Location = New System.Drawing.Point(811, 158)
        Me.ronglb.Name = "ronglb"
        Me.ronglb.Size = New System.Drawing.Size(300, 130)
        Me.ronglb.TabIndex = 23
        Me.ronglb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dailb
        '
        Me.dailb.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dailb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dailb.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailb.Location = New System.Drawing.Point(427, 158)
        Me.dailb.Name = "dailb"
        Me.dailb.Size = New System.Drawing.Size(300, 130)
        Me.dailb.TabIndex = 22
        Me.dailb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'daylb
        '
        Me.daylb.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.daylb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.daylb.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daylb.Location = New System.Drawing.Point(87, 158)
        Me.daylb.Name = "daylb"
        Me.daylb.Size = New System.Drawing.Size(250, 130)
        Me.daylb.TabIndex = 21
        Me.daylb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(872, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 37)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Chiều Rộng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(500, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 37)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Chiều Dài"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 37)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Độ Dày"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(907, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 41)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Kết Nối"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'same
        '
        Me.same.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.same.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.same.Location = New System.Drawing.Point(428, 324)
        Me.same.Name = "same"
        Me.same.Size = New System.Drawing.Size(300, 100)
        Me.same.TabIndex = 28
        Me.same.Text = "CÙNG KHỔ"
        Me.same.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 455)
        Me.Controls.Add(Me.same)
        Me.Controls.Add(Me.oklb)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ronglb)
        Me.Controls.Add(Me.dailb)
        Me.Controls.Add(Me.daylb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents oklb As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ronglb As System.Windows.Forms.Label
    Friend WithEvents dailb As System.Windows.Forms.Label
    Friend WithEvents daylb As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents same As System.Windows.Forms.Label

End Class
