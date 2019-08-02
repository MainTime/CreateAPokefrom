Public Class CreateAttack
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As New Attack
        n.Damage = NumericUpDown1.Value
        n.IsContinuous = CheckBox1.Checked
        n.Level = TrackBar1.Value
        n.Name = TextBox1.Text
        n.Type = ComboBox1.SelectedIndex

        Dim sw As IO.StreamWriter = New IO.StreamWriter("attacks.json", True)
        sw.WriteLine(n.ToString())
        sw.Close()
        Me.Close()
    End Sub
End Class