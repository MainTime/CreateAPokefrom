Public Class BuildAAttack

    Private currLevel = 1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        Dim f = 0
        For Each i In System.Enum.GetValues(GetType(PokefromTypes))
            If i.ToString = sender.Text Then f = 1
        Next
        If f = 0 Then sender.Text = System.Enum.GetValues(GetType(PokefromTypes))(0).ToString
    End Sub

    Private Sub AminkaButton3_Click(sender As Object, e As EventArgs) Handles AminkaButton3.Click
        Dim n As New Attack With {
            .Damage = TextBox2.Text,
            .IsContinuous = cb_male.Checked,
            .Level = currLevel,
            .Name = tb_name1.Text,
            .Type = [Enum].Parse(GetType(PokefromTypes), TextBox1.Text)
        }
        Using sw As New IO.StreamWriter("pfr_Data\attacks.json", True)
            sw.WriteLine(n.ToString())
            sw.Close()
        End Using
        Me.Close()
    End Sub

    Private Sub AminkaButton1_Click(sender As Object, e As EventArgs) Handles AminkaButton1.Click
        If currLevel > 1 Then
            currLevel -= 1
        End If
        SetLevelprog()
    End Sub

    Private Sub AminkaButton2_Click(sender As Object, e As EventArgs) Handles AminkaButton2.Click
        If currLevel < 4 Then
            currLevel += 1
        End If
        SetLevelprog()
    End Sub

    Sub SetLevelprog()
        AminkaProgressbar1.Percentage = currLevel * 100 / 4
        AminkaProgressbar1.Invalidate()
        CalcFairness()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        CalcFairness()
    End Sub

    Sub CalcFairness()
        If IsNumeric(TextBox2.Text) = False Then TextBox2.Text = 10
        Dim dmg = TextBox2.Text

        Dim dmgF1 = -1.9132 * dmg + 95.229
        Dim dmgF2 = -1.621 * dmg + 105.76
        Dim dmgF3 = -1.3204 * dmg + 109.46
        Dim dmgF4 = -0.0001 * dmg ^ 3 + 0.0306 * dmg ^ 2 - 2.6924 * dmg + 99.697

        If currLevel = 1 Then dmgF1 *= 2
        If currLevel = 2 Then dmgF2 *= 2
        If currLevel = 3 Then dmgF3 *= 2
        If currLevel = 4 Then dmgF4 *= 2

        Dim dmgF = (dmgF1 + dmgF2 + dmgF3 + dmgF4) / 5
        If dmgF > 100 Then dmgF = 100

        If cb_male.Checked = True Then
            dmgF = (dmgF + 75) / 2
        Else
            dmgF = (dmgF + 100) / 2
        End If

        If dmgF < 0 Then dmgF = 0

        AminkaProgressCircle1.Percentage = dmgF
    End Sub

    Private Sub Cb_male_CheckedChanged(sender As Object, e As EventArgs) Handles cb_male.CheckedChanged
        CalcFairness()
    End Sub


    Private Sub AminkaButton4_Click(sender As Object, e As EventArgs) Handles AminkaButton4.Click
        Dim i = [Enum].Parse(GetType(PokefromTypes), TextBox1.Text) + 1
        If i > [Enum].GetValues(GetType(PokefromTypes)).Cast(Of PokefromTypes).Last Then
            i = 0
        End If
        TextBox1.Text = System.Enum.GetValues(GetType(PokefromTypes))(i).ToString
    End Sub

    Private Sub BuildAAttack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalcFairness()
    End Sub
End Class