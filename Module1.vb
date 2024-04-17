Imports System.Windows.Forms

Module Module1

    Public Sub Main()
        ' Nastaví výchozí nastavení pro text rendering
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Zobrazí InputBox a požádá uživatele o název formuláře
        Dim formName As String = InputBox("Zadejte název formuláře", "Otevření formuláře")

        ' Pokud byl zadán nějaký text, zobrazí formulář
        If Not String.IsNullOrEmpty(formName) Then
            ' Vytvoří instance formuláře
            Dim frm As New frHlavni()
            frm.Text = formName

            ' Zobrazí formulář
            Application.Run(frm)
        Else
            ' Uživatel nezadal název, aplikace se ukončí
            Application.Exit()
        End If
    End Sub

End Module