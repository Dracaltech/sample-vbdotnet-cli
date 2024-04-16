# sample-vbdotnet-cli
Dracal // SDK code sample for VB.NET on CLI

## Assumptions

Running this repository requires you to have installed:
- .NET (version >= `8.0`)
- Visual Studio (version >= 2022)
- DracalView (version >= `3.2.x`)
  - Specifically, `dracal-usb-get` needs to be accessible from your `PATH` environment variable (more info in the [documentation how-to](https://www.dracal.com/en/programmers_howto/#dracal-usb-get)).

Script may need to be adjusted depending on your instrument's # of outputs _(currently assumed: 3 outputs)_. See script comments for details.


## Simple usage

Run by
- Using the **Play** button (Visual Studio)
- Build and run using the command line:

```
dotnet run sample-vbdotnet-cli.sln
```



## Sample output
<img src="https://github.com/Dracaltech/sample-vbdotnet-cli/assets/1357711/655893a6-3305-4044-8285-d4cbdf418ac4" width=400 />

```
Pressure..(kPa): 101.00
Temperature (C): 25.12
RH..........(%): 50.40
Tempearture.(F): 77.21600000000001

C:\dev\dracal\sample-vbdotnet-cli\bin\Debug\net8.0\sample-vbdotnet-cli.exe (process 25712) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
```
