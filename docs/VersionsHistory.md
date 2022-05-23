# Versions History <!-- omit in toc -->

## Table of contents <!-- omit in toc -->

- [2.1.0-Bravo](#210-bravo)
  - [Acknowledgement](#acknowledgement)
  - [Preface](#preface)
  - [Executive summary of the reported warnings](#executive-summary-of-the-reported-warnings)
    - [OPC-UA-OOI.asp 6.5.0-Kilo](#opc-ua-ooiasp-650-kilo)
      - [The model related warnings](#the-model-related-warnings)
      - [Th tool related warnings](#th-tool-related-warnings)
    - [UA-ModelCompiler 3.0.0-Delta](#ua-modelcompiler-300-delta)
      - [Errors reported by the tool](#errors-reported-by-the-tool)
      - [Model not tested](#model-not-tested)
      - [Existing models test](#existing-models-test)
    - [ASMD 4.5.3](#asmd-453)

## 2.1.0-Bravo

### Acknowledgement

I would like to acknowledge the contribution supported by the Erasmus Internship. I would like to thank [Mert Yuşa Atağ](https://github.com/mertyusaatag) for his inputs/inspiration, feedback, and cooperation in this respect.

### Preface

The following tools have been applied to test and convert the domain-specific language of the model.

| Tool                                                            | release                                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------------------- |
| [UA-ModelCompiler](https://github.com/mpostol/UA-ModelCompiler) | [3.0.0-Delta](https://github.com/mpostol/UA-ModelCompiler/tree/3.0.0-Delta) |
| [OPC-UA-OOI.asp](https://github.com/mpostol/OPC-UA-OOI)         | [6.5.0-Kilo](https://github.com/mpostol/OPC-UA-OOI/tree/6.5.0-Kilo)         |
| [ASMD](https://github.com/mpostol/ASMD/)                        | [4.5.3-Echo](https://github.com/mpostol/ASMD/tree/4.5.3--Echo)              |

The scope of the work is described in the following table;

| Tool             | Work                                                                                                          |
| ---------------- | ------------------------------------------------------------------------------------------------------------- |
| UA-ModelCompiler | `GoNodeSet.cmd` - scrips was prepared and executed for all models in the repository.                          |
| OPC-UA-OOI.asp   | `DoRecoverModel.cmd` - scrips was prepared and executed for all models in the repository.                     |
| ASMD             | `UAModelDesignerSolution.uamdsl` - the solution configuration files are created for models in the repository. |

### Executive summary of the reported warnings

#### OPC-UA-OOI.asp 6.5.0-Kilo

This section covers all reported warnings for existing and recovered  by `OPC-UA-OOI.asp 6.5.0-Kilo` models.

##### The model related warnings

``` txt
Warning, Error Focus: NodeClass, Identifier: P3-0503020000 Description: Unexpected value of the InverseName. If ReferenceType 1:HasAMLInternalLink is symmetric the InverseName :HasAMLInternalLink shall be omitted.
```

**Affected Models**: AML,MachineVision,MTConnect,TMC
**Recommendations**: Must be confirmed (by MP) and reported as the model error in the `mpostol/UA-Nodeset` repository.

``` txt
Warning, Error Focus: Reference, Identifier: P3-0503030201 Description: Wrong Reference type targeting the Property component. Target node of the HasProperty reference cannot be 1:MajorVersion of a base type.
Warning, Error Focus: Reference, Identifier: P3-0503030201 Description: Wrong Reference type targeting the Property component. Target node of the HasProperty reference cannot be 1:MinorVersion of a base type.
Warning, Error Focus: Reference, Identifier: P3-0503030201 Description: Wrong Reference type targeting the Property component. Target node of the HasProperty reference cannot be 1:Build of a base type.
```

**Affected Models**: `MDIS`
**Recommendations**: Must be confirmed (by MP) and reported as the model error in the `mpostol/UA-Nodeset` repository.

##### Th tool related warnings

``` txt
Warning, Error Focus: Diagnostic, Identifier: P0-0003010000 Description: It is diagnostic information Id = D290E7B4-F77C-4EF0-883B-844F66471DB6; Reference HierarchicalReferences not supported. Removed the graph at http://opcfoundation.org/UA/:Organizes of nodes from the model"
```

**Affected Models**: `ADI`, `AML`, `AUTOID`, `CSPPlusForMachine`, `DI`, `MTConnect`, `POWERLINK`
**Recommendations**: Must be confirmed (by MP) and reported as the model error in the `mpostol/UA-Nodeset` repository.

``` txt
Warning, Error Focus: Diagnostic, Identifier: P0-0001010000 Description: The XML attribute or element is not supported and neglected. Extensions are omitted during the import" 
```

**Affected Models**: `CAS`, `CNC`, `CommercialKitchenEquipment`, `FDT`, `I4AAS`, `IA`, `IJT`, `IOLINK`, `ISA95JOBCONTOL`, `Machinery`, `MachineTool`, `MachineVision`, `MTConnect`, `OpenSCS`, `PackML`, `PNEM`, `PROFINET`, `PUMPS`, `TMC`, `Weihenstephan`, `PlasticRubber/Extrusion/Calendar`,`PlasticRubber/Extrusion/GeneralTypes`,`PlasticRubber/HotRunner`,`PlasticRubber/IMM2MES`,`PlasticRubber/LDS`,`PlasticRubber/TCD`, `PlasticRubber/Extrusion/Calibator`, `PlasticRubber/Extrusion/Corrugator`, `PlasticRubber/Extrusion/Cutter`, `PlasticRubber/Extrusion/Die`,`PlasticRubber/Extrusion/MeltPump`, `PlasticRubber/Extrusion/Pelletizer`, `PlasticRubber/Extrusion/Hauloff`, `PlasticRubber/Extrusion/Filter`, `PlasticRubber/Extrusion/ExtrusionLine`
**Recommendations**: Add the XML attribute or element to the warning. Change the severity from `warning` to `information`. `Improvement of the asp.

``` txt
Warning, Error Focus: Diagnostic, Identifier: P0-0001010000 Description: The XML attribute or element is not supported and neglected. The AccessLevel value 5 is not supported
```

**Affected models**: `PlasticsRubber\Extrusion\HaulOff`, `PlasticsRubber\GeneralTypes\1.03`, `PlasticsRubber\Extrusion\Filter`, `PlasticsRubber\TCD`, `PlasticsRubber\Extrusion\Extruder`, `PlasticsRubber\Extrusion\GeneralTypes\1.01`
**Recommendations**: Add the XML attribute or element to the warning. Change the severity from `warning` to `information`. `Improvement of the asp.

``` txt
- Warning;226242104;;"Finishing Validator.ValidateExportModel - the model contains 13 nodes and 1 errors reported.
```

**Affected Models**: `MachineVision`, `MDIS`, `MTConnect`, `TMC`,`PlasticRubber/Extrusion/GeneralTypes`
**Recommendations**: not relevant - wontfix

#### UA-ModelCompiler 3.0.0-Delta

##### Errors reported by the tool

``` txt
"ModelCompilerUI";Information;552021345;;"Trace: Information, Error Focus:NonCategorized, ErrorID: P0-0002010000 Info: General processing error see trace for details. Compilation ended with error FormatException: '20/11/2020' not valid ALLXsd value. 
   location: System.Xml.Schema.XsdDateTime..ctor(String text, XsdDateTimeFlags kinds)
   location: System.Xml.XmlConvert.ToDateTime(String s, XmlDateTimeSerializationMode dateTimeOption)
   location: OOI.ModelCompiler.ModelCompilerValidator.Validate2(IList`1 designFilePaths, String identifierFilePath, Boolean generateIds) C:\VS.git\github.mpostol\UA-ModelCompiler\Opc.Ua.ModelCompiler\ModelDesignerValidator.cs : line 1172
   location: OOI.ModelCompiler.ModelGenerator2.ValidateAndUpdateIds(IList`1 designFilePaths, String identifierFilePath, UInt32 startId, String specificationVersion, Boolean useAllowSubtypes, IList`1 exclusions, String modelVersion, String modelPublicationDate, Boolean releaseCandidate) C:\VS.git\github.mpostol\UA-ModelCompiler\Opc.Ua.ModelCompiler\ModelGenerator2.cs içinde: satır 119
   location: OOI.ModelCompiler.ModelDesignCompiler.BuildModel(ICompilerOptions options) C:\VS.git\github.mpostol\UA-ModelCompiler\Opc.Ua.ModelCompiler\ModelCompiler.cs : line 25
   location: OOI.ModelCompilerUI.EntryPoint.Compile(CompilerOptions options) C:\VS.git\github.mpostol\UA-ModelCompiler\ModelCompilerUI\EntryPoint.cs içinde: line 98";;;;;; 
```

**Affected Models**: `ADI`, `AML`, `AUTOID`, `CAS`, `CNC`, `CommericialKitchenEquipment`, `CSPPlusForMachine`, `DEXPI`, `DI`, `FDI`, `FDT`, `I4AAS`, `IA`, `IJT`, `ISA-95`, `ISA95-JOBCONTROL`, `Machinery`, `MachineTool`, `MachineVision`, `MDIS`, `MTConnect`, `OpenSCS`, `PackML`, `PADIM`,`PNEM`,`Powerlink`, `Profinet`, `Pumps`, `Robotics`, `Safety`
**Recommendations**: Must be confirmed (by MP) and reported as the model error in the `mpostol/UA-Nodeset` repository.

``` txt
"ModelCompilerUI";Information;552021345;;"Trace: Information, Error Focus:NonCategorized, ErrorID: P0-0002010000 Info: General processing error see trace for details. Compilation ended with error ArgumentOutOfRangeException: The identifier file path is null or empty.
Parameter name: IdentifierFile 
   location: OOI.ModelCompilerUI.CommandLineSyntax.CompilerOptions.ValidateOptionsConsistency() C:\VS.git\github.mpostol\UA-ModelCompiler\ModelCompilerUI\CommandLineSyntax\CompilerOptions.cs : line 55
   location: OOI.ModelCompilerUI.EntryPoint.Compile(CompilerOptions options) C:\VS.git\github.mpostol\UA-ModelCompiler\ModelCompilerUI\EntryPoint.cs : line 98";;;;;;
```

**Affected models**: `IOLINK`, `SERCOS`, `Weihenstephan`, `TMC`, `Scales`, `Opc.Ua.PlasticsRubber.LDS.NodeSet2.xml`
**Recommendations**: It is script error.

##### Model not tested

`PlasticsRubber\GeneralTypes\1.02` because there is a newer one.

##### Existing models test

``` txt
"ModelCompilerUI";Information;552021345;;"Trace: Information, Error Focus:NonCategorized, ErrorID: P0-0002010000 Info: General processing error see trace for details. Compilation ended with error ArgumentOutOfRangeException: The required identifier file does not exist: OpcUaAdiModel.csv
Parametre adı: IdentifierFile 
   Location: OOI.ModelCompilerUI.CommandLineSyntax.CompilerOptions.ValidateOptionsConsistency() C:\VS.git\github.mpostol\UA-ModelCompiler\ModelCompilerUI\CommandLineSyntax\CompilerOptions.cs içinde: line 59
   Location: OOI.ModelCompilerUI.EntryPoint.Compile(CompilerOptions options) C:\VS.git\github.mpostol\UA-ModelCompiler\ModelCompilerUI\EntryPoint.cs : line 98";;;;;;
```

**Affected Models**: `ADI`
**Recommendations**: It is script error.

#### ASMD 4.5.3

The tool throws an exception while adding project to the solution for model `IOLink`.

**Affected Models**: `IOLink`
**Recommendations**: Must be reviewed and followed up accordingly
