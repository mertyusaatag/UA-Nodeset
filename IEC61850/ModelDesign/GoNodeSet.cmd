set COMPILER=OOI.ModelCompilerUI

:: -d22 "C:\VS.git\github.mpostol\UA-Nodeset\ADI\ModelDesign\Opc.Ua.Adi.Model.xml"  -cg "C:\VS.git\github.mpostol\UA-Nodeset\ADI\ModelDesign\Opc.Ua.Adi.Model.csv" -o "C:\VS.git\github.mpostol\UA-Nodeset\ADI\ModelDesign\Opc.Ua.Adi.Model" -console

"%1\%COMPILER%" -d2 "Opc.Ua.IEC61850-7-3.Model.xml" -cg "IEC61850-7-3.csv" -o "IEC61850-7-3" -console
:: "%1\%COMPILER%" -d2 "ObjectTypeTest.xml" -cg "ObjectTypeTest.csv" -o "ObjectTypeTest" -console
:: "%1\%COMPILER%" -d2 "VariableTypeTest.xml" -cg "VariableTypeTest.csv" -o "VariableTypeTest" -console
:: "%1\%COMPILER%" -d2 "DataTypeTest.xml" -cg "DataTypeTest.csv" -o "DataTypeTest" -console
