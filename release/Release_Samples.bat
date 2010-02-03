del samples.zip
cd "..\samples"
"C:\Program Files\7-Zip\7z.exe" a -r -x!.svn* -x!obj -x!bin "..\release\samples.zip"
pause