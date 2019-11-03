Public Class MainMenu

    Private loPf As New List(Of PokefromObject)

    Private Sub AminkaItemList1_ItemClick(ByRef Itemindex As Object, ByRef item As Project_Aminka.AminkaItemListItem) Handles AminkaItemList1.ItemClick
        tb_name1.Text = item.Text
        tb_cd.Text = IO.File.GetLastWriteTime("pfr_Data/" & item.Text & ".pfrObj").ToShortDateString
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.Directory.Exists("pfr_Data") = False Then IO.Directory.CreateDirectory("pfr_Data\")

        LoadItems()

    End Sub

    Private Sub AminkaButton1_Click(sender As Object, e As EventArgs) Handles AminkaButton1.Click
        Create.Show()
        Me.Hide()
    End Sub

    Private Sub AminkaButton3_Click(sender As Object, e As EventArgs) Handles AminkaButton3.Click
        For i = 0 To Math.Sqrt(AminkaItemList1.ItemHeight + AminkaItemList1.ItemSpaceing)
            AminkaItemList1.VerticalOffset -= Math.Sqrt(AminkaItemList1.ItemHeight + AminkaItemList1.ItemSpaceing)
            AminkaItemList1.Refresh()
            Application.DoEvents()
        Next
    End Sub

    Private Sub AminkaButton2_Click(sender As Object, e As EventArgs) Handles AminkaButton2.Click
        For i = 0 To Math.Sqrt(AminkaItemList1.ItemHeight + AminkaItemList1.ItemSpaceing)
            AminkaItemList1.VerticalOffset += Math.Sqrt(AminkaItemList1.ItemHeight + AminkaItemList1.ItemSpaceing)
            AminkaItemList1.Refresh()
            Application.DoEvents()
        Next
    End Sub

    Private Sub AminkaButton7_Click(sender As Object, e As EventArgs) Handles AminkaButton7.Click
        BuildAAttack.Show()
        Me.Hide()
    End Sub

    Private Sub AminkaButton4_Click(sender As Object, e As EventArgs) Handles AminkaButton4.Click
        Try
            IO.File.Move("pfr_Data/" & tb_name1.Text & ".pfrObj", "pfr_Data/" & tb_name1.Text & ".pfrObj.old")
            LoadItems()
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadItems()
        AminkaItemList1.Items.Clear()
        Dim c = 0
        For Each f In IO.Directory.GetFiles("pfr_Data")

            If IO.Path.GetExtension(f) = ".pfrObj" Then
                If c = 0 Then AminkaItemList1.Items.Clear()
                c += 1

                AminkaItemList1.Items.Add(New Project_Aminka.AminkaItemListItem())
                AminkaItemList1.Items.Last.Name = "pfr" & AminkaItemList1.Items.Count
                AminkaItemList1.Items.Last.Text = IO.Path.GetFileNameWithoutExtension(f)
                loPf.Add(PokefromObject.FromCode(IO.File.ReadAllText(f)))

            End If

        Next
    End Sub

    Private Sub AminkaButton8_Click(sender As Object, e As EventArgs) Handles AminkaButton8.Click
        If IO.Directory.Exists("pfr_Data/out") = False Then IO.Directory.CreateDirectory("pfr_Data\out")
        Using sw = IO.File.CreateText("pfr_Data/out/" & Now.ToShortDateString & ".pfrCollection")
            sw.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(loPf))
        End Using
    End Sub
End Class