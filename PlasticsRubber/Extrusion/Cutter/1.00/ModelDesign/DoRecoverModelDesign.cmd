:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\..\..\..\..\DI\Opc.Ua.Di.NodeSet2.xml" "..\..\..\..\GeneralTypes\1.03\Opc.Ua.PlasticsRubber.GeneralTypes.NodeSet2.xml" "..\..\..\GeneralTypes\1.01\Opc.Ua.PlasticsRubber.Extrusion.GeneralTypes.NodeSet2.xml" "..\Opc.Ua.PlasticsRubber.Extrusion.Cutter.NodeSet2.xml" -e "Opc.Ua.PlasticsRubber.Extrusion.Cutter.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/PlasticsRubber/Extrusion/Cutter/"
xcopy %1\asp.log asp.log /y
xcopy %1\asp.warnings.log .\asp.warnings.log /y /i


