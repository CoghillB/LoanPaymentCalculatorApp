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
        titleLBL = New Label()
        loanAmountLBL = New Label()
        termLBL = New Label()
        interestLBL = New Label()
        amountTBX = New TextBox()
        limitTBX = New TextBox()
        interestTBX = New TextBox()
        paymentLBL = New Label()
        optionsGBX = New GroupBox()
        loyaltyCBX = New CheckBox()
        bonusCBX = New CheckBox()
        outputLBX = New ListBox()
        paymentBTN = New Button()
        optionsGBX.SuspendLayout()
        SuspendLayout()
        ' 
        ' titleLBL
        ' 
        titleLBL.AutoSize = True
        titleLBL.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        titleLBL.Location = New Point(152, 29)
        titleLBL.Name = "titleLBL"
        titleLBL.Size = New Size(549, 65)
        titleLBL.TabIndex = 0
        titleLBL.Text = "Loan Payment Calculator"
        ' 
        ' loanAmountLBL
        ' 
        loanAmountLBL.AutoSize = True
        loanAmountLBL.Location = New Point(55, 135)
        loanAmountLBL.Name = "loanAmountLBL"
        loanAmountLBL.Size = New Size(194, 32)
        loanAmountLBL.TabIndex = 1
        loanAmountLBL.Text = "Loan amount ($):"
        ' 
        ' termLBL
        ' 
        termLBL.AutoSize = True
        termLBL.Location = New Point(55, 203)
        termLBL.Name = "termLBL"
        termLBL.Size = New Size(202, 32)
        termLBL.TabIndex = 2
        termLBL.Text = "Term limit (years):"
        ' 
        ' interestLBL
        ' 
        interestLBL.AutoSize = True
        interestLBL.Location = New Point(55, 271)
        interestLBL.Name = "interestLBL"
        interestLBL.Size = New Size(188, 32)
        interestLBL.TabIndex = 3
        interestLBL.Text = "Interest rate (%):"
        ' 
        ' amountTBX
        ' 
        amountTBX.Location = New Point(262, 132)
        amountTBX.Name = "amountTBX"
        amountTBX.Size = New Size(120, 39)
        amountTBX.TabIndex = 4
        amountTBX.TextAlign = HorizontalAlignment.Right
        ' 
        ' limitTBX
        ' 
        limitTBX.Location = New Point(307, 200)
        limitTBX.Name = "limitTBX"
        limitTBX.Size = New Size(75, 39)
        limitTBX.TabIndex = 5
        limitTBX.TextAlign = HorizontalAlignment.Right
        ' 
        ' interestTBX
        ' 
        interestTBX.Location = New Point(307, 268)
        interestTBX.Name = "interestTBX"
        interestTBX.Size = New Size(75, 39)
        interestTBX.TabIndex = 6
        interestTBX.TextAlign = HorizontalAlignment.Right
        ' 
        ' paymentLBL
        ' 
        paymentLBL.AutoSize = True
        paymentLBL.Location = New Point(439, 123)
        paymentLBL.Name = "paymentLBL"
        paymentLBL.Size = New Size(310, 32)
        paymentLBL.TabIndex = 8
        paymentLBL.Text = "Monthly payment amounts:"
        ' 
        ' optionsGBX
        ' 
        optionsGBX.Controls.Add(loyaltyCBX)
        optionsGBX.Controls.Add(bonusCBX)
        optionsGBX.Location = New Point(58, 342)
        optionsGBX.Name = "optionsGBX"
        optionsGBX.Size = New Size(324, 156)
        optionsGBX.TabIndex = 7
        optionsGBX.TabStop = False
        optionsGBX.Text = "Borrowing Options"
        ' 
        ' loyaltyCBX
        ' 
        loyaltyCBX.AutoSize = True
        loyaltyCBX.Cursor = Cursors.Hand
        loyaltyCBX.Location = New Point(32, 105)
        loyaltyCBX.Name = "loyaltyCBX"
        loyaltyCBX.Size = New Size(248, 36)
        loyaltyCBX.TabIndex = 1
        loyaltyCBX.Text = "1% loyalty discount"
        loyaltyCBX.UseVisualStyleBackColor = True
        ' 
        ' bonusCBX
        ' 
        bonusCBX.AutoSize = True
        bonusCBX.Cursor = Cursors.Hand
        bonusCBX.Location = New Point(32, 47)
        bonusCBX.Name = "bonusCBX"
        bonusCBX.Size = New Size(263, 36)
        bonusCBX.TabIndex = 0
        bonusCBX.Text = "$1000 signing bonus"
        bonusCBX.UseVisualStyleBackColor = True
        ' 
        ' outputLBX
        ' 
        outputLBX.Font = New Font("Courier New", 11F, FontStyle.Regular, GraphicsUnit.Point)
        outputLBX.FormattingEnabled = True
        outputLBX.ItemHeight = 24
        outputLBX.Location = New Point(439, 174)
        outputLBX.Name = "outputLBX"
        outputLBX.Size = New Size(338, 316)
        outputLBX.TabIndex = 9
        ' 
        ' paymentBTN
        ' 
        paymentBTN.Cursor = Cursors.Hand
        paymentBTN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        paymentBTN.Location = New Point(526, 520)
        paymentBTN.Name = "paymentBTN"
        paymentBTN.Size = New Size(251, 52)
        paymentBTN.TabIndex = 10
        paymentBTN.Text = "Calculate Payments"
        paymentBTN.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(852, 610)
        Controls.Add(paymentBTN)
        Controls.Add(outputLBX)
        Controls.Add(paymentLBL)
        Controls.Add(optionsGBX)
        Controls.Add(interestTBX)
        Controls.Add(limitTBX)
        Controls.Add(amountTBX)
        Controls.Add(interestLBL)
        Controls.Add(termLBL)
        Controls.Add(loanAmountLBL)
        Controls.Add(titleLBL)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Loan Payment Calculator"
        optionsGBX.ResumeLayout(False)
        optionsGBX.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents titleLBL As Label
    Friend WithEvents loanAmountLBL As Label
    Friend WithEvents termLBL As Label
    Friend WithEvents interestLBL As Label
    Friend WithEvents amountTBX As TextBox
    Friend WithEvents limitTBX As TextBox
    Friend WithEvents interestTBX As TextBox
    Friend WithEvents paymentLBL As Label
    Friend WithEvents optionsGBX As GroupBox
    Friend WithEvents loyaltyCBX As CheckBox
    Friend WithEvents bonusCBX As CheckBox
    Friend WithEvents outputLBX As ListBox
    Friend WithEvents paymentBTN As Button

End Class
