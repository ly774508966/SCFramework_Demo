SET WORKSPACE=%cd%
SET SOURCETABLEDIR=%cd%\..\srcTable\ios\
SET PROJECTTABLEDIR=%cd%\..\..\UnityProject\Framework\Assets\Scripts\Game\Tables\

pushd %cd%\xlsxconvert
SET OUTPUTCODEEXE=%WORKSPACE%\xlsxconvert\output\outputcode.exe
SET TEMPOUTPUTDIR=%WORKSPACE%\csharpoutput\
RMDIR /s /q %TEMPOUTPUTDIR%
SET TARGET=csharp
%OUTPUTCODEEXE% -i %SOURCETABLEDIR% -o %TEMPOUTPUTDIR% -t %TARGET%

SET COPYCODEEXE=%WORKSPACE%\xlsxconvert\output\copy_csharp_code.exe
%COPYCODEEXE% %TEMPOUTPUTDIR%/ %PROJECTTABLEDIR%
popd
pause