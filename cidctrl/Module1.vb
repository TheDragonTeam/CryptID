Module Module1

    Sub Main()

        MsgBox(System.Environment.GetCommandLineArgs.ToArray.GetValue(1))
        MsgBox(System.Environment.GetCommandLineArgs.ToArray.GetValue(2))
    End Sub

End Module
