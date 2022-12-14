Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO

Namespace Settings

   Public Class IniFileProcessor

      Public Class PropertyList(Of T)

         Inherits List(Of IniProperty)

         Default Public Overloads Property Item(propertyName As String) As IniProperty
            Get
               Dim ret As IniProperty = Nothing
               For Each ip As IniProperty In Me
                  If (ip.Name = propertyName) Then
                     ret = ip
                     Exit For
                  End If
               Next
               Return ret
            End Get
            Set(value As IniProperty)
            End Set
         End Property

         Public Sub New()
            MyBase.New
         End Sub

         Public Overloads Sub Add(ByVal Name As String, ByVal Value As String)
            Dim ip As New IniProperty With {
               .Name = Name,
               .Value = Value
            }
            Me.Add(ip.Name, ip.Value)
         End Sub
      End Class

      Public Class IniProperty

         Public Property Name As String

         Public Property Value As String

         Public Sub New()
            Name = "newPropertyName_" & DateTime.Now.Ticks.ToString()
            Value = ""
         End Sub

         Public Sub New(ByVal name As String, ByVal value As String)
            Me.Value = value
            Me.Name = name
         End Sub

      End Class

      Public Property FileName As String
      Public Property IpCollection As PropertyList(Of IniProperty)

      Public Sub New()
         Me.New(AppDomain.CurrentDomain.BaseDirectory + "config.ini")
      End Sub

      Public Sub New(ByVal fileName As String)
         IpCollection = New PropertyList(Of IniProperty)()
         Me.FileName = fileName
         If fileName IsNot Nothing AndAlso File.Exists(fileName) Then
            ReadFile()
         End If
      End Sub

      Private Sub ReadFile()

         If File.Exists(FileName) Then

            IpCollection = New PropertyList(Of IniProperty)()

            Using sr As New StreamReader(FileName, Encoding.[Default])

               While Not sr.EndOfStream
                  Dim line As String = sr.ReadLine()

                  If Not line.StartsWith("#") Then
                     Dim ip As New IniProperty()
                     Dim tmp As String = ""
                     Dim splitter As Char = "="c

                     For i As Integer = 0 To line.Length - 1

                        If line(i) <> splitter Then
                           tmp += (CChar(line(i))).ToString()
                        Else
                           ip.Name = tmp
                           tmp = ""
                           splitter = vbLf
                        End If
                     Next

                     ip.Value = tmp

                     If ip.Name.Length > 0 Then
                        IpCollection.Add(ip)
                     End If
                  End If
               End While

               sr.Close()

            End Using

         End If

      End Sub

      Private Sub SaveConfigProperty(ByVal prop As IniProperty)

         Dim output = New List(Of String)

         If File.Exists(Me.FileName) Then

            Dim sr = New StreamReader(Me.FileName, Encoding.Default)

            While Not sr.EndOfStream
               Dim line As String = sr.ReadLine
               If line.StartsWith((prop.Name + "=")) Then
                  output.Add((prop.Name + ("=" + prop.Value)))
               Else
                  output.Add(line)
               End If
            End While

            sr.Close()

         End If

         If Not output.Contains((prop.Name + ("=" + prop.Value))) Then
            output.Add((prop.Name + ("=" + prop.Value)))
         End If

         Dim sw = New StreamWriter(Me.FileName, False, Encoding.Default)
         For Each s As String In output
            sw.WriteLine(s)
         Next

         sw.Close()
         sw.Dispose()
         GC.SuppressFinalize(sw)
         output.Clear()

      End Sub

      Public Sub Save()
         For Each ip As IniProperty In Me.IpCollection
            Me.SaveConfigProperty(ip)
         Next
      End Sub

      Public Sub UpdateValue(ByVal propertyName As String, ByVal propertyValue As String)

         Try
            Dim myProps As IEnumerable(Of IniProperty) = Me.IpCollection.Where(Function(ip) ip.Name.Equals(propertyName))
            If (myProps.Count = 1) Then
               myProps.ElementAt(0).Value = propertyValue
            ElseIf (myProps.Count = 0) Then
               Me.IpCollection.Add(New IniProperty(propertyName, propertyValue))
            Else
               Throw New Exception(("Can't find/set value for: " + propertyName))
            End If

         Catch ex As Exception
            Throw ex
         End Try

      End Sub

      Public Function PropertyName_ToString(ByVal propertyName As String) As String

         Try
            Return Me.IpCollection.Where(Function(ip) ip.Name.Equals(propertyName)).First.Value
         Catch ex As Exception
            Throw New Exception(("Can't find/read value for: " + propertyName), ex)
         End Try

      End Function

   End Class

End Namespace