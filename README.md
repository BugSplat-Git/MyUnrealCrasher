# MyUnrealCrasher

Developed with Unreal Engine 4

## Prerequisites
* [Unreal Engine 4](https://www.unrealengine.com/download)
* [Visual Studio](https://visualstudio.microsoft.com/downloads/) 2019 Community or newer
* [BugSplat](https://app.bugsplat.com/v2/company) database

## Steps
1. Open MyUnrealCrasher.uproject in Unreal Engine 4
2. If prompted to rebuild missing modules click 'Yes'
3. Add a Visual Studio 2019 Project
4. In the Content Browser, click the folder icon and select 'C++ Classes'
5. Drag FloatingActor into the Viewport (optionally position FloatingActor at x: -180, y: 0, z: 180)
6. Verify the following options are checked in the 'Packaging Settings' (File > Package Project > Packaging Settings)
    * Packaging > Include Crash Reporter
    * Project > Include Debug Files
7. Package the project and note what directory you choose (File > Package Project)
8. Create or edit the contents of the file found in `{{output_directory}}/Engine/Programs/CrashReportClient/Config/NoRedist/DefaultEngine.ini`. Make sure to replace {database} with the value of your BugSplat database. The following example will post a crash with the application MyUnrealCrasher and version 1.0:
```
[CrashReportClient]
CrashReportClientVersion=1.0
DataRouterUrl="https://{database}.bugsplat.com/post/ue4/MyUnrealCrasher/1.0"
```
9. Use SendPdbs to post all the .dll, .exe and .pdb files to BugSplat. Be sure to match the database, application and version values from the previous step.
10. Open the MyUnrealCrasher.exe and submit the crash when prompted.
