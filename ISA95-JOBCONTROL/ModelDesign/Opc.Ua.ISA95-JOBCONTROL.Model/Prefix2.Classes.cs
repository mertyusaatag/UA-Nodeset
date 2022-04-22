/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Prefix0;

namespace Prefix2
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the ISA95JobOrderCommandEnum DataType.
        /// </summary>
        public const uint ISA95JobOrderCommandEnum = 1;

        /// <summary>
        /// The identifier for the ISA95JobOrderStateEnum DataType.
        /// </summary>
        public const uint ISA95JobOrderStateEnum = 4;

        /// <summary>
        /// The identifier for the ISA95ReturnEnum DataType.
        /// </summary>
        public const uint ISA95ReturnEnum = 7;

        /// <summary>
        /// The identifier for the ISA95EquipmentDataType DataType.
        /// </summary>
        public const uint ISA95EquipmentDataType = 10;

        /// <summary>
        /// The identifier for the ISA95JobOrderDataType DataType.
        /// </summary>
        public const uint ISA95JobOrderDataType = 11;

        /// <summary>
        /// The identifier for the ISA95JobResponseDataType DataType.
        /// </summary>
        public const uint ISA95JobResponseDataType = 12;

        /// <summary>
        /// The identifier for the ISA95MaterialDataType DataType.
        /// </summary>
        public const uint ISA95MaterialDataType = 13;

        /// <summary>
        /// The identifier for the ISA95ParameterDataType DataType.
        /// </summary>
        public const uint ISA95ParameterDataType = 14;

        /// <summary>
        /// The identifier for the ISA95PersonnelDataType DataType.
        /// </summary>
        public const uint ISA95PersonnelDataType = 15;

        /// <summary>
        /// The identifier for the ISA95PhysicalAssetDataType DataType.
        /// </summary>
        public const uint ISA95PhysicalAssetDataType = 16;

        /// <summary>
        /// The identifier for the ISA95PropertyDataType DataType.
        /// </summary>
        public const uint ISA95PropertyDataType = 17;

        /// <summary>
        /// The identifier for the ISA95WorkMasterDataType DataType.
        /// </summary>
        public const uint ISA95WorkMasterDataType = 18;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_ReceiveJobOrder Method.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_ReceiveJobOrder = 26;

        /// <summary>
        /// The identifier for the ISA95JobResponseProviderObjectType_RequestJobResponse Method.
        /// </summary>
        public const uint ISA95JobResponseProviderObjectType_RequestJobResponse = 31;

        /// <summary>
        /// The identifier for the ISA95JobResponseReceiverObjectType_ReceiveJobResponse Method.
        /// </summary>
        public const uint ISA95JobResponseReceiverObjectType_ReceiveJobResponse = 35;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the ISA95EquipmentDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ISA95EquipmentDataType_Encoding_DefaultXml = 38;

        /// <summary>
        /// The identifier for the ISA95JobOrderDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ISA95JobOrderDataType_Encoding_DefaultXml = 39;

        /// <summary>
        /// The identifier for the ISA95JobResponseDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ISA95JobResponseDataType_Encoding_DefaultXml = 40;

        /// <summary>
        /// The identifier for the ISA95MaterialDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ISA95MaterialDataType_Encoding_DefaultXml = 41;

        /// <summary>
        /// The identifier for the ISA95ParameterDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ISA95ParameterDataType_Encoding_DefaultXml = 42;

        /// <summary>
        /// The identifier for the ISA95PersonnelDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ISA95PersonnelDataType_Encoding_DefaultXml = 43;

        /// <summary>
        /// The identifier for the ISA95PhysicalAssetDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ISA95PhysicalAssetDataType_Encoding_DefaultXml = 44;

        /// <summary>
        /// The identifier for the ISA95PropertyDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ISA95PropertyDataType_Encoding_DefaultXml = 45;

        /// <summary>
        /// The identifier for the ISA95WorkMasterDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ISA95WorkMasterDataType_Encoding_DefaultXml = 46;

        /// <summary>
        /// The identifier for the ISA95EquipmentDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ISA95EquipmentDataType_Encoding_DefaultBinary = 77;

        /// <summary>
        /// The identifier for the ISA95JobOrderDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ISA95JobOrderDataType_Encoding_DefaultBinary = 78;

        /// <summary>
        /// The identifier for the ISA95JobResponseDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ISA95JobResponseDataType_Encoding_DefaultBinary = 79;

        /// <summary>
        /// The identifier for the ISA95MaterialDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ISA95MaterialDataType_Encoding_DefaultBinary = 80;

        /// <summary>
        /// The identifier for the ISA95ParameterDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ISA95ParameterDataType_Encoding_DefaultBinary = 81;

        /// <summary>
        /// The identifier for the ISA95PersonnelDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ISA95PersonnelDataType_Encoding_DefaultBinary = 82;

        /// <summary>
        /// The identifier for the ISA95PhysicalAssetDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ISA95PhysicalAssetDataType_Encoding_DefaultBinary = 83;

        /// <summary>
        /// The identifier for the ISA95PropertyDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ISA95PropertyDataType_Encoding_DefaultBinary = 84;

        /// <summary>
        /// The identifier for the ISA95WorkMasterDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ISA95WorkMasterDataType_Encoding_DefaultBinary = 85;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType ObjectType.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType = 19;

        /// <summary>
        /// The identifier for the ISA95JobResponseProviderObjectType ObjectType.
        /// </summary>
        public const uint ISA95JobResponseProviderObjectType = 30;

        /// <summary>
        /// The identifier for the ISA95JobResponseReceiverObjectType ObjectType.
        /// </summary>
        public const uint ISA95JobResponseReceiverObjectType = 34;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the ISA95JobOrderCommandEnum_EnumValues Variable.
        /// </summary>
        public const uint ISA95JobOrderCommandEnum_EnumValues = 2;

        /// <summary>
        /// The identifier for the ISA95JobOrderCommandEnum_EnumStrings Variable.
        /// </summary>
        public const uint ISA95JobOrderCommandEnum_EnumStrings = 3;

        /// <summary>
        /// The identifier for the ISA95JobOrderStateEnum_EnumValues Variable.
        /// </summary>
        public const uint ISA95JobOrderStateEnum_EnumValues = 5;

        /// <summary>
        /// The identifier for the ISA95JobOrderStateEnum_EnumStrings Variable.
        /// </summary>
        public const uint ISA95JobOrderStateEnum_EnumStrings = 6;

        /// <summary>
        /// The identifier for the ISA95ReturnEnum_EnumValues Variable.
        /// </summary>
        public const uint ISA95ReturnEnum_EnumValues = 8;

        /// <summary>
        /// The identifier for the ISA95ReturnEnum_EnumStrings Variable.
        /// </summary>
        public const uint ISA95ReturnEnum_EnumStrings = 9;

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_EquipmentID Variable.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_EquipmentID = 20;

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_JobOrderList Variable.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_JobOrderList = 21;

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_MaterialClassID Variable.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_MaterialClassID = 22;

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_MaterialDefinitionID Variable.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_MaterialDefinitionID = 23;

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_PersonnelID Variable.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_PersonnelID = 24;

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_PhysicalAssetID Variable.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_PhysicalAssetID = 25;

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_ReceiveJobOrder_InputArguments Variable.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_ReceiveJobOrder_InputArguments = 27;

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_ReceiveJobOrder_OutputArguments Variable.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_ReceiveJobOrder_OutputArguments = 28;

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_WorkMaster Variable.
        /// </summary>
        public const uint ISA95JobOrderReceiverObjectType_WorkMaster = 29;

        /// <summary>
        /// The identifier for the ISA95JobResponseProviderObjectType_RequestJobResponse_InputArguments Variable.
        /// </summary>
        public const uint ISA95JobResponseProviderObjectType_RequestJobResponse_InputArguments = 32;

        /// <summary>
        /// The identifier for the ISA95JobResponseProviderObjectType_RequestJobResponse_OutputArguments Variable.
        /// </summary>
        public const uint ISA95JobResponseProviderObjectType_RequestJobResponse_OutputArguments = 33;

        /// <summary>
        /// The identifier for the ISA95JobResponseReceiverObjectType_ReceiveJobResponse_InputArguments Variable.
        /// </summary>
        public const uint ISA95JobResponseReceiverObjectType_ReceiveJobResponse_InputArguments = 36;

        /// <summary>
        /// The identifier for the ISA95JobResponseReceiverObjectType_ReceiveJobResponse_OutputArguments Variable.
        /// </summary>
        public const uint ISA95JobResponseReceiverObjectType_ReceiveJobResponse_OutputArguments = 37;

        /// <summary>
        /// The identifier for the Name2_XmlSchema Variable.
        /// </summary>
        public const uint Name2_XmlSchema = 47;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint Name2_XmlSchema_NamespaceUri = 49;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95EquipmentDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_ISA95EquipmentDataType = 50;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95JobOrderDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_ISA95JobOrderDataType = 53;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95JobResponseDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_ISA95JobResponseDataType = 56;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95MaterialDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_ISA95MaterialDataType = 59;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95ParameterDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_ISA95ParameterDataType = 62;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95PersonnelDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_ISA95PersonnelDataType = 65;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95PhysicalAssetDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_ISA95PhysicalAssetDataType = 68;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95PropertyDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_ISA95PropertyDataType = 71;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95WorkMasterDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_ISA95WorkMasterDataType = 74;

        /// <summary>
        /// The identifier for the Name2_BinarySchema Variable.
        /// </summary>
        public const uint Name2_BinarySchema = 86;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint Name2_BinarySchema_NamespaceUri = 88;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95EquipmentDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_ISA95EquipmentDataType = 89;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95JobOrderDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_ISA95JobOrderDataType = 92;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95JobResponseDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_ISA95JobResponseDataType = 95;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95MaterialDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_ISA95MaterialDataType = 98;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95ParameterDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_ISA95ParameterDataType = 101;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95PersonnelDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_ISA95PersonnelDataType = 104;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95PhysicalAssetDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_ISA95PhysicalAssetDataType = 107;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95PropertyDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_ISA95PropertyDataType = 110;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95WorkMasterDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_ISA95WorkMasterDataType = 113;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the ISA95JobOrderCommandEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderCommandEnum = new ExpandedNodeId(Prefix2.DataTypes.ISA95JobOrderCommandEnum, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderStateEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderStateEnum = new ExpandedNodeId(Prefix2.DataTypes.ISA95JobOrderStateEnum, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95ReturnEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95ReturnEnum = new ExpandedNodeId(Prefix2.DataTypes.ISA95ReturnEnum, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95EquipmentDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95EquipmentDataType = new ExpandedNodeId(Prefix2.DataTypes.ISA95EquipmentDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderDataType = new ExpandedNodeId(Prefix2.DataTypes.ISA95JobOrderDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseDataType = new ExpandedNodeId(Prefix2.DataTypes.ISA95JobResponseDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95MaterialDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95MaterialDataType = new ExpandedNodeId(Prefix2.DataTypes.ISA95MaterialDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95ParameterDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95ParameterDataType = new ExpandedNodeId(Prefix2.DataTypes.ISA95ParameterDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95PersonnelDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95PersonnelDataType = new ExpandedNodeId(Prefix2.DataTypes.ISA95PersonnelDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95PhysicalAssetDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95PhysicalAssetDataType = new ExpandedNodeId(Prefix2.DataTypes.ISA95PhysicalAssetDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95PropertyDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95PropertyDataType = new ExpandedNodeId(Prefix2.DataTypes.ISA95PropertyDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95WorkMasterDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95WorkMasterDataType = new ExpandedNodeId(Prefix2.DataTypes.ISA95WorkMasterDataType, Prefix2.Namespaces.Name2);
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_ReceiveJobOrder Method.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_ReceiveJobOrder = new ExpandedNodeId(Prefix2.Methods.ISA95JobOrderReceiverObjectType_ReceiveJobOrder, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseProviderObjectType_RequestJobResponse Method.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseProviderObjectType_RequestJobResponse = new ExpandedNodeId(Prefix2.Methods.ISA95JobResponseProviderObjectType_RequestJobResponse, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseReceiverObjectType_ReceiveJobResponse Method.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseReceiverObjectType_ReceiveJobResponse = new ExpandedNodeId(Prefix2.Methods.ISA95JobResponseReceiverObjectType_ReceiveJobResponse, Prefix2.Namespaces.Name2);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the ISA95EquipmentDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95EquipmentDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.ISA95EquipmentDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.ISA95JobOrderDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.ISA95JobResponseDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95MaterialDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95MaterialDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.ISA95MaterialDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95ParameterDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95ParameterDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.ISA95ParameterDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95PersonnelDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95PersonnelDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.ISA95PersonnelDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95PhysicalAssetDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95PhysicalAssetDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.ISA95PhysicalAssetDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95PropertyDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95PropertyDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.ISA95PropertyDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95WorkMasterDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95WorkMasterDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.ISA95WorkMasterDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95EquipmentDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95EquipmentDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.ISA95EquipmentDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.ISA95JobOrderDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.ISA95JobResponseDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95MaterialDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95MaterialDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.ISA95MaterialDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95ParameterDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95ParameterDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.ISA95ParameterDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95PersonnelDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95PersonnelDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.ISA95PersonnelDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95PhysicalAssetDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95PhysicalAssetDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.ISA95PhysicalAssetDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95PropertyDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95PropertyDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.ISA95PropertyDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95WorkMasterDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ISA95WorkMasterDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.ISA95WorkMasterDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType = new ExpandedNodeId(Prefix2.ObjectTypes.ISA95JobOrderReceiverObjectType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseProviderObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseProviderObjectType = new ExpandedNodeId(Prefix2.ObjectTypes.ISA95JobResponseProviderObjectType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseReceiverObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseReceiverObjectType = new ExpandedNodeId(Prefix2.ObjectTypes.ISA95JobResponseReceiverObjectType, Prefix2.Namespaces.Name2);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the ISA95JobOrderCommandEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderCommandEnum_EnumValues = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderCommandEnum_EnumValues, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderCommandEnum_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderCommandEnum_EnumStrings = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderCommandEnum_EnumStrings, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderStateEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderStateEnum_EnumValues = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderStateEnum_EnumValues, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderStateEnum_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderStateEnum_EnumStrings = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderStateEnum_EnumStrings, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95ReturnEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95ReturnEnum_EnumValues = new ExpandedNodeId(Prefix2.Variables.ISA95ReturnEnum_EnumValues, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95ReturnEnum_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95ReturnEnum_EnumStrings = new ExpandedNodeId(Prefix2.Variables.ISA95ReturnEnum_EnumStrings, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_EquipmentID Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_EquipmentID = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderReceiverObjectType_EquipmentID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_JobOrderList Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_JobOrderList = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderReceiverObjectType_JobOrderList, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_MaterialClassID Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_MaterialClassID = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderReceiverObjectType_MaterialClassID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_MaterialDefinitionID Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_MaterialDefinitionID = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderReceiverObjectType_MaterialDefinitionID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_PersonnelID Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_PersonnelID = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderReceiverObjectType_PersonnelID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_PhysicalAssetID Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_PhysicalAssetID = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderReceiverObjectType_PhysicalAssetID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_ReceiveJobOrder_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_ReceiveJobOrder_InputArguments = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderReceiverObjectType_ReceiveJobOrder_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_ReceiveJobOrder_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_ReceiveJobOrder_OutputArguments = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderReceiverObjectType_ReceiveJobOrder_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobOrderReceiverObjectType_WorkMaster Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobOrderReceiverObjectType_WorkMaster = new ExpandedNodeId(Prefix2.Variables.ISA95JobOrderReceiverObjectType_WorkMaster, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseProviderObjectType_RequestJobResponse_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseProviderObjectType_RequestJobResponse_InputArguments = new ExpandedNodeId(Prefix2.Variables.ISA95JobResponseProviderObjectType_RequestJobResponse_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseProviderObjectType_RequestJobResponse_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseProviderObjectType_RequestJobResponse_OutputArguments = new ExpandedNodeId(Prefix2.Variables.ISA95JobResponseProviderObjectType_RequestJobResponse_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseReceiverObjectType_ReceiveJobResponse_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseReceiverObjectType_ReceiveJobResponse_InputArguments = new ExpandedNodeId(Prefix2.Variables.ISA95JobResponseReceiverObjectType_ReceiveJobResponse_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the ISA95JobResponseReceiverObjectType_ReceiveJobResponse_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISA95JobResponseReceiverObjectType_ReceiveJobResponse_OutputArguments = new ExpandedNodeId(Prefix2.Variables.ISA95JobResponseReceiverObjectType_ReceiveJobResponse_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_NamespaceUri = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_NamespaceUri, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95EquipmentDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_ISA95EquipmentDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_ISA95EquipmentDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95JobOrderDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_ISA95JobOrderDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_ISA95JobOrderDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95JobResponseDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_ISA95JobResponseDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_ISA95JobResponseDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95MaterialDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_ISA95MaterialDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_ISA95MaterialDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95ParameterDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_ISA95ParameterDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_ISA95ParameterDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95PersonnelDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_ISA95PersonnelDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_ISA95PersonnelDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95PhysicalAssetDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_ISA95PhysicalAssetDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_ISA95PhysicalAssetDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95PropertyDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_ISA95PropertyDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_ISA95PropertyDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_ISA95WorkMasterDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_ISA95WorkMasterDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_ISA95WorkMasterDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_NamespaceUri = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_NamespaceUri, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95EquipmentDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_ISA95EquipmentDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_ISA95EquipmentDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95JobOrderDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_ISA95JobOrderDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_ISA95JobOrderDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95JobResponseDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_ISA95JobResponseDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_ISA95JobResponseDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95MaterialDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_ISA95MaterialDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_ISA95MaterialDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95ParameterDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_ISA95ParameterDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_ISA95ParameterDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95PersonnelDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_ISA95PersonnelDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_ISA95PersonnelDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95PhysicalAssetDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_ISA95PhysicalAssetDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_ISA95PhysicalAssetDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95PropertyDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_ISA95PropertyDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_ISA95PropertyDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_ISA95WorkMasterDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_ISA95WorkMasterDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_ISA95WorkMasterDataType, Prefix2.Namespaces.Name2);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the EquipmentID component.
        /// </summary>
        public const string EquipmentID = "EquipmentID";

        /// <summary>
        /// The BrowseName for the ISA95EquipmentDataType component.
        /// </summary>
        public const string ISA95EquipmentDataType = "ISA95EquipmentDataType";

        /// <summary>
        /// The BrowseName for the ISA95JobOrderCommandEnum component.
        /// </summary>
        public const string ISA95JobOrderCommandEnum = "ISA95JobOrderCommandEnum";

        /// <summary>
        /// The BrowseName for the ISA95JobOrderDataType component.
        /// </summary>
        public const string ISA95JobOrderDataType = "ISA95JobOrderDataType";

        /// <summary>
        /// The BrowseName for the ISA95JobOrderReceiverObjectType component.
        /// </summary>
        public const string ISA95JobOrderReceiverObjectType = "ISA95JobOrderReceiverObjectType";

        /// <summary>
        /// The BrowseName for the ISA95JobOrderStateEnum component.
        /// </summary>
        public const string ISA95JobOrderStateEnum = "ISA95JobOrderStateEnum";

        /// <summary>
        /// The BrowseName for the ISA95JobResponseDataType component.
        /// </summary>
        public const string ISA95JobResponseDataType = "ISA95JobResponseDataType";

        /// <summary>
        /// The BrowseName for the ISA95JobResponseProviderObjectType component.
        /// </summary>
        public const string ISA95JobResponseProviderObjectType = "ISA95JobResponseProviderObjectType";

        /// <summary>
        /// The BrowseName for the ISA95JobResponseReceiverObjectType component.
        /// </summary>
        public const string ISA95JobResponseReceiverObjectType = "ISA95JobResponseReceiverObjectType";

        /// <summary>
        /// The BrowseName for the ISA95MaterialDataType component.
        /// </summary>
        public const string ISA95MaterialDataType = "ISA95MaterialDataType";

        /// <summary>
        /// The BrowseName for the ISA95ParameterDataType component.
        /// </summary>
        public const string ISA95ParameterDataType = "ISA95ParameterDataType";

        /// <summary>
        /// The BrowseName for the ISA95PersonnelDataType component.
        /// </summary>
        public const string ISA95PersonnelDataType = "ISA95PersonnelDataType";

        /// <summary>
        /// The BrowseName for the ISA95PhysicalAssetDataType component.
        /// </summary>
        public const string ISA95PhysicalAssetDataType = "ISA95PhysicalAssetDataType";

        /// <summary>
        /// The BrowseName for the ISA95PropertyDataType component.
        /// </summary>
        public const string ISA95PropertyDataType = "ISA95PropertyDataType";

        /// <summary>
        /// The BrowseName for the ISA95ReturnEnum component.
        /// </summary>
        public const string ISA95ReturnEnum = "ISA95ReturnEnum";

        /// <summary>
        /// The BrowseName for the ISA95WorkMasterDataType component.
        /// </summary>
        public const string ISA95WorkMasterDataType = "ISA95WorkMasterDataType";

        /// <summary>
        /// The BrowseName for the JobOrderList component.
        /// </summary>
        public const string JobOrderList = "JobOrderList";

        /// <summary>
        /// The BrowseName for the MaterialClassID component.
        /// </summary>
        public const string MaterialClassID = "MaterialClassID";

        /// <summary>
        /// The BrowseName for the MaterialDefinitionID component.
        /// </summary>
        public const string MaterialDefinitionID = "MaterialDefinitionID";

        /// <summary>
        /// The BrowseName for the Name2_BinarySchema component.
        /// </summary>
        public const string Name2_BinarySchema = "Prefix2";

        /// <summary>
        /// The BrowseName for the Name2_XmlSchema component.
        /// </summary>
        public const string Name2_XmlSchema = "Prefix2";

        /// <summary>
        /// The BrowseName for the PersonnelID component.
        /// </summary>
        public const string PersonnelID = "PersonnelID";

        /// <summary>
        /// The BrowseName for the PhysicalAssetID component.
        /// </summary>
        public const string PhysicalAssetID = "PhysicalAssetID";

        /// <summary>
        /// The BrowseName for the ReceiveJobOrder component.
        /// </summary>
        public const string ReceiveJobOrder = "ReceiveJobOrder";

        /// <summary>
        /// The BrowseName for the ReceiveJobResponse component.
        /// </summary>
        public const string ReceiveJobResponse = "ReceiveJobResponse";

        /// <summary>
        /// The BrowseName for the RequestJobResponse component.
        /// </summary>
        public const string RequestJobResponse = "RequestJobResponse";

        /// <summary>
        /// The BrowseName for the WorkMaster component.
        /// </summary>
        public const string WorkMaster = "WorkMaster";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the Name0Xsd namespace (.NET code namespace is 'Prefix0').
        /// </summary>
        public const string Name0Xsd = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the Name0Xsd namespace (.NET code namespace is 'Prefix0').
        /// </summary>
        public const string Name0Xsd = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the Name2Xsd namespace (.NET code namespace is 'Prefix2').
        /// </summary>
        public const string Name2Xsd = "http://opcfoundation.org/UA/ISA95-JOBCONTROL";

        /// <summary>
        /// The URI for the Name2Xsd namespace (.NET code namespace is 'Prefix2').
        /// </summary>
        public const string Name2Xsd = "http://opcfoundation.org/UA/ISA95-JOBCONTROL";
    }
    #endregion

    #region ISA95JobOrderCommandEnum Enumeration
    #if (!OPCUA_EXCLUDE_ISA95JobOrderCommandEnum)
    /// <summary>
    /// Describes the possible job order commands.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public enum ISA95JobOrderCommandEnum
    {
        /// <summary>
        /// Undefined value, should never be seen.
        /// </summary>
        [EnumMember(Value = "Undefined_0")]
        Undefined = 0,

        /// <summary>
        /// Command to store the job order in local storage, but not to start the order.
        /// </summary>
        [EnumMember(Value = "Store_1")]
        Store = 1,

        /// <summary>
        /// Command to store the job order and start it as soon as the Job Order receiver is ready to start.
        /// </summary>
        [EnumMember(Value = "StoreAndStart_2")]
        StoreAndStart = 2,

        /// <summary>
        /// Command to start a stored job order as soon as the receiver is ready to start. Only the Job Orders ID is used to identify the stored job order, all other information is not used.  No changes are made to the stored order. If multiple Job Orders have been commanded to Start, then the priority and timing values in the Job Orders shall be used to determine the order of execution of the orders.
        /// </summary>
        [EnumMember(Value = "Start_3")]
        Start = 3,

        /// <summary>
        /// Command to update a stored Job Order that has not yet been started, with the new order information.  All previously stored information is replaced.
        /// </summary>
        [EnumMember(Value = "Update_4")]
        Update = 4,

        /// <summary>
        /// Command to stop a started job order, report on any work done on the order, and remove the stored information. Only the Job Orders ID is used to identify the job order, all other information is not used.
        /// </summary>
        [EnumMember(Value = "Stop_5")]
        Stop = 5,

        /// <summary>
        /// Cancel an un-started job order and remove the stored information. Only the Job Orders ID is used to identify the job order, all other information is not used.
        /// </summary>
        [EnumMember(Value = "Cancel_6")]
        Cancel = 6,

        /// <summary>
        /// Command to allow the Information Receiver to clear any maintained information on the Job Order (usually sent after a receipt of a Job Response with a status of Finished.) Only the Job Orders ID is used to identify the job order, all other information is not used.
        /// </summary>
        [EnumMember(Value = "Clear_7")]
        Clear = 7,
    }

    #region ISA95JobOrderCommandEnumCollection Class
    /// <summary>
    /// A collection of ISA95JobOrderCommandEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95JobOrderCommandEnum", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95JobOrderCommandEnum")]
    #if !NET_STANDARD
    public partial class ISA95JobOrderCommandEnumCollection : List<ISA95JobOrderCommandEnum>, ICloneable
    #else
    public partial class ISA95JobOrderCommandEnumCollection : List<ISA95JobOrderCommandEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95JobOrderCommandEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95JobOrderCommandEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95JobOrderCommandEnumCollection(IEnumerable<ISA95JobOrderCommandEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95JobOrderCommandEnumCollection(ISA95JobOrderCommandEnum[] values)
        {
            if (values != null)
            {
                return new ISA95JobOrderCommandEnumCollection(values);
            }

            return new ISA95JobOrderCommandEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95JobOrderCommandEnum[](ISA95JobOrderCommandEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95JobOrderCommandEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95JobOrderCommandEnumCollection clone = new ISA95JobOrderCommandEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95JobOrderCommandEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95JobOrderStateEnum Enumeration
    #if (!OPCUA_EXCLUDE_ISA95JobOrderStateEnum)
    /// <summary>
    /// Describes the defined job statuses.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public enum ISA95JobOrderStateEnum
    {
        /// <summary>
        /// Undefined value, should never be seen.
        /// </summary>
        [EnumMember(Value = "Undefined_0")]
        Undefined = 0,

        /// <summary>
        /// The necessary pre-conditions have not been met and the order is not ready to run.
        /// </summary>
        [EnumMember(Value = "Waiting_1")]
        Waiting = 1,

        /// <summary>
        /// The necessary pre-conditions have been met and the order is ready to run, awaiting a Start command.
        /// </summary>
        [EnumMember(Value = "Ready_2")]
        Ready = 2,

        /// <summary>
        /// In situations where only one job may be in active memory and is able to be run, then the job is loaded in active memory, the necessary pre-conditions have been met, and the order is ready to run, awaiting a Start command.
        /// </summary>
        [EnumMember(Value = "Loaded_3")]
        Loaded = 3,

        /// <summary>
        /// The order is executing.
        /// </summary>
        [EnumMember(Value = "Running_4")]
        Running = 4,

        /// <summary>
        /// The order has been completed and is no longer in execution.
        /// </summary>
        [EnumMember(Value = "Completed_5")]
        Completed = 5,

        /// <summary>
        /// The order was aborted.
        /// </summary>
        [EnumMember(Value = "Aborted_6")]
        Aborted = 6,

        /// <summary>
        /// The order has been temporarily stopped due to a constraint of some form.
        /// </summary>
        [EnumMember(Value = "Held_7")]
        Held = 7,

        /// <summary>
        /// The order has been temporarily stopped due to a deliberate decision within the execution system.
        /// </summary>
        [EnumMember(Value = "Suspended_8")]
        Suspended = 8,

        /// <summary>
        /// The order has been completed and fully reconciled. No further changes, or restatement of actuals is expected.
        /// </summary>
        [EnumMember(Value = "Closed_9")]
        Closed = 9,

        /// <summary>
        /// The Job is in error and requires attention.
        /// </summary>
        [EnumMember(Value = "Error_10")]
        Error = 10,
    }

    #region ISA95JobOrderStateEnumCollection Class
    /// <summary>
    /// A collection of ISA95JobOrderStateEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95JobOrderStateEnum", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95JobOrderStateEnum")]
    #if !NET_STANDARD
    public partial class ISA95JobOrderStateEnumCollection : List<ISA95JobOrderStateEnum>, ICloneable
    #else
    public partial class ISA95JobOrderStateEnumCollection : List<ISA95JobOrderStateEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95JobOrderStateEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95JobOrderStateEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95JobOrderStateEnumCollection(IEnumerable<ISA95JobOrderStateEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95JobOrderStateEnumCollection(ISA95JobOrderStateEnum[] values)
        {
            if (values != null)
            {
                return new ISA95JobOrderStateEnumCollection(values);
            }

            return new ISA95JobOrderStateEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95JobOrderStateEnum[](ISA95JobOrderStateEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95JobOrderStateEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95JobOrderStateEnumCollection clone = new ISA95JobOrderStateEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95JobOrderStateEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95ReturnEnum Enumeration
    #if (!OPCUA_EXCLUDE_ISA95ReturnEnum)
    /// <summary>
    /// It describes the possible return status from a Method call
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public enum ISA95ReturnEnum
    {
        /// <summary>
        /// Undefined value, should never be seen
        /// </summary>
        [EnumMember(Value = "Undefined_0")]
        Undefined = 0,

        /// <summary>
        /// There were no errors in processing the method.
        /// </summary>
        [EnumMember(Value = "NoError_1")]
        NoError = 1,

        /// <summary>
        /// The referenced job order ID is invalid or not known to the receiver.
        /// </summary>
        [EnumMember(Value = "InvalidJobOrderID_2")]
        InvalidJobOrderID = 2,

        /// <summary>
        /// The server is currently unable to accept job orders.
        /// </summary>
        [EnumMember(Value = "UnableToAcceptJobOrder_3")]
        UnableToAcceptJobOrder = 3,

        /// <summary>
        /// The server is currently unable to accept job order commands for the specified job order.
        /// </summary>
        [EnumMember(Value = "UnableToAcceptJobOrderCommand_4")]
        UnableToAcceptJobOrderCommand = 4,

        /// <summary>
        /// The server is unable to provide a Job Response for the specified Job Order.
        /// </summary>
        [EnumMember(Value = "UnableToReturnJobResponse_5")]
        UnableToReturnJobResponse = 5,
    }

    #region ISA95ReturnEnumCollection Class
    /// <summary>
    /// A collection of ISA95ReturnEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95ReturnEnum", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95ReturnEnum")]
    #if !NET_STANDARD
    public partial class ISA95ReturnEnumCollection : List<ISA95ReturnEnum>, ICloneable
    #else
    public partial class ISA95ReturnEnumCollection : List<ISA95ReturnEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95ReturnEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95ReturnEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95ReturnEnumCollection(IEnumerable<ISA95ReturnEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95ReturnEnumCollection(ISA95ReturnEnum[] values)
        {
            if (values != null)
            {
                return new ISA95ReturnEnumCollection(values);
            }

            return new ISA95ReturnEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95ReturnEnum[](ISA95ReturnEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95ReturnEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95ReturnEnumCollection clone = new ISA95ReturnEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95ReturnEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95EquipmentDataType Class
    #if (!OPCUA_EXCLUDE_ISA95EquipmentDataType)
    /// <summary>
    /// Defines an equipment resource or a piece of equipment, a quantity, an optional description, and an optional collection of properties.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class ISA95EquipmentDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ISA95EquipmentDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_ıD = null;
            m_description = null;
            m_equipmentUse = null;
            m_quantity = null;
            m_uoM = null;
            m_properties = new ISA95PropertyDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// An identification of an EquipmentClass or Equipment.
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// Additional information and description about the resource.
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 2)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// Information about the expected use of the equipment, see the ISA 95 Part 2 standard for defined values. 
        /// </summary>
        [DataMember(Name = "EquipmentUse", IsRequired = false, Order = 3)]
        public string EquipmentUse
        {
            get { return m_equipmentUse;  }
            set { m_equipmentUse = value; }
        }

        /// <summary>
        /// The quantity of the resource
        /// </summary>
        [DataMember(Name = "Quantity", IsRequired = false, Order = 4)]
        public string Quantity
        {
            get { return m_quantity;  }
            set { m_quantity = value; }
        }

        /// <summary>
        /// The Unit Of Measure of the quantity
        /// </summary>
        [DataMember(Name = "UoM", IsRequired = false, Order = 5)]
        public string UoM
        {
            get { return m_uoM;  }
            set { m_uoM = value; }
        }

        /// <summary>
        /// Any associated properties, or empty if there are no properties defined. 
        /// </summary>
        [DataMember(Name = "Properties", IsRequired = false, Order = 6)]
        public ISA95PropertyDataTypeCollection Properties
        {
            get
            {
                return m_properties;
            }

            set
            {
                m_properties = value;

                if (value == null)
                {
                    m_properties = new ISA95PropertyDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ISA95EquipmentDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ISA95EquipmentDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ISA95EquipmentDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteString("Description", Description);
            encoder.WriteString("EquipmentUse", EquipmentUse);
            encoder.WriteString("Quantity", Quantity);
            encoder.WriteString("UoM", UoM);
            encoder.WriteEncodeableArray("Properties", Properties.ToArray(), typeof(ISA95PropertyDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            Description = decoder.ReadString("Description");
            EquipmentUse = decoder.ReadString("EquipmentUse");
            Quantity = decoder.ReadString("Quantity");
            UoM = decoder.ReadString("UoM");
            Properties = (ISA95PropertyDataTypeCollection)decoder.ReadEncodeableArray("Properties", typeof(ISA95PropertyDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ISA95EquipmentDataType value = encodeable as ISA95EquipmentDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_equipmentUse, value.m_equipmentUse)) return false;
            if (!Utils.IsEqual(m_quantity, value.m_quantity)) return false;
            if (!Utils.IsEqual(m_uoM, value.m_uoM)) return false;
            if (!Utils.IsEqual(m_properties, value.m_properties)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ISA95EquipmentDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95EquipmentDataType clone = (ISA95EquipmentDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_equipmentUse = (string)Utils.Clone(this.m_equipmentUse);
            clone.m_quantity = (string)Utils.Clone(this.m_quantity);
            clone.m_uoM = (string)Utils.Clone(this.m_uoM);
            clone.m_properties = (ISA95PropertyDataTypeCollection)Utils.Clone(this.m_properties);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private string m_description;
        private string m_equipmentUse;
        private string m_quantity;
        private string m_uoM;
        private ISA95PropertyDataTypeCollection m_properties;
        #endregion
    }

    #region ISA95EquipmentDataTypeCollection Class
    /// <summary>
    /// A collection of ISA95EquipmentDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95EquipmentDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95EquipmentDataType")]
    #if !NET_STANDARD
    public partial class ISA95EquipmentDataTypeCollection : List<ISA95EquipmentDataType>, ICloneable
    #else
    public partial class ISA95EquipmentDataTypeCollection : List<ISA95EquipmentDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95EquipmentDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95EquipmentDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95EquipmentDataTypeCollection(IEnumerable<ISA95EquipmentDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95EquipmentDataTypeCollection(ISA95EquipmentDataType[] values)
        {
            if (values != null)
            {
                return new ISA95EquipmentDataTypeCollection(values);
            }

            return new ISA95EquipmentDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95EquipmentDataType[](ISA95EquipmentDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95EquipmentDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95EquipmentDataTypeCollection clone = new ISA95EquipmentDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95EquipmentDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95JobOrderDataType Class
    #if (!OPCUA_EXCLUDE_ISA95JobOrderDataType)
    /// <summary>
    /// Defines the information needed to schedule and execute a job.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class ISA95JobOrderDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ISA95JobOrderDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_ıD = null;
            m_description = null;
            m_workMasterID = new ISA95WorkMasterDataTypeCollection();
            m_startTime = DateTime.MinValue;
            m_endTime = DateTime.MinValue;
            m_priority = (short)0;
            m_jobOrderParameters = new ISA95ParameterDataTypeCollection();
            m_personnelRequirements = new ISA95PersonnelDataTypeCollection();
            m_equipmentRequirements = new ISA95EquipmentDataTypeCollection();
            m_physicalAssetRequirements = new ISA95PhysicalAssetDataTypeCollection();
            m_materialRequirements = new ISA95MaterialDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// An identification of the Job Order.
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// Addition information about the Job Order 
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 2)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// Work Master associated with the job order. If multiple work masters are defined, then the execution system can select the work master based on the availability of resources. 
        /// </summary>
        [DataMember(Name = "WorkMasterID", IsRequired = false, Order = 3)]
        public ISA95WorkMasterDataTypeCollection WorkMasterID
        {
            get
            {
                return m_workMasterID;
            }

            set
            {
                m_workMasterID = value;

                if (value == null)
                {
                    m_workMasterID = new ISA95WorkMasterDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// The proposed start time for the order, may be empty if not specified
        /// </summary>
        [DataMember(Name = "StartTime", IsRequired = false, Order = 4)]
        public DateTime StartTime
        {
            get { return m_startTime;  }
            set { m_startTime = value; }
        }

        /// <summary>
        /// The proposed end time for the order, may be empty if not specified
        /// </summary>
        [DataMember(Name = "EndTime", IsRequired = false, Order = 5)]
        public DateTime EndTime
        {
            get { return m_endTime;  }
            set { m_endTime = value; }
        }

        /// <summary>
        /// The priority of the job order, may be empty of not specified. Higher numbers have higher priority.  This type allows the Job Order clients to pick their own ranges, and the Job Order server only has to pick the highest number.
        /// </summary>
        [DataMember(Name = "Priority", IsRequired = false, Order = 6)]
        public short Priority
        {
            get { return m_priority;  }
            set { m_priority = value; }
        }

        /// <summary>
        /// Key value pair with values, not associated with a resource that is provided as part of the job order, may be empty if not specified.
        /// </summary>
        [DataMember(Name = "JobOrderParameters", IsRequired = false, Order = 7)]
        public ISA95ParameterDataTypeCollection JobOrderParameters
        {
            get
            {
                return m_jobOrderParameters;
            }

            set
            {
                m_jobOrderParameters = value;

                if (value == null)
                {
                    m_jobOrderParameters = new ISA95ParameterDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// A specification of any personnel requirements associated with the job order, may be empty if not specified
        /// </summary>
        [DataMember(Name = "PersonnelRequirements", IsRequired = false, Order = 8)]
        public ISA95PersonnelDataTypeCollection PersonnelRequirements
        {
            get
            {
                return m_personnelRequirements;
            }

            set
            {
                m_personnelRequirements = value;

                if (value == null)
                {
                    m_personnelRequirements = new ISA95PersonnelDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// A specification of any equipment requirements associated with the job order, may be empty if not specified.
        /// </summary>
        [DataMember(Name = "EquipmentRequirements", IsRequired = false, Order = 9)]
        public ISA95EquipmentDataTypeCollection EquipmentRequirements
        {
            get
            {
                return m_equipmentRequirements;
            }

            set
            {
                m_equipmentRequirements = value;

                if (value == null)
                {
                    m_equipmentRequirements = new ISA95EquipmentDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// A specification of any physical asset requirements associated with the job order, may be empty if not specified.
        /// </summary>
        [DataMember(Name = "PhysicalAssetRequirements", IsRequired = false, Order = 10)]
        public ISA95PhysicalAssetDataTypeCollection PhysicalAssetRequirements
        {
            get
            {
                return m_physicalAssetRequirements;
            }

            set
            {
                m_physicalAssetRequirements = value;

                if (value == null)
                {
                    m_physicalAssetRequirements = new ISA95PhysicalAssetDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// A specification of any material requirements associated with the job order, may be empty if not specified.
        /// </summary>
        [DataMember(Name = "MaterialRequirements", IsRequired = false, Order = 11)]
        public ISA95MaterialDataTypeCollection MaterialRequirements
        {
            get
            {
                return m_materialRequirements;
            }

            set
            {
                m_materialRequirements = value;

                if (value == null)
                {
                    m_materialRequirements = new ISA95MaterialDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ISA95JobOrderDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ISA95JobOrderDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ISA95JobOrderDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteString("Description", Description);
            encoder.WriteEncodeableArray("WorkMasterID", WorkMasterID.ToArray(), typeof(ISA95WorkMasterDataType));
            encoder.WriteDateTime("StartTime", StartTime);
            encoder.WriteDateTime("EndTime", EndTime);
            encoder.WriteInt16("Priority", Priority);
            encoder.WriteEncodeableArray("JobOrderParameters", JobOrderParameters.ToArray(), typeof(ISA95ParameterDataType));
            encoder.WriteEncodeableArray("PersonnelRequirements", PersonnelRequirements.ToArray(), typeof(ISA95PersonnelDataType));
            encoder.WriteEncodeableArray("EquipmentRequirements", EquipmentRequirements.ToArray(), typeof(ISA95EquipmentDataType));
            encoder.WriteEncodeableArray("PhysicalAssetRequirements", PhysicalAssetRequirements.ToArray(), typeof(ISA95PhysicalAssetDataType));
            encoder.WriteEncodeableArray("MaterialRequirements", MaterialRequirements.ToArray(), typeof(ISA95MaterialDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            Description = decoder.ReadString("Description");
            WorkMasterID = (ISA95WorkMasterDataTypeCollection)decoder.ReadEncodeableArray("WorkMasterID", typeof(ISA95WorkMasterDataType));
            StartTime = decoder.ReadDateTime("StartTime");
            EndTime = decoder.ReadDateTime("EndTime");
            Priority = decoder.ReadInt16("Priority");
            JobOrderParameters = (ISA95ParameterDataTypeCollection)decoder.ReadEncodeableArray("JobOrderParameters", typeof(ISA95ParameterDataType));
            PersonnelRequirements = (ISA95PersonnelDataTypeCollection)decoder.ReadEncodeableArray("PersonnelRequirements", typeof(ISA95PersonnelDataType));
            EquipmentRequirements = (ISA95EquipmentDataTypeCollection)decoder.ReadEncodeableArray("EquipmentRequirements", typeof(ISA95EquipmentDataType));
            PhysicalAssetRequirements = (ISA95PhysicalAssetDataTypeCollection)decoder.ReadEncodeableArray("PhysicalAssetRequirements", typeof(ISA95PhysicalAssetDataType));
            MaterialRequirements = (ISA95MaterialDataTypeCollection)decoder.ReadEncodeableArray("MaterialRequirements", typeof(ISA95MaterialDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ISA95JobOrderDataType value = encodeable as ISA95JobOrderDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_workMasterID, value.m_workMasterID)) return false;
            if (!Utils.IsEqual(m_startTime, value.m_startTime)) return false;
            if (!Utils.IsEqual(m_endTime, value.m_endTime)) return false;
            if (!Utils.IsEqual(m_priority, value.m_priority)) return false;
            if (!Utils.IsEqual(m_jobOrderParameters, value.m_jobOrderParameters)) return false;
            if (!Utils.IsEqual(m_personnelRequirements, value.m_personnelRequirements)) return false;
            if (!Utils.IsEqual(m_equipmentRequirements, value.m_equipmentRequirements)) return false;
            if (!Utils.IsEqual(m_physicalAssetRequirements, value.m_physicalAssetRequirements)) return false;
            if (!Utils.IsEqual(m_materialRequirements, value.m_materialRequirements)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ISA95JobOrderDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95JobOrderDataType clone = (ISA95JobOrderDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_workMasterID = (ISA95WorkMasterDataTypeCollection)Utils.Clone(this.m_workMasterID);
            clone.m_startTime = (DateTime)Utils.Clone(this.m_startTime);
            clone.m_endTime = (DateTime)Utils.Clone(this.m_endTime);
            clone.m_priority = (short)Utils.Clone(this.m_priority);
            clone.m_jobOrderParameters = (ISA95ParameterDataTypeCollection)Utils.Clone(this.m_jobOrderParameters);
            clone.m_personnelRequirements = (ISA95PersonnelDataTypeCollection)Utils.Clone(this.m_personnelRequirements);
            clone.m_equipmentRequirements = (ISA95EquipmentDataTypeCollection)Utils.Clone(this.m_equipmentRequirements);
            clone.m_physicalAssetRequirements = (ISA95PhysicalAssetDataTypeCollection)Utils.Clone(this.m_physicalAssetRequirements);
            clone.m_materialRequirements = (ISA95MaterialDataTypeCollection)Utils.Clone(this.m_materialRequirements);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private string m_description;
        private ISA95WorkMasterDataTypeCollection m_workMasterID;
        private DateTime m_startTime;
        private DateTime m_endTime;
        private short m_priority;
        private ISA95ParameterDataTypeCollection m_jobOrderParameters;
        private ISA95PersonnelDataTypeCollection m_personnelRequirements;
        private ISA95EquipmentDataTypeCollection m_equipmentRequirements;
        private ISA95PhysicalAssetDataTypeCollection m_physicalAssetRequirements;
        private ISA95MaterialDataTypeCollection m_materialRequirements;
        #endregion
    }

    #region ISA95JobOrderDataTypeCollection Class
    /// <summary>
    /// A collection of ISA95JobOrderDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95JobOrderDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95JobOrderDataType")]
    #if !NET_STANDARD
    public partial class ISA95JobOrderDataTypeCollection : List<ISA95JobOrderDataType>, ICloneable
    #else
    public partial class ISA95JobOrderDataTypeCollection : List<ISA95JobOrderDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95JobOrderDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95JobOrderDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95JobOrderDataTypeCollection(IEnumerable<ISA95JobOrderDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95JobOrderDataTypeCollection(ISA95JobOrderDataType[] values)
        {
            if (values != null)
            {
                return new ISA95JobOrderDataTypeCollection(values);
            }

            return new ISA95JobOrderDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95JobOrderDataType[](ISA95JobOrderDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95JobOrderDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95JobOrderDataTypeCollection clone = new ISA95JobOrderDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95JobOrderDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95JobResponseDataType Class
    #if (!OPCUA_EXCLUDE_ISA95JobResponseDataType)
    /// <summary>
    /// defines the information needed to schedule and execute a job.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class ISA95JobResponseDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ISA95JobResponseDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_ıD = null;
            m_description = null;
            m_jobOrderID = null;
            m_startTime = DateTime.MinValue;
            m_endTime = DateTime.MinValue;
            m_jobState = ISA95JobOrderStateEnum.Undefined;
            m_jobResponseData = new ISA95ParameterDataTypeCollection();
            m_personnelActuals = new ISA95PersonnelDataTypeCollection();
            m_equipmentActuals = new ISA95EquipmentDataTypeCollection();
            m_physicalAssetActuals = new ISA95PhysicalAssetDataTypeCollection();
            m_materialActuals = new ISA95MaterialDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// An identification of the Job Response
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// Additional information about the Job Response
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 2)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// An identification of the job order associated with the job response. 
        /// </summary>
        [DataMember(Name = "JobOrderID", IsRequired = false, Order = 3)]
        public string JobOrderID
        {
            get { return m_jobOrderID;  }
            set { m_jobOrderID = value; }
        }

        /// <summary>
        /// The actual start time for the order. 
        /// </summary>
        [DataMember(Name = "StartTime", IsRequired = false, Order = 4)]
        public DateTime StartTime
        {
            get { return m_startTime;  }
            set { m_startTime = value; }
        }

        /// <summary>
        /// The actual end time for the order. 
        /// </summary>
        [DataMember(Name = "EndTime", IsRequired = false, Order = 5)]
        public DateTime EndTime
        {
            get { return m_endTime;  }
            set { m_endTime = value; }
        }

        /// <summary>
        /// The current state of the job.
        /// </summary>
        [DataMember(Name = "JobState", IsRequired = false, Order = 6)]
        public ISA95JobOrderStateEnum JobState
        {
            get { return m_jobState;  }
            set { m_jobState = value; }
        }

        /// <summary>
        /// Key value pair with values, not associated with a resource that is provided as part of the job response, may be empty if not specified.
        /// </summary>
        [DataMember(Name = "JobResponseData", IsRequired = false, Order = 7)]
        public ISA95ParameterDataTypeCollection JobResponseData
        {
            get
            {
                return m_jobResponseData;
            }

            set
            {
                m_jobResponseData = value;

                if (value == null)
                {
                    m_jobResponseData = new ISA95ParameterDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// A specification of any personnel requirements associated with the job response, may be empty if not specified.
        /// </summary>
        [DataMember(Name = "PersonnelActuals", IsRequired = false, Order = 8)]
        public ISA95PersonnelDataTypeCollection PersonnelActuals
        {
            get
            {
                return m_personnelActuals;
            }

            set
            {
                m_personnelActuals = value;

                if (value == null)
                {
                    m_personnelActuals = new ISA95PersonnelDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// A specification of any equipment requirements associated with the job response, may be empty if not specified.
        /// </summary>
        [DataMember(Name = "EquipmentActuals", IsRequired = false, Order = 9)]
        public ISA95EquipmentDataTypeCollection EquipmentActuals
        {
            get
            {
                return m_equipmentActuals;
            }

            set
            {
                m_equipmentActuals = value;

                if (value == null)
                {
                    m_equipmentActuals = new ISA95EquipmentDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// A specification of any physical asset requirements associated with the job response, may be empty if not specified.
        /// </summary>
        [DataMember(Name = "PhysicalAssetActuals", IsRequired = false, Order = 10)]
        public ISA95PhysicalAssetDataTypeCollection PhysicalAssetActuals
        {
            get
            {
                return m_physicalAssetActuals;
            }

            set
            {
                m_physicalAssetActuals = value;

                if (value == null)
                {
                    m_physicalAssetActuals = new ISA95PhysicalAssetDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// A specification of any material requirements associated with the job response, may be empty if not specified.
        /// </summary>
        [DataMember(Name = "MaterialActuals", IsRequired = false, Order = 11)]
        public ISA95MaterialDataTypeCollection MaterialActuals
        {
            get
            {
                return m_materialActuals;
            }

            set
            {
                m_materialActuals = value;

                if (value == null)
                {
                    m_materialActuals = new ISA95MaterialDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ISA95JobResponseDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ISA95JobResponseDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ISA95JobResponseDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteString("Description", Description);
            encoder.WriteString("JobOrderID", JobOrderID);
            encoder.WriteDateTime("StartTime", StartTime);
            encoder.WriteDateTime("EndTime", EndTime);
            encoder.WriteEnumerated("JobState", JobState);
            encoder.WriteEncodeableArray("JobResponseData", JobResponseData.ToArray(), typeof(ISA95ParameterDataType));
            encoder.WriteEncodeableArray("PersonnelActuals", PersonnelActuals.ToArray(), typeof(ISA95PersonnelDataType));
            encoder.WriteEncodeableArray("EquipmentActuals", EquipmentActuals.ToArray(), typeof(ISA95EquipmentDataType));
            encoder.WriteEncodeableArray("PhysicalAssetActuals", PhysicalAssetActuals.ToArray(), typeof(ISA95PhysicalAssetDataType));
            encoder.WriteEncodeableArray("MaterialActuals", MaterialActuals.ToArray(), typeof(ISA95MaterialDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            Description = decoder.ReadString("Description");
            JobOrderID = decoder.ReadString("JobOrderID");
            StartTime = decoder.ReadDateTime("StartTime");
            EndTime = decoder.ReadDateTime("EndTime");
            JobState = (ISA95JobOrderStateEnum)decoder.ReadEnumerated("JobState", typeof(ISA95JobOrderStateEnum));
            JobResponseData = (ISA95ParameterDataTypeCollection)decoder.ReadEncodeableArray("JobResponseData", typeof(ISA95ParameterDataType));
            PersonnelActuals = (ISA95PersonnelDataTypeCollection)decoder.ReadEncodeableArray("PersonnelActuals", typeof(ISA95PersonnelDataType));
            EquipmentActuals = (ISA95EquipmentDataTypeCollection)decoder.ReadEncodeableArray("EquipmentActuals", typeof(ISA95EquipmentDataType));
            PhysicalAssetActuals = (ISA95PhysicalAssetDataTypeCollection)decoder.ReadEncodeableArray("PhysicalAssetActuals", typeof(ISA95PhysicalAssetDataType));
            MaterialActuals = (ISA95MaterialDataTypeCollection)decoder.ReadEncodeableArray("MaterialActuals", typeof(ISA95MaterialDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ISA95JobResponseDataType value = encodeable as ISA95JobResponseDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_jobOrderID, value.m_jobOrderID)) return false;
            if (!Utils.IsEqual(m_startTime, value.m_startTime)) return false;
            if (!Utils.IsEqual(m_endTime, value.m_endTime)) return false;
            if (!Utils.IsEqual(m_jobState, value.m_jobState)) return false;
            if (!Utils.IsEqual(m_jobResponseData, value.m_jobResponseData)) return false;
            if (!Utils.IsEqual(m_personnelActuals, value.m_personnelActuals)) return false;
            if (!Utils.IsEqual(m_equipmentActuals, value.m_equipmentActuals)) return false;
            if (!Utils.IsEqual(m_physicalAssetActuals, value.m_physicalAssetActuals)) return false;
            if (!Utils.IsEqual(m_materialActuals, value.m_materialActuals)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ISA95JobResponseDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95JobResponseDataType clone = (ISA95JobResponseDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_jobOrderID = (string)Utils.Clone(this.m_jobOrderID);
            clone.m_startTime = (DateTime)Utils.Clone(this.m_startTime);
            clone.m_endTime = (DateTime)Utils.Clone(this.m_endTime);
            clone.m_jobState = (ISA95JobOrderStateEnum)Utils.Clone(this.m_jobState);
            clone.m_jobResponseData = (ISA95ParameterDataTypeCollection)Utils.Clone(this.m_jobResponseData);
            clone.m_personnelActuals = (ISA95PersonnelDataTypeCollection)Utils.Clone(this.m_personnelActuals);
            clone.m_equipmentActuals = (ISA95EquipmentDataTypeCollection)Utils.Clone(this.m_equipmentActuals);
            clone.m_physicalAssetActuals = (ISA95PhysicalAssetDataTypeCollection)Utils.Clone(this.m_physicalAssetActuals);
            clone.m_materialActuals = (ISA95MaterialDataTypeCollection)Utils.Clone(this.m_materialActuals);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private string m_description;
        private string m_jobOrderID;
        private DateTime m_startTime;
        private DateTime m_endTime;
        private ISA95JobOrderStateEnum m_jobState;
        private ISA95ParameterDataTypeCollection m_jobResponseData;
        private ISA95PersonnelDataTypeCollection m_personnelActuals;
        private ISA95EquipmentDataTypeCollection m_equipmentActuals;
        private ISA95PhysicalAssetDataTypeCollection m_physicalAssetActuals;
        private ISA95MaterialDataTypeCollection m_materialActuals;
        #endregion
    }

    #region ISA95JobResponseDataTypeCollection Class
    /// <summary>
    /// A collection of ISA95JobResponseDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95JobResponseDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95JobResponseDataType")]
    #if !NET_STANDARD
    public partial class ISA95JobResponseDataTypeCollection : List<ISA95JobResponseDataType>, ICloneable
    #else
    public partial class ISA95JobResponseDataTypeCollection : List<ISA95JobResponseDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95JobResponseDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95JobResponseDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95JobResponseDataTypeCollection(IEnumerable<ISA95JobResponseDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95JobResponseDataTypeCollection(ISA95JobResponseDataType[] values)
        {
            if (values != null)
            {
                return new ISA95JobResponseDataTypeCollection(values);
            }

            return new ISA95JobResponseDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95JobResponseDataType[](ISA95JobResponseDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95JobResponseDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95JobResponseDataTypeCollection clone = new ISA95JobResponseDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95JobResponseDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95MaterialDataType Class
    #if (!OPCUA_EXCLUDE_ISA95MaterialDataType)
    /// <summary>
    /// defines a material resource, a quantity, an optional description, and an optional collection of properties.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class ISA95MaterialDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ISA95MaterialDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_materialClassID = null;
            m_materialDefinitionID = null;
            m_materialLotID = null;
            m_materialSublotID = null;
            m_description = null;
            m_materialUse = null;
            m_quantity = null;
            m_uoM = null;
            m_properties = new ISA95PropertyDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// An identification of the resource, or null if the Material Class is not used to identify the material. 
        /// </summary>
        [DataMember(Name = "MaterialClassID", IsRequired = false, Order = 1)]
        public string MaterialClassID
        {
            get { return m_materialClassID;  }
            set { m_materialClassID = value; }
        }

        /// <summary>
        /// An identification of the resource, or null if the Material Definition is not used to identify the material. 
        /// </summary>
        [DataMember(Name = "MaterialDefinitionID", IsRequired = false, Order = 2)]
        public string MaterialDefinitionID
        {
            get { return m_materialDefinitionID;  }
            set { m_materialDefinitionID = value; }
        }

        /// <summary>
        /// An identification of the resource, or null if the Material Lot is not used to identify the material. 
        /// </summary>
        [DataMember(Name = "MaterialLotID", IsRequired = false, Order = 3)]
        public string MaterialLotID
        {
            get { return m_materialLotID;  }
            set { m_materialLotID = value; }
        }

        /// <summary>
        /// An identification of the resource, or null if the Material Sublot is not used to identify the material. 
        /// </summary>
        [DataMember(Name = "MaterialSublotID", IsRequired = false, Order = 4)]
        public string MaterialSublotID
        {
            get { return m_materialSublotID;  }
            set { m_materialSublotID = value; }
        }

        /// <summary>
        /// Additional information and description about the resource.
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 5)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// Information about the expected use of the material, see the ISA 95 Part 2 standard for defined values. 
        /// </summary>
        [DataMember(Name = "MaterialUse", IsRequired = false, Order = 6)]
        public string MaterialUse
        {
            get { return m_materialUse;  }
            set { m_materialUse = value; }
        }

        /// <summary>
        /// The quantity of the resource
        /// </summary>
        [DataMember(Name = "Quantity", IsRequired = false, Order = 7)]
        public string Quantity
        {
            get { return m_quantity;  }
            set { m_quantity = value; }
        }

        /// <summary>
        /// The Unit Of Measure of the quantity
        /// </summary>
        [DataMember(Name = "UoM", IsRequired = false, Order = 8)]
        public string UoM
        {
            get { return m_uoM;  }
            set { m_uoM = value; }
        }

        /// <summary>
        /// Any associated properties, or empty if there are no properties defined.
        /// </summary>
        [DataMember(Name = "Properties", IsRequired = false, Order = 9)]
        public ISA95PropertyDataTypeCollection Properties
        {
            get
            {
                return m_properties;
            }

            set
            {
                m_properties = value;

                if (value == null)
                {
                    m_properties = new ISA95PropertyDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ISA95MaterialDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ISA95MaterialDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ISA95MaterialDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("MaterialClassID", MaterialClassID);
            encoder.WriteString("MaterialDefinitionID", MaterialDefinitionID);
            encoder.WriteString("MaterialLotID", MaterialLotID);
            encoder.WriteString("MaterialSublotID", MaterialSublotID);
            encoder.WriteString("Description", Description);
            encoder.WriteString("MaterialUse", MaterialUse);
            encoder.WriteString("Quantity", Quantity);
            encoder.WriteString("UoM", UoM);
            encoder.WriteEncodeableArray("Properties", Properties.ToArray(), typeof(ISA95PropertyDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            MaterialClassID = decoder.ReadString("MaterialClassID");
            MaterialDefinitionID = decoder.ReadString("MaterialDefinitionID");
            MaterialLotID = decoder.ReadString("MaterialLotID");
            MaterialSublotID = decoder.ReadString("MaterialSublotID");
            Description = decoder.ReadString("Description");
            MaterialUse = decoder.ReadString("MaterialUse");
            Quantity = decoder.ReadString("Quantity");
            UoM = decoder.ReadString("UoM");
            Properties = (ISA95PropertyDataTypeCollection)decoder.ReadEncodeableArray("Properties", typeof(ISA95PropertyDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ISA95MaterialDataType value = encodeable as ISA95MaterialDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_materialClassID, value.m_materialClassID)) return false;
            if (!Utils.IsEqual(m_materialDefinitionID, value.m_materialDefinitionID)) return false;
            if (!Utils.IsEqual(m_materialLotID, value.m_materialLotID)) return false;
            if (!Utils.IsEqual(m_materialSublotID, value.m_materialSublotID)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_materialUse, value.m_materialUse)) return false;
            if (!Utils.IsEqual(m_quantity, value.m_quantity)) return false;
            if (!Utils.IsEqual(m_uoM, value.m_uoM)) return false;
            if (!Utils.IsEqual(m_properties, value.m_properties)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ISA95MaterialDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95MaterialDataType clone = (ISA95MaterialDataType)base.MemberwiseClone();

            clone.m_materialClassID = (string)Utils.Clone(this.m_materialClassID);
            clone.m_materialDefinitionID = (string)Utils.Clone(this.m_materialDefinitionID);
            clone.m_materialLotID = (string)Utils.Clone(this.m_materialLotID);
            clone.m_materialSublotID = (string)Utils.Clone(this.m_materialSublotID);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_materialUse = (string)Utils.Clone(this.m_materialUse);
            clone.m_quantity = (string)Utils.Clone(this.m_quantity);
            clone.m_uoM = (string)Utils.Clone(this.m_uoM);
            clone.m_properties = (ISA95PropertyDataTypeCollection)Utils.Clone(this.m_properties);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_materialClassID;
        private string m_materialDefinitionID;
        private string m_materialLotID;
        private string m_materialSublotID;
        private string m_description;
        private string m_materialUse;
        private string m_quantity;
        private string m_uoM;
        private ISA95PropertyDataTypeCollection m_properties;
        #endregion
    }

    #region ISA95MaterialDataTypeCollection Class
    /// <summary>
    /// A collection of ISA95MaterialDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95MaterialDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95MaterialDataType")]
    #if !NET_STANDARD
    public partial class ISA95MaterialDataTypeCollection : List<ISA95MaterialDataType>, ICloneable
    #else
    public partial class ISA95MaterialDataTypeCollection : List<ISA95MaterialDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95MaterialDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95MaterialDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95MaterialDataTypeCollection(IEnumerable<ISA95MaterialDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95MaterialDataTypeCollection(ISA95MaterialDataType[] values)
        {
            if (values != null)
            {
                return new ISA95MaterialDataTypeCollection(values);
            }

            return new ISA95MaterialDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95MaterialDataType[](ISA95MaterialDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95MaterialDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95MaterialDataTypeCollection clone = new ISA95MaterialDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95MaterialDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95ParameterDataType Class
    #if (!OPCUA_EXCLUDE_ISA95ParameterDataType)
    /// <summary>
    /// A subtype of OPC UA Structure that defines three linked data items: the ID, which is a unique identifier for a property, the value, which is the data that is identified, and an optional description of the parameter.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class ISA95ParameterDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ISA95ParameterDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_ıD = null;
            m_value = Variant.Null;
            m_description = null;
            m_uoM = null;
            m_subparameters = new ISA95ParameterDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A unique identifier for a parameter
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// Value of the parameter.
        /// </summary>
        [DataMember(Name = "Value", IsRequired = false, Order = 2)]
        public Variant Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }

        /// <summary>
        /// An optional description of the parameter.
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 3)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// The Unit Of Measure of the value
        /// </summary>
        [DataMember(Name = "UoM", IsRequired = false, Order = 4)]
        public string UoM
        {
            get { return m_uoM;  }
            set { m_uoM = value; }
        }

        /// <summary>
        /// A description for the Subparameters field.
        /// </summary>
        [DataMember(Name = "Subparameters", IsRequired = false, Order = 5)]
        public ISA95ParameterDataTypeCollection Subparameters
        {
            get
            {
                return m_subparameters;
            }

            set
            {
                m_subparameters = value;

                if (value == null)
                {
                    m_subparameters = new ISA95ParameterDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ISA95ParameterDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ISA95ParameterDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ISA95ParameterDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteVariant("Value", Value);
            encoder.WriteString("Description", Description);
            encoder.WriteString("UoM", UoM);
            encoder.WriteEncodeableArray("Subparameters", Subparameters.ToArray(), typeof(ISA95ParameterDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            Value = decoder.ReadVariant("Value");
            Description = decoder.ReadString("Description");
            UoM = decoder.ReadString("UoM");
            Subparameters = (ISA95ParameterDataTypeCollection)decoder.ReadEncodeableArray("Subparameters", typeof(ISA95ParameterDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ISA95ParameterDataType value = encodeable as ISA95ParameterDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_value, value.m_value)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_uoM, value.m_uoM)) return false;
            if (!Utils.IsEqual(m_subparameters, value.m_subparameters)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ISA95ParameterDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95ParameterDataType clone = (ISA95ParameterDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_value = (Variant)Utils.Clone(this.m_value);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_uoM = (string)Utils.Clone(this.m_uoM);
            clone.m_subparameters = (ISA95ParameterDataTypeCollection)Utils.Clone(this.m_subparameters);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private Variant m_value;
        private string m_description;
        private string m_uoM;
        private ISA95ParameterDataTypeCollection m_subparameters;
        #endregion
    }

    #region ISA95ParameterDataTypeCollection Class
    /// <summary>
    /// A collection of ISA95ParameterDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95ParameterDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95ParameterDataType")]
    #if !NET_STANDARD
    public partial class ISA95ParameterDataTypeCollection : List<ISA95ParameterDataType>, ICloneable
    #else
    public partial class ISA95ParameterDataTypeCollection : List<ISA95ParameterDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95ParameterDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95ParameterDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95ParameterDataTypeCollection(IEnumerable<ISA95ParameterDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95ParameterDataTypeCollection(ISA95ParameterDataType[] values)
        {
            if (values != null)
            {
                return new ISA95ParameterDataTypeCollection(values);
            }

            return new ISA95ParameterDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95ParameterDataType[](ISA95ParameterDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95ParameterDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95ParameterDataTypeCollection clone = new ISA95ParameterDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95ParameterDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95PersonnelDataType Class
    #if (!OPCUA_EXCLUDE_ISA95PersonnelDataType)
    /// <summary>
    /// defines a personnel resource or a person, a quantity, an optional description, and an optional collection of properties.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class ISA95PersonnelDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ISA95PersonnelDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_ıD = null;
            m_description = null;
            m_personnelUse = null;
            m_quantity = null;
            m_uoM = null;
            m_properties = new ISA95PropertyDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// An identification of a Personnel Class or Person. 
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// Additional information and description about the resource.
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 2)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// Information about the expected use of the personnel, see the ISA 95 Part 2 standard for defined values. 
        /// </summary>
        [DataMember(Name = "PersonnelUse", IsRequired = false, Order = 3)]
        public string PersonnelUse
        {
            get { return m_personnelUse;  }
            set { m_personnelUse = value; }
        }

        /// <summary>
        /// The quantity of the resource
        /// </summary>
        [DataMember(Name = "Quantity", IsRequired = false, Order = 4)]
        public string Quantity
        {
            get { return m_quantity;  }
            set { m_quantity = value; }
        }

        /// <summary>
        /// The Unit Of Measure of the quantity
        /// </summary>
        [DataMember(Name = "UoM", IsRequired = false, Order = 5)]
        public string UoM
        {
            get { return m_uoM;  }
            set { m_uoM = value; }
        }

        /// <summary>
        /// Any associated properties, or empty if there are no properties defined. 
        /// </summary>
        [DataMember(Name = "Properties", IsRequired = false, Order = 6)]
        public ISA95PropertyDataTypeCollection Properties
        {
            get
            {
                return m_properties;
            }

            set
            {
                m_properties = value;

                if (value == null)
                {
                    m_properties = new ISA95PropertyDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ISA95PersonnelDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ISA95PersonnelDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ISA95PersonnelDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteString("Description", Description);
            encoder.WriteString("PersonnelUse", PersonnelUse);
            encoder.WriteString("Quantity", Quantity);
            encoder.WriteString("UoM", UoM);
            encoder.WriteEncodeableArray("Properties", Properties.ToArray(), typeof(ISA95PropertyDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            Description = decoder.ReadString("Description");
            PersonnelUse = decoder.ReadString("PersonnelUse");
            Quantity = decoder.ReadString("Quantity");
            UoM = decoder.ReadString("UoM");
            Properties = (ISA95PropertyDataTypeCollection)decoder.ReadEncodeableArray("Properties", typeof(ISA95PropertyDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ISA95PersonnelDataType value = encodeable as ISA95PersonnelDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_personnelUse, value.m_personnelUse)) return false;
            if (!Utils.IsEqual(m_quantity, value.m_quantity)) return false;
            if (!Utils.IsEqual(m_uoM, value.m_uoM)) return false;
            if (!Utils.IsEqual(m_properties, value.m_properties)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ISA95PersonnelDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95PersonnelDataType clone = (ISA95PersonnelDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_personnelUse = (string)Utils.Clone(this.m_personnelUse);
            clone.m_quantity = (string)Utils.Clone(this.m_quantity);
            clone.m_uoM = (string)Utils.Clone(this.m_uoM);
            clone.m_properties = (ISA95PropertyDataTypeCollection)Utils.Clone(this.m_properties);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private string m_description;
        private string m_personnelUse;
        private string m_quantity;
        private string m_uoM;
        private ISA95PropertyDataTypeCollection m_properties;
        #endregion
    }

    #region ISA95PersonnelDataTypeCollection Class
    /// <summary>
    /// A collection of ISA95PersonnelDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95PersonnelDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95PersonnelDataType")]
    #if !NET_STANDARD
    public partial class ISA95PersonnelDataTypeCollection : List<ISA95PersonnelDataType>, ICloneable
    #else
    public partial class ISA95PersonnelDataTypeCollection : List<ISA95PersonnelDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95PersonnelDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95PersonnelDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95PersonnelDataTypeCollection(IEnumerable<ISA95PersonnelDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95PersonnelDataTypeCollection(ISA95PersonnelDataType[] values)
        {
            if (values != null)
            {
                return new ISA95PersonnelDataTypeCollection(values);
            }

            return new ISA95PersonnelDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95PersonnelDataType[](ISA95PersonnelDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95PersonnelDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95PersonnelDataTypeCollection clone = new ISA95PersonnelDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95PersonnelDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95PhysicalAssetDataType Class
    #if (!OPCUA_EXCLUDE_ISA95PhysicalAssetDataType)
    /// <summary>
    /// defines a physical asset, a quantity, an optional description, and an optional collection of properties.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class ISA95PhysicalAssetDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ISA95PhysicalAssetDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_ıD = null;
            m_description = null;
            m_physicalAssetUse = null;
            m_quantity = null;
            m_uoM = null;
            m_properties = new ISA95PropertyDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// An identification of a Physical Asset Class or Physical Asset. 
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// Additional information and description about the resource.
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 2)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// Information about the expected use of the physical asset, see the ISA 95 Part 2 standard for defined values. 
        /// </summary>
        [DataMember(Name = "PhysicalAssetUse", IsRequired = false, Order = 3)]
        public string PhysicalAssetUse
        {
            get { return m_physicalAssetUse;  }
            set { m_physicalAssetUse = value; }
        }

        /// <summary>
        /// The quantity of the resource
        /// </summary>
        [DataMember(Name = "Quantity", IsRequired = false, Order = 4)]
        public string Quantity
        {
            get { return m_quantity;  }
            set { m_quantity = value; }
        }

        /// <summary>
        /// The Unit Of Measure of the quantity
        /// </summary>
        [DataMember(Name = "UoM", IsRequired = false, Order = 5)]
        public string UoM
        {
            get { return m_uoM;  }
            set { m_uoM = value; }
        }

        /// <summary>
        /// Any associated properties, or empty if there are no properties defined. 
        /// </summary>
        [DataMember(Name = "Properties", IsRequired = false, Order = 6)]
        public ISA95PropertyDataTypeCollection Properties
        {
            get
            {
                return m_properties;
            }

            set
            {
                m_properties = value;

                if (value == null)
                {
                    m_properties = new ISA95PropertyDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ISA95PhysicalAssetDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ISA95PhysicalAssetDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ISA95PhysicalAssetDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteString("Description", Description);
            encoder.WriteString("PhysicalAssetUse", PhysicalAssetUse);
            encoder.WriteString("Quantity", Quantity);
            encoder.WriteString("UoM", UoM);
            encoder.WriteEncodeableArray("Properties", Properties.ToArray(), typeof(ISA95PropertyDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            Description = decoder.ReadString("Description");
            PhysicalAssetUse = decoder.ReadString("PhysicalAssetUse");
            Quantity = decoder.ReadString("Quantity");
            UoM = decoder.ReadString("UoM");
            Properties = (ISA95PropertyDataTypeCollection)decoder.ReadEncodeableArray("Properties", typeof(ISA95PropertyDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ISA95PhysicalAssetDataType value = encodeable as ISA95PhysicalAssetDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_physicalAssetUse, value.m_physicalAssetUse)) return false;
            if (!Utils.IsEqual(m_quantity, value.m_quantity)) return false;
            if (!Utils.IsEqual(m_uoM, value.m_uoM)) return false;
            if (!Utils.IsEqual(m_properties, value.m_properties)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ISA95PhysicalAssetDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95PhysicalAssetDataType clone = (ISA95PhysicalAssetDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_physicalAssetUse = (string)Utils.Clone(this.m_physicalAssetUse);
            clone.m_quantity = (string)Utils.Clone(this.m_quantity);
            clone.m_uoM = (string)Utils.Clone(this.m_uoM);
            clone.m_properties = (ISA95PropertyDataTypeCollection)Utils.Clone(this.m_properties);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private string m_description;
        private string m_physicalAssetUse;
        private string m_quantity;
        private string m_uoM;
        private ISA95PropertyDataTypeCollection m_properties;
        #endregion
    }

    #region ISA95PhysicalAssetDataTypeCollection Class
    /// <summary>
    /// A collection of ISA95PhysicalAssetDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95PhysicalAssetDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95PhysicalAssetDataType")]
    #if !NET_STANDARD
    public partial class ISA95PhysicalAssetDataTypeCollection : List<ISA95PhysicalAssetDataType>, ICloneable
    #else
    public partial class ISA95PhysicalAssetDataTypeCollection : List<ISA95PhysicalAssetDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95PhysicalAssetDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95PhysicalAssetDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95PhysicalAssetDataTypeCollection(IEnumerable<ISA95PhysicalAssetDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95PhysicalAssetDataTypeCollection(ISA95PhysicalAssetDataType[] values)
        {
            if (values != null)
            {
                return new ISA95PhysicalAssetDataTypeCollection(values);
            }

            return new ISA95PhysicalAssetDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95PhysicalAssetDataType[](ISA95PhysicalAssetDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95PhysicalAssetDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95PhysicalAssetDataTypeCollection clone = new ISA95PhysicalAssetDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95PhysicalAssetDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95PropertyDataType Class
    #if (!OPCUA_EXCLUDE_ISA95PropertyDataType)
    /// <summary>
    /// A subtype of OPC UA Structure that defines two linked data items: an ID, which is a unique identifier for a property within the scope of the associated resource, and the value, which is the data for the property.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class ISA95PropertyDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ISA95PropertyDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_ıD = null;
            m_value = Variant.Null;
            m_description = null;
            m_uoM = null;
            m_subproperties = new ISA95PropertyDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Unique identifier for a property within the scope of the associated resource
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// Value for the property
        /// </summary>
        [DataMember(Name = "Value", IsRequired = false, Order = 2)]
        public Variant Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }

        /// <summary>
        /// An optional description of the parameter.
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 3)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// The Unit Of Measure of the value
        /// </summary>
        [DataMember(Name = "UoM", IsRequired = false, Order = 4)]
        public string UoM
        {
            get { return m_uoM;  }
            set { m_uoM = value; }
        }

        /// <summary>
        /// A description for the Subproperties field.
        /// </summary>
        [DataMember(Name = "Subproperties", IsRequired = false, Order = 5)]
        public ISA95PropertyDataTypeCollection Subproperties
        {
            get
            {
                return m_subproperties;
            }

            set
            {
                m_subproperties = value;

                if (value == null)
                {
                    m_subproperties = new ISA95PropertyDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ISA95PropertyDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ISA95PropertyDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ISA95PropertyDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteVariant("Value", Value);
            encoder.WriteString("Description", Description);
            encoder.WriteString("UoM", UoM);
            encoder.WriteEncodeableArray("Subproperties", Subproperties.ToArray(), typeof(ISA95PropertyDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            Value = decoder.ReadVariant("Value");
            Description = decoder.ReadString("Description");
            UoM = decoder.ReadString("UoM");
            Subproperties = (ISA95PropertyDataTypeCollection)decoder.ReadEncodeableArray("Subproperties", typeof(ISA95PropertyDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ISA95PropertyDataType value = encodeable as ISA95PropertyDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_value, value.m_value)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_uoM, value.m_uoM)) return false;
            if (!Utils.IsEqual(m_subproperties, value.m_subproperties)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ISA95PropertyDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95PropertyDataType clone = (ISA95PropertyDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_value = (Variant)Utils.Clone(this.m_value);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_uoM = (string)Utils.Clone(this.m_uoM);
            clone.m_subproperties = (ISA95PropertyDataTypeCollection)Utils.Clone(this.m_subproperties);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private Variant m_value;
        private string m_description;
        private string m_uoM;
        private ISA95PropertyDataTypeCollection m_subproperties;
        #endregion
    }

    #region ISA95PropertyDataTypeCollection Class
    /// <summary>
    /// A collection of ISA95PropertyDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95PropertyDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95PropertyDataType")]
    #if !NET_STANDARD
    public partial class ISA95PropertyDataTypeCollection : List<ISA95PropertyDataType>, ICloneable
    #else
    public partial class ISA95PropertyDataTypeCollection : List<ISA95PropertyDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95PropertyDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95PropertyDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95PropertyDataTypeCollection(IEnumerable<ISA95PropertyDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95PropertyDataTypeCollection(ISA95PropertyDataType[] values)
        {
            if (values != null)
            {
                return new ISA95PropertyDataTypeCollection(values);
            }

            return new ISA95PropertyDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95PropertyDataType[](ISA95PropertyDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95PropertyDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95PropertyDataTypeCollection clone = new ISA95PropertyDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95PropertyDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95WorkMasterDataType Class
    #if (!OPCUA_EXCLUDE_ISA95WorkMasterDataType)
    /// <summary>
    /// Defines a Work Master ID and the defined parameters for the Work Master.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class ISA95WorkMasterDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public ISA95WorkMasterDataType()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_ıD = null;
            m_description = null;
            m_parameters = new ISA95ParameterDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// An identification of the Work Master. 
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// Additional information and description about the Work Master.
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 2)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// Defined parameters for the Work Master.
        /// </summary>
        [DataMember(Name = "Parameters", IsRequired = false, Order = 3)]
        public ISA95ParameterDataTypeCollection Parameters
        {
            get
            {
                return m_parameters;
            }

            set
            {
                m_parameters = value;

                if (value == null)
                {
                    m_parameters = new ISA95ParameterDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ISA95WorkMasterDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ISA95WorkMasterDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ISA95WorkMasterDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteString("Description", Description);
            encoder.WriteEncodeableArray("Parameters", Parameters.ToArray(), typeof(ISA95ParameterDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            Description = decoder.ReadString("Description");
            Parameters = (ISA95ParameterDataTypeCollection)decoder.ReadEncodeableArray("Parameters", typeof(ISA95ParameterDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ISA95WorkMasterDataType value = encodeable as ISA95WorkMasterDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_parameters, value.m_parameters)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (ISA95WorkMasterDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95WorkMasterDataType clone = (ISA95WorkMasterDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_parameters = (ISA95ParameterDataTypeCollection)Utils.Clone(this.m_parameters);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private string m_description;
        private ISA95ParameterDataTypeCollection m_parameters;
        #endregion
    }

    #region ISA95WorkMasterDataTypeCollection Class
    /// <summary>
    /// A collection of ISA95WorkMasterDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfISA95WorkMasterDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "ISA95WorkMasterDataType")]
    #if !NET_STANDARD
    public partial class ISA95WorkMasterDataTypeCollection : List<ISA95WorkMasterDataType>, ICloneable
    #else
    public partial class ISA95WorkMasterDataTypeCollection : List<ISA95WorkMasterDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ISA95WorkMasterDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ISA95WorkMasterDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ISA95WorkMasterDataTypeCollection(IEnumerable<ISA95WorkMasterDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ISA95WorkMasterDataTypeCollection(ISA95WorkMasterDataType[] values)
        {
            if (values != null)
            {
                return new ISA95WorkMasterDataTypeCollection(values);
            }

            return new ISA95WorkMasterDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ISA95WorkMasterDataType[](ISA95WorkMasterDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ISA95WorkMasterDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ISA95WorkMasterDataTypeCollection clone = new ISA95WorkMasterDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ISA95WorkMasterDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ISA95JobOrderReceiverObjectState Class
    #if (!OPCUA_EXCLUDE_ISA95JobOrderReceiverObjectState)
    /// <summary>
    /// Stores an instance of the ISA95JobOrderReceiverObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ISA95JobOrderReceiverObjectState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ISA95JobOrderReceiverObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.ISA95JobOrderReceiverObjectType, Prefix2.Namespaces.Name2, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACwAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvSVNBOTUtSk9CQ09OVFJPTP////8EYIAA" +
           "AQAAAAEAJwAAAElTQTk1Sm9iT3JkZXJSZWNlaXZlck9iamVjdFR5cGVJbnN0YW5jZQEBEwABARMA////" +
           "/wgAAAA3YIkKAgAAAAEACwAAAEVxdWlwbWVudElEAQEUAAMAAAAAZgAAAERlZmluZXMgYSByZWFkLW9u" +
           "bHkgc2V0IG9mIEVxdWlwbWVudCBDbGFzcyBJRHMgYW5kIEVxdWlwbWVudCBJRHMgdGhhdCBtYXkgYmUg" +
           "c3BlY2lmaWVkIGluIGEgam9iIG9yZGVyLgAvAD8UAAAAAAwBAAAAAQAAAAAAAAADA/////8AAAAAN2CJ" +
           "CgIAAAABAAwAAABKb2JPcmRlckxpc3QBARUAAwAAAABMAAAARGVmaW5lcyBhIHJlYWQtb25seSBsaXN0" +
           "IG9mIGpvYiBvcmRlciBpbmZvcm1hdGlvbiBhdmFpbGFibGUgZnJvbSB0aGUgc2VydmVyLgAvAD8VAAAA" +
           "AQELAAEAAAABAAAAAAAAAAMD/////wAAAAA3YIkKAgAAAAEADwAAAE1hdGVyaWFsQ2xhc3NJRAEBFgAD" +
           "AAAAAFUAAABEZWZpbmVzIGEgcmVhZC1vbmx5IHNldCBvZiBNYXRlcmlhbCBDbGFzc2VzIElEcyB0aGF0" +
           "IG1heSBiZSBzcGVjaWZpZWQgaW4gYSBqb2Igb3JkZXIuAC8APxYAAAAADAEAAAABAAAAAAAAAAMD////" +
           "/wAAAAA3YIkKAgAAAAEAFAAAAE1hdGVyaWFsRGVmaW5pdGlvbklEAQEXAAMAAAAAVQAAAERlZmluZXMg" +
           "YSByZWFkLW9ubHkgc2V0IG9mIE1hdGVyaWFsIENsYXNzZXMgSURzIHRoYXQgbWF5IGJlIHNwZWNpZmll" +
           "ZCBpbiBhIGpvYiBvcmRlci4ALwA/FwAAAAAMAQAAAAEAAAAAAAAAAwP/////AAAAADdgiQoCAAAAAQAL" +
           "AAAAUGVyc29ubmVsSUQBARgAAwAAAABdAAAARGVmaW5lcyBhIHJlYWQtb25seSBzZXQgb2YgUGVyc29u" +
           "bmVsIElEcyBhbmQgUGVyc29uIElEcyB0aGF0IG1heSBiZSBzcGVjaWZpZWQgaW4gYSBqb2Igb3JkZXIu" +
           "AC8APxgAAAAADAEAAAABAAAAAAAAAAMD/////wAAAAA3YIkKAgAAAAEADwAAAFBoeXNpY2FsQXNzZXRJ" +
           "RAEBGQADAAAAAHAAAABEZWZpbmVzIGEgcmVhZC1vbmx5IHNldCBvZiBQaHlzaWNhbCBBc3NldCBDbGFz" +
           "cyBJRHMgYW5kIFBoeXNpY2FsIEFzc2V0IElEcyB0aGF0IG1heSBiZSBzcGVjaWZpZWQgaW4gYSBqb2Ig" +
           "b3JkZXIuAC8APxkAAAAADAEAAAABAAAAAAAAAAMD/////wAAAAAkYYIKBAAAAAEADwAAAFJlY2VpdmVK" +
           "b2JPcmRlcgEBGgADAAAAAEkAAABEZWZpbmVzIGEgbWV0aG9kIG9mIHR5cGUgd2hpY2ggcmVjZWl2ZXMg" +
           "am9iIG9yZGVycyBhbmQgam9iIG9yZGVyIGNvbW1hbmRzAC8BARoAGgAAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQEbAAAuAEQbAAAAlgAAAAABACgBAQAAAAEAAAACAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEcAAAuAEQcAAAAlgAAAAABACgBAQAAAAEA" +
           "AAABAAAAAQH/////AAAAADdgiQoCAAAAAQAKAAAAV29ya01hc3RlcgEBHQADAAAAAKYAAABEZWZpbmVz" +
           "IGEgcmVhZC1vbmx5IHNldCBvZiB3b3JrIG1hc3RlciBJRHMgdGhhdCBtYXkgYmUgc3BlY2lmaWVkIGlu" +
           "IGEgam9iIG9yZGVyLCBhbmQgdGhlIHJlYWQtb25seSBzZXQgb2YgcGFyYW1ldGVycyB0aGF0IG1heSBi" +
           "ZSBzcGVjaWZpZWQgZm9yIGEgc3BlY2lmaWMgd29yayBtYXN0ZXIuAC8APx0AAAABARIAAQAAAAEAAAAA" +
           "AAAAAwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Defines a read-only set of Equipment Class IDs and Equipment IDs that may be specified in a job order.
        /// </summary>
        public BaseDataVariableState<string[]> EquipmentID
        {
            get
            {
                return m_equipmentID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_equipmentID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_equipmentID = value;
            }
        }

        /// <summary>
        /// Defines a read-only list of job order information available from the server.
        /// </summary>
        public BaseDataVariableState<ISA95JobOrderDataType[]> JobOrderList
        {
            get
            {
                return m_jobOrderList;
            }

            set
            {
                if (!Object.ReferenceEquals(m_jobOrderList, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_jobOrderList = value;
            }
        }

        /// <summary>
        /// Defines a read-only set of Material Classes IDs that may be specified in a job order.
        /// </summary>
        public BaseDataVariableState<string[]> MaterialClassID
        {
            get
            {
                return m_materialClassID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_materialClassID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_materialClassID = value;
            }
        }

        /// <summary>
        /// Defines a read-only set of Material Classes IDs that may be specified in a job order.
        /// </summary>
        public BaseDataVariableState<string[]> MaterialDefinitionID
        {
            get
            {
                return m_materialDefinitionID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_materialDefinitionID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_materialDefinitionID = value;
            }
        }

        /// <summary>
        /// Defines a read-only set of Personnel IDs and Person IDs that may be specified in a job order.
        /// </summary>
        public BaseDataVariableState<string[]> PersonnelID
        {
            get
            {
                return m_personnelID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_personnelID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_personnelID = value;
            }
        }

        /// <summary>
        /// Defines a read-only set of Physical Asset Class IDs and Physical Asset IDs that may be specified in a job order.
        /// </summary>
        public BaseDataVariableState<string[]> PhysicalAssetID
        {
            get
            {
                return m_physicalAssetID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_physicalAssetID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_physicalAssetID = value;
            }
        }

        /// <summary>
        /// Defines a method of type which receives job orders and job order commands
        /// </summary>
        public MethodState ReceiveJobOrder
        {
            get
            {
                return m_receiveJobOrderMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_receiveJobOrderMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_receiveJobOrderMethod = value;
            }
        }

        /// <summary>
        /// Defines a read-only set of work master IDs that may be specified in a job order, and the read-only set of parameters that may be specified for a specific work master.
        /// </summary>
        public BaseDataVariableState<ISA95WorkMasterDataType[]> WorkMaster
        {
            get
            {
                return m_workMaster;
            }

            set
            {
                if (!Object.ReferenceEquals(m_workMaster, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_workMaster = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_equipmentID != null)
            {
                children.Add(m_equipmentID);
            }

            if (m_jobOrderList != null)
            {
                children.Add(m_jobOrderList);
            }

            if (m_materialClassID != null)
            {
                children.Add(m_materialClassID);
            }

            if (m_materialDefinitionID != null)
            {
                children.Add(m_materialDefinitionID);
            }

            if (m_personnelID != null)
            {
                children.Add(m_personnelID);
            }

            if (m_physicalAssetID != null)
            {
                children.Add(m_physicalAssetID);
            }

            if (m_receiveJobOrderMethod != null)
            {
                children.Add(m_receiveJobOrderMethod);
            }

            if (m_workMaster != null)
            {
                children.Add(m_workMaster);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Prefix2.BrowseNames.EquipmentID:
                {
                    if (createOrReplace)
                    {
                        if (EquipmentID == null)
                        {
                            if (replacement == null)
                            {
                                EquipmentID = new BaseDataVariableState<string[]>(this);
                            }
                            else
                            {
                                EquipmentID = (BaseDataVariableState<string[]>)replacement;
                            }
                        }
                    }

                    instance = EquipmentID;
                    break;
                }

                case Prefix2.BrowseNames.JobOrderList:
                {
                    if (createOrReplace)
                    {
                        if (JobOrderList == null)
                        {
                            if (replacement == null)
                            {
                                JobOrderList = new BaseDataVariableState<ISA95JobOrderDataType[]>(this);
                            }
                            else
                            {
                                JobOrderList = (BaseDataVariableState<ISA95JobOrderDataType[]>)replacement;
                            }
                        }
                    }

                    instance = JobOrderList;
                    break;
                }

                case Prefix2.BrowseNames.MaterialClassID:
                {
                    if (createOrReplace)
                    {
                        if (MaterialClassID == null)
                        {
                            if (replacement == null)
                            {
                                MaterialClassID = new BaseDataVariableState<string[]>(this);
                            }
                            else
                            {
                                MaterialClassID = (BaseDataVariableState<string[]>)replacement;
                            }
                        }
                    }

                    instance = MaterialClassID;
                    break;
                }

                case Prefix2.BrowseNames.MaterialDefinitionID:
                {
                    if (createOrReplace)
                    {
                        if (MaterialDefinitionID == null)
                        {
                            if (replacement == null)
                            {
                                MaterialDefinitionID = new BaseDataVariableState<string[]>(this);
                            }
                            else
                            {
                                MaterialDefinitionID = (BaseDataVariableState<string[]>)replacement;
                            }
                        }
                    }

                    instance = MaterialDefinitionID;
                    break;
                }

                case Prefix2.BrowseNames.PersonnelID:
                {
                    if (createOrReplace)
                    {
                        if (PersonnelID == null)
                        {
                            if (replacement == null)
                            {
                                PersonnelID = new BaseDataVariableState<string[]>(this);
                            }
                            else
                            {
                                PersonnelID = (BaseDataVariableState<string[]>)replacement;
                            }
                        }
                    }

                    instance = PersonnelID;
                    break;
                }

                case Prefix2.BrowseNames.PhysicalAssetID:
                {
                    if (createOrReplace)
                    {
                        if (PhysicalAssetID == null)
                        {
                            if (replacement == null)
                            {
                                PhysicalAssetID = new BaseDataVariableState<string[]>(this);
                            }
                            else
                            {
                                PhysicalAssetID = (BaseDataVariableState<string[]>)replacement;
                            }
                        }
                    }

                    instance = PhysicalAssetID;
                    break;
                }

                case Prefix2.BrowseNames.ReceiveJobOrder:
                {
                    if (createOrReplace)
                    {
                        if (ReceiveJobOrder == null)
                        {
                            if (replacement == null)
                            {
                                ReceiveJobOrder = new MethodState(this);
                            }
                            else
                            {
                                ReceiveJobOrder = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ReceiveJobOrder;
                    break;
                }

                case Prefix2.BrowseNames.WorkMaster:
                {
                    if (createOrReplace)
                    {
                        if (WorkMaster == null)
                        {
                            if (replacement == null)
                            {
                                WorkMaster = new BaseDataVariableState<ISA95WorkMasterDataType[]>(this);
                            }
                            else
                            {
                                WorkMaster = (BaseDataVariableState<ISA95WorkMasterDataType[]>)replacement;
                            }
                        }
                    }

                    instance = WorkMaster;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string[]> m_equipmentID;
        private BaseDataVariableState<ISA95JobOrderDataType[]> m_jobOrderList;
        private BaseDataVariableState<string[]> m_materialClassID;
        private BaseDataVariableState<string[]> m_materialDefinitionID;
        private BaseDataVariableState<string[]> m_personnelID;
        private BaseDataVariableState<string[]> m_physicalAssetID;
        private MethodState m_receiveJobOrderMethod;
        private BaseDataVariableState<ISA95WorkMasterDataType[]> m_workMaster;
        #endregion
    }
    #endif
    #endregion

    #region ISA95JobResponseProviderObjectState Class
    #if (!OPCUA_EXCLUDE_ISA95JobResponseProviderObjectState)
    /// <summary>
    /// Stores an instance of the ISA95JobResponseProviderObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ISA95JobResponseProviderObjectState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ISA95JobResponseProviderObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.ISA95JobResponseProviderObjectType, Prefix2.Namespaces.Name2, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACwAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvSVNBOTUtSk9CQ09OVFJPTP////8EYIAA" +
           "AQAAAAEAKgAAAElTQTk1Sm9iUmVzcG9uc2VQcm92aWRlck9iamVjdFR5cGVJbnN0YW5jZQEBHgABAR4A" +
           "/////wEAAAAkYYIKBAAAAAEAEgAAAFJlcXVlc3RKb2JSZXNwb25zZQEBHwADAAAAAGUAAABUaGlzIG1l" +
           "dGhvZCBpcyB1c2VkIHRvIHJldHVybiBKb2IgUmVzcG9uc2VzIGZyb20gdW5zb2xpY2l0ZWQgcmVxdWVz" +
           "dHMgZm9yIHJlc3BvbnNlcyBmcm9tIGEgam9iIG9yZGVyLgAvAQEfAB8AAAABAf////8CAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBIAAALgBEIAAAAJYAAAAAAQAoAQEAAAABAAAAAgAAAAEB////" +
           "/wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBIQAALgBEIQAAAJYAAAAAAQAoAQEAAAAB" +
           "AAAAAgAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// This method is used to return Job Responses from unsolicited requests for responses from a job order.
        /// </summary>
        public MethodState RequestJobResponse
        {
            get
            {
                return m_requestJobResponseMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_requestJobResponseMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_requestJobResponseMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_requestJobResponseMethod != null)
            {
                children.Add(m_requestJobResponseMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Prefix2.BrowseNames.RequestJobResponse:
                {
                    if (createOrReplace)
                    {
                        if (RequestJobResponse == null)
                        {
                            if (replacement == null)
                            {
                                RequestJobResponse = new MethodState(this);
                            }
                            else
                            {
                                RequestJobResponse = (MethodState)replacement;
                            }
                        }
                    }

                    instance = RequestJobResponse;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MethodState m_requestJobResponseMethod;
        #endregion
    }
    #endif
    #endregion

    #region ISA95JobResponseReceiverObjectState Class
    #if (!OPCUA_EXCLUDE_ISA95JobResponseReceiverObjectState)
    /// <summary>
    /// Stores an instance of the ISA95JobResponseReceiverObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ISA95JobResponseReceiverObjectState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ISA95JobResponseReceiverObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.ISA95JobResponseReceiverObjectType, Prefix2.Namespaces.Name2, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACwAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvSVNBOTUtSk9CQ09OVFJPTP////8EYIAA" +
           "AQAAAAEAKgAAAElTQTk1Sm9iUmVzcG9uc2VSZWNlaXZlck9iamVjdFR5cGVJbnN0YW5jZQEBIgABASIA" +
           "/////wEAAAAkYYIKBAAAAAEAEgAAAFJlY2VpdmVKb2JSZXNwb25zZQEBIwADAAAAAF8AAABEZWZpbmVz" +
           "IGEgbWV0aG9kIG9mIHR5cGUgUmVjZWl2ZUpvYlJlc3BvbnNlTWV0aG9kVHlwZSB3aGljaCByZWNlaXZl" +
           "cyB1bnNvbGljaXRlZCBKb2IgUmVzcG9uc2VzLgAvAQEjACMAAAABAf////8CAAAAF2CpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBJAAALgBEJAAAAJYAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBJQAALgBEJQAAAJYAAAAAAQAoAQEAAAABAAAAAQAA" +
           "AAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Defines a method of type ReceiveJobResponseMethodType which receives unsolicited Job Responses.
        /// </summary>
        public MethodState ReceiveJobResponse
        {
            get
            {
                return m_receiveJobResponseMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_receiveJobResponseMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_receiveJobResponseMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_receiveJobResponseMethod != null)
            {
                children.Add(m_receiveJobResponseMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Prefix2.BrowseNames.ReceiveJobResponse:
                {
                    if (createOrReplace)
                    {
                        if (ReceiveJobResponse == null)
                        {
                            if (replacement == null)
                            {
                                ReceiveJobResponse = new MethodState(this);
                            }
                            else
                            {
                                ReceiveJobResponse = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ReceiveJobResponse;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MethodState m_receiveJobResponseMethod;
        #endregion
    }
    #endif
    #endregion
}