# Versions History

## 2.1.0-Bravo

Synchronized with `3f630745894e06d5a42329bc701e6ac36f365cb9`

### Tools in Concern

The following tools has been used tp prototype with models

| Tool                                                            | release                                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------------------- |
| [UA-ModelCompiler](https://github.com/mpostol/UA-ModelCompiler) | [3.0.0-Delta](https://github.com/mpostol/UA-ModelCompiler/tree/3.0.0-Delta) |
| [OPC-UA-OOI.asp](https://github.com/mpostol/OPC-UA-OOI)         | [6.5.0-Kilo](https://github.com/mpostol/OPC-UA-OOI/tree/6.5.0-Kilo)         |
| [ASMD](https://github.com/mpostol/ASMD/)                        | [4.5.3-Echo](https://github.com/mpostol/ASMD/tree/4.5.3--Echo)              |

### Erasmus Intership First Report 02/05/2022 

#### Below is what has been done during this internship

## 1 - ASP.6.5.0
- I prepared DoRecoverModel.cmd files.

- These files were executed with asp 6.5.0 and the results were sent as pull requests.

- All files have been checked for the latest version. Prepared for every file except 'GDS' File. The GDS file was noticed while writing this report. It will be added after the next meeting.

### Received errors for ASP.

- Warning, Error Focus: NodeClass --Description: Unexpected value of the InverseName. If ReferenceType 1:HasAMLInternalLink is symmetric the InverseName :HasAMLInternalLink shall be omitted. - Affected Models: AML,MachineVision,MTConnect,TMC
  

- Warning, Error Focus: Diagnostic, Identifier: P0-0003010000 Description: It is diagnostic information Id = D290E7B4-F77C-4EF0-883B-844F66471DB6; Reference HierarchicalReferences not supported. Removed the graph at http://opcfoundation.org/UA/:Organizes of nodes from the model"- 
Affected Models: ADI,AML,AUTOID,CSPPlusForMachine,DI,MTConnect,POWERLINK

- Warning, Error Focus: Diagnostic, Identifier: P0-0001010000 Description: The XML attribute or element is not supported and neglected. Extensions are omitted during the import" - Affected Models:CAS,CNC,CommercialKitchenEquipment,FDT,I4AAS,IA,IJT,IOLINK,ISA-95JOBCONTOL,Machinery,MachineTool,MachineVision,MTConnect,OpenSCS,PackML,PNEM,PROFINET,PUMPS,TMC,Weihenstephan

Warning;226242104;;"Finishing Validator.ValidateExportModel - the model contains 13 nodes and 1 errors reported. - Affected Models: MachineVision,MDIS,MTConnect,TMC


- Warning, Error Focus: Reference, Identifier: P3-0503030201 Description: Wrong Reference type targeting the Property component. Target node of the HasProperty reference cannot be 1:MajorVersion of a base type.
Err code:43988162 - Affected Models:MDIS


## 2 - ASMD 4.5.3

### While adding solution recieved problems:
- There is a only 1 error which is IOLink.

## 3 - Model Compiler 3.0.0-Delta

- I wrote GoNodeSet.cmd file for each file. then I executed all of them with Model Compiler 3.0.0 (except IEC61850). Basically I got 2 main errors. I've included them below along with the affected models.

### Errors for Model Compiler 3.0.0

- "ModelCompilerUI";Information;552021345;;"Trace: Information, Error Focus:NonCategorized, ErrorID: P0-0002010000 Info: General processing error see trace for details. Compilation ended with error FormatException: '20/11/2020' not valid ALLXsd value. 
   location: System.Xml.Schema.XsdDateTime..ctor(String text, XsdDateTimeFlags kinds)
   location: System.Xml.XmlConvert.ToDateTime(String s, XmlDateTimeSerializationMode dateTimeOption)
   location: OOI.ModelCompiler.ModelCompilerValidator.Validate2(IList`1 designFilePaths, String identifierFilePath, Boolean generateIds) C:\VS.git\github.mpostol\UA-ModelCompiler\Opc.Ua.ModelCompiler\ModelDesignerValidator.cs : line 1172
   location: OOI.ModelCompiler.ModelGenerator2.ValidateAndUpdateIds(IList`1 designFilePaths, String identifierFilePath, UInt32 startId, String specificationVersion, Boolean useAllowSubtypes, IList`1 exclusions, String modelVersion, String modelPublicationDate, Boolean releaseCandidate) C:\VS.git\github.mpostol\UA-ModelCompiler\Opc.Ua.ModelCompiler\ModelGenerator2.cs içinde: satır 119
   location: OOI.ModelCompiler.ModelDesignCompiler.BuildModel(ICompilerOptions options) C:\VS.git\github.mpostol\UA-ModelCompiler\Opc.Ua.ModelCompiler\ModelCompiler.cs : line 25
   location: OOI.ModelCompilerUI.EntryPoint.Compile(CompilerOptions options) C:\VS.git\github.mpostol\UA-ModelCompiler\ModelCompilerUI\EntryPoint.cs içinde: line 98";;;;;; - Affected Models:ADI,AML,AUTOID,CAS,CNC,CommericialKitchenEquipment,CSPPlusForMachine,DEXPI,DI,FDI,FDT,I4AAS,IA,IJT,ISA-95,ISA95-JOBCONTROL,Machinery,MachineTool,MachineVision,MDIS,MTConnect,OpenSCS,PackML,PADIM,PNEM,Powerlink,Profinet,Pumps,Robotics,Safety


- "ModelCompilerUI";Information;552021345;;"Trace: Information, Error Focus:NonCategorized, ErrorID: P0-0002010000 Info: General processing error see trace for details. Compilation ended with error ArgumentOutOfRangeException: The identifier file path is null or empty.
Parameter name: IdentifierFile 
   location: OOI.ModelCompilerUI.CommandLineSyntax.CompilerOptions.ValidateOptionsConsistency() C:\VS.git\github.mpostol\UA-ModelCompiler\ModelCompilerUI\CommandLineSyntax\CompilerOptions.cs : line 55
   location: OOI.ModelCompilerUI.EntryPoint.Compile(CompilerOptions options) C:\VS.git\github.mpostol\UA-ModelCompiler\ModelCompilerUI\EntryPoint.cs : line 98";;;;;; - Affected models : IOLINK, SERCOS ,Weihenstephan,TMC,Scales