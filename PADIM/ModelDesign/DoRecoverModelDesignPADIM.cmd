:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\..\DI\Opc.Ua.Di.NodeSet2.xml" "..\Opc.Ua.IRDI.NodeSet2.xml" "..\Opc.Ua.PADIM.NodeSet2.xml" -e "Opc.Ua.PADIM.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/PADIM/"
xcopy %1\asp.log asp.padim.log /y
xcopy %1\asp.warnings.log .\asp.padim.warnings.log /y /i


