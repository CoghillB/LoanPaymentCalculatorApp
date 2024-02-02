Option Strict On
Imports System.Diagnostics.Eventing.Reader
Imports System.Numerics
Imports System.Runtime.CompilerServices

Public Class Form1

    Private Sub paymentBTN_Click(sender As Object, e As EventArgs) Handles paymentBTN.Click
        outputLBX.Items.Clear()

        'show error message if user doesnt enter a value in the textbox
        If amountTBX.Text.Equals("") Then
            MessageBox.Show("Please enter all information", "Missing Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf limitTBX.Text.Equals("") Then
            MessageBox.Show("Please enter all information", "Missing Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf interestTBX.Text.Equals("") Then
            MessageBox.Show("Please enter all information", "Missing Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim loanAmount As Double = CDbl(amountTBX.Text)
            Dim loanTerm As Integer = CInt(limitTBX.Text)
            Dim interestRate As Double = CDbl(interestTBX.Text)
            Dim monthlyPayment As Double




            For i As Integer = 1 To loanTerm

                outputLBX.Items.Add("Term" & vbTab & "Monthly Payment")

                If CInt(limitTBX.Text) > 10 Then
                    MessageBox.Show("Please enter a term less than 10 years", "Invalid Term", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limitTBX.Text = ""
                    outputLBX.Items.Clear()
                End If

                If bonusCBX.Checked Then loanAmount = CDbl(amountTBX.Text) - 1000.0

                If loyaltyCBX.Checked Then interestRate = CInt(interestTBX.Text) - 1

                monthlyPayment = interestRate / 12 / 100 * loanAmount / (1 - (1 + interestRate / 12 / 100) ^ (-i * 12))
                outputLBX.Items.Add(i & " year" & vbTab & monthlyPayment.ToString("C"))

            Next
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        amountTBX.Focus()

    End Sub

    Private Sub inputChange_TextChanged(sender As Object, e As EventArgs) Handles _
        amountTBX.TextChanged, limitTBX.TextChanged, interestTBX.TextChanged, bonusCBX.CheckedChanged, loyaltyCBX.CheckedChanged
        outputLBX.Items.Clear()

    End Sub
End Class
