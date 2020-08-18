Imports System.IO
Imports System.Xml
Public Class frmSettings
    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "BC2IP", autoip.Text)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "BC2Port", autoport.Text)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "iPadIP", ipadip.Text)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "SecString", secret.Text)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "StartName", startcmd.Text)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "StopName", endcmd.Text)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "UserName", apiusn.Text)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "VismoID", apiid.Text)

        Dim newxml As String = Form1.examplexml

        newxml = newxml.Replace("visval", apiid.Text)
        newxml = newxml.Replace("usnval", apiusn.Text)
        newxml = newxml.Replace("secval", secret.Text)
        newxml = newxml.Replace("bc2ipval", autoip.Text)
        newxml = newxml.Replace("bc2portval", autoport.Text)
        newxml = newxml.Replace("ipadipval", ipadip.Text)
        newxml = newxml.Replace("startval", startcmd.Text)
        newxml = newxml.Replace("stopval", endcmd.Text)
        newxml = newxml.Replace("endval", Form1.enddelay)
        newxml = newxml.Replace("leadval", Form1.leadin)
        newxml = newxml.Replace("tokval", Form1.token)


        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/" & "Settings.xml", newxml, False)


        MsgBox("Application Will Restart to re-load values", vbInformation, "Restart")

        Application.Restart()

    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'autoip.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "BC2IP", autoip.Text)
        'autoport.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "BC2Port", autoport.Text)
        'ipadip.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "iPadIP", ipadip.Text)
        'secret.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "SecString", secret.Text)
        'startcmd.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "StartName", startcmd.Text)
        'endcmd.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "StopName", endcmd.Text)
        'apiusn.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "UserName", apiusn.Text)
        'apiid.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "VismoID", apiid.Text)
        Dim xmlnode As String
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "/" & "Settings.xml") Then
            xmlnode = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "/" & "Settings.xml")
        Else
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "/" & "Settings.xml", "<?xml version='1.0'?>
            <Settings>
            <Vismo_ID>unset</Vismo_ID>
            <User_Name>unset</User_Name>
            <Secret>unset</Secret>
			<token>unser</token>
			<bc2ip>unset</bc2ip>
			<bc2port>unset</bc2port>
			<ipadip>unser</ipadip>
			<start_macro>bwc:macro:2:</start_macro>
			<stop_macro>bwc:macro:4:</stop_macro>
			<end_delay>90</end_delay>
			<lead_in>60</lead_in>
            </Settings>", False)
            xmlnode = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "/" & "Settings.xml")
        End If
        Dim lastname As String = ""
        Dim xreader As XmlReader = XmlReader.Create(New StringReader(xmlnode))
        While (xreader.Read())
            If xreader.NodeType = Xml.XmlNodeType.Element Then
                lastname = xreader.Name


            End If

            If xreader.NodeType = XmlNodeType.Text Then
                If lastname = "Vismo_ID" Then
                    apiid.Text = xreader.Value
                ElseIf lastname = "User_Name" Then
                    apiusn.Text = xreader.Value
                ElseIf lastname = "Secret" Then
                    secret.Text = xreader.Value
                ElseIf lastname = "bc2ip" Then
                    autoip.Text = xreader.Value
                ElseIf lastname = "bc2port" Then
                    autoport.Text = xreader.Value
                ElseIf lastname = "ipadip" Then
                    ipadip.Text = xreader.Value
                ElseIf lastname = "start_macro" Then
                    startcmd.Text = xreader.Value
                ElseIf lastname = "stop_macro" Then
                    endcmd.Text = xreader.Value


                End If
            End If

        End While
    End Sub
End Class