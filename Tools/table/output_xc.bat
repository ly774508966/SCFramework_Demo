SET WORKSPACE=%cd%
SET SOURCETABLEDIR=%cd%\..\srcTable\ios\
SET TABLERESDIR=%cd%\..\..\UnityProject\Framework\Assets\StreamingAssets\config\

pushd %cd%\xlsxconvert
SET OUTPUTCODEEXE=%WORKSPACE%\xlsxconvert\output\convertxlsx.exe
SET TEMPOUTPUTDIR=%WORKSPACE%\txtoutput\
RMDIR /s /q %TEMPOUTPUTDIR%
SET FORMAT=xc
%OUTPUTCODEEXE% -i %SOURCETABLEDIR% -o %TEMPOUTPUTDIR% -f %FORMAT%
popd

XCOPY /Y /E /Q %TEMPOUTPUTDIR%\client\* %TABLERESDIR%

pause