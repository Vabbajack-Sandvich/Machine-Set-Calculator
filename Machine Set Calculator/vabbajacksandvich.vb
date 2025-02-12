Module vabbajacksandvich

    ' this is my bas file (yes i know its a vb file module)
    ' but modules used to be called bas files
    ' so i will forever refer to it as a bas file
    ' i use it between projects so its got some random other crap in it
    ' thats not related to this project

    Public Structure POINTAPI
        Public X1 As Long
        Public Y1 As Long
    End Structure

    Public zQ As String = Chr(34)

    Public zTf2Class As String = "engineer"

    Public Declare Function GetCursorPos Lib "user32" (lpPoint As POINTAPI) As Long
    Public Declare Function ScreenToClient Lib "user32" (ByVal hWnd As Long, lpPoint As POINTAPI) As Long

    Function MouseX(Optional ByVal hWnd As Long = 0) As Long
        ' Get mouse X coordinates in pixels
        ' If a window handle is passed, the result is relative to the client area
        ' of that window, otherwise the result is relative to the screen
        Dim lpPoint As POINTAPI
        GetCursorPos(lpPoint)
        If hWnd Then ScreenToClient(hWnd, lpPoint)
        MouseX = lpPoint.X1
    End Function

    Function MouseY(Optional ByVal hWnd As Long = 0) As Long
        ' Get mouse Y coordinates in pixels
        ' If a window handle is passed, the result is relative to the client area
        ' of that window, otherwise the result is relative to the screen
        Dim lpPoint As POINTAPI
        GetCursorPos(lpPoint)
        If hWnd Then ScreenToClient(hWnd, lpPoint)
        MouseY = lpPoint.Y1
    End Function

    Public Function zNumFilter(zNf As String) As String
        'this filters out any characters that arent 0 through 9
        'it leaves them in the original order
        'then it passes the filtered string back

        'adding decimal for this program

        If zNf = "" Then Exit Function

        Dim zNfi As Long
        Dim zNfos As String
        Dim zNfl As Long
        Dim zNfis As String
        zNfl = Len(zNf)
        For zNfi = 1 To zNfl
            zNfis = Mid(zNf, zNfi, 1)
            Select Case zNfis
                Case "0"
                    zNfos = zNfos & "0"
                Case "1"
                    zNfos = zNfos & "1"
                Case "2"
                    zNfos = zNfos & "2"
                Case "3"
                    zNfos = zNfos & "3"
                Case "4"
                    zNfos = zNfos & "4"
                Case "5"
                    zNfos = zNfos & "5"
                Case "6"
                    zNfos = zNfos & "6"
                Case "7"
                    zNfos = zNfos & "7"
                Case "8"
                    zNfos = zNfos & "8"
                Case "9"
                    zNfos = zNfos & "9"
                Case "."
                    zNfos = zNfos & "."
                Case Else
                    zNfos = zNfos & ""
            End Select
        Next
        zNumFilter = zNfos
    End Function

    Public Function zAlphaNumFilter(zANf As String) As String
        'this filters out any characters that arent 0 through 9
        'it leaves them in the original order
        'then it passes the filtered string back
        If zANf = "" Then Exit Function

        zANf = LCase(zANf)

        Dim zANfi As Long
        Dim zANfos As String
        Dim zANfl As Long
        Dim zANfis As String
        zANfl = Len(zANf)
        For zANfi = 1 To zANfl
            zANfis = Mid(zANf, zANfi, 1)
            Select Case zANfis
                Case "0"
                    zANfos = zANfos & "0"
                Case "1"
                    zANfos = zANfos & "1"
                Case "2"
                    zANfos = zANfos & "2"
                Case "3"
                    zANfos = zANfos & "3"
                Case "4"
                    zANfos = zANfos & "4"
                Case "5"
                    zANfos = zANfos & "5"
                Case "6"
                    zANfos = zANfos & "6"
                Case "7"
                    zANfos = zANfos & "7"
                Case "8"
                    zANfos = zANfos & "8"
                Case "9"
                    zANfos = zANfos & "9"
                Case "a"
                    zANfos = zANfos & "a"
                Case "b"
                    zANfos = zANfos & "b"
                Case "c"
                    zANfos = zANfos & "c"
                Case "d"
                    zANfos = zANfos & "d"
                Case "e"
                    zANfos = zANfos & "e"
                Case "f"
                    zANfos = zANfos & "f"
                Case "g"
                    zANfos = zANfos & "g"
                Case "h"
                    zANfos = zANfos & "h"
                Case "i"
                    zANfos = zANfos & "i"
                Case "j"
                    zANfos = zANfos & "j"
                Case "k"
                    zANfos = zANfos & "k"
                Case "l"
                    zANfos = zANfos & "l"
                Case "m"
                    zANfos = zANfos & "m"
                Case "n"
                    zANfos = zANfos & "n"
                Case "o"
                    zANfos = zANfos & "o"
                Case "p"
                    zANfos = zANfos & "p"
                Case "q"
                    zANfos = zANfos & "q"
                Case "r"
                    zANfos = zANfos & "r"
                Case "s"
                    zANfos = zANfos & "s"
                Case "t"
                    zANfos = zANfos & "t"
                Case "u"
                    zANfos = zANfos & "u"
                Case "v"
                    zANfos = zANfos & "v"
                Case "w"
                    zANfos = zANfos & "w"
                Case "x"
                    zANfos = zANfos & "x"
                Case "y"
                    zANfos = zANfos & "y"
                Case "z"
                    zANfos = zANfos & "z"
                Case Else
                    zANfos = zANfos & ""
            End Select
        Next
        zAlphaNumFilter = zANfos
    End Function

    Public Function zAlphaNumFilterWithDashPlus(zANf As String) As String
        'this filters out any characters that arent 0 through 9
        'and symbols
        'it leaves them in the original order
        'then it passes the filtered string back
        If zANf = "" Then Exit Function

        zANf = LCase(zANf)

        Dim zANfi As Long
        Dim zANfos As String
        Dim zANfl As Long
        Dim zANfis As String
        zANfl = Len(zANf)
        For zANfi = 1 To zANfl
            zANfis = Mid(zANf, zANfi, 1)
            Select Case zANfis
                Case "0"
                    zANfos = zANfos & "0"
                Case "1"
                    zANfos = zANfos & "1"
                Case "2"
                    zANfos = zANfos & "2"
                Case "3"
                    zANfos = zANfos & "3"
                Case "4"
                    zANfos = zANfos & "4"
                Case "5"
                    zANfos = zANfos & "5"
                Case "6"
                    zANfos = zANfos & "6"
                Case "7"
                    zANfos = zANfos & "7"
                Case "8"
                    zANfos = zANfos & "8"
                Case "9"
                    zANfos = zANfos & "9"
                Case "a"
                    zANfos = zANfos & "a"
                Case "b"
                    zANfos = zANfos & "b"
                Case "c"
                    zANfos = zANfos & "c"
                Case "d"
                    zANfos = zANfos & "d"
                Case "e"
                    zANfos = zANfos & "e"
                Case "f"
                    zANfos = zANfos & "f"
                Case "g"
                    zANfos = zANfos & "g"
                Case "h"
                    zANfos = zANfos & "h"
                Case "i"
                    zANfos = zANfos & "i"
                Case "j"
                    zANfos = zANfos & "j"
                Case "k"
                    zANfos = zANfos & "k"
                Case "l"
                    zANfos = zANfos & "l"
                Case "m"
                    zANfos = zANfos & "m"
                Case "n"
                    zANfos = zANfos & "n"
                Case "o"
                    zANfos = zANfos & "o"
                Case "p"
                    zANfos = zANfos & "p"
                Case "q"
                    zANfos = zANfos & "q"
                Case "r"
                    zANfos = zANfos & "r"
                Case "s"
                    zANfos = zANfos & "s"
                Case "t"
                    zANfos = zANfos & "t"
                Case "u"
                    zANfos = zANfos & "u"
                Case "v"
                    zANfos = zANfos & "v"
                Case "w"
                    zANfos = zANfos & "w"
                Case "x"
                    zANfos = zANfos & "x"
                Case "y"
                    zANfos = zANfos & "y"
                Case "z"
                    zANfos = zANfos & "z"
                Case "-"
                    zANfos = zANfos & "-"
                Case "+"
                    zANfos = zANfos & "+"
                Case Else
                    zANfos = zANfos & ""
            End Select
        Next
        zAlphaNumFilterWithDashPlus = zANfos
    End Function

    Public Sub zClearCheckListBoxChecks(zCkLb As CheckedListBox, Optional zIndex As Integer = -1)
        'cklbOtherBotCmd
        'this clears all the checks in the check list box
        'if the index is specfied then it will ignore clearing that index
        'adding the optional means i dont have to change the retro active usages
        Dim zCount As Integer
        zCount = zCkLb.Items.Count
        If zCount = 0 Then Exit Sub
        Dim zCycle As Integer
        zCycle = 0
        For zCycle = 0 To zCount - 1
            If zIndex = -1 Then
                zCkLb.SetItemChecked(zCycle, False)
            Else
                If zCycle <> zIndex Then
                    zCkLb.SetItemChecked(zCycle, False)
                End If
            End If
        Next
    End Sub

    Public Function zTrimLeadingZero(zTlzs As String) As String
        'filters out any characters but 0 to 9 using znumfilter
        'then returns a whole number without any potential leading zeros
        zTlzs = zNumFilter(zTlzs)
        If zTlzs = "" Then
            zTlzs = "0"
            Return zTlzs
        Else
            Dim zTcfc As String
            Dim zTs As String
            Dim zSetPass As Boolean
            Dim zTsL As Long

            zTs = zTlzs
            zSetPass = False

            Do
                'this filters out as many potential leading 0s
                'and trims the output to a whole number
                zTsL = Len(zTs)
                If zTsL > 1 Then
                    zTcfc = Mid(zTs, 1, 1)
                    If zTcfc = "0" Then
                        zTs = Mid(zTs, 2, zTsL - 1)
                    Else
                        zSetPass = True
                    End If
                ElseIf zTsL = 1 Then
                    zSetPass = True
                Else
                    zTlzs = "0"
                    Return zTlzs
                    Exit Function
                End If

            Loop Until zSetPass = True

            zTlzs = zTs
            Return zTlzs
        End If
    End Function

    Public Function zTrimLeadingZero2(zTlzs As String) As String
        'filters out any characters but 0 to 9 using znumfilter
        'then returns a whole number without any potential leading zeros
        'this version returns nothing instead of zero
        zTlzs = zNumFilter(zTlzs)
        If zTlzs = "" Then
            'zTlzs = "0"
            zTlzs = ""
            Return zTlzs
        Else
            Dim zTcfc As String
            Dim zTs As String
            Dim zSetPass As Boolean
            Dim zTsL As Long

            zTs = zTlzs
            zSetPass = False

            Do
                'this filters out as many potential leading 0s
                'and trims the output to a whole number
                zTsL = Len(zTs)
                If zTsL > 1 Then
                    zTcfc = Mid(zTs, 1, 1)
                    If zTcfc = "0" Then
                        zTs = Mid(zTs, 2, zTsL - 1)
                    Else
                        zSetPass = True
                    End If
                ElseIf zTsL = 1 Then
                    zSetPass = True
                Else
                    zTlzs = "0"
                    Return zTlzs
                    Exit Function
                End If

            Loop Until zSetPass = True

            zTlzs = zTs
            Return zTlzs
        End If
    End Function


    Public Function zTextLinesToListbox(zTxt As TextBox, zList As ListBox, Optional zListClear As Integer = 0)
        'this assumes that whichever text or list box exists
        'and is correct
        'this function adds every line of text to a list box
        'this also clears the list box based on zListClear
        'this wont clear the list unless its set to 1
        'this also trims return characters when adding entires
        'this also trims blank lines vbcrlf



        If zTxt.Text = vbNullString Then Exit Function
        'have to make sure the last character is a return character
        Dim zLastCharacter1 As String
        Dim zLastCharacter2 As String
        zLastCharacter1 = Mid(zTxt.Text, Len(zTxt.Text))
        zLastCharacter2 = Mid(zTxt.Text, Len(zTxt.Text) - 1)

        If zLastCharacter1 <> Chr(13) And zLastCharacter2 <> Chr(10) Then
            zTxt.Text = zTxt.Text & vbCrLf
        End If

        Dim zRt As Integer, zRt2 As Integer, zTstr As String
        Dim zRstop As Boolean
        zRstop = False
        zRt = InStr(zTxt.Text, vbCrLf)
        If zRt = 0 Then
            'no return character
            'assuming just one line
            If zListClear = 1 Then
                zList.Items.Clear()
            End If
            zList.Items.Add(zTxt.Text)
        Else
            If zListClear = 1 Then
                zList.Items.Clear()
            End If
            'found a return character
            'check to see if there is more than one
            zRt2 = InStr(zRt + 2, zTxt.Text, vbCrLf)
            If zRt2 > 0 Then
                'there is more than one
                zRt2 = zRt
                zRt = 1
                'first pass
                zTstr = Mid(zTxt.Text, zRt, zRt2 - 1)
                If zTstr <> vbNullString And zTstr <> vbCrLf Then
                    zList.Items.Add(zTstr)
                End If

                'every other pass to the end

                zRt = zRt2
                zRt2 = InStr(zRt + 2, zTxt.Text, vbCrLf)

                Do
                    zTstr = Mid(zTxt.Text, zRt + 2, zRt2 - zRt - 2)
                    If zTstr <> vbNullString And zTstr <> vbCrLf Then
                        zList.Items.Add(zTstr)
                    End If
                    zRt = zRt2
                    zRt2 = InStr(zRt + 2, zTxt.Text, vbCrLf)
                    If zRt2 = 0 Then
                        zRstop = True
                        zTstr = Mid(zTxt.Text, zRt, Len(zTxt.Text))
                        If zTstr <> vbNullString And zTstr <> vbCrLf Then
                            zList.Items.Add(zTstr)
                        End If
                    End If
                Loop Until zRstop = True
            Else
                'there isnt more than one
                'add the string to the list box minus the return character
                zTstr = Mid(zTxt.Text, 1, Len(zTxt.Text) - 2)
                zList.Items.Add(zTstr)
            End If
        End If
    End Function

    Public Function zFormatTeleport(zList As ListBox, zList2 As ListBox, zTxtOut As TextBox, zBotName As TextBox, zEnumBots As CheckBox)

        'this will go through each line and if it meets the format critera
        'it will add that line
        'if a line doesnt meet the criteria then it will skip it
        'by not adding it
        If zBotName.Text = vbNullString Then
            zBotName.Text = "bot"
        End If
        If zList.Items.Count = 0 Then Exit Function
        zList2.Items.Clear()
        zTxtOut.Text = vbNullString
        Dim zListI As Integer
        Dim zLentry As String
        Dim zSetpos As Integer, zSetang As Integer
        'set pos
        Dim zspSpace1 As Integer, zspSpace2 As Integer, zspSpace3 As Integer
        'set angle
        Dim zsaSpace1 As Integer, zsaSpace2 As Integer, zsaSpace3 As Integer
        'teleport formatting
        Dim zSemiColon As Integer
        Dim zFirstHalf As String
        Dim zSecondHalf As String
        Dim zTp As String
        Dim zTxtOutString As String

        Dim zBotI As Integer
        zBotI = 0

        Dim zBNnolastchar As String

        'go through each entry in the list
        For zListI = 0 To zList.Items.Count - 1
            'setpos -52.407482 662.477600 353.586365;setang 33.054932 -4.829772 0.000000
            'thats how it comes out of the game using getpos
            'thats the string i have to take apart

            zLentry = zList.Items.Item(zListI)
            zSetpos = InStr(1, zLentry, "setpos")
            zSetang = InStr(1, zLentry, "setang")

            If (zSetpos > 0) And (zSetang > 0) Then
                'both exist
                'test for further formatting stuff
                'for setpos section
                zspSpace1 = InStr(1, zLentry, " ")
                zspSpace2 = InStr(zspSpace1 + 1, zLentry, " ")
                zspSpace3 = InStr(zspSpace2 + 1, zLentry, " ")

                zsaSpace1 = InStr(zspSpace3 + 1, zLentry, " ")
                zsaSpace2 = InStr(zsaSpace1 + 1, zLentry, " ")
                zsaSpace3 = InStr(zsaSpace2 + 1, zLentry, " ")

                If (zspSpace1 > 0) And (zspSpace2 > 0) And (zspSpace3 > 0) And (zsaSpace1 > 0) And (zsaSpace2 > 0) And (zsaSpace3 > 0) Then
                    'this should be a copy and pasted line from the console
                    'setpos -52.407482 662.477600 353.586365;setang 33.054932 -4.829772 0.000000
                    zSemiColon = InStr(1, zLentry, ";")
                    'so starting from the first space
                    If zSemiColon > 0 Then
                        'to - 1 the semicolon
                        'should be the first half of the teleport command
                        'coordinates
                        zFirstHalf = Mid(zLentry, zspSpace1 + 1, zSemiColon - 1 - zspSpace1)
                        zSecondHalf = Mid(zLentry, zsaSpace1 + 1, Len(zLentry))
                        'zList2.Items.Add(zFirstHalf)
                        'zList2.Items.Add(zSecondHalf)

                        'now that i have the first and second coordinates
                        'make the teleport command
                        'bot_teleport "hoovy1" -301.160034 -588.444153 78.468124 18.458006 15.540970 0.000000

                        If zEnumBots.Checked = True Then
                            'add the index to the end of the bot name text
                            'quotes for bot
                            'zTp = "bot_teleport " & zQ & zBotName.Text & zBotI & zQ & " " & zFirstHalf & " " & zSecondHalf
                            'no quotes for bot
                            'zTp = "bot_teleport " & zBotName.Text & zBotI & " " & zFirstHalf & " " & zSecondHalf

                            zBNnolastchar = Mid(zBotName.Text, 1, Len(zBotName.Text) - 1)

                            zTp = "bot_teleport " & zBNnolastchar & zBotI & " " & zFirstHalf & " " & zSecondHalf

                            zBotI = zBotI + 1
                        Else
                            'dont enumerate bots
                            'quotes for bot
                            'zTp = "bot_teleport " & zQ & zBotName.Text & zQ & " " & zFirstHalf & " " & zSecondHalf
                            'no quotes for bot
                            zTp = "bot_teleport " & zBotName.Text & " " & zFirstHalf & " " & zSecondHalf
                        End If

                        zList2.Items.Add(zTp)

                        zTxtOutString = zTxtOutString & zTp & vbCrLf
                        'If zListI = (zList.Items.Count - 1) Then
                        zTxtOut.Text = zTxtOutString
                        'End If
                    End If
                End If
            End If
        Next
    End Function


End Module
