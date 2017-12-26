Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function pg4show()
        GroupBox1.Hide()
        GroupBox3.Hide()
        TextBox9.Hide()
        TextBox11.Hide()
        Button9.Hide()
        Button10.Hide()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox7.Hide()

    End Function
    Public Function addnewdetail()
        GroupBox2.Hide()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        GroupBox1.Hide()
        GroupBox7.Hide()
    End Function
    Public Function bales()
        GroupBox1.Hide()
        GroupBox3.Hide()
        GroupBox2.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        TextBox9.Hide()
        TextBox11.Hide()
        Button9.Hide()
        Button10.Hide()
        GroupBox7.Hide()
    End Function
    Public Function lifting()
        GroupBox1.Hide()
        GroupBox3.Hide()
        GroupBox2.Hide()
        GroupBox5.Hide()
        GroupBox6.Hide()
        TextBox9.Hide()
        TextBox11.Hide()
        Button9.Hide()
        Button10.Hide()

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addnewdetail()

        GroupBox3.Show()


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        TextBox9.Show()
        Button9.Show()
        If RadioButton1.Checked = False Then
            TextBox9.Hide()
            Button9.Hide()
        End If
        ' RadioButton1.Checked = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        TextBox11.Show()
        Button10.Show()
        If RadioButton2.Checked = False Then
            TextBox11.Hide()
            Button10.Hide()

        End If


    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        GroupBox1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label7.Show()
        Label9.Show()
        Label10.Show()
        ComboBox1.Show()
        TextBox3.Show()
        TextBox4.Show()
        TextBox8.Show()
        TextBox7.Show()
        TextBox6.Show()
        TextBox5.Show()
        Button4.Show()
        Button5.Show()

        If RadioButton5.Checked = False Then
            GroupBox1.Hide()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox2.Show()
        pg4show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bales()

        GroupBox4.Show()

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        GroupBox5.Show()
        If RadioButton4.Checked = False Then
            GroupBox5.Hide()

        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        GroupBox6.Show()
        If RadioButton7.Checked = False Then
            GroupBox6.Hide()

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        GroupBox7.Show()

    End Sub
End Class