Module vabbajacksandvich

    ' this is my bas file (yes i know its a vb file module)
    ' but modules used to be called bas files
    ' so i will forever refer to it as a bas file
    ' i use it between projects so its got some random other crap in it
    ' thats not related to this project

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
                    'zTlzs = "0"
                    zTlzs = ""
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


End Module
