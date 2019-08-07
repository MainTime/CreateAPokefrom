Public Class Form1
    Private Attacks As New List(Of Attack)
    Private Gender As Boolean = False

    Private Sub LoadFrom(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.Directory.Exists("pfr_Data") = False Then IO.Directory.CreateDirectory("pfr_Data\")
        For Each I In System.Enum.GetValues(GetType(PokefromTypes))
            ComboBox1.Items.Add(I)
            ComboBox2.Items.Add(I)
            ComboBox3.Items.Add(I)
            ComboBox4.Items.Add(I)
        Next
        If IO.File.Exists("pfr_Data\attacks.json") = True Then
            For Each ln In IO.File.ReadAllLines("pfr_Data\attacks.json")
                Attacks.Add(Newtonsoft.Json.JsonConvert.DeserializeObject(Of Attack)(ln))
                CheckedListBox1.Items.Add(Newtonsoft.Json.JsonConvert.DeserializeObject(Of Attack)(ln).Name)
            Next
        End If
    End Sub

#Region "CBSync"
    Private Sub C3(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.SelectedItem = sender.SelectedItem
        ComboBox3.SelectedItem = sender.SelectedItem
        ComboBox4.SelectedItem = sender.SelectedItem
    End Sub
    Private Sub C2(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.SelectedItem = sender.SelectedItem
        ComboBox4.SelectedItem = sender.SelectedItem
    End Sub
    Private Sub C1(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox4.SelectedItem = sender.SelectedItem
    End Sub
#End Region

    Private Sub CreateNewAttack(sender As Object, e As EventArgs) Handles Button6.Click
        CreateAttack.ShowDialog()
    End Sub

    Private Sub CreatePokefrom(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New PokefromObject
        obj.Name0 = TextBox1.Text
        obj.Name1 = TextBox2.Text
        obj.Name2 = TextBox3.Text
        obj.Name3 = TextBox4.Text

        obj.Type0 = ComboBox1.SelectedIndex
        obj.Type1 = ComboBox2.SelectedIndex
        obj.Type2 = ComboBox3.SelectedIndex
        obj.Type3 = ComboBox4.SelectedIndex

        obj.Texture1 = "" 'Unassigned
        obj.Texture1 = "" 'Unassigned
        obj.Texture1 = "" 'Unassigned
        obj.Texture1 = "" 'Unassigned

        obj.LevelUp1 = NumericUpDown1.Value
        obj.LevelUp2 = NumericUpDown2.Value
        obj.LevelUp3 = NumericUpDown3.Value

        obj.Gender = Gender

        obj.Attacks = New List(Of Attack)
        For Each i In CheckedListBox1.CheckedIndices
            obj.Attacks.Add(Attacks.Item(i))
        Next

        Clipboard.SetText(obj.ToCode)
    End Sub

    Private Sub ChangeGenderByRadioButton(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            RadioButton2.Checked = False
            Gender = False
        End If
        If RadioButton2.Checked = True Then
            RadioButton1.Checked = False
            Gender = True
        End If
    End Sub

    Private Sub SetImage(sender As Object, e As EventArgs) Handles Button5.Click, Button4.Click, Button3.Click, Button2.Click
        Dim opFDia As New OpenFileDialog()
        opFDia.Filter = "Image|*.png|Image|*.jpg"
        opFDia.ShowDialog()
        sender.backgroundimage = Image.FromFile(opFDia.FileName)
    End Sub
End Class
