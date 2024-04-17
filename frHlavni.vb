Imports System.Windows.Forms
Imports System.IO


Public Class frHlavni
    Private slInfo As ToolStripStatusLabel

    Private Sub frHlavni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim statusStrip As New StatusStrip()
        slInfo = New ToolStripStatusLabel()
        statusStrip.Items.Add(slInfo)
        Me.Controls.Add(statusStrip)

        AddHandler Me.OtevřítToolStripMenuItem.Click, AddressOf Me.OtevřítToolStripMenuItem_Click
        AddHandler Me.UložítToolStripMenuItem.Click, AddressOf Me.UložitToolStripMenuItem_Click

        ComboBox1.Items.Add("hnědá")
        ComboBox1.Items.Add("červená")
        ComboBox1.Items.Add("fialová")
        ComboBox1.Items.Add("zelená")
        ComboBox1.Items.Add("modrá")

        ComboBox1.SelectedItem = "hnědá"
    End Sub

    Private Sub OtevřítToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Textové soubory|*.txt|Dokumenty|*.doc|Všechny soubory|*.*"
            openFileDialog.FilterIndex = 1
            openFileDialog.InitialDirectory = "C:\KURS"
            If openFileDialog.ShowDialog() = DialogResult.OK Then

                slInfo.Text = "Naposledy otevřený soubor: " & openFileDialog.FileName
            End If
            Dim fileContent As String = File.ReadAllText(openFileDialog.FileName)
            TextBoxMultiline.Text = fileContent
        End Using
    End Sub


    Private Sub UložitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Textové soubory|*.txt|Dokumenty|*.doc|Všchny soubory|*.*"
            saveFileDialog.FilterIndex = 1
            saveFileDialog.OverwritePrompt = True
            saveFileDialog.InitialDirectory = "C:\KURS"
            saveFileDialog.Title = "Vyberte složku, do které chcete umístit výsledky:"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                slInfo.Text = "Data byla uložena do souboru: " & saveFileDialog.FileName
            Else
                slInfo.Text = "Dialog pro uložení souboru byl zrušen."
            End If

        End Using

    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress


        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If

    End Sub

    Private Sub lblSum_Click(sender As Object, e As EventArgs) Handles lblSum.Click
        Dim sum As Integer = 0
        Dim value As Integer


        If Integer.TryParse(TextBox1.Text, value) Then
            sum += value
        End If


        If Integer.TryParse(TextBox2.Text, value) Then
            sum += value
        End If


        sum += Convert.ToInt32(NumericUpDown1.Value)


        lblSum.Text = "Součet: " & sum.ToString()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

        Label2.Text = "Posuvníkem nastaveno: " & TrackBar1.Value.ToString()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        Dim sumText As String = lblSum.Text.Substring(8)
        Dim currentSum As Integer

        If Integer.TryParse(sumText, currentSum) Then

            Dim totalSum As Integer = currentSum + TrackBar1.Value


            Label3.Text = "Součet * TrackBar = " & totalSum.ToString()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("hnědá")
        ComboBox1.Items.Add("červená")
        ComboBox1.Items.Add("fialová")
        ComboBox1.Items.Add("zelená")
        ComboBox1.Items.Add("modrá")


        ComboBox1.SelectedItem = "hnědá"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim selectedColor As String = ComboBox1.SelectedItem.ToString()

    End Sub

    Private Sub UpdateLabel()
        Dim delsi As String = If(CheckBox1.Checked, "delší", "")
        Dim vyssi As String = If(CheckBox2.Checked, "vyšší", "")
        Dim hlubsi As String = If(CheckBox3.Checked, "hlubší", "")

        Dim material As String = ""
        If RadioButton1.Checked Then
            material = "dřevo"
        ElseIf RadioButton2.Checked Then
            material = "kov"
        ElseIf RadioButton3.Checked Then
            material = "plast"
        ElseIf RadioButton4.Checked Then
            material = "sklo"
        End If

        Dim barva As String = ComboBox1.SelectedItem.ToString()

        Dim value As Integer = TrackBar1.Value
        labelVystup.Text = $"{value} {delsi} {vyssi} {hlubsi} {material}, barva {barva}"
    End Sub


    Private Sub CheckBoxes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged
        UpdateLabel()
    End Sub


    Private Sub RadioButtonsMaterial_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged
        UpdateLabel()
    End Sub

    Private Sub LabelPB_Click(sender As Object, e As EventArgs) Handles LabelPB.Click

    End Sub
    Private countdown As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProgressBar1.Maximum = 10

        Timer1.Interval = 1000
        Timer1.Start()
        countdown = ProgressBar1.Maximum
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        countdown -= 1

        ProgressBar1.Value = ProgressBar1.Maximum - countdown

        LabelPB.Text = "ProgressBar bude běžet ještě: " & countdown.ToString() & " s"

        If countdown = 0 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ProgressBar1.Value = 0
        countdown = ProgressBar1.Maximum
        Timer1.Start()
    End Sub


    Private WithEvents Timer2 As New Timer()

    Private Sub frHlavni_Load2(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer2.Interval = 1000
        AddHandler Timer2.Tick, AddressOf Timer2_Tick
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

        slInfo.Text = "Aktuální čas: " & DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Toto je nápověda...")
    End Sub



    Private Sub ButtonESC_MouseHover(sender As Object, e As EventArgs) Handles ButtonESC.MouseHover



        ToolTip1.Show("Ukončit program (ESC)", ButtonESC)
    End Sub

    Private Sub ButtonESC_MouseLeave(sender As Object, e As EventArgs) Handles ButtonESC.MouseLeave

        ToolTip1.Hide(ButtonESC)
    End Sub


End Class
