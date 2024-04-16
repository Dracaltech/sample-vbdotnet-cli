Module VBExample
    Sub Main()

        ' Prepare a Process object for running dracal-usb-get.
        ' This assumes that dracal-usb-get is in your PATH, or
        ' that dracal-usb-get.exe is present in the same directory
        ' as this program.
        Dim usbtenki As New Process()
        usbtenki.StartInfo.FileName = "dracal-usb-get"
        usbtenki.StartInfo.Arguments = "-i 0,1,2"
        usbtenki.StartInfo.UseShellExecute = False
        usbtenki.StartInfo.RedirectStandardOutput = True

        ' Run dracal-usb-get and wait until it exits
        usbtenki.Start()
        usbtenki.WaitForExit()

        ' Read one line of what was output by dracal-usb-get
        Dim output = usbtenki.StandardOutput.ReadLine()

        If output Is Nothing Then
            Console.Error.WriteLine("dracal-usb-get did not return data")
            Return
        End If

        ' Split the line into fields stored in an array, trim individual fields
        ' to remove extra spaces before fields.
        Dim fields() As String
        fields = output.Split(",").Select(Function(s) s.Trim()).ToArray()

        ' Check that the expected number of fields were read.
        ' In this case, due to the use of the -i 0,1,2 dracal-usb-get
        ' argument, exactly 3 are expected.
        If fields.Length <> 3 Then
            Console.Error.WriteLine("dracal-usb-get returned an incorrect number of fields")
            Return
        End If

        Console.Out.WriteLine("Pressure..(kPa): " & fields(0))
        Console.Out.WriteLine("Temperature (C): " & fields(1))
        Console.Out.WriteLine("RH..........(%): " & fields(2))
        Console.Out.WriteLine("Tempearture.(F): " & fields(1) * 9 / 5 + 32)

    End Sub
End Module