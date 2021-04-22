
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.LogViewer.WebPart.dll  D:\U9PackMark\LogViewerFiles\Portal\UILib
copy .\bin\Debug\UFIDA.U9.Cust.LogViewer.WebPart.pdb  D:\U9PackMark\LogViewerFiles\Portal\UILib

echo begin run build UI Script
echo 目录：.\..\..\BULK\\u_ui\UIScript\

echo .\..\..\..\Yonyou\UBFV60\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=LEN_ovo_u965;Data Source=WIN-9THMNRAGKAT;Initial Catalog=SHBC;packet size=4096;Max Pool size=500;Connection Timeout=5;persist security info=True;MultipleActiveResultSets=true;" -NotDropDB -NotWriteLog -ExecuteDelete .\..\..\..\..\shbc_U9_BEBPUI\BULK\\u_ui\UIScript\

echo ui buid end
pause

