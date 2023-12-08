<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GamePage
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        PlayerA = New Label()
        PlayerB = New Label()
        Reset_Btn = New Button()
        NewGame_btn = New Button()
        Exit_btn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.Font = New Font("ROG Fonts", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(161, 133)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 125)
        Button1.TabIndex = 0
        Button1.Tag = ""
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.Font = New Font("ROG Fonts", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(299, 133)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 125)
        Button2.TabIndex = 1
        Button2.Tag = ""
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.Font = New Font("ROG Fonts", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(437, 133)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 125)
        Button3.TabIndex = 2
        Button3.Tag = ""
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.None
        Button4.Font = New Font("ROG Fonts", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(161, 264)
        Button4.Name = "Button4"
        Button4.Size = New Size(132, 125)
        Button4.TabIndex = 3
        Button4.Tag = ""
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.Font = New Font("ROG Fonts", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(299, 264)
        Button5.Name = "Button5"
        Button5.Size = New Size(132, 125)
        Button5.TabIndex = 4
        Button5.Tag = ""
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.None
        Button6.Font = New Font("ROG Fonts", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(437, 264)
        Button6.Name = "Button6"
        Button6.Size = New Size(132, 125)
        Button6.TabIndex = 5
        Button6.Tag = ""
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.None
        Button7.Font = New Font("ROG Fonts", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(161, 395)
        Button7.Name = "Button7"
        Button7.Size = New Size(132, 125)
        Button7.TabIndex = 6
        Button7.Tag = ""
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.None
        Button8.Font = New Font("ROG Fonts", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.Location = New Point(299, 395)
        Button8.Name = "Button8"
        Button8.Size = New Size(132, 125)
        Button8.TabIndex = 7
        Button8.Tag = ""
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Anchor = AnchorStyles.None
        Button9.Font = New Font("ROG Fonts", 28F, FontStyle.Bold, GraphicsUnit.Point)
        Button9.Location = New Point(437, 395)
        Button9.Name = "Button9"
        Button9.Size = New Size(132, 125)
        Button9.TabIndex = 8
        Button9.Tag = ""
        Button9.UseVisualStyleBackColor = True
        ' 
        ' PlayerA
        ' 
        PlayerA.Anchor = AnchorStyles.None
        PlayerA.AutoSize = True
        PlayerA.Font = New Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point)
        PlayerA.ForeColor = Color.Gray
        PlayerA.Location = New Point(136, 71)
        PlayerA.Name = "PlayerA"
        PlayerA.Size = New Size(52, 62)
        PlayerA.TabIndex = 9
        PlayerA.Tag = ""
        PlayerA.Text = "0"
        PlayerA.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PlayerB
        ' 
        PlayerB.Anchor = AnchorStyles.None
        PlayerB.AutoSize = True
        PlayerB.Font = New Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point)
        PlayerB.ForeColor = Color.Gray
        PlayerB.Location = New Point(647, 71)
        PlayerB.Name = "PlayerB"
        PlayerB.Size = New Size(52, 62)
        PlayerB.TabIndex = 10
        PlayerB.Tag = ""
        PlayerB.Text = "0"
        PlayerB.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Reset_Btn
        ' 
        Reset_Btn.Anchor = AnchorStyles.None
        Reset_Btn.BackColor = Color.FromArgb(CByte(113), CByte(62), CByte(249))
        Reset_Btn.Font = New Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Reset_Btn.ForeColor = SystemColors.ButtonFace
        Reset_Btn.Location = New Point(60, 562)
        Reset_Btn.Name = "Reset_Btn"
        Reset_Btn.Size = New Size(151, 58)
        Reset_Btn.TabIndex = 11
        Reset_Btn.Tag = ""
        Reset_Btn.Text = "Reset"
        Reset_Btn.UseVisualStyleBackColor = False
        ' 
        ' NewGame_btn
        ' 
        NewGame_btn.Anchor = AnchorStyles.None
        NewGame_btn.BackColor = Color.FromArgb(CByte(113), CByte(62), CByte(249))
        NewGame_btn.Font = New Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point)
        NewGame_btn.ForeColor = SystemColors.ButtonFace
        NewGame_btn.Location = New Point(252, 562)
        NewGame_btn.Name = "NewGame_btn"
        NewGame_btn.Size = New Size(237, 58)
        NewGame_btn.TabIndex = 12
        NewGame_btn.Tag = ""
        NewGame_btn.Text = "New Game"
        NewGame_btn.UseVisualStyleBackColor = False
        ' 
        ' Exit_btn
        ' 
        Exit_btn.Anchor = AnchorStyles.None
        Exit_btn.BackColor = Color.FromArgb(CByte(113), CByte(62), CByte(249))
        Exit_btn.Font = New Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Exit_btn.ForeColor = SystemColors.ButtonFace
        Exit_btn.Location = New Point(527, 562)
        Exit_btn.Name = "Exit_btn"
        Exit_btn.Size = New Size(151, 58)
        Exit_btn.TabIndex = 13
        Exit_btn.Tag = ""
        Exit_btn.Text = "Exit"
        Exit_btn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 62)
        Label1.TabIndex = 14
        Label1.Tag = ""
        Label1.Text = "PlayerX"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(19, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 52)
        Label2.TabIndex = 15
        Label2.Tag = ""
        Label2.Text = "Score:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(527, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 62)
        Label3.TabIndex = 16
        Label3.Tag = ""
        Label3.Text = "PlayerO"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Sylfaen", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(527, 71)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 52)
        Label4.TabIndex = 17
        Label4.Tag = ""
        Label4.Text = "Score:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GamePage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(763, 650)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Exit_btn)
        Controls.Add(NewGame_btn)
        Controls.Add(Reset_Btn)
        Controls.Add(PlayerB)
        Controls.Add(PlayerA)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "GamePage"
        Text = "Tic-Toc-Toe Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents PlayerA As Label
    Friend WithEvents PlayerB As Label
    Friend WithEvents Reset_Btn As Button
    Friend WithEvents NewGame_btn As Button
    Friend WithEvents Exit_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
