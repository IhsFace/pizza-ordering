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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        rbnXLarge = New RadioButton()
        rbnLarge = New RadioButton()
        rbnMedium = New RadioButton()
        rbnSmall = New RadioButton()
        cbxPizzas = New ComboBox()
        chxDelivery = New CheckBox()
        btnOrder = New Button()
        btnReset = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(116, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(581, 71)
        Label1.TabIndex = 0
        Label1.Text = "PAPPA JOE'S PIZZAS"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbnXLarge)
        GroupBox1.Controls.Add(rbnLarge)
        GroupBox1.Controls.Add(rbnMedium)
        GroupBox1.Controls.Add(rbnSmall)
        GroupBox1.Location = New Point(12, 100)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(400, 200)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pizza Size"
        ' 
        ' rbnXLarge
        ' 
        rbnXLarge.AutoSize = True
        rbnXLarge.Location = New Point(45, 158)
        rbnXLarge.Name = "rbnXLarge"
        rbnXLarge.Size = New Size(161, 36)
        rbnXLarge.TabIndex = 3
        rbnXLarge.TabStop = True
        rbnXLarge.Text = "Extra Large"
        rbnXLarge.UseVisualStyleBackColor = True
        ' 
        ' rbnLarge
        ' 
        rbnLarge.AutoSize = True
        rbnLarge.Location = New Point(45, 116)
        rbnLarge.Name = "rbnLarge"
        rbnLarge.Size = New Size(103, 36)
        rbnLarge.TabIndex = 2
        rbnLarge.TabStop = True
        rbnLarge.Text = "Large"
        rbnLarge.UseVisualStyleBackColor = True
        ' 
        ' rbnMedium
        ' 
        rbnMedium.AutoSize = True
        rbnMedium.Location = New Point(45, 74)
        rbnMedium.Name = "rbnMedium"
        rbnMedium.Size = New Size(135, 36)
        rbnMedium.TabIndex = 1
        rbnMedium.TabStop = True
        rbnMedium.Text = "Medium"
        rbnMedium.UseVisualStyleBackColor = True
        ' 
        ' rbnSmall
        ' 
        rbnSmall.AutoSize = True
        rbnSmall.Location = New Point(45, 32)
        rbnSmall.Name = "rbnSmall"
        rbnSmall.Size = New Size(103, 36)
        rbnSmall.TabIndex = 0
        rbnSmall.TabStop = True
        rbnSmall.Text = "Small"
        rbnSmall.UseVisualStyleBackColor = True
        ' 
        ' cbxPizzas
        ' 
        cbxPizzas.FormattingEnabled = True
        cbxPizzas.Items.AddRange(New Object() {"Hawaiian", "Capricciosa", "Aussie", "Meat Lovers", "Four Seasons", "Supreme", "Margarita"})
        cbxPizzas.Location = New Point(510, 147)
        cbxPizzas.Name = "cbxPizzas"
        cbxPizzas.Size = New Size(242, 40)
        cbxPizzas.TabIndex = 2
        ' 
        ' chxDelivery
        ' 
        chxDelivery.AutoSize = True
        chxDelivery.Location = New Point(510, 241)
        chxDelivery.Name = "chxDelivery"
        chxDelivery.Size = New Size(144, 36)
        chxDelivery.TabIndex = 3
        chxDelivery.Text = "Delivery?"
        chxDelivery.UseVisualStyleBackColor = True
        ' 
        ' btnOrder
        ' 
        btnOrder.BackColor = SystemColors.ControlText
        btnOrder.ForeColor = SystemColors.Control
        btnOrder.Location = New Point(510, 314)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(242, 100)
        btnOrder.TabIndex = 4
        btnOrder.Text = "Order Now!"
        btnOrder.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ControlText
        btnReset.ForeColor = SystemColors.Control
        btnReset.Location = New Point(57, 314)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(242, 100)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnOrder)
        Controls.Add(chxDelivery)
        Controls.Add(cbxPizzas)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Pizza Ordering App"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbnXLarge As RadioButton
    Friend WithEvents rbnLarge As RadioButton
    Friend WithEvents rbnMedium As RadioButton
    Friend WithEvents rbnSmall As RadioButton
    Friend WithEvents cbxPizzas As ComboBox
    Friend WithEvents chxDelivery As CheckBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnReset As Button

End Class
