:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\..\DI\Opc.Ua.Di.NodeSet2.xml" "..\Opc.Ua.FDT.NodeSet2.xml" -e "Opc.Ua.FDT.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/schemas/FDT/1.0/"
xcopy %1\asp.log asp.log /y
xcopy %1\asp.warnings.log .\asp.warnings.log /y /i


