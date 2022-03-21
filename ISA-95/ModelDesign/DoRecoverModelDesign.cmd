:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\Opc.ISA95.NodeSet2.xml" -e "Opc.Ua.ISA95.Model.xml" -s XMLstylesheet -n "http://www.OPCFoundation.org/UA/2013/01/ISA95"
xcopy %1\asp.log asp.log /y
xcopy %1\asp.warnings.log .\asp.warnings.log /y /i


