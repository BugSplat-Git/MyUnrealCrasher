[![BugSplat](https://s3.amazonaws.com/bugsplat-public/npm/header.png)](https://www.bugsplat.com)

## Prerequisites
* [Unreal Engine 4](https://www.unrealengine.com/download)
* [Visual Studio](https://visualstudio.microsoft.com/downloads/) 2017 Community or newer
* [BugSplat](https://app.bugsplat.com/v2/company) database

## Steps
1. Open MyUnrealCrasher.uproject in Unreal Engine 4
2. If prompted to rebuild missing modules click 'Yes'
3. Add a Visual Studio Project (File > Add Visual Studio Project)
4. Search the Modes panel for 'FloatingActor' and drag FloatingActor into the viewport (optionally position FloatingActor at x: -180, y: 0, z: 180)
5. Verify the following options are checked in the 'Packaging Settings' (File > Package Project > Packaging Settings)
    * Packaging > Include Crash Reporter
    * Project > Include Debug Files
6. Package the project and note what directory you choose (File > Package Project)
    * If you get an error packaging your project, ensure that UE4 is properly connected to Visual Studio (Edit > Editor Preferences > Source Code > Ensure the correct version of Visual Studio is selected in the dropdown)
7. Create a DefaultEngine.ini file in the following folder `{{output_directory}}/Engine/Programs/CrashReportClient/Config/NoRedist/DefaultEngine.ini`. Make sure to replace `{database}` with the value of your BugSplat database. The following example will post a crash with the application MyUnrealCrasher and version 1.0:
```
[CrashReportClient]
CrashReportClientVersion=1.0
DataRouterUrl="https://{database}.bugsplat.com/post/ue4/MyUnrealCrasher/1.0"
```
8. Use [SendPdbs](https://www.bugsplat.com/docs/faq/sendpdbs/) to post all the packaged .dll, .exe and .pdb files to BugSplat. Be sure to match the database, application and version values from the previous step.
9. Open the MyUnrealCrasher.exe and submit the crash when prompted
10. View the [Crashes](https://app.bugsplat.com/v2/crashes) page in BugSplat, click the value in the ID column to be taken to the crash details view where you will find a stack trace, loaded modules, register values and more.
