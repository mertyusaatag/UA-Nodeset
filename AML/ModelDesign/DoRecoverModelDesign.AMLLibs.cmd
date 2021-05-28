:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\Opc.Ua.AMLBaseTypes.NodeSet2.xml" "..\Opc.Ua.AMLLibraries.NodeSet2.xml" -e "Opc.Ua.AMLLibraries.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/AMLLibs/"
xcopy "%1\asp.log" ".\asp.AMLLibraries.log"/y
xcopy "%1\asp.warnings.log" ".\asp.warnings.AMLLibraries.log" /y


