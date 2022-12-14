Public Class Form1

   'set the IniFile path
   ReadOnly DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
   ReadOnly IniProcessor As New Settings.IniFileProcessor(DesktopFolder & "\test.ini")

   Private Sub bnWrite_Click(sender As Object, e As EventArgs) Handles bnWrite.Click

      'to update or insert new values
      IniProcessor.UpdateValue("MyProperty1", "Wah?")
      IniProcessor.UpdateValue("MyProperty2", "Wahoo!")
      IniProcessor.UpdateValue("MyProperty3", "Wahooey!")

      'to permanently write changes to the ini file
      IniProcessor.Save()

   End Sub

   Private Sub bnRead_Click(sender As Object, e As EventArgs) Handles bnRead.Click

      'to get stored values
      tx.Text += IniProcessor.PropertyName_ToString("MyProperty1") & vbCrLf
      tx.Text += IniProcessor.PropertyName_ToString("MyProperty2") & vbCrLf
      tx.Text += IniProcessor.PropertyName_ToString("MyProperty3") & vbCrLf

   End Sub

   Private Sub bnExit_Click(sender As Object, e As EventArgs) Handles bnExit.Click
      Close()
   End Sub

End Class
