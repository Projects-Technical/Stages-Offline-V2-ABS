Imports System.Net
Imports System.IO
Imports System.Xml
Imports System.Threading
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports Newtonsoft.Json

Public Class Form1
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Delegate Sub MyDelegate()
    Dim thiscpuid As String = GetHash(SystemSerialNumber())

    Dim trd As Thread
    Dim runjson As Boolean = False
    Dim pollcount As Integer = 0
    Dim starttime(100) As DateTime
    Dim classlist As New List(Of Classes)
    Dim userlist As New List(Of usern)

    Public token As String

    Public examplexml As String = "<?xml version='1.0'?>
                    <Settings>
                      <Vismo_ID>visval</Vismo_ID>
                      <User_Name>usnval</User_Name>
                       <Secret>secval</Secret>
			<token>tokval</token>
			<bc2ip>bc2ipval</bc2ip>
			<bc2port>bc2portval</bc2port>
			<ipadip>ipadipval</ipadip>
			<start_macro>startval</start_macro>
			<stop_macro>stopval</stop_macro>
			<end_delay>endval</end_delay>
			<lead_in>leadval</lead_in>
                   </Settings>"

    Dim trd2 As Thread

    Dim scrun As Boolean = False

    Dim bc2ip As String
    Dim bc2port As Integer

    Dim ipadip As String
    Dim startmacro As String
    Dim stopmacro As String
    Dim cstart As DateTime
    Dim cstop As DateTime
    Dim Vid As Integer
    Dim Usn As String
    Dim Csecret As String
    Dim navgo As Boolean = False
    Dim navadr As String
    Public enddelay As Integer
    Public leadin As Integer
    Dim runmode As Integer = 0

    Dim testsite As Integer
    Dim teststudio As Integer

#Region "Security"

    Private Function SystemSerialNumber() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object =
            wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers =
            serial_numbers.Substring(2)


        Return serial_numbers
    End Function

    Shared Function GetHash(ByVal theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(System.Text.Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New System.Text.StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function
#End Region

#Region "Stages Class Info"
    Public Class usern
        Public Property ClientId As String
        Public Property ClientSecret As String


        Public Sub New(clid As String, clsec As String)
            ClientId = clid
            ClientSecret = clsec

        End Sub
    End Class
    <Serializable()>
    Public Class OfflineClasses
        Public Property time As TimeSpan
        Public Property duration As Integer

        Public Sub New(Start_Time As TimeSpan, Length As Integer)
            time = Start_Time

            duration = Length
        End Sub
    End Class

    <Serializable()>
    Public Class Classes
        Public Property Name As String
        Public Property StartDateTime As DateTime
        Public Property Duration As Integer
        Public Property Id As Integer
        Public Property InstructorId As Integer
        Public Property Type As String
        Public Property AvailableToBookBefore As String





        Public Sub New(n As String, dt As DateTime, d As Integer, cid As Integer, instid As Integer, classt As String, cldate As String)

            Name = n
            StartDateTime = dt
            Duration = d          ' some default
            Id = cid
            InstructorId = instid
            Type = classt
            AvailableToBookBefore = cldate


        End Sub

    End Class
#End Region

#Region "DLLABS"


    Public Class condensedSession
        Public Property name As String

        Public Property starttime As DateTime

        Public Property endtime As DateTime

        Public Property duration As Integer

        Public Property courseid As Integer


        Public Sub New(n As String, st As DateTime, et As DateTime, dur As Integer, cid As Integer)

            name = n

            starttime = st

            endtime = et

            duration = dur

            courseid = cid


        End Sub
    End Class

    <Serializable()>
    Public Class SessionsDetail
        Public Property courseId As Integer
        Public Property courseInstanceId As Integer
        Public Property courseTemplateId As Integer
        Public Property [date] As Date
        Public Property startTime As TimeSpan
        Public Property duration As Integer
        Public Property name As String
        Public Property level As String
        Public Property levelTranslationKey As String
        Public Property instructorNames As List(Of String)
        Public Property instructorProfileIds As List(Of Integer)
        Public Property status As String
    End Class

    Public Class Video
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class EnGb
        Public Property title As String
        Public Property subtitle As String
        Public Property description As String
    End Class

    Public Class ItIt
        Public Property title As String
        Public Property subtitle As String
        Public Property description As String
    End Class

    Public Class DeDe
        Public Property title As String
        Public Property subtitle As String
        Public Property description As String
    End Class

    Public Class FrBe
        Public Property title As String
        Public Property subtitle As String
        Public Property description As String
    End Class

    Public Class EsEs
        Public Property title As String
        Public Property subtitle As String
        Public Property description As String
    End Class

    Public Class FrFr
        Public Property title As String
        Public Property subtitle As String
        Public Property description As String
    End Class

    Public Class NlBe
        Public Property title As String
        Public Property subtitle As String
        Public Property description As String
    End Class

    Public Class Ca
        Public Property title As String
        Public Property subtitle As String
        Public Property description As String
    End Class

    Public Class DetailsByLanguages
        Public Property engb As EnGb
        Public Property itit As ItIt
        Public Property dede As DeDe
        Public Property frbe As FrBe
        Public Property eses As EsEs
        Public Property frfr As FrFr
        Public Property nlbe As NlBe
        Public Property ca As Ca
    End Class

    Public Class HeroImageUrlByBrand
        Public Property harbour As String
        Public Property davidlloyd As String
        Public Property germany As String
        Public Property barcelona As String
        Public Property netherlands As String
        Public Property france As String
        Public Property belgium As String
        Public Property italy As String
        Public Property ireland As String
    End Class

    Public Class LogoImageUrlByBrand
        Public Property harbour As String
        Public Property davidlloyd As String
        Public Property germany As String
        Public Property barcelona As String
        Public Property netherlands As String
        Public Property france As String
        Public Property belgium As String
        Public Property italy As String
        Public Property ireland As String
    End Class

    Public Class Harbour
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class DavidLloyd
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class Barcelona
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class Germany
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class Netherlands
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class France
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class Belgium
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class Italy
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class Ireland
        Public Property videoId As Object
        Public Property videoType As Object
    End Class

    Public Class VideoByBrand
        Public Property harbour As Harbour
        Public Property davidlloyd As DavidLloyd
        Public Property barcelona As Barcelona
        Public Property germany As Germany
        Public Property netherlands As Netherlands
        Public Property france As France
        Public Property belgium As Belgium
        Public Property italy As Italy
        Public Property ireland As Ireland
    End Class

    Public Class Template
        Public Property templateId As Integer
        Public Property title As String
        Public Property subtitle As String
        Public Property description As String
        Public Property heroImageUrl As String
        Public Property logoImageUrl As String
        Public Property video As Video
        Public Property detailsByLanguages As DetailsByLanguages
        Public Property heroImageUrlByBrand As HeroImageUrlByBrand
        Public Property logoImageUrlByBrand As LogoImageUrlByBrand
        Public Property videoByBrand As VideoByBrand
    End Class

    Public Class DLLClassEntries
        Public Property sessionsDetails As List(Of SessionsDetail)
        Public Property templates As List(Of Template)
    End Class


#End Region
    Dim offlinelist As List(Of OfflineClasses) = New List(Of OfflineClasses)
    Dim sortedlist As List(Of OfflineClasses) = New List(Of OfflineClasses)

    Dim abslist As List(Of SessionsDetail) = New List(Of SessionsDetail)
    Dim sortedabs As List(Of SessionsDetail) = New List(Of SessionsDetail)



    Dim dow As Day

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'MsgBox(SystemSerialNumber)
        Me.BringToFront()

        Dim wc As WebClient = New WebClient

        Dim returnval As String = wc.DownloadString("http://www.htanalytics.co.uk/stages/getauth.aspx?id=" & thiscpuid)

        If returnval.Contains("NOAUTH") Then
            Clipboard.SetText(thiscpuid)

            MsgBox("You are not authorised to use this application" & vbCrLf & "Your request number is: " & thiscpuid, vbInformation)

            End
        End If

        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\logs\") Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\logs\")

        End If
        Dim xmlnode As String
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\" & "Settings.xml") Then
            xmlnode = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\" & "Settings.xml")
        Else
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory & "\" & "Settings.xml", "<?xml version='1.0'?>
            <Settings>
            <Vismo_ID>0</Vismo_ID>
            <User_Name>unset</User_Name>
            <Secret>unset</Secret>
			<token>unser</token>
			<bc2ip>192.168.0.2</bc2ip>
			<bc2port>5000</bc2port>
			<ipadip>192.168.0.10</ipadip>
			<start_macro>bwc:macro:2:</start_macro>
			<stop_macro>bwc:macro:4:</stop_macro>
			<end_delay>90</end_delay>
			<lead_in>60</lead_in>
            </Settings>", False)
            xmlnode = "<?xml version='1.0'?>
            <Settings>
            <Vismo_ID>0</Vismo_ID>
            <User_Name>unset</User_Name>
            <Secret>unset</Secret>
			<token>unser</token>
			<bc2ip>192.168.0.2</bc2ip>
			<bc2port>5000</bc2port>
			<ipadip>192.168.0.10</ipadip>
			<start_macro>bwc:macro:2:</start_macro>
			<stop_macro>bwc:macro:4:</stop_macro>
			<end_delay>90</end_delay>
			<lead_in>60</lead_in>
            </Settings>"
        End If

        Dim lastname As String = ""
        Dim xreader As XmlReader = XmlReader.Create(New StringReader(xmlnode))
        Dim readid As String = 0
        While (xreader.Read())


            If xreader.NodeType = Xml.XmlNodeType.Element Then
                lastname = xreader.Name
                If xreader.HasAttributes And xreader.GetAttribute("length") <> Nothing And xreader.GetAttribute("length") > 0 Then
                    readid = xreader.GetAttribute("length")


                End If
            End If


            If xreader.NodeType = XmlNodeType.Text Then
                If lastname = "Vismo_ID" Then

                    Vid = xreader.Value


                ElseIf lastname = "User_Name" Then
                    Usn = xreader.Value
                    ' MsgBox(xreader.Value)
                ElseIf lastname = "Secret" Then
                    Csecret = xreader.Value
                    ' MsgBox(xreader.Value)
                ElseIf lastname = "bc2ip" Then
                    bc2ip = xreader.Value
                    'MsgBox(xreader.Value)
                ElseIf lastname = "bc2port" Then
                    bc2port = xreader.Value
                    ' MsgBox(xreader.Value)
                ElseIf lastname = "ipadip" Then
                    ipadip = xreader.Value
                    'MsgBox(xreader.Value)
                ElseIf lastname = "start_macro" Then
                    startmacro = xreader.Value
                    ' MsgBox(xreader.Value)
                ElseIf lastname = "stop_macro" Then
                    stopmacro = xreader.Value

                ElseIf lastname = "end_delay" Then
                    enddelay = xreader.Value
                    'MsgBox(xreader.Value)
                ElseIf lastname = "lead_in" Then
                    leadin = xreader.Value
                    ' MsgBox(xreader.Value)
                ElseIf lastname = "token" Then
                    token = xreader.Value
                    ' MsgBox(xreader.Value)
                ElseIf lastname.ToLower = "runmode" Then

                    runmode = Integer.Parse(xreader.Value)


                ElseIf lastname = "classentry" Then




                    offlinelist.Add(New OfflineClasses(TimeSpan.Parse(xreader.Value), readid))


                ElseIf lastname.ToLower = "absstudioid" Then
                    teststudio = Integer.Parse(xreader.Value)
                ElseIf lastname.ToLower = "abssiteid" Then
                    testsite = Integer.Parse(xreader.Value)


                End If
            End If
        End While



        sortedlist = offlinelist.OrderBy(Function(d) d.time).ToList



        'Vid = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "VismoID", "abc")
        'Usn = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "UserName", "abc")
        'Csecret = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "SecString", "abc")
        userlist.Add(New usern(Usn, Csecret))
        getauth()
        Thread.Sleep(1000)
        '' token = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "Token", "abc")
        'bc2ip = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "BC2IP", "abc")
        'bc2port = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "BC2Port", "abc")
        'ipadip = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "iPadIP", "abc")
        'startmacro = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "StartName", "abc")
        'stopmacro = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "StopName", "abc")
        'enddelay = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "Outro", "90")
        'leadin = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\HutchisonTechnologies\VismoX", "Intro", "60")

        If enddelay = Nothing Or enddelay = 0 Then
            enddelay = 90
        End If

        If leadin = Nothing Or leadin = 0 Then
            leadin = 60
        End If
        'Me.Text = "test"

        trd = New Thread(AddressOf checkjson)

        trd.IsBackground = True
        runjson = True

        trd.Start()

        trd2 = New Thread(AddressOf SendCommand)
        trd2.IsBackground = True
        scrun = True

        trd2.Start()

#If DEBUG Then
        frmjson.Show()

#End If

    End Sub
    Public Sub getauth()
        Try


            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse

            myReq = HttpWebRequest.Create("https://stagesflight.com/locapi/v1/auth/" & Vid)

            myReq.Method = "POST"
            myReq.ContentType = "application/json"
            myReq.Headers.Add("Authorization", "Basic " & Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("username:password")))
            Dim myData As String = "{" & Chr(34) & "ClientId" & Chr(34) & ":" & Chr(34) & Usn & Chr(34) & "," & Chr(34) & "ClientSecret" & Chr(34) & ":" & Chr(34) & Csecret & Chr(34) & "}"
            myReq.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(myData), 0, System.Text.Encoding.UTF8.GetBytes(myData).Count)
            myResp = myReq.GetResponse
            Dim myreader As New System.IO.StreamReader(myResp.GetResponseStream)
            Dim myText As String
            myText = myreader.ReadToEnd
            myText = myText.Replace(Chr(34), "")

            token = myText
            authfailed = False
            writelogs("Authentication Successful - " & myText, True)
            ListBox1.Items.Insert(0, "Get Auth Successful at " & Now.ToShortTimeString)
        Catch ex As Exception
            writelogs("Authentication Failed", True)
            'Me.Text = "Could not refresh authentication"
            authfailed = True

        End Try
    End Sub
    Dim authfailed As Boolean = False
    Dim runjsn As Integer = 0
    Public Sub checkjson()


        While runjson = True



            runjsn = runjsn + 1
            lblrunjson.Text = runjsn

            ListBox1.Items.Insert(0, "Polling for class updates" & " at " & Now.ToLongTimeString)


            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim reader As StreamReader


            Try
                Dim modelc As List(Of stagesclass) = New List(Of stagesclass)
                If runmode = 0 Then


                    If authfailed = True Then
                        ListBox1.Items.Insert(0, "Get Auth Failed - Retrying at " & Now.AddSeconds(15).ToLongTimeString)

                        getauth()
                        writelogs("Authentication Expired", True)
                    End If
                    Dim eod As DateTime = New DateTime(Now.Date.Year, Now.Date.Month, Now.Date.Day, Now.TimeOfDay.Hours, Now.TimeOfDay.Minutes, Now.TimeOfDay.Seconds)
                    myReq = HttpWebRequest.Create("https://stagesflight.com/locapi/v1/sessions")
                    classlist.Clear()


                    myReq.Method = "GET"
                    myReq.ContentType = "application/json"

                    myReq.Headers.Add("Authorization", "Bearer " & token)


                    myResp = myReq.GetResponse



                    Dim myreader As New System.IO.StreamReader(myResp.GetResponseStream)
                    Dim myText As String
                    myText = myreader.ReadToEnd()

                    Dim Jsonstring2 As String = myText


                    Dim model = JsonConvert.DeserializeObject(Of List(Of stagesclass))(Jsonstring2)


                    Dim modelb As List(Of stagesclass) = model.OrderBy(Function(d) d.StartDateTime).ToList



                    txtJson.Text = ""
                    For Each c As stagesclass In modelb
                        If c.StartDateTime.AddMinutes(c.Duration) > Now Then
                            modelc.Add(c)
                            txtJson.Text = txtJson.Text & ("Classname: " & c.Name & " Date: " & c.StartDateTime & " Length: " & c.Duration) & vbCrLf
                        End If
                    Next


                ElseIf runmode = 1 Then
                    Dim stepint As Integer = 0

                    For Each c In sortedlist
                        stepint = stepint + 1
                        Dim classdt As Date = New Date(Now.Year, Now.Month, Now.Day, c.time.Hours, c.time.Minutes, c.time.Seconds)
                        If Now < classdt Then

                            modelc.Add(New stagesclass(c.duration, "Offline Class " & stepint, New Date(Now.Year, Now.Month, Now.Day, c.time.Hours, c.time.Minutes, c.time.Seconds), c.duration, 0, 0, "Nothing", "Nothing"))

                        End If
                    Next

                ElseIf runmode = 2 Then
                    Try



                        Dim wc As WebClient = New WebClient()
                        Dim absjson As String = wc.DownloadString("https://staff-back.davidlloyd.co.uk/clubs/" & testsite & "/studio/" & teststudio & "/sessions/timetable")

                        Dim nlist As DLLClassEntries = New DLLClassEntries

                        nlist = JsonConvert.DeserializeObject(Of DLLClassEntries)(absjson)

                        Dim sortdata As List(Of condensedSession) = New List(Of condensedSession)



                        For Each c As SessionsDetail In nlist.sessionsDetails
                            If c.courseTemplateId = 15865 Then


                                sortdata.Add(New condensedSession(c.name, DateTime.Parse(c.date.ToShortDateString & " " & c.startTime.ToString), DateTime.Parse(c.date.ToShortDateString & " " & c.startTime.ToString).AddMinutes(c.duration), c.duration, c.courseId))
                            End If

                        Next

                        Dim sortdatab As List(Of condensedSession) = New List(Of condensedSession)

                        sortdatab = sortdata.OrderBy(Function(d) d.starttime).ToList


                        Dim starttimes As String = ""

                        For Each c As condensedSession In sortdatab

                            modelc.Add(New stagesclass(c.courseid, c.name, c.starttime, c.duration, 0, teststudio, "CYCLONE VIRTUAL", "True"))

                        Next



                    Catch ex As Exception

                    End Try
                End If


                If modelc.Count > 0 Then
                    nclass = modelc.Item(0).StartDateTime
                    If nclass <> cclass Then




                        Me.Text = "Next Up: " & modelc.Item(0).Name & " at: " & modelc.Item(0).StartDateTime & " Duration: " & modelc.Item(0).Duration & " minutes"





                        cclass = modelc.Item(0).StartDateTime
                        cstart = modelc.Item(0).StartDateTime
                        classdur = modelc.Item(0).Duration

                        cstarttime = TimeSpan.Parse(cstart.ToShortTimeString)

                        ListBox1.Items.Insert(0, "Next Class Set" & " at " & Now.ToShortTimeString)

                        ListBox1.Items.Insert(0, "Name:" & modelc(0).Name)
                        ListBox1.Items.Insert(0, "Time: " & modelc(0).StartDateTime)
                        ListBox1.Items.Insert(0, "Duration: " & modelc(0).Duration & "mins")
                        cstartset = True

                    End If




                Else
                    Me.Text = "No Classes Scheduled Today"
                End If



            Catch ex As Exception
                ' txtJson.Text = txtJson.Text & (ex.ToString)

                'MsgBox(ex.ToString)
            End Try

            Thread.Sleep(15000)

            ' modelb.Clear()
            pollcount = pollcount + 1


        End While
    End Sub
    Dim cclass As DateTime

    Dim nclass As DateTime
    Dim classstart As DateTime
    Dim cstartset As Boolean = False
    Dim classdur As Integer = 0
    Dim classend As DateTime
    Dim lastclassend As DateTime
    Dim cendset As Boolean = False
    Dim cstarttime As TimeSpan
    Dim datetimenow As DateTime
    Dim incremental As Integer
    Dim timearray(1000) As DateTime
    Dim sendactive As Boolean = False



    Private Sub SendCommand()
        Try



            While scrun = True




                datetimenow = Now

                If cstartset = True Then

                    If datetimenow.Date = cstart.Date Then

                        If datetimenow.AddSeconds(leadin) >= cstart And Now <= cstart.AddMinutes(classdur) Then


                            lastclassend = cstart.AddMinutes(classdur)
                            SendC(startmacro)

                            ListBox1.Items.Insert(0, "Sent Start - " & startmacro & " at " & Now.ToShortTimeString)
                            writelogs("Sent Start - " & startmacro & " at " & Now & vbCrLf, True)

                            Thread.Sleep(1500)

                            cendset = True

                            cstartset = False
                            sendactive = True

                        End If
                    End If
                End If


                If cendset = True Then

                    If datetimenow.Date = cstart.Date Then


                        If (lastclassend.AddSeconds(enddelay) < cstart) Or classlist.Count = 0 Then

                            If sendactive = True Then
                                ListBox1.Items.Insert(0, "Off Activated - Set for: " & lastclassend.TimeOfDay.ToString)
                                ToolStripTextBox1.Text = lastclassend.AddSeconds(enddelay).TimeOfDay.ToString



                                sendactive = False

                            End If

                            If datetimenow >= lastclassend.AddSeconds(enddelay) Then

                                ListBox1.Items.Insert(0, "Preparing End Command")


                                SendC(stopmacro)
                                ListBox1.Items.Insert(0, "Sent End - " & stopmacro & " at " & Now.ToShortTimeString)
                                ToolStripTextBox1.Text = ""

                                writelogs("Sent Stop - " & stopmacro & " at " & Now & vbCrLf, True)
                                Thread.Sleep(1500)
                                cendset = False


                            End If
                        End If
                    End If
                End If




                Thread.Sleep(10)

            End While
        Catch ex As Exception

            'MsgBox(ex.ToString)


        End Try
    End Sub

    Dim sndmode As Integer = 0
    Private Sub writelogs(ByVal text As String, ByVal append As Boolean)
        Try

            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\logs\") Then
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\logs\" & Now.Day & Now.Month & Now.Year & ".HTLog", Now.ToLongTimeString & " - " & text & vbCrLf, append)
            Else
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\logs\")
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\logs\" & Now.Day & Now.Month & Now.Year & ".HTLog", Now.ToLongTimeString & " - " & text & vbCrLf, append)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub SendC(ByVal cmd As String)

        Try

            If sndmode = 0 Then
                Dim tcpcl As TcpClient = New TcpClient()

                tcpcl.Connect(New IPEndPoint(IPAddress.Parse(bc2ip), bc2port))
                Dim sendbyte As Byte() = System.Text.Encoding.ASCII.GetBytes(cmd & vbCrLf)
                Dim ns As NetworkStream = tcpcl.GetStream

                ns.Write(sendbyte, 0, sendbyte.Length)

                ns.Close()
                tcpcl.Close()
            ElseIf sndmode = 1 Then
                If cmd = startmacro Then

                    WebBrowser1.Navigate("http://127.0.0.1:1022?command=68,111,95,78,97,118,61,72,111,109,101,112,97,103,101,86,105,114,116,117,97,108,13,255,255")
                ElseIf cmd = stopmacro Then



                    WebBrowser1.Navigate("http://127.0.0.1:1022?command=68,111,95,78,97,118,61,72,111,109,101,112,97,103,101,13,255,255")


                End If


            End If


        Catch ex As Exception
            writelogs("Failed Connection to BC2 - " & Now & vbCrLf, True)
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try

            scrun = False
            runjson = False

            trd.Abort()
            trd2.Abort()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Shell("http://www.hutchison-t.com")
        Process.Start("http://www.hutchison-t.com")
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()

    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("http://www.hutchison-t.com")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim passcode As String = "Hutch150n"
        Dim trypass As String = InputBox("Enter the password", "Password")

        If trypass = passcode Then
            frmSettings.Show()
        End If


    End Sub

    Private Sub SendTestCommandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendTestCommandToolStripMenuItem.Click

        If teststat = False Then

            Dim TestTrd As New Thread(AddressOf testcommand)
            TestTrd.Start()
            TestTrd.IsBackground = True

        Else
            MsgBox("There is currently another test running")
        End If





    End Sub
    Dim teststat As Boolean = False

    Private Sub testcommand()
        teststat = True
        If sndmode = 0 Then

            Try
                Dim tcpcl As New TcpClient
                tcpcl.Connect(New IPEndPoint(IPAddress.Parse(bc2ip), bc2port))
                Dim sendbyte As Byte() = System.Text.Encoding.ASCII.GetBytes(startmacro & vbCrLf)
                tcpcl.Client.Send(sendbyte)

                ListBox1.Items.Insert(0, "Sent Test Command")
                Thread.Sleep(120000)

                sendbyte = System.Text.Encoding.ASCII.GetBytes(stopmacro & vbCrLf)
                tcpcl.Client.Send(sendbyte)
                ListBox1.Items.Insert(0, "Sending Test Command - Off")


                tcpcl.Close()


            Catch ex As Exception
                MsgBox("No Connection Could Be Made")
            End Try
        ElseIf sndmode = 1 Then

            navadr = ("http://127.0.0.1:1022?command=68,111,95,78,97,118,61,72,111,109,101,112,97,103,101,86,105,114,116,117,97,108,13,255,255")

            navgo = True


            Thread.Sleep(120000)


            navadr = ("http://127.0.0.1:1022?command=68,111,95,78,97,118,61,72,111,109,101,112,97,103,101,13,255,255")
            navgo = True




        End If

        teststat = False


    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If navgo = True Then
            WebBrowser1.Navigate(navadr)
            navgo = False

        End If

        lblCnd.Text = cendset
        lblCstrt.Text = cstartset

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub
End Class

Public Class ItemDetails

    Public id As Integer
    Public name As String
    Public startdatetime As DateTime
    Public duration As Integer
    Public instructorid As Integer
    Public locationid As Integer
    Public cltype As String
    Public bookbefore As String


End Class

Public Class ItemArray

    Public DetailList As List(Of ItemDetails)
    Public Duplicated As String

End Class

Public Class GeneralArray

    Public GeneralList As List(Of ItemArray)

End Class

Public Class stagesclass
    Property Id As String

    Property Name As String

    Property StartDateTime As DateTime

    Property Duration As Integer

    Property InstructorId As Integer

    Property LocationId As Integer

    Property Type As String

    Property AvailableToBookBefore As String

    Public Sub New(i As String, n As String, sdt As DateTime, dur As Integer, insid As Integer, locid As Integer, typ As String, avail As String)
        Id = i

        Name = n

        StartDateTime = sdt

        Duration = dur

        InstructorId = insid

        LocationId = locid

        Type = typ

        AvailableToBookBefore = avail

    End Sub
End Class