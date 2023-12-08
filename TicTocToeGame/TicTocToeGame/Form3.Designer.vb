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
        Label1 = New Label()
        Label2 = New Label()
        FirstPlayerName = New TextBox()
        SecondPlayerName = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Start_btn = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(42, 318)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 45)
        Label1.TabIndex = 0
        Label1.Text = "First Player Name"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(42, 396)
        Label2.Name = "Label2"
        Label2.Size = New Size(320, 45)
        Label2.TabIndex = 1
        Label2.Text = "Second Player Name"
        ' 
        ' FirstPlayerName
        ' 
        FirstPlayerName.Anchor = AnchorStyles.None
        FirstPlayerName.Font = New Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point)
        FirstPlayerName.Location = New Point(364, 319)
        FirstPlayerName.Name = "FirstPlayerName"
        FirstPlayerName.Size = New Size(322, 46)
        FirstPlayerName.TabIndex = 2
        ' 
        ' SecondPlayerName
        ' 
        SecondPlayerName.Anchor = AnchorStyles.None
        SecondPlayerName.Font = New Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point)
        SecondPlayerName.Location = New Point(364, 397)
        SecondPlayerName.Name = "SecondPlayerName"
        SecondPlayerName.Size = New Size(322, 46)
        SecondPlayerName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Forte", 42F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(42, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(635, 92)
        Label3.TabIndex = 4
        Label3.Text = "Tic Toc Toe Game"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Forte", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Teal
        Label4.Location = New Point(216, 128)
        Label4.Name = "Label4"
        Label4.Size = New Size(256, 26)
        Label4.TabIndex = 5
        Label4.Text = "Developed By : Group-B"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Forte", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Teal
        Label5.Location = New Point(170, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(358, 26)
        Label5.TabIndex = 6
        Label5.Text = "Developed using VB programming"
        ' 
        ' Start_btn
        ' 
        Start_btn.Anchor = AnchorStyles.None
        Start_btn.BackColor = Color.FromArgb(CByte(113), CByte(62), CByte(249))
        Start_btn.Font = New Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Start_btn.ForeColor = SystemColors.ButtonFace
        Start_btn.Location = New Point(269, 495)
        Start_btn.Name = "Start_btn"
        Start_btn.Size = New Size(151, 58)
        Start_btn.TabIndex = 12
        Start_btn.Text = "Start"
        Start_btn.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Forte", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(164, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(361, 40)
        Label6.TabIndex = 13
        Label6.Text = "Members of the Group"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Forte", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.DodgerBlue
        Label7.Location = New Point(165, 193)
        Label7.Name = "Label7"
        Label7.Size = New Size(357, 31)
        Label7.TabIndex = 14
        Label7.Text = "Chhotu Kumar - Team Leader,"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Forte", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Teal
        Label8.Location = New Point(74, 224)
        Label8.Name = "Label8"
        Label8.Size = New Size(565, 26)
        Label8.TabIndex = 15
        Label8.Text = "Vivek Kumar, Soni Kumai, Moni Kumari, Swati Kumari"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(722, 565)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Start_btn)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(SecondPlayerName)
        Controls.Add(FirstPlayerName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Tic-Toc-Toe-Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstPlayerName As TextBox
    Friend WithEvents SecondPlayerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Start_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
