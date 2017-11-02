<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TheBoard
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
        Me.hitButton = New System.Windows.Forms.Button()
        Me.StandButton = New System.Windows.Forms.Button()
        Me.HideDealersCardPB = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.totalCashLabel = New System.Windows.Forms.Label()
        Me.yourCashTextBox = New System.Windows.Forms.TextBox()
        Me.betAmountLabel = New System.Windows.Forms.Label()
        Me.betAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.HideDealersCardPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hitButton
        '
        Me.hitButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.hitButton.Location = New System.Drawing.Point(22, 703)
        Me.hitButton.Name = "hitButton"
        Me.hitButton.Size = New System.Drawing.Size(92, 31)
        Me.hitButton.TabIndex = 1
        Me.hitButton.Text = "Hit"
        Me.hitButton.UseVisualStyleBackColor = False
        '
        'StandButton
        '
        Me.StandButton.BackColor = System.Drawing.Color.IndianRed
        Me.StandButton.Location = New System.Drawing.Point(135, 703)
        Me.StandButton.Name = "StandButton"
        Me.StandButton.Size = New System.Drawing.Size(92, 31)
        Me.StandButton.TabIndex = 2
        Me.StandButton.Text = "Stand"
        Me.StandButton.UseVisualStyleBackColor = False
        '
        'HideDealersCardPB
        '
        Me.HideDealersCardPB.Cursor = System.Windows.Forms.Cursors.Default
        Me.HideDealersCardPB.Image = Global.Poker.My.Resources.Resources.back2
        Me.HideDealersCardPB.Location = New System.Drawing.Point(540, 231)
        Me.HideDealersCardPB.Name = "HideDealersCardPB"
        Me.HideDealersCardPB.Size = New System.Drawing.Size(78, 106)
        Me.HideDealersCardPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.HideDealersCardPB.TabIndex = 3
        Me.HideDealersCardPB.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(363, 661)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Your Hand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(342, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dealer's Hand"
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.LightGreen
        Me.ResetButton.Location = New System.Drawing.Point(858, 703)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(92, 31)
        Me.ResetButton.TabIndex = 6
        Me.ResetButton.Text = "Deal"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'totalCashLabel
        '
        Me.totalCashLabel.AutoSize = True
        Me.totalCashLabel.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.totalCashLabel.Location = New System.Drawing.Point(29, 72)
        Me.totalCashLabel.Name = "totalCashLabel"
        Me.totalCashLabel.Size = New System.Drawing.Size(85, 20)
        Me.totalCashLabel.TabIndex = 7
        Me.totalCashLabel.Text = "Total Cash"
        '
        'yourCashTextBox
        '
        Me.yourCashTextBox.Enabled = False
        Me.yourCashTextBox.Location = New System.Drawing.Point(133, 70)
        Me.yourCashTextBox.Name = "yourCashTextBox"
        Me.yourCashTextBox.ReadOnly = True
        Me.yourCashTextBox.Size = New System.Drawing.Size(114, 26)
        Me.yourCashTextBox.TabIndex = 8
        Me.yourCashTextBox.TabStop = False
        Me.yourCashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'betAmountLabel
        '
        Me.betAmountLabel.AutoSize = True
        Me.betAmountLabel.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.betAmountLabel.Location = New System.Drawing.Point(18, 110)
        Me.betAmountLabel.Name = "betAmountLabel"
        Me.betAmountLabel.Size = New System.Drawing.Size(98, 20)
        Me.betAmountLabel.TabIndex = 9
        Me.betAmountLabel.Text = "Bet Amount:"
        '
        'betAmountTextBox
        '
        Me.betAmountTextBox.Location = New System.Drawing.Point(133, 107)
        Me.betAmountTextBox.Name = "betAmountTextBox"
        Me.betAmountTextBox.Size = New System.Drawing.Size(114, 26)
        Me.betAmountTextBox.TabIndex = 10
        Me.betAmountTextBox.TabStop = False
        Me.betAmountTextBox.Text = "0"
        Me.betAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(968, 703)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(92, 31)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.TabStop = False
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TheBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.BackgroundImage = Global.Poker.My.Resources.Resources.bet_em_all_layout
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1072, 760)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.betAmountTextBox)
        Me.Controls.Add(Me.betAmountLabel)
        Me.Controls.Add(Me.yourCashTextBox)
        Me.Controls.Add(Me.totalCashLabel)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HideDealersCardPB)
        Me.Controls.Add(Me.StandButton)
        Me.Controls.Add(Me.hitButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TheBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blackjack"
        CType(Me.HideDealersCardPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hitButton As Button
    Friend WithEvents StandButton As Button
    Friend WithEvents HideDealersCardPB As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents totalCashLabel As Label
    Friend WithEvents yourCashTextBox As TextBox
    Friend WithEvents betAmountLabel As Label
    Friend WithEvents betAmountTextBox As TextBox
    Friend WithEvents ExitButton As Button
End Class
