:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\..\DI\Opc.Ua.Di.NodeSet2.xml" "..\..\Machinery\Opc.Ua.Machinery.NodeSet2.xml" "..\..\IA\Opc.Ua.IA.NodeSet2.xml" "..\Opc.Ua.MachineTool.NodeSet2.xml" -e "Opc.Ua.MachineTool.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/MachineTool/"
xcopy %1\asp.log asp.log /y
xcopy %1\asp.warnings.log .\asp.warnings.log /y /i

