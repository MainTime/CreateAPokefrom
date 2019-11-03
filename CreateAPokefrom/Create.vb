Public Class Create
    Private AllAttacks As New List(Of Attack)


    Private pFromObj As New PokefromObject

    Private Sub Create_Load(sender As Object, e As EventArgs) Handles Me.Load
        AminkaProgressbar1.Percentage = 5
        AminkaProgressbar1.Invalidate()
        clb_1.Items.Clear()

        For Each I In System.Enum.GetValues(GetType(PokefromTypes))
            tb_name1.AutoCompleteCustomSource.Add(I)
            tb_name2.AutoCompleteCustomSource.Add(I)
            tb_name3.AutoCompleteCustomSource.Add(I)
            tb_name4.AutoCompleteCustomSource.Add(I)
        Next

        If IO.File.Exists("pfr_Data\attacks.json") = True Then
            For Each ln In IO.File.ReadAllLines("pfr_Data\attacks.json")
                AllAttacks.Add(Newtonsoft.Json.JsonConvert.DeserializeObject(Of Attack)(ln))
                clb_1.Items.Add(Newtonsoft.Json.JsonConvert.DeserializeObject(Of Attack)(ln).Name)
            Next
        End If
    End Sub


    Private Sub AminkaButton1_Click(sender As Object, e As EventArgs) Handles AminkaButton1.Click
        Static f = False
        TabControl1.SelectedIndex += 1

        AminkaProgressbar1.Percentage = 100 * TabControl1.SelectedIndex / (TabControl1.TabCount - 1)

        If TabControl1.SelectedIndex = 4 And f = True Then

            Dim l As New List(Of Attack)
            For Each i In clb_1.SelectedIndices
                l.Add(AllAttacks.Item(i))
            Next
            pFromObj.Attacks = l

            pFromObj.Name0 = tb_name1.Text
            pFromObj.Name1 = tb_name2.Text
            pFromObj.Name2 = tb_name3.Text
            pFromObj.Name3 = tb_name4.Text

            pFromObj.Type0 = [Enum].Parse(GetType(PokefromTypes), tb_type1.Text)
            pFromObj.Type1 = [Enum].Parse(GetType(PokefromTypes), tb_type2.Text)
            pFromObj.Type2 = [Enum].Parse(GetType(PokefromTypes), tb_type3.Text)
            pFromObj.Type3 = [Enum].Parse(GetType(PokefromTypes), tb_type4.Text)

            Using i = IO.File.CreateText("pfr_Data/" & tb_name1.Text & ".pfrObj")
                i.Write(pFromObj.ToCode())
                i.Close()
            End Using

            Me.Hide()
            MainMenu.Show()
            Application.Restart()
        ElseIf TabControl1.SelectedIndex = 4 And f = False Then
            f = True
        End If

        AminkaProgressbar1.Invalidate()
    End Sub

    Private Sub type_changed(sender As Object, e As EventArgs) Handles tb_type1.LostFocus, tb_type2.LostFocus, tb_type3.LostFocus, tb_type4.LostFocus
        Dim f = 0
        For Each i In System.Enum.GetValues(GetType(PokefromTypes))
            If i.ToString = sender.Text Then f = 1
        Next
        If f = 0 Then sender.Text = System.Enum.GetValues(GetType(PokefromTypes))(0).ToString
    End Sub
End Class