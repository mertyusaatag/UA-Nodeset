:: Recovering ModelDesign from UANodeSet OPC UA Model Information
:: %1 - location of the asp.exe 
del %1\asp.log  /q
del %1\asp.warnings.log /q
%1\asp "..\Opc.Ua.Pn.NodeSet2.xml" -e "Opc.Ua.PROFINET.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/PROFINET/"
xcopy %1\asp.log asp.log /y
xcopy %1\asp.warnings.log .\asp.warnings.log /y /i


