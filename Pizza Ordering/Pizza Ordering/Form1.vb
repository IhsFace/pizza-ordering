Public Class Form1
    Dim dblSize As Double
    Dim strPizza As String
    Dim dblType As Double
    Dim dblDelivery As Double
    Dim dblPrice As Double

    Private Sub rbnSmall_CheckedChanged(sender As Object, e As EventArgs) Handles rbnSmall.CheckedChanged
        dblSize = 10.5
    End Sub
    Private Sub rbnMedium_CheckedChanged(sender As Object, e As EventArgs) Handles rbnMedium.CheckedChanged
        dblSize = 11.5
    End Sub
    Private Sub rbnLarge_CheckedChanged(sender As Object, e As EventArgs) Handles rbnLarge.CheckedChanged
        dblSize = 12.0
    End Sub
    Private Sub rbnXLarge_CheckedChanged(sender As Object, e As EventArgs) Handles rbnXLarge.CheckedChanged
        dblSize = 15.5
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Select Case cbxPizzas.SelectedIndex
            Case 0
                strPizza = "Hawaiian"
            Case 1
                strPizza = "Capricciosa"
            Case 2
                strPizza = "Aussie"
            Case 3
                strPizza = "Meat Lovers"
                dblType = 2.5
            Case 4
                strPizza = "Four Seasons"
            Case 5
                strPizza = "Supreme"
                dblType = 3.0
            Case 6
                strPizza = "Margarita"
            Case Else
                MsgBox("Please select a pizza.")
                Return
        End Select

        If chxDelivery.Checked = True Then
            dblDelivery = 5
        Else
            dblDelivery = 0
        End If

        dblPrice = dblSize + dblType + dblDelivery

        If dblType > 0 Then
            MsgBox("You have ordered a " & strPizza & " at $" & dblPrice & ". There will be an extra charge of $" & dblType)
        Else
            MsgBox("You have ordered a " & strPizza & " at $" & dblPrice)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        rbnSmall.Checked = True
        rbnMedium.Checked = False
        rbnLarge.Checked = False
        rbnXLarge.Checked = False
        chxDelivery.Checked = False
        cbxPizzas.SelectedIndex = -1
        dblSize = 0
        strPizza = ""
        dblType = 0
        dblDelivery = 0
        dblPrice = 0
    End Sub
End Class
