:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\Opc.Ua.IEC61850-6.NodeSet2.xml"  "..\Opc.Ua.IEC61850-7-3.NodeSet2.xml" -e "Opc.Ua.IEC61850-6.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/IEC61850-6"
xcopy %1\asp.log asp.6.log /y
xcopy %1\asp.warnings.log .\asp.warnings.6.log /y /i

del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\Opc.Ua.IEC61850-7-3.NodeSet2.xml" -e "Opc.Ua.IEC61850-7-3.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/IEC61850-7-3"
xcopy %1\asp.log asp.7.3.log /y
xcopy %1\asp.warnings.log .\asp.warnings.7.3.log /y /i

del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\Opc.Ua.IEC61850-7-3.NodeSet2.xml"  "..\Opc.Ua.IEC61850-7-4.NodeSet2.xml" -e "Opc.Ua.IEC61850-7-4.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/IEC61850-7-4"
xcopy %1\asp.log asp.7.4.log /y
xcopy %1\asp.warnings.log .\asp.warnings.7.4.log /y /i


