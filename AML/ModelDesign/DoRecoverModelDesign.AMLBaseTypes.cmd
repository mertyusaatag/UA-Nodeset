:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\Opc.Ua.AMLBaseTypes.NodeSet2.xml" -e "Opc.Ua.AMLBaseTypes.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/AML/"
xcopy "%1\asp.log" ".\asp.AMLBaseTypes.log"/y
xcopy "%1\asp.warnings.log" ".\asp.warnings.AMLBaseTypes.log" /y


