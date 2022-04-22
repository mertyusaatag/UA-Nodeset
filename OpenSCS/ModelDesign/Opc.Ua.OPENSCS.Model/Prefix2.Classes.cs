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
        /// The identifier for the JobOrderCommandEnum DataType.
        /// </summary>
        public const uint JobOrderCommandEnum = 1;

        /// <summary>
        /// The identifier for the JobOrderStateEnum DataType.
        /// </summary>
        public const uint JobOrderStateEnum = 4;

        /// <summary>
        /// The identifier for the OPENSCSReturnEnum DataType.
        /// </summary>
        public const uint OPENSCSReturnEnum = 7;

        /// <summary>
        /// The identifier for the OPENSCSSerialNumberStateEnum DataType.
        /// </summary>
        public const uint OPENSCSSerialNumberStateEnum = 10;

        /// <summary>
        /// The identifier for the OPENSCSAggregationDataType DataType.
        /// </summary>
        public const uint OPENSCSAggregationDataType = 13;

        /// <summary>
        /// The identifier for the OPENSCSCollectionDataType DataType.
        /// </summary>
        public const uint OPENSCSCollectionDataType = 14;

        /// <summary>
        /// The identifier for the OPENSCSLabelCollectionDataType DataType.
        /// </summary>
        public const uint OPENSCSLabelCollectionDataType = 15;

        /// <summary>
        /// The identifier for the OPENSCSSNCollectionDataType DataType.
        /// </summary>
        public const uint OPENSCSSNCollectionDataType = 16;

        /// <summary>
        /// The identifier for the OPENSCSEventStreamArgumentDataType DataType.
        /// </summary>
        public const uint OPENSCSEventStreamArgumentDataType = 17;

        /// <summary>
        /// The identifier for the OPENSCSKeyValueDataType DataType.
        /// </summary>
        public const uint OPENSCSKeyValueDataType = 18;

        /// <summary>
        /// The identifier for the OPENSCSLabelDataType DataType.
        /// </summary>
        public const uint OPENSCSLabelDataType = 19;

        /// <summary>
        /// The identifier for the OPENSCSLabelPropertyDataType DataType.
        /// </summary>
        public const uint OPENSCSLabelPropertyDataType = 20;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassPropertyDataType DataType.
        /// </summary>
        public const uint OPENSCSSIDClassPropertyDataType = 21;
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
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationPackingEvent Method.
        /// </summary>
        public const uint OPENSCSAggregationManagerObjectType_AggregationPackingEvent = 23;

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent Method.
        /// </summary>
        public const uint OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent = 26;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead = 33;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite = 36;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit = 39;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsEncodingEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsEncodingEvent = 42;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsInspectingEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsInspectingEvent = 45;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsSamplingEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsSamplingEvent = 48;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsScrappingEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsScrappingEvent = 51;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDCommissioningEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDCommissioningEvent = 57;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDecommissioningEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDDecommissioningEvent = 60;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDestroyingEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDDestroyingEvent = 63;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDInspectingEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDInspectingEvent = 66;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDShippingEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDShippingEvent = 69;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SNInvalidatingEvent Method.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SNInvalidatingEvent = 72;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestAllocated Method.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNRequestAllocated = 81;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnallocated Method.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNRequestUnallocated = 84;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnassigned Method.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNRequestUnassigned = 87;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnAllocated Method.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNReturnAllocated = 90;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnUnallocated Method.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNReturnUnallocated = 93;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoAllocated Method.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNtoAllocated = 96;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoEncoded Method.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNtoEncoded = 99;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoUnallocated Method.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNtoUnallocated = 102;
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
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream Object.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream = 31;

        /// <summary>
        /// The identifier for the OPENSCSAggregationDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint OPENSCSAggregationDataType_Encoding_DefaultXml = 113;

        /// <summary>
        /// The identifier for the OPENSCSCollectionDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint OPENSCSCollectionDataType_Encoding_DefaultXml = 114;

        /// <summary>
        /// The identifier for the OPENSCSLabelCollectionDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint OPENSCSLabelCollectionDataType_Encoding_DefaultXml = 115;

        /// <summary>
        /// The identifier for the OPENSCSSNCollectionDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint OPENSCSSNCollectionDataType_Encoding_DefaultXml = 116;

        /// <summary>
        /// The identifier for the OPENSCSEventStreamArgumentDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint OPENSCSEventStreamArgumentDataType_Encoding_DefaultXml = 117;

        /// <summary>
        /// The identifier for the OPENSCSKeyValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint OPENSCSKeyValueDataType_Encoding_DefaultXml = 118;

        /// <summary>
        /// The identifier for the OPENSCSLabelDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint OPENSCSLabelDataType_Encoding_DefaultXml = 119;

        /// <summary>
        /// The identifier for the OPENSCSLabelPropertyDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint OPENSCSLabelPropertyDataType_Encoding_DefaultXml = 120;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassPropertyDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint OPENSCSSIDClassPropertyDataType_Encoding_DefaultXml = 121;

        /// <summary>
        /// The identifier for the OPENSCSAggregationDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint OPENSCSAggregationDataType_Encoding_DefaultBinary = 152;

        /// <summary>
        /// The identifier for the OPENSCSCollectionDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint OPENSCSCollectionDataType_Encoding_DefaultBinary = 153;

        /// <summary>
        /// The identifier for the OPENSCSLabelCollectionDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint OPENSCSLabelCollectionDataType_Encoding_DefaultBinary = 154;

        /// <summary>
        /// The identifier for the OPENSCSSNCollectionDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint OPENSCSSNCollectionDataType_Encoding_DefaultBinary = 155;

        /// <summary>
        /// The identifier for the OPENSCSEventStreamArgumentDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint OPENSCSEventStreamArgumentDataType_Encoding_DefaultBinary = 156;

        /// <summary>
        /// The identifier for the OPENSCSKeyValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint OPENSCSKeyValueDataType_Encoding_DefaultBinary = 157;

        /// <summary>
        /// The identifier for the OPENSCSLabelDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint OPENSCSLabelDataType_Encoding_DefaultBinary = 158;

        /// <summary>
        /// The identifier for the OPENSCSLabelPropertyDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint OPENSCSLabelPropertyDataType_Encoding_DefaultBinary = 159;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassPropertyDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint OPENSCSSIDClassPropertyDataType_Encoding_DefaultBinary = 160;
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
        /// The identifier for the OPENSCSAggregationManagerObjectType ObjectType.
        /// </summary>
        public const uint OPENSCSAggregationManagerObjectType = 22;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType ObjectType.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType = 30;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType ObjectType.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType = 75;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType ObjectType.
        /// </summary>
        public const uint OPENSCSSIDClassObjectType = 105;
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
        /// The identifier for the JobOrderCommandEnum_EnumValues Variable.
        /// </summary>
        public const uint JobOrderCommandEnum_EnumValues = 2;

        /// <summary>
        /// The identifier for the JobOrderCommandEnum_EnumStrings Variable.
        /// </summary>
        public const uint JobOrderCommandEnum_EnumStrings = 3;

        /// <summary>
        /// The identifier for the JobOrderStateEnum_EnumValues Variable.
        /// </summary>
        public const uint JobOrderStateEnum_EnumValues = 5;

        /// <summary>
        /// The identifier for the JobOrderStateEnum_EnumStrings Variable.
        /// </summary>
        public const uint JobOrderStateEnum_EnumStrings = 6;

        /// <summary>
        /// The identifier for the OPENSCSReturnEnum_EnumValues Variable.
        /// </summary>
        public const uint OPENSCSReturnEnum_EnumValues = 8;

        /// <summary>
        /// The identifier for the OPENSCSReturnEnum_EnumStrings Variable.
        /// </summary>
        public const uint OPENSCSReturnEnum_EnumStrings = 9;

        /// <summary>
        /// The identifier for the OPENSCSSerialNumberStateEnum_EnumValues Variable.
        /// </summary>
        public const uint OPENSCSSerialNumberStateEnum_EnumValues = 11;

        /// <summary>
        /// The identifier for the OPENSCSSerialNumberStateEnum_EnumStrings Variable.
        /// </summary>
        public const uint OPENSCSSerialNumberStateEnum_EnumStrings = 12;

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationPackingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSAggregationManagerObjectType_AggregationPackingEvent_InputArguments = 24;

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationPackingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSAggregationManagerObjectType_AggregationPackingEvent_OutputArguments = 25;

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_InputArguments = 27;

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_OutputArguments = 28;

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_MaxAggregationEvents Variable.
        /// </summary>
        public const uint OPENSCSAggregationManagerObjectType_MaxAggregationEvents = 29;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_ClientProcessingTimeout Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_ClientProcessingTimeout = 32;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_InputArguments = 34;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_OutputArguments = 35;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_InputArguments = 37;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_OutputArguments = 38;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_InputArguments = 40;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_OutputArguments = 41;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsEncodingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsEncodingEvent_InputArguments = 43;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsEncodingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsEncodingEvent_OutputArguments = 44;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsInspectingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsInspectingEvent_InputArguments = 46;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsInspectingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsInspectingEvent_OutputArguments = 47;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsSamplingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsSamplingEvent_InputArguments = 49;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsSamplingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsSamplingEvent_OutputArguments = 50;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsScrappingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsScrappingEvent_InputArguments = 52;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsScrappingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_LabelsScrappingEvent_OutputArguments = 53;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_MaxEPCISaggregationEvents Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_MaxEPCISaggregationEvents = 54;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_MaxEPCISObjectEventSIDs Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_MaxEPCISObjectEventSIDs = 55;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_MaxEvents Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_MaxEvents = 56;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDCommissioningEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDCommissioningEvent_InputArguments = 58;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDCommissioningEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDCommissioningEvent_OutputArguments = 59;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDecommissioningEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDDecommissioningEvent_InputArguments = 61;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDecommissioningEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDDecommissioningEvent_OutputArguments = 62;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDestroyingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDDestroyingEvent_InputArguments = 64;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDestroyingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDDestroyingEvent_OutputArguments = 65;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDInspectingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDInspectingEvent_InputArguments = 67;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDInspectingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDInspectingEvent_OutputArguments = 68;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDShippingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDShippingEvent_InputArguments = 70;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDShippingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SIDShippingEvent_OutputArguments = 71;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SNInvalidatingEvent_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SNInvalidatingEvent_InputArguments = 73;

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SNInvalidatingEvent_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSEventManagerObjectType_SNInvalidatingEvent_OutputArguments = 74;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_MaxSNPushable Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_MaxSNPushable = 76;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_MaxSNRequestable Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_MaxSNRequestable = 77;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_MaxSNReturnable Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_MaxSNReturnable = 78;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_PoolSelectionCriteria Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_PoolSelectionCriteria = 79;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNFormat Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNFormat = 80;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestAllocated_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNRequestAllocated_InputArguments = 82;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestAllocated_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNRequestAllocated_OutputArguments = 83;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnallocated_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNRequestUnallocated_InputArguments = 85;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnallocated_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNRequestUnallocated_OutputArguments = 86;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnassigned_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNRequestUnassigned_InputArguments = 88;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnassigned_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNRequestUnassigned_OutputArguments = 89;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnAllocated_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNReturnAllocated_InputArguments = 91;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnAllocated_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNReturnAllocated_OutputArguments = 92;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnUnallocated_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNReturnUnallocated_InputArguments = 94;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnUnallocated_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNReturnUnallocated_OutputArguments = 95;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoAllocated_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNtoAllocated_InputArguments = 97;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoAllocated_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNtoAllocated_OutputArguments = 98;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoEncoded_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNtoEncoded_InputArguments = 100;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoEncoded_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNtoEncoded_OutputArguments = 101;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoUnallocated_InputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNtoUnallocated_InputArguments = 103;

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoUnallocated_OutputArguments Variable.
        /// </summary>
        public const uint OPENSCSPoolManagerObjectType_SNtoUnallocated_OutputArguments = 104;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_AllowedCharacterSet Variable.
        /// </summary>
        public const uint OPENSCSSIDClassObjectType_AllowedCharacterSet = 106;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_IntendedUse Variable.
        /// </summary>
        public const uint OPENSCSSIDClassObjectType_IntendedUse = 107;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SIDClassDescription Variable.
        /// </summary>
        public const uint OPENSCSSIDClassObjectType_SIDClassDescription = 108;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SIDClassID Variable.
        /// </summary>
        public const uint OPENSCSSIDClassObjectType_SIDClassID = 109;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SIDClassOwner Variable.
        /// </summary>
        public const uint OPENSCSSIDClassObjectType_SIDClassOwner = 110;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SIDClassProperty Variable.
        /// </summary>
        public const uint OPENSCSSIDClassObjectType_SIDClassProperty = 111;

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SyntaxSpecification Variable.
        /// </summary>
        public const uint OPENSCSSIDClassObjectType_SyntaxSpecification = 112;

        /// <summary>
        /// The identifier for the Name2_XmlSchema Variable.
        /// </summary>
        public const uint Name2_XmlSchema = 122;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint Name2_XmlSchema_NamespaceUri = 124;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSAggregationDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_OPENSCSAggregationDataType = 125;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSCollectionDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_OPENSCSCollectionDataType = 128;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSLabelCollectionDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_OPENSCSLabelCollectionDataType = 131;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSSNCollectionDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_OPENSCSSNCollectionDataType = 134;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSEventStreamArgumentDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_OPENSCSEventStreamArgumentDataType = 137;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSKeyValueDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_OPENSCSKeyValueDataType = 140;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSLabelDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_OPENSCSLabelDataType = 143;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSLabelPropertyDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_OPENSCSLabelPropertyDataType = 146;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSSIDClassPropertyDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_OPENSCSSIDClassPropertyDataType = 149;

        /// <summary>
        /// The identifier for the Name2_BinarySchema Variable.
        /// </summary>
        public const uint Name2_BinarySchema = 161;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint Name2_BinarySchema_NamespaceUri = 163;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSAggregationDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_OPENSCSAggregationDataType = 164;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSCollectionDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_OPENSCSCollectionDataType = 167;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSLabelCollectionDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_OPENSCSLabelCollectionDataType = 170;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSSNCollectionDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_OPENSCSSNCollectionDataType = 173;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSEventStreamArgumentDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_OPENSCSEventStreamArgumentDataType = 176;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSKeyValueDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_OPENSCSKeyValueDataType = 179;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSLabelDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_OPENSCSLabelDataType = 182;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSLabelPropertyDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_OPENSCSLabelPropertyDataType = 185;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSSIDClassPropertyDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_OPENSCSSIDClassPropertyDataType = 188;
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
        /// The identifier for the JobOrderCommandEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId JobOrderCommandEnum = new ExpandedNodeId(Prefix2.DataTypes.JobOrderCommandEnum, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the JobOrderStateEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId JobOrderStateEnum = new ExpandedNodeId(Prefix2.DataTypes.JobOrderStateEnum, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSReturnEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSReturnEnum = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSReturnEnum, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSerialNumberStateEnum DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSerialNumberStateEnum = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSSerialNumberStateEnum, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSAggregationDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationDataType = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSAggregationDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSCollectionDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSCollectionDataType = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSCollectionDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSLabelCollectionDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSLabelCollectionDataType = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSLabelCollectionDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSNCollectionDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSNCollectionDataType = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSSNCollectionDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventStreamArgumentDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventStreamArgumentDataType = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSEventStreamArgumentDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSKeyValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSKeyValueDataType = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSKeyValueDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSLabelDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSLabelDataType = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSLabelDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSLabelPropertyDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSLabelPropertyDataType = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSLabelPropertyDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassPropertyDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassPropertyDataType = new ExpandedNodeId(Prefix2.DataTypes.OPENSCSSIDClassPropertyDataType, Prefix2.Namespaces.Name2);
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
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationPackingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationManagerObjectType_AggregationPackingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSAggregationManagerObjectType_AggregationPackingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsEncodingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsEncodingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_LabelsEncodingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsInspectingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsInspectingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_LabelsInspectingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsSamplingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsSamplingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_LabelsSamplingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsScrappingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsScrappingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_LabelsScrappingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDCommissioningEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDCommissioningEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_SIDCommissioningEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDecommissioningEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDDecommissioningEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_SIDDecommissioningEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDestroyingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDDestroyingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_SIDDestroyingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDInspectingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDInspectingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_SIDInspectingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDShippingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDShippingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_SIDShippingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SNInvalidatingEvent Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SNInvalidatingEvent = new ExpandedNodeId(Prefix2.Methods.OPENSCSEventManagerObjectType_SNInvalidatingEvent, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestAllocated Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNRequestAllocated = new ExpandedNodeId(Prefix2.Methods.OPENSCSPoolManagerObjectType_SNRequestAllocated, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnallocated Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNRequestUnallocated = new ExpandedNodeId(Prefix2.Methods.OPENSCSPoolManagerObjectType_SNRequestUnallocated, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnassigned Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNRequestUnassigned = new ExpandedNodeId(Prefix2.Methods.OPENSCSPoolManagerObjectType_SNRequestUnassigned, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnAllocated Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNReturnAllocated = new ExpandedNodeId(Prefix2.Methods.OPENSCSPoolManagerObjectType_SNReturnAllocated, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnUnallocated Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNReturnUnallocated = new ExpandedNodeId(Prefix2.Methods.OPENSCSPoolManagerObjectType_SNReturnUnallocated, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoAllocated Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNtoAllocated = new ExpandedNodeId(Prefix2.Methods.OPENSCSPoolManagerObjectType_SNtoAllocated, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoEncoded Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNtoEncoded = new ExpandedNodeId(Prefix2.Methods.OPENSCSPoolManagerObjectType_SNtoEncoded, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoUnallocated Method.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNtoUnallocated = new ExpandedNodeId(Prefix2.Methods.OPENSCSPoolManagerObjectType_SNtoUnallocated, Prefix2.Namespaces.Name2);
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
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream = new ExpandedNodeId(Prefix2.Objects.OPENSCSEventManagerObjectType_EPCISStream, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSAggregationDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.OPENSCSAggregationDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSCollectionDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSCollectionDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.OPENSCSCollectionDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSLabelCollectionDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSLabelCollectionDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.OPENSCSLabelCollectionDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSNCollectionDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSNCollectionDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.OPENSCSSNCollectionDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventStreamArgumentDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventStreamArgumentDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.OPENSCSEventStreamArgumentDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSKeyValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSKeyValueDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.OPENSCSKeyValueDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSLabelDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSLabelDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.OPENSCSLabelDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSLabelPropertyDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSLabelPropertyDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.OPENSCSLabelPropertyDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassPropertyDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassPropertyDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.OPENSCSSIDClassPropertyDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSAggregationDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.OPENSCSAggregationDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSCollectionDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSCollectionDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.OPENSCSCollectionDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSLabelCollectionDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSLabelCollectionDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.OPENSCSLabelCollectionDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSNCollectionDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSNCollectionDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.OPENSCSSNCollectionDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventStreamArgumentDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventStreamArgumentDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.OPENSCSEventStreamArgumentDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSKeyValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSKeyValueDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.OPENSCSKeyValueDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSLabelDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSLabelDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.OPENSCSLabelDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSLabelPropertyDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSLabelPropertyDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.OPENSCSLabelPropertyDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassPropertyDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassPropertyDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.OPENSCSSIDClassPropertyDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);
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
        /// The identifier for the OPENSCSAggregationManagerObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationManagerObjectType = new ExpandedNodeId(Prefix2.ObjectTypes.OPENSCSAggregationManagerObjectType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType = new ExpandedNodeId(Prefix2.ObjectTypes.OPENSCSEventManagerObjectType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType = new ExpandedNodeId(Prefix2.ObjectTypes.OPENSCSPoolManagerObjectType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassObjectType = new ExpandedNodeId(Prefix2.ObjectTypes.OPENSCSSIDClassObjectType, Prefix2.Namespaces.Name2);
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
        /// The identifier for the JobOrderCommandEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId JobOrderCommandEnum_EnumValues = new ExpandedNodeId(Prefix2.Variables.JobOrderCommandEnum_EnumValues, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the JobOrderCommandEnum_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId JobOrderCommandEnum_EnumStrings = new ExpandedNodeId(Prefix2.Variables.JobOrderCommandEnum_EnumStrings, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the JobOrderStateEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId JobOrderStateEnum_EnumValues = new ExpandedNodeId(Prefix2.Variables.JobOrderStateEnum_EnumValues, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the JobOrderStateEnum_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId JobOrderStateEnum_EnumStrings = new ExpandedNodeId(Prefix2.Variables.JobOrderStateEnum_EnumStrings, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSReturnEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSReturnEnum_EnumValues = new ExpandedNodeId(Prefix2.Variables.OPENSCSReturnEnum_EnumValues, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSReturnEnum_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSReturnEnum_EnumStrings = new ExpandedNodeId(Prefix2.Variables.OPENSCSReturnEnum_EnumStrings, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSerialNumberStateEnum_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSerialNumberStateEnum_EnumValues = new ExpandedNodeId(Prefix2.Variables.OPENSCSSerialNumberStateEnum_EnumValues, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSerialNumberStateEnum_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSerialNumberStateEnum_EnumStrings = new ExpandedNodeId(Prefix2.Variables.OPENSCSSerialNumberStateEnum_EnumStrings, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationPackingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationManagerObjectType_AggregationPackingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSAggregationManagerObjectType_AggregationPackingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationPackingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationManagerObjectType_AggregationPackingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSAggregationManagerObjectType_AggregationPackingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSAggregationManagerObjectType_AggregationUnpackingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSAggregationManagerObjectType_MaxAggregationEvents Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSAggregationManagerObjectType_MaxAggregationEvents = new ExpandedNodeId(Prefix2.Variables.OPENSCSAggregationManagerObjectType_MaxAggregationEvents, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_ClientProcessingTimeout Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_ClientProcessingTimeout = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_EPCISStream_ClientProcessingTimeout, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForRead_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_EPCISStream_GenerateFileForWrite_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_EPCISStream_CloseAndCommit_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsEncodingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsEncodingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_LabelsEncodingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsEncodingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsEncodingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_LabelsEncodingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsInspectingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsInspectingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_LabelsInspectingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsInspectingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsInspectingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_LabelsInspectingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsSamplingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsSamplingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_LabelsSamplingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsSamplingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsSamplingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_LabelsSamplingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsScrappingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsScrappingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_LabelsScrappingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_LabelsScrappingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_LabelsScrappingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_LabelsScrappingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_MaxEPCISaggregationEvents Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_MaxEPCISaggregationEvents = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_MaxEPCISaggregationEvents, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_MaxEPCISObjectEventSIDs Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_MaxEPCISObjectEventSIDs = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_MaxEPCISObjectEventSIDs, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_MaxEvents Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_MaxEvents = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_MaxEvents, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDCommissioningEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDCommissioningEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDCommissioningEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDCommissioningEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDCommissioningEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDCommissioningEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDecommissioningEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDDecommissioningEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDDecommissioningEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDecommissioningEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDDecommissioningEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDDecommissioningEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDestroyingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDDestroyingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDDestroyingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDDestroyingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDDestroyingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDDestroyingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDInspectingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDInspectingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDInspectingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDInspectingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDInspectingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDInspectingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDShippingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDShippingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDShippingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SIDShippingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SIDShippingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SIDShippingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SNInvalidatingEvent_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SNInvalidatingEvent_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SNInvalidatingEvent_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSEventManagerObjectType_SNInvalidatingEvent_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSEventManagerObjectType_SNInvalidatingEvent_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSEventManagerObjectType_SNInvalidatingEvent_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_MaxSNPushable Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_MaxSNPushable = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_MaxSNPushable, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_MaxSNRequestable Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_MaxSNRequestable = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_MaxSNRequestable, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_MaxSNReturnable Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_MaxSNReturnable = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_MaxSNReturnable, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_PoolSelectionCriteria Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_PoolSelectionCriteria = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_PoolSelectionCriteria, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNFormat Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNFormat = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNFormat, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestAllocated_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNRequestAllocated_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNRequestAllocated_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestAllocated_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNRequestAllocated_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNRequestAllocated_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnallocated_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNRequestUnallocated_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNRequestUnallocated_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnallocated_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNRequestUnallocated_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNRequestUnallocated_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnassigned_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNRequestUnassigned_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNRequestUnassigned_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNRequestUnassigned_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNRequestUnassigned_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNRequestUnassigned_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnAllocated_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNReturnAllocated_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNReturnAllocated_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnAllocated_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNReturnAllocated_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNReturnAllocated_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnUnallocated_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNReturnUnallocated_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNReturnUnallocated_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNReturnUnallocated_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNReturnUnallocated_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNReturnUnallocated_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoAllocated_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNtoAllocated_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNtoAllocated_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoAllocated_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNtoAllocated_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNtoAllocated_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoEncoded_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNtoEncoded_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNtoEncoded_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoEncoded_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNtoEncoded_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNtoEncoded_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoUnallocated_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNtoUnallocated_InputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNtoUnallocated_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSPoolManagerObjectType_SNtoUnallocated_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSPoolManagerObjectType_SNtoUnallocated_OutputArguments = new ExpandedNodeId(Prefix2.Variables.OPENSCSPoolManagerObjectType_SNtoUnallocated_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_AllowedCharacterSet Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassObjectType_AllowedCharacterSet = new ExpandedNodeId(Prefix2.Variables.OPENSCSSIDClassObjectType_AllowedCharacterSet, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_IntendedUse Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassObjectType_IntendedUse = new ExpandedNodeId(Prefix2.Variables.OPENSCSSIDClassObjectType_IntendedUse, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SIDClassDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassObjectType_SIDClassDescription = new ExpandedNodeId(Prefix2.Variables.OPENSCSSIDClassObjectType_SIDClassDescription, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SIDClassID Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassObjectType_SIDClassID = new ExpandedNodeId(Prefix2.Variables.OPENSCSSIDClassObjectType_SIDClassID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SIDClassOwner Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassObjectType_SIDClassOwner = new ExpandedNodeId(Prefix2.Variables.OPENSCSSIDClassObjectType_SIDClassOwner, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SIDClassProperty Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassObjectType_SIDClassProperty = new ExpandedNodeId(Prefix2.Variables.OPENSCSSIDClassObjectType_SIDClassProperty, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the OPENSCSSIDClassObjectType_SyntaxSpecification Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPENSCSSIDClassObjectType_SyntaxSpecification = new ExpandedNodeId(Prefix2.Variables.OPENSCSSIDClassObjectType_SyntaxSpecification, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_NamespaceUri = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_NamespaceUri, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSAggregationDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_OPENSCSAggregationDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_OPENSCSAggregationDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSCollectionDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_OPENSCSCollectionDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_OPENSCSCollectionDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSLabelCollectionDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_OPENSCSLabelCollectionDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_OPENSCSLabelCollectionDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSSNCollectionDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_OPENSCSSNCollectionDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_OPENSCSSNCollectionDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSEventStreamArgumentDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_OPENSCSEventStreamArgumentDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_OPENSCSEventStreamArgumentDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSKeyValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_OPENSCSKeyValueDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_OPENSCSKeyValueDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSLabelDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_OPENSCSLabelDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_OPENSCSLabelDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSLabelPropertyDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_OPENSCSLabelPropertyDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_OPENSCSLabelPropertyDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_OPENSCSSIDClassPropertyDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_OPENSCSSIDClassPropertyDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_OPENSCSSIDClassPropertyDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_NamespaceUri = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_NamespaceUri, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSAggregationDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_OPENSCSAggregationDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_OPENSCSAggregationDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSCollectionDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_OPENSCSCollectionDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_OPENSCSCollectionDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSLabelCollectionDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_OPENSCSLabelCollectionDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_OPENSCSLabelCollectionDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSSNCollectionDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_OPENSCSSNCollectionDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_OPENSCSSNCollectionDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSEventStreamArgumentDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_OPENSCSEventStreamArgumentDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_OPENSCSEventStreamArgumentDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSKeyValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_OPENSCSKeyValueDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_OPENSCSKeyValueDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSLabelDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_OPENSCSLabelDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_OPENSCSLabelDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSLabelPropertyDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_OPENSCSLabelPropertyDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_OPENSCSLabelPropertyDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_OPENSCSSIDClassPropertyDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_OPENSCSSIDClassPropertyDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_OPENSCSSIDClassPropertyDataType, Prefix2.Namespaces.Name2);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the AggregationPackingEvent component.
        /// </summary>
        public const string AggregationPackingEvent = "AggregationPackingEvent";

        /// <summary>
        /// The BrowseName for the AggregationUnpackingEvent component.
        /// </summary>
        public const string AggregationUnpackingEvent = "AggregationUnpackingEvent";

        /// <summary>
        /// The BrowseName for the AllowedCharacterSet component.
        /// </summary>
        public const string AllowedCharacterSet = "AllowedCharacterSet";

        /// <summary>
        /// The BrowseName for the EPCISStream component.
        /// </summary>
        public const string EPCISStream = "EPCISStream";

        /// <summary>
        /// The BrowseName for the IntendedUse component.
        /// </summary>
        public const string IntendedUse = "IntendedUse";

        /// <summary>
        /// The BrowseName for the JobOrderCommandEnum component.
        /// </summary>
        public const string JobOrderCommandEnum = "JobOrderCommandEnum";

        /// <summary>
        /// The BrowseName for the JobOrderStateEnum component.
        /// </summary>
        public const string JobOrderStateEnum = "JobOrderStateEnum";

        /// <summary>
        /// The BrowseName for the LabelsEncodingEvent component.
        /// </summary>
        public const string LabelsEncodingEvent = "LabelsEncodingEvent";

        /// <summary>
        /// The BrowseName for the LabelsInspectingEvent component.
        /// </summary>
        public const string LabelsInspectingEvent = "LabelsInspectingEvent";

        /// <summary>
        /// The BrowseName for the LabelsSamplingEvent component.
        /// </summary>
        public const string LabelsSamplingEvent = "LabelsSamplingEvent";

        /// <summary>
        /// The BrowseName for the LabelsScrappingEvent component.
        /// </summary>
        public const string LabelsScrappingEvent = "LabelsScrappingEvent";

        /// <summary>
        /// The BrowseName for the MaxAggregationEvents component.
        /// </summary>
        public const string MaxAggregationEvents = "MaxAggregationEvents";

        /// <summary>
        /// The BrowseName for the MaxEPCISaggregationEvents component.
        /// </summary>
        public const string MaxEPCISaggregationEvents = "MaxEPCISaggregationEvents";

        /// <summary>
        /// The BrowseName for the MaxEPCISObjectEventSIDs component.
        /// </summary>
        public const string MaxEPCISObjectEventSIDs = "MaxEPCISObjectEventSIDs";

        /// <summary>
        /// The BrowseName for the MaxEvents component.
        /// </summary>
        public const string MaxEvents = "MaxEvents";

        /// <summary>
        /// The BrowseName for the MaxSNPushable component.
        /// </summary>
        public const string MaxSNPushable = "MaxSNPushable";

        /// <summary>
        /// The BrowseName for the MaxSNRequestable component.
        /// </summary>
        public const string MaxSNRequestable = "MaxSNRequestable";

        /// <summary>
        /// The BrowseName for the MaxSNReturnable component.
        /// </summary>
        public const string MaxSNReturnable = "MaxSNReturnable";

        /// <summary>
        /// The BrowseName for the Name2_BinarySchema component.
        /// </summary>
        public const string Name2_BinarySchema = "Prefix2";

        /// <summary>
        /// The BrowseName for the Name2_XmlSchema component.
        /// </summary>
        public const string Name2_XmlSchema = "Prefix2";

        /// <summary>
        /// The BrowseName for the OPENSCSAggregationDataType component.
        /// </summary>
        public const string OPENSCSAggregationDataType = "OPENSCSAggregationDataType";

        /// <summary>
        /// The BrowseName for the OPENSCSAggregationManagerObjectType component.
        /// </summary>
        public const string OPENSCSAggregationManagerObjectType = "OPENSCSAggregationManagerObjectType";

        /// <summary>
        /// The BrowseName for the OPENSCSCollectionDataType component.
        /// </summary>
        public const string OPENSCSCollectionDataType = "OPENSCSCollectionDataType";

        /// <summary>
        /// The BrowseName for the OPENSCSEventManagerObjectType component.
        /// </summary>
        public const string OPENSCSEventManagerObjectType = "OPENSCSEventManagerObjectType";

        /// <summary>
        /// The BrowseName for the OPENSCSEventStreamArgumentDataType component.
        /// </summary>
        public const string OPENSCSEventStreamArgumentDataType = "OPENSCSEventStreamArgumentDataType";

        /// <summary>
        /// The BrowseName for the OPENSCSKeyValueDataType component.
        /// </summary>
        public const string OPENSCSKeyValueDataType = "OPENSCSKeyValueDataType";

        /// <summary>
        /// The BrowseName for the OPENSCSLabelCollectionDataType component.
        /// </summary>
        public const string OPENSCSLabelCollectionDataType = "OPENSCSLabelCollectionDataType";

        /// <summary>
        /// The BrowseName for the OPENSCSLabelDataType component.
        /// </summary>
        public const string OPENSCSLabelDataType = "OPENSCSLabelDataType";

        /// <summary>
        /// The BrowseName for the OPENSCSLabelPropertyDataType component.
        /// </summary>
        public const string OPENSCSLabelPropertyDataType = "OPENSCSLabelPropertyDataType";

        /// <summary>
        /// The BrowseName for the OPENSCSPoolManagerObjectType component.
        /// </summary>
        public const string OPENSCSPoolManagerObjectType = "OPENSCSPoolManagerObjectType";

        /// <summary>
        /// The BrowseName for the OPENSCSReturnEnum component.
        /// </summary>
        public const string OPENSCSReturnEnum = "OPENSCSReturnEnum";

        /// <summary>
        /// The BrowseName for the OPENSCSSerialNumberStateEnum component.
        /// </summary>
        public const string OPENSCSSerialNumberStateEnum = "OPENSCSSerialNumberStateEnum";

        /// <summary>
        /// The BrowseName for the OPENSCSSIDClassObjectType component.
        /// </summary>
        public const string OPENSCSSIDClassObjectType = "OPENSCSSIDClassObjectType";

        /// <summary>
        /// The BrowseName for the OPENSCSSIDClassPropertyDataType component.
        /// </summary>
        public const string OPENSCSSIDClassPropertyDataType = "OPENSCSSIDClassPropertyDataType";

        /// <summary>
        /// The BrowseName for the OPENSCSSNCollectionDataType component.
        /// </summary>
        public const string OPENSCSSNCollectionDataType = "OPENSCSSNCollectionDataType";

        /// <summary>
        /// The BrowseName for the PoolSelectionCriteria component.
        /// </summary>
        public const string PoolSelectionCriteria = "PoolSelectionCriteria";

        /// <summary>
        /// The BrowseName for the SIDClassDescription component.
        /// </summary>
        public const string SIDClassDescription = "SIDClassDescription";

        /// <summary>
        /// The BrowseName for the SIDClassID component.
        /// </summary>
        public const string SIDClassID = "SIDClassID";

        /// <summary>
        /// The BrowseName for the SIDClassOwner component.
        /// </summary>
        public const string SIDClassOwner = "SIDClassOwner";

        /// <summary>
        /// The BrowseName for the SIDClassProperty component.
        /// </summary>
        public const string SIDClassProperty = "SIDClassProperty";

        /// <summary>
        /// The BrowseName for the SIDCommissioningEvent component.
        /// </summary>
        public const string SIDCommissioningEvent = "SIDCommissioningEvent";

        /// <summary>
        /// The BrowseName for the SIDDecommissioningEvent component.
        /// </summary>
        public const string SIDDecommissioningEvent = "SIDDecommissioningEvent";

        /// <summary>
        /// The BrowseName for the SIDDestroyingEvent component.
        /// </summary>
        public const string SIDDestroyingEvent = "SIDDestroyingEvent";

        /// <summary>
        /// The BrowseName for the SIDInspectingEvent component.
        /// </summary>
        public const string SIDInspectingEvent = "SIDInspectingEvent";

        /// <summary>
        /// The BrowseName for the SIDShippingEvent component.
        /// </summary>
        public const string SIDShippingEvent = "SIDShippingEvent";

        /// <summary>
        /// The BrowseName for the SNFormat component.
        /// </summary>
        public const string SNFormat = "SNFormat";

        /// <summary>
        /// The BrowseName for the SNInvalidatingEvent component.
        /// </summary>
        public const string SNInvalidatingEvent = "SNInvalidatingEvent";

        /// <summary>
        /// The BrowseName for the SNRequestAllocated component.
        /// </summary>
        public const string SNRequestAllocated = "SNRequestAllocated";

        /// <summary>
        /// The BrowseName for the SNRequestUnallocated component.
        /// </summary>
        public const string SNRequestUnallocated = "SNRequestUnallocated";

        /// <summary>
        /// The BrowseName for the SNRequestUnassigned component.
        /// </summary>
        public const string SNRequestUnassigned = "SNRequestUnassigned";

        /// <summary>
        /// The BrowseName for the SNReturnAllocated component.
        /// </summary>
        public const string SNReturnAllocated = "SNReturnAllocated";

        /// <summary>
        /// The BrowseName for the SNReturnUnallocated component.
        /// </summary>
        public const string SNReturnUnallocated = "SNReturnUnallocated";

        /// <summary>
        /// The BrowseName for the SNtoAllocated component.
        /// </summary>
        public const string SNtoAllocated = "SNtoAllocated";

        /// <summary>
        /// The BrowseName for the SNtoEncoded component.
        /// </summary>
        public const string SNtoEncoded = "SNtoEncoded";

        /// <summary>
        /// The BrowseName for the SNtoUnallocated component.
        /// </summary>
        public const string SNtoUnallocated = "SNtoUnallocated";

        /// <summary>
        /// The BrowseName for the SyntaxSpecification component.
        /// </summary>
        public const string SyntaxSpecification = "SyntaxSpecification";
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
        public const string Name2Xsd = "http://opcfoundation.org/UA/OPENSCS-SER/";

        /// <summary>
        /// The URI for the Name2Xsd namespace (.NET code namespace is 'Prefix2').
        /// </summary>
        public const string Name2Xsd = "http://opcfoundation.org/UA/OPENSCS-SER/";
    }
    #endregion

    #region JobOrderCommandEnum Enumeration
    #if (!OPCUA_EXCLUDE_JobOrderCommandEnum)
    /// <summary>
    /// Describes the possible job order commands.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public enum JobOrderCommandEnum
    {
        /// <summary>
        /// Undefined value, should never be seen.
        /// </summary>
        [EnumMember(Value = "Undefined_0")]
        Undefined_0 = 0,

        /// <summary>
        /// Command to store the job order in local storage, but not to start the order.
        /// </summary>
        [EnumMember(Value = "Store_1")]
        Store_1 = 1,

        /// <summary>
        /// Command to store the job order and start it as soon as the Job Order receiver is ready to start.
        /// </summary>
        [EnumMember(Value = "StoreAndStart_2")]
        StoreAndStart_2 = 2,

        /// <summary>
        /// Command to start a stored job order as soon as the receiver is ready to start. Only the Job Orders ID is used to identify the stored job order, all other information is not used.  No changes are made to the stored order. If multiple Job Orders have been commanded to Start, then the priority and timing values in the Job Orders shall be used to determine the order of execution of the orders.
        /// </summary>
        [EnumMember(Value = "Start_3")]
        Start_3 = 3,

        /// <summary>
        /// Command to update a stored Job Order that has not yet been started, with the new order information.  All previously stored information is replaced.
        /// </summary>
        [EnumMember(Value = "Update_4")]
        Update_4 = 4,

        /// <summary>
        /// Command to stop a started job order, report on any work done on the order, and remove the stored information. Only the Job Orders ID is used to identify the job order, all other information is not used.
        /// </summary>
        [EnumMember(Value = "Stop_5")]
        Stop_5 = 5,

        /// <summary>
        /// Cancel an un-started job order and remove the stored information. Only the Job Orders ID is used to identify the job order, all other information is not used.
        /// </summary>
        [EnumMember(Value = "Cancel_6")]
        Cancel_6 = 6,

        /// <summary>
        /// Command to allow the Information Receiver to clear any maintained information on the Job Order (usually sent after a receipt of a Job Response with a status of Finished.) Only the Job Orders ID is used to identify the job order, all other information is not used.
        /// </summary>
        [EnumMember(Value = "Clear_7")]
        Clear_7 = 7,
    }

    #region JobOrderCommandEnumCollection Class
    /// <summary>
    /// A collection of JobOrderCommandEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfJobOrderCommandEnum", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "JobOrderCommandEnum")]
    #if !NET_STANDARD
    public partial class JobOrderCommandEnumCollection : List<JobOrderCommandEnum>, ICloneable
    #else
    public partial class JobOrderCommandEnumCollection : List<JobOrderCommandEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public JobOrderCommandEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public JobOrderCommandEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public JobOrderCommandEnumCollection(IEnumerable<JobOrderCommandEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator JobOrderCommandEnumCollection(JobOrderCommandEnum[] values)
        {
            if (values != null)
            {
                return new JobOrderCommandEnumCollection(values);
            }

            return new JobOrderCommandEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator JobOrderCommandEnum[](JobOrderCommandEnumCollection values)
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
            return (JobOrderCommandEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            JobOrderCommandEnumCollection clone = new JobOrderCommandEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((JobOrderCommandEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region JobOrderStateEnum Enumeration
    #if (!OPCUA_EXCLUDE_JobOrderStateEnum)
    /// <summary>
    /// Describes the possible serial number statesjob order states.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public enum JobOrderStateEnum
    {
        /// <summary>
        /// defined value, should never be seen.
        /// </summary>
        [EnumMember(Value = "Undefined_0")]
        Undefined_0 = 0,

        /// <summary>
        /// The necessary pre-conditions have not been met and the order is not ready to run.
        /// </summary>
        [EnumMember(Value = "Waiting_1")]
        Waiting_1 = 1,

        /// <summary>
        /// The necessary pre-conditions have been met and the order is ready to run, awaiting a Start command.
        /// </summary>
        [EnumMember(Value = "Ready_2")]
        Ready_2 = 2,

        /// <summary>
        /// In situations where only one job may be in active memory and is able to be run, then the job is loaded in active memory, the  necessary pre-conditions have been met, and the order is ready to run, awaiting a Start command.
        /// </summary>
        [EnumMember(Value = "Loaded_3")]
        Loaded_3 = 3,

        /// <summary>
        /// The order is executing.
        /// </summary>
        [EnumMember(Value = "Running_4")]
        Running_4 = 4,

        /// <summary>
        /// The order has been completed and are no longer in execution.
        /// </summary>
        [EnumMember(Value = "Completed_5")]
        Completed_5 = 5,

        /// <summary>
        /// The order was aborted.
        /// </summary>
        [EnumMember(Value = "Aborted_6")]
        Aborted_6 = 6,

        /// <summary>
        /// The order has been temporarily stopped due to a constraint of some form.
        /// </summary>
        [EnumMember(Value = "Held_7")]
        Held_7 = 7,

        /// <summary>
        /// The order has been temporarily stopped due to a deliberate decision within the execution system.
        /// </summary>
        [EnumMember(Value = "Suspended_8")]
        Suspended_8 = 8,

        /// <summary>
        /// The order has been completed and fully reconciled. No further changes, or restatement of actuals is expected.
        /// </summary>
        [EnumMember(Value = "Closed_9")]
        Closed_9 = 9,
    }

    #region JobOrderStateEnumCollection Class
    /// <summary>
    /// A collection of JobOrderStateEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfJobOrderStateEnum", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "JobOrderStateEnum")]
    #if !NET_STANDARD
    public partial class JobOrderStateEnumCollection : List<JobOrderStateEnum>, ICloneable
    #else
    public partial class JobOrderStateEnumCollection : List<JobOrderStateEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public JobOrderStateEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public JobOrderStateEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public JobOrderStateEnumCollection(IEnumerable<JobOrderStateEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator JobOrderStateEnumCollection(JobOrderStateEnum[] values)
        {
            if (values != null)
            {
                return new JobOrderStateEnumCollection(values);
            }

            return new JobOrderStateEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator JobOrderStateEnum[](JobOrderStateEnumCollection values)
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
            return (JobOrderStateEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            JobOrderStateEnumCollection clone = new JobOrderStateEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((JobOrderStateEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSReturnEnum Enumeration
    #if (!OPCUA_EXCLUDE_OPENSCSReturnEnum)
    /// <summary>
    /// A description for the OPENSCSReturnEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public enum OPENSCSReturnEnum
    {
        /// <summary>
        /// Undefined value, should never be seen.
        /// </summary>
        [EnumMember(Value = "Undefined0_0")]
        Undefined0 = 0,

        /// <summary>
        /// There were no errors in processing the method.  
        /// </summary>
        [EnumMember(Value = "NoError1_1")]
        NoError1 = 1,

        /// <summary>
        /// The Serial Number Collection ID does not match a Serial Number Collection managed by the server.
        /// </summary>
        [EnumMember(Value = "InvalidSerialNumberCollection2_2")]
        InvalidSerialNumberCollection2 = 2,

        /// <summary>
        /// Fewer Serial Numbers are available from the pool, then are requested.
        /// </summary>
        [EnumMember(Value = "InsufficientSerialNumbers3_3")]
        InsufficientSerialNumbers3 = 3,

        /// <summary>
        /// The serial number format is not known or defined in the server
        /// </summary>
        [EnumMember(Value = "InvalidSerialNumbersFormat4_4")]
        InvalidSerialNumbersFormat4 = 4,

        /// <summary>
        /// The Request Token has a value not understood by the server.
        /// </summary>
        [EnumMember(Value = "InvalidRequestToken5_5")]
        InvalidRequestToken5 = 5,

        /// <summary>
        /// The Selection Criteria is not known or defined in the server.
        /// </summary>
        [EnumMember(Value = "InvalidSelectionCriteria6_6")]
        InvalidSelectionCriteria6 = 6,

        /// <summary>
        /// The server cannot accept Serial Number events.
        /// </summary>
        [EnumMember(Value = "UnableToAcceptSerialNumberEvents7_7")]
        UnableToAcceptSerialNumberEvents7 = 7,

        /// <summary>
        /// The server cannot accept Label events.
        /// </summary>
        [EnumMember(Value = "UnableToAcceptLabelEvents8_8")]
        UnableToAcceptLabelEvents8 = 8,

        /// <summary>
        /// The server cannot accept SID events.
        /// </summary>
        [EnumMember(Value = "UnableToAcceptSIDEvents9_9")]
        UnableToAcceptSIDEvents9 = 9,

        /// <summary>
        /// The SID of the aggregation for packing or unpacking is unknown.
        /// </summary>
        [EnumMember(Value = "UnknownAggregationSID10_10")]
        UnknownAggregationSID10 = 10,

        /// <summary>
        ///  The server has determined that the client does not have sufficient privilege for the method to execute.
        /// </summary>
        [EnumMember(Value = "InsufficientPrivilegeToExecute11_11")]
        InsufficientPrivilegeToExecute11 = 11,
    }

    #region OPENSCSReturnEnumCollection Class
    /// <summary>
    /// A collection of OPENSCSReturnEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSReturnEnum", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSReturnEnum")]
    #if !NET_STANDARD
    public partial class OPENSCSReturnEnumCollection : List<OPENSCSReturnEnum>, ICloneable
    #else
    public partial class OPENSCSReturnEnumCollection : List<OPENSCSReturnEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSReturnEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSReturnEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSReturnEnumCollection(IEnumerable<OPENSCSReturnEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSReturnEnumCollection(OPENSCSReturnEnum[] values)
        {
            if (values != null)
            {
                return new OPENSCSReturnEnumCollection(values);
            }

            return new OPENSCSReturnEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSReturnEnum[](OPENSCSReturnEnumCollection values)
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
            return (OPENSCSReturnEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSReturnEnumCollection clone = new OPENSCSReturnEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSReturnEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSSerialNumberStateEnum Enumeration
    #if (!OPCUA_EXCLUDE_OPENSCSSerialNumberStateEnum)
    /// <summary>
    /// A description for the OPENSCSSerialNumberStateEnum DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public enum OPENSCSSerialNumberStateEnum
    {
        /// <summary>
        /// The Serial Number has not been assigned to production or a packaging run.
        /// </summary>
        [EnumMember(Value = "Unassigned0_0")]
        Unassigned0 = 0,

        /// <summary>
        /// As Serial Number has been assigned to production or a packaging run, but it has not yet been allocated for use a specific production run of a product or aggregation.
        /// </summary>
        [EnumMember(Value = "Unallocated1_1")]
        Unallocated1 = 1,

        /// <summary>
        /// The Serial Number has been assigned to a specific product or aggregation production run. 
        /// </summary>
        [EnumMember(Value = "Allocated2_2")]
        Allocated2 = 2,

        /// <summary>
        /// The Serial Number is no longer viable, and the related serial number is no longer defined. 
        /// </summary>
        [EnumMember(Value = "SNInvalid3_3")]
        SNInvalid3 = 3,

        /// <summary>
        /// The Serial Number has been written to a barcode or RFID tag, but not yet commissioned.
        /// </summary>
        [EnumMember(Value = "Encoded4_4")]
        Encoded4 = 4,

        /// <summary>
        /// The printed label has been retained and is not associated with a physical product or aggregation.
        /// </summary>
        [EnumMember(Value = "LabelSampled5_5")]
        LabelSampled5 = 5,

        /// <summary>
        /// A label was encoded with a Serial Number, but was made unusable before being applied to a product or aggregation.
        /// </summary>
        [EnumMember(Value = "LabelScrapped6_6")]
        LabelScrapped6 = 6,

        /// <summary>
        /// The Serial Number has been associated with a physical product or aggregation, but has not yet left the responsibility of production
        /// </summary>
        [EnumMember(Value = "Commissioned7_7")]
        Commissioned7 = 7,

        /// <summary>
        /// The product or aggregation is to be used as a sample for testing or other use, not to be made active.
        /// </summary>
        [EnumMember(Value = "Sampled8_8")]
        Sampled8 = 8,

        /// <summary>
        /// The product or aggregation is no longer active, but may not have been destroyed.
        /// </summary>
        [EnumMember(Value = "Inactive9_9")]
        Inactive9 = 9,

        /// <summary>
        /// The product or aggregation was has been fully rendered non-usable.
        /// </summary>
        [EnumMember(Value = "Destroyed10_10")]
        Destroyed10 = 10,

        /// <summary>
        /// The Serial Number has been associated with a physical product or aggregation, and has left the responsibility of production.
        /// </summary>
        [EnumMember(Value = "Released11_11")]
        Released11 = 11,
    }

    #region OPENSCSSerialNumberStateEnumCollection Class
    /// <summary>
    /// A collection of OPENSCSSerialNumberStateEnum objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSSerialNumberStateEnum", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSSerialNumberStateEnum")]
    #if !NET_STANDARD
    public partial class OPENSCSSerialNumberStateEnumCollection : List<OPENSCSSerialNumberStateEnum>, ICloneable
    #else
    public partial class OPENSCSSerialNumberStateEnumCollection : List<OPENSCSSerialNumberStateEnum>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSSerialNumberStateEnumCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSSerialNumberStateEnumCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSSerialNumberStateEnumCollection(IEnumerable<OPENSCSSerialNumberStateEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSSerialNumberStateEnumCollection(OPENSCSSerialNumberStateEnum[] values)
        {
            if (values != null)
            {
                return new OPENSCSSerialNumberStateEnumCollection(values);
            }

            return new OPENSCSSerialNumberStateEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSSerialNumberStateEnum[](OPENSCSSerialNumberStateEnumCollection values)
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
            return (OPENSCSSerialNumberStateEnumCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSSerialNumberStateEnumCollection clone = new OPENSCSSerialNumberStateEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSSerialNumberStateEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSAggregationDataType Class
    #if (!OPCUA_EXCLUDE_OPENSCSAggregationDataType)
    /// <summary>
    /// Iidentifies a parent element and a collection of packed elements. This is used in the aggregation packing and unpacking methods.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class OPENSCSAggregationDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OPENSCSAggregationDataType()
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
            m_parentElement = new OPENSCSLabelDataType();
            m_parentElementCollection = new OPENSCSLabelCollectionDataType();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Identifies the single serial number representing the aggregation which acts as the parent
        /// </summary>
        [DataMember(Name = "ParentElement", IsRequired = false, Order = 1)]
        public OPENSCSLabelDataType ParentElement
        {
            get
            {
                return m_parentElement;
            }

            set
            {
                m_parentElement = value;

                if (value == null)
                {
                    m_parentElement = new OPENSCSLabelDataType();
                }
            }
        }

        /// <summary>
        /// Identifies the Serial Number Collection that was added to, or removed from, the parent element.
        /// </summary>
        [DataMember(Name = "ParentElementCollection", IsRequired = false, Order = 2)]
        public OPENSCSLabelCollectionDataType ParentElementCollection
        {
            get
            {
                return m_parentElementCollection;
            }

            set
            {
                m_parentElementCollection = value;

                if (value == null)
                {
                    m_parentElementCollection = new OPENSCSLabelCollectionDataType();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OPENSCSAggregationDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OPENSCSAggregationDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OPENSCSAggregationDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteEncodeable("ParentElement", ParentElement, typeof(OPENSCSLabelDataType));
            encoder.WriteEncodeable("ParentElementCollection", ParentElementCollection, typeof(OPENSCSLabelCollectionDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ParentElement = (OPENSCSLabelDataType)decoder.ReadEncodeable("ParentElement", typeof(OPENSCSLabelDataType));
            ParentElementCollection = (OPENSCSLabelCollectionDataType)decoder.ReadEncodeable("ParentElementCollection", typeof(OPENSCSLabelCollectionDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OPENSCSAggregationDataType value = encodeable as OPENSCSAggregationDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_parentElement, value.m_parentElement)) return false;
            if (!Utils.IsEqual(m_parentElementCollection, value.m_parentElementCollection)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (OPENSCSAggregationDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSAggregationDataType clone = (OPENSCSAggregationDataType)base.MemberwiseClone();

            clone.m_parentElement = (OPENSCSLabelDataType)Utils.Clone(this.m_parentElement);
            clone.m_parentElementCollection = (OPENSCSLabelCollectionDataType)Utils.Clone(this.m_parentElementCollection);

            return clone;
        }
        #endregion

        #region Private Fields
        private OPENSCSLabelDataType m_parentElement;
        private OPENSCSLabelCollectionDataType m_parentElementCollection;
        #endregion
    }

    #region OPENSCSAggregationDataTypeCollection Class
    /// <summary>
    /// A collection of OPENSCSAggregationDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSAggregationDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSAggregationDataType")]
    #if !NET_STANDARD
    public partial class OPENSCSAggregationDataTypeCollection : List<OPENSCSAggregationDataType>, ICloneable
    #else
    public partial class OPENSCSAggregationDataTypeCollection : List<OPENSCSAggregationDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSAggregationDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSAggregationDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSAggregationDataTypeCollection(IEnumerable<OPENSCSAggregationDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSAggregationDataTypeCollection(OPENSCSAggregationDataType[] values)
        {
            if (values != null)
            {
                return new OPENSCSAggregationDataTypeCollection(values);
            }

            return new OPENSCSAggregationDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSAggregationDataType[](OPENSCSAggregationDataTypeCollection values)
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
            return (OPENSCSAggregationDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSAggregationDataTypeCollection clone = new OPENSCSAggregationDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSAggregationDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSCollectionDataType Class
    #if (!OPCUA_EXCLUDE_OPENSCSCollectionDataType)
    /// <summary>
    /// A description for the OPENSCSCollectionDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class OPENSCSCollectionDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OPENSCSCollectionDataType()
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
            m_state = OPENSCSSerialNumberStateEnum.Unassigned0;
            m_associatedPoolID = null;
            m_serialNumbers = new StringCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// An identification of the Collection. It usually refers to a specific packaging level of a specific product.
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// Additional information and description about the Collection.
        /// </summary>
        [DataMember(Name = "Description", IsRequired = false, Order = 2)]
        public string Description
        {
            get { return m_description;  }
            set { m_description = value; }
        }

        /// <summary>
        /// State of the Serial Numbers in the Collection. 
        /// </summary>
        [DataMember(Name = "State", IsRequired = false, Order = 3)]
        public OPENSCSSerialNumberStateEnum State
        {
            get { return m_state;  }
            set { m_state = value; }
        }

        /// <summary>
        /// An identification of the Serial Number Pool from which the Serial Numbers were obtained. 
        /// </summary>
        [DataMember(Name = "AssociatedPoolID", IsRequired = false, Order = 4)]
        public string AssociatedPoolID
        {
            get { return m_associatedPoolID;  }
            set { m_associatedPoolID = value; }
        }

        /// <summary>
        /// Array of Serial Numbers in the collection.
        /// </summary>
        [DataMember(Name = "SerialNumbers", IsRequired = false, Order = 5)]
        public StringCollection SerialNumbers
        {
            get
            {
                return m_serialNumbers;
            }

            set
            {
                m_serialNumbers = value;

                if (value == null)
                {
                    m_serialNumbers = new StringCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OPENSCSCollectionDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OPENSCSCollectionDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OPENSCSCollectionDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteString("Description", Description);
            encoder.WriteEnumerated("State", State);
            encoder.WriteString("AssociatedPoolID", AssociatedPoolID);
            encoder.WriteStringArray("SerialNumbers", SerialNumbers);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            Description = decoder.ReadString("Description");
            State = (OPENSCSSerialNumberStateEnum)decoder.ReadEnumerated("State", typeof(OPENSCSSerialNumberStateEnum));
            AssociatedPoolID = decoder.ReadString("AssociatedPoolID");
            SerialNumbers = decoder.ReadStringArray("SerialNumbers");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OPENSCSCollectionDataType value = encodeable as OPENSCSCollectionDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_description, value.m_description)) return false;
            if (!Utils.IsEqual(m_state, value.m_state)) return false;
            if (!Utils.IsEqual(m_associatedPoolID, value.m_associatedPoolID)) return false;
            if (!Utils.IsEqual(m_serialNumbers, value.m_serialNumbers)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (OPENSCSCollectionDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSCollectionDataType clone = (OPENSCSCollectionDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_description = (string)Utils.Clone(this.m_description);
            clone.m_state = (OPENSCSSerialNumberStateEnum)Utils.Clone(this.m_state);
            clone.m_associatedPoolID = (string)Utils.Clone(this.m_associatedPoolID);
            clone.m_serialNumbers = (StringCollection)Utils.Clone(this.m_serialNumbers);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private string m_description;
        private OPENSCSSerialNumberStateEnum m_state;
        private string m_associatedPoolID;
        private StringCollection m_serialNumbers;
        #endregion
    }

    #region OPENSCSCollectionDataTypeCollection Class
    /// <summary>
    /// A collection of OPENSCSCollectionDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSCollectionDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSCollectionDataType")]
    #if !NET_STANDARD
    public partial class OPENSCSCollectionDataTypeCollection : List<OPENSCSCollectionDataType>, ICloneable
    #else
    public partial class OPENSCSCollectionDataTypeCollection : List<OPENSCSCollectionDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSCollectionDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSCollectionDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSCollectionDataTypeCollection(IEnumerable<OPENSCSCollectionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSCollectionDataTypeCollection(OPENSCSCollectionDataType[] values)
        {
            if (values != null)
            {
                return new OPENSCSCollectionDataTypeCollection(values);
            }

            return new OPENSCSCollectionDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSCollectionDataType[](OPENSCSCollectionDataTypeCollection values)
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
            return (OPENSCSCollectionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSCollectionDataTypeCollection clone = new OPENSCSCollectionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSCollectionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSLabelCollectionDataType Class
    #if (!OPCUA_EXCLUDE_OPENSCSLabelCollectionDataType)
    /// <summary>
    /// A description for the OPENSCSLabelCollectionDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class OPENSCSLabelCollectionDataType : OPENSCSCollectionDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OPENSCSLabelCollectionDataType()
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
            m_labelCollection = new OPENSCSLabelDataTypeCollection();
            m_labelCollectionProperties = new OPENSCSKeyValueDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// The collections of labels with serial numbers.
        /// </summary>
        [DataMember(Name = "LabelCollection", IsRequired = false, Order = 1)]
        public OPENSCSLabelDataTypeCollection LabelCollection
        {
            get
            {
                return m_labelCollection;
            }

            set
            {
                m_labelCollection = value;

                if (value == null)
                {
                    m_labelCollection = new OPENSCSLabelDataTypeCollection();
                }
            }
        }

        /// <summary>
        /// An optional array of additional properties in the form of Key/Value pairs which are valid for the whole collection.
        /// </summary>
        [DataMember(Name = "LabelCollectionProperties", IsRequired = false, Order = 2)]
        public OPENSCSKeyValueDataTypeCollection LabelCollectionProperties
        {
            get
            {
                return m_labelCollectionProperties;
            }

            set
            {
                m_labelCollectionProperties = value;

                if (value == null)
                {
                    m_labelCollectionProperties = new OPENSCSKeyValueDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OPENSCSLabelCollectionDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OPENSCSLabelCollectionDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OPENSCSLabelCollectionDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteEncodeableArray("LabelCollection", LabelCollection.ToArray(), typeof(OPENSCSLabelDataType));
            encoder.WriteEncodeableArray("LabelCollectionProperties", LabelCollectionProperties.ToArray(), typeof(OPENSCSKeyValueDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            LabelCollection = (OPENSCSLabelDataTypeCollection)decoder.ReadEncodeableArray("LabelCollection", typeof(OPENSCSLabelDataType));
            LabelCollectionProperties = (OPENSCSKeyValueDataTypeCollection)decoder.ReadEncodeableArray("LabelCollectionProperties", typeof(OPENSCSKeyValueDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OPENSCSLabelCollectionDataType value = encodeable as OPENSCSLabelCollectionDataType;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;
            if (!Utils.IsEqual(m_labelCollection, value.m_labelCollection)) return false;
            if (!Utils.IsEqual(m_labelCollectionProperties, value.m_labelCollectionProperties)) return false;

            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (OPENSCSLabelCollectionDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSLabelCollectionDataType clone = (OPENSCSLabelCollectionDataType)base.MemberwiseClone();

            clone.m_labelCollection = (OPENSCSLabelDataTypeCollection)Utils.Clone(this.m_labelCollection);
            clone.m_labelCollectionProperties = (OPENSCSKeyValueDataTypeCollection)Utils.Clone(this.m_labelCollectionProperties);

            return clone;
        }
        #endregion

        #region Private Fields
        private OPENSCSLabelDataTypeCollection m_labelCollection;
        private OPENSCSKeyValueDataTypeCollection m_labelCollectionProperties;
        #endregion
    }

    #region OPENSCSLabelCollectionDataTypeCollection Class
    /// <summary>
    /// A collection of OPENSCSLabelCollectionDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSLabelCollectionDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSLabelCollectionDataType")]
    #if !NET_STANDARD
    public partial class OPENSCSLabelCollectionDataTypeCollection : List<OPENSCSLabelCollectionDataType>, ICloneable
    #else
    public partial class OPENSCSLabelCollectionDataTypeCollection : List<OPENSCSLabelCollectionDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSLabelCollectionDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSLabelCollectionDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSLabelCollectionDataTypeCollection(IEnumerable<OPENSCSLabelCollectionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSLabelCollectionDataTypeCollection(OPENSCSLabelCollectionDataType[] values)
        {
            if (values != null)
            {
                return new OPENSCSLabelCollectionDataTypeCollection(values);
            }

            return new OPENSCSLabelCollectionDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSLabelCollectionDataType[](OPENSCSLabelCollectionDataTypeCollection values)
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
            return (OPENSCSLabelCollectionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSLabelCollectionDataTypeCollection clone = new OPENSCSLabelCollectionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSLabelCollectionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSSNCollectionDataType Class
    #if (!OPCUA_EXCLUDE_OPENSCSSNCollectionDataType)
    /// <summary>
    /// A description for the OPENSCSSNCollectionDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class OPENSCSSNCollectionDataType : OPENSCSCollectionDataType
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OPENSCSSNCollectionDataType()
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
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OPENSCSSNCollectionDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OPENSCSSNCollectionDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OPENSCSSNCollectionDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OPENSCSSNCollectionDataType value = encodeable as OPENSCSSNCollectionDataType;

            if (value == null)
            {
                return false;
            }


            return true;
        }    

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (OPENSCSSNCollectionDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSSNCollectionDataType clone = (OPENSCSSNCollectionDataType)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region OPENSCSSNCollectionDataTypeCollection Class
    /// <summary>
    /// A collection of OPENSCSSNCollectionDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSSNCollectionDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSSNCollectionDataType")]
    #if !NET_STANDARD
    public partial class OPENSCSSNCollectionDataTypeCollection : List<OPENSCSSNCollectionDataType>, ICloneable
    #else
    public partial class OPENSCSSNCollectionDataTypeCollection : List<OPENSCSSNCollectionDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSSNCollectionDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSSNCollectionDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSSNCollectionDataTypeCollection(IEnumerable<OPENSCSSNCollectionDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSSNCollectionDataTypeCollection(OPENSCSSNCollectionDataType[] values)
        {
            if (values != null)
            {
                return new OPENSCSSNCollectionDataTypeCollection(values);
            }

            return new OPENSCSSNCollectionDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSSNCollectionDataType[](OPENSCSSNCollectionDataTypeCollection values)
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
            return (OPENSCSSNCollectionDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSSNCollectionDataTypeCollection clone = new OPENSCSSNCollectionDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSSNCollectionDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSEventStreamArgumentDataType Class
    #if (!OPCUA_EXCLUDE_OPENSCSEventStreamArgumentDataType)
    /// <summary>
    /// Defines the generateOptions argument for an EPCISStream GenerateFileForWrite method. It defines the serial number format information for object events and for aggregation events, and event context information.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class OPENSCSEventStreamArgumentDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OPENSCSEventStreamArgumentDataType()
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
            m_sNFormat = null;
            m_parentSNFormat = null;
            m_packedElementSNFormat = null;
            m_eventContext = new OPENSCSKeyValueDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// The format for of serial numbers in object events, can be a null string if there are no object events in the transferred events.
        /// </summary>
        [DataMember(Name = "SNFormat", IsRequired = false, Order = 1)]
        public string SNFormat
        {
            get { return m_sNFormat;  }
            set { m_sNFormat = value; }
        }

        /// <summary>
        /// The format for of parent serial numbers in aggregation events, can be a null string if there are no aggregation events in the transferred events.
        /// </summary>
        [DataMember(Name = "ParentSNFormat", IsRequired = false, Order = 2)]
        public string ParentSNFormat
        {
            get { return m_parentSNFormat;  }
            set { m_parentSNFormat = value; }
        }

        /// <summary>
        /// The format for of packed element serial numbers in aggregation events, can be a null string if there are no aggregation events in the transferred events.
        /// </summary>
        [DataMember(Name = "PackedElementSNFormat", IsRequired = false, Order = 3)]
        public string PackedElementSNFormat
        {
            get { return m_packedElementSNFormat;  }
            set { m_packedElementSNFormat = value; }
        }

        /// <summary>
        /// Zero or more key value pairs that define additional context information for the event, such as order number or lot number.
        /// </summary>
        [DataMember(Name = "EventContext", IsRequired = false, Order = 4)]
        public OPENSCSKeyValueDataTypeCollection EventContext
        {
            get
            {
                return m_eventContext;
            }

            set
            {
                m_eventContext = value;

                if (value == null)
                {
                    m_eventContext = new OPENSCSKeyValueDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OPENSCSEventStreamArgumentDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OPENSCSEventStreamArgumentDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OPENSCSEventStreamArgumentDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("SNFormat", SNFormat);
            encoder.WriteString("ParentSNFormat", ParentSNFormat);
            encoder.WriteString("PackedElementSNFormat", PackedElementSNFormat);
            encoder.WriteEncodeableArray("EventContext", EventContext.ToArray(), typeof(OPENSCSKeyValueDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            SNFormat = decoder.ReadString("SNFormat");
            ParentSNFormat = decoder.ReadString("ParentSNFormat");
            PackedElementSNFormat = decoder.ReadString("PackedElementSNFormat");
            EventContext = (OPENSCSKeyValueDataTypeCollection)decoder.ReadEncodeableArray("EventContext", typeof(OPENSCSKeyValueDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OPENSCSEventStreamArgumentDataType value = encodeable as OPENSCSEventStreamArgumentDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_sNFormat, value.m_sNFormat)) return false;
            if (!Utils.IsEqual(m_parentSNFormat, value.m_parentSNFormat)) return false;
            if (!Utils.IsEqual(m_packedElementSNFormat, value.m_packedElementSNFormat)) return false;
            if (!Utils.IsEqual(m_eventContext, value.m_eventContext)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (OPENSCSEventStreamArgumentDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSEventStreamArgumentDataType clone = (OPENSCSEventStreamArgumentDataType)base.MemberwiseClone();

            clone.m_sNFormat = (string)Utils.Clone(this.m_sNFormat);
            clone.m_parentSNFormat = (string)Utils.Clone(this.m_parentSNFormat);
            clone.m_packedElementSNFormat = (string)Utils.Clone(this.m_packedElementSNFormat);
            clone.m_eventContext = (OPENSCSKeyValueDataTypeCollection)Utils.Clone(this.m_eventContext);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_sNFormat;
        private string m_parentSNFormat;
        private string m_packedElementSNFormat;
        private OPENSCSKeyValueDataTypeCollection m_eventContext;
        #endregion
    }

    #region OPENSCSEventStreamArgumentDataTypeCollection Class
    /// <summary>
    /// A collection of OPENSCSEventStreamArgumentDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSEventStreamArgumentDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSEventStreamArgumentDataType")]
    #if !NET_STANDARD
    public partial class OPENSCSEventStreamArgumentDataTypeCollection : List<OPENSCSEventStreamArgumentDataType>, ICloneable
    #else
    public partial class OPENSCSEventStreamArgumentDataTypeCollection : List<OPENSCSEventStreamArgumentDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSEventStreamArgumentDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSEventStreamArgumentDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSEventStreamArgumentDataTypeCollection(IEnumerable<OPENSCSEventStreamArgumentDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSEventStreamArgumentDataTypeCollection(OPENSCSEventStreamArgumentDataType[] values)
        {
            if (values != null)
            {
                return new OPENSCSEventStreamArgumentDataTypeCollection(values);
            }

            return new OPENSCSEventStreamArgumentDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSEventStreamArgumentDataType[](OPENSCSEventStreamArgumentDataTypeCollection values)
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
            return (OPENSCSEventStreamArgumentDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSEventStreamArgumentDataTypeCollection clone = new OPENSCSEventStreamArgumentDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSEventStreamArgumentDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSKeyValueDataType Class
    #if (!OPCUA_EXCLUDE_OPENSCSKeyValueDataType)
    /// <summary>
    /// A description for the OPENSCSKeyValueDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class OPENSCSKeyValueDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OPENSCSKeyValueDataType()
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
            m_key = null;
            m_value = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// A string defining the key for the pair
        /// </summary>
        [DataMember(Name = "Key", IsRequired = false, Order = 1)]
        public string Key
        {
            get { return m_key;  }
            set { m_key = value; }
        }

        /// <summary>
        /// A variant for the value of the pair structure
        /// </summary>
        [DataMember(Name = "Value", IsRequired = false, Order = 2)]
        public string Value
        {
            get { return m_value;  }
            set { m_value = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OPENSCSKeyValueDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OPENSCSKeyValueDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OPENSCSKeyValueDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("Key", Key);
            encoder.WriteString("Value", Value);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            Key = decoder.ReadString("Key");
            Value = decoder.ReadString("Value");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OPENSCSKeyValueDataType value = encodeable as OPENSCSKeyValueDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_key, value.m_key)) return false;
            if (!Utils.IsEqual(m_value, value.m_value)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (OPENSCSKeyValueDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSKeyValueDataType clone = (OPENSCSKeyValueDataType)base.MemberwiseClone();

            clone.m_key = (string)Utils.Clone(this.m_key);
            clone.m_value = (string)Utils.Clone(this.m_value);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_key;
        private string m_value;
        #endregion
    }

    #region OPENSCSKeyValueDataTypeCollection Class
    /// <summary>
    /// A collection of OPENSCSKeyValueDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSKeyValueDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSKeyValueDataType")]
    #if !NET_STANDARD
    public partial class OPENSCSKeyValueDataTypeCollection : List<OPENSCSKeyValueDataType>, ICloneable
    #else
    public partial class OPENSCSKeyValueDataTypeCollection : List<OPENSCSKeyValueDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSKeyValueDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSKeyValueDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSKeyValueDataTypeCollection(IEnumerable<OPENSCSKeyValueDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSKeyValueDataTypeCollection(OPENSCSKeyValueDataType[] values)
        {
            if (values != null)
            {
                return new OPENSCSKeyValueDataTypeCollection(values);
            }

            return new OPENSCSKeyValueDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSKeyValueDataType[](OPENSCSKeyValueDataTypeCollection values)
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
            return (OPENSCSKeyValueDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSKeyValueDataTypeCollection clone = new OPENSCSKeyValueDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSKeyValueDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSLabelDataType Class
    #if (!OPCUA_EXCLUDE_OPENSCSLabelDataType)
    /// <summary>
    /// Defines a single serial number and label, which may be associated with an SID, and collection of properties in the form of OPENSCSKeyValueDataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class OPENSCSLabelDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OPENSCSLabelDataType()
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
            m_labelProperties = new OPENSCSKeyValueDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// The serial number of the label in the SID or EPC format. 
        /// </summary>
        [DataMember(Name = "ID", IsRequired = false, Order = 1)]
        public string ID
        {
            get { return m_ıD;  }
            set { m_ıD = value; }
        }

        /// <summary>
        /// An optional array of additional properties in the form of Key/Value pairs
        /// </summary>
        [DataMember(Name = "LabelProperties", IsRequired = false, Order = 2)]
        public OPENSCSKeyValueDataTypeCollection LabelProperties
        {
            get
            {
                return m_labelProperties;
            }

            set
            {
                m_labelProperties = value;

                if (value == null)
                {
                    m_labelProperties = new OPENSCSKeyValueDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OPENSCSLabelDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OPENSCSLabelDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OPENSCSLabelDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("ID", ID);
            encoder.WriteEncodeableArray("LabelProperties", LabelProperties.ToArray(), typeof(OPENSCSKeyValueDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            ID = decoder.ReadString("ID");
            LabelProperties = (OPENSCSKeyValueDataTypeCollection)decoder.ReadEncodeableArray("LabelProperties", typeof(OPENSCSKeyValueDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OPENSCSLabelDataType value = encodeable as OPENSCSLabelDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_ıD, value.m_ıD)) return false;
            if (!Utils.IsEqual(m_labelProperties, value.m_labelProperties)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (OPENSCSLabelDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSLabelDataType clone = (OPENSCSLabelDataType)base.MemberwiseClone();

            clone.m_ıD = (string)Utils.Clone(this.m_ıD);
            clone.m_labelProperties = (OPENSCSKeyValueDataTypeCollection)Utils.Clone(this.m_labelProperties);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_ıD;
        private OPENSCSKeyValueDataTypeCollection m_labelProperties;
        #endregion
    }

    #region OPENSCSLabelDataTypeCollection Class
    /// <summary>
    /// A collection of OPENSCSLabelDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSLabelDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSLabelDataType")]
    #if !NET_STANDARD
    public partial class OPENSCSLabelDataTypeCollection : List<OPENSCSLabelDataType>, ICloneable
    #else
    public partial class OPENSCSLabelDataTypeCollection : List<OPENSCSLabelDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSLabelDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSLabelDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSLabelDataTypeCollection(IEnumerable<OPENSCSLabelDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSLabelDataTypeCollection(OPENSCSLabelDataType[] values)
        {
            if (values != null)
            {
                return new OPENSCSLabelDataTypeCollection(values);
            }

            return new OPENSCSLabelDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSLabelDataType[](OPENSCSLabelDataTypeCollection values)
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
            return (OPENSCSLabelDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSLabelDataTypeCollection clone = new OPENSCSLabelDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSLabelDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSLabelPropertyDataType Class
    #if (!OPCUA_EXCLUDE_OPENSCSLabelPropertyDataType)
    /// <summary>
    /// A description for the OPENSCSLabelPropertyDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class OPENSCSLabelPropertyDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OPENSCSLabelPropertyDataType()
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
            m_propertyID = null;
            m_propertyDescription = null;
            m_propertyValue = null;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// The identification of a property associated with a label.
        /// </summary>
        [DataMember(Name = "PropertyID", IsRequired = false, Order = 1)]
        public string PropertyID
        {
            get { return m_propertyID;  }
            set { m_propertyID = value; }
        }

        /// <summary>
        /// An optional description of the property associated with the label
        /// </summary>
        [DataMember(Name = "PropertyDescription", IsRequired = false, Order = 2)]
        public string PropertyDescription
        {
            get { return m_propertyDescription;  }
            set { m_propertyDescription = value; }
        }

        /// <summary>
        /// A value for the property, if defined this may be considered a default property value.
        /// </summary>
        [DataMember(Name = "PropertyValue", IsRequired = false, Order = 3)]
        public string PropertyValue
        {
            get { return m_propertyValue;  }
            set { m_propertyValue = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OPENSCSLabelPropertyDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OPENSCSLabelPropertyDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OPENSCSLabelPropertyDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("PropertyID", PropertyID);
            encoder.WriteString("PropertyDescription", PropertyDescription);
            encoder.WriteString("PropertyValue", PropertyValue);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            PropertyID = decoder.ReadString("PropertyID");
            PropertyDescription = decoder.ReadString("PropertyDescription");
            PropertyValue = decoder.ReadString("PropertyValue");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OPENSCSLabelPropertyDataType value = encodeable as OPENSCSLabelPropertyDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_propertyID, value.m_propertyID)) return false;
            if (!Utils.IsEqual(m_propertyDescription, value.m_propertyDescription)) return false;
            if (!Utils.IsEqual(m_propertyValue, value.m_propertyValue)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (OPENSCSLabelPropertyDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSLabelPropertyDataType clone = (OPENSCSLabelPropertyDataType)base.MemberwiseClone();

            clone.m_propertyID = (string)Utils.Clone(this.m_propertyID);
            clone.m_propertyDescription = (string)Utils.Clone(this.m_propertyDescription);
            clone.m_propertyValue = (string)Utils.Clone(this.m_propertyValue);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_propertyID;
        private string m_propertyDescription;
        private string m_propertyValue;
        #endregion
    }

    #region OPENSCSLabelPropertyDataTypeCollection Class
    /// <summary>
    /// A collection of OPENSCSLabelPropertyDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSLabelPropertyDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSLabelPropertyDataType")]
    #if !NET_STANDARD
    public partial class OPENSCSLabelPropertyDataTypeCollection : List<OPENSCSLabelPropertyDataType>, ICloneable
    #else
    public partial class OPENSCSLabelPropertyDataTypeCollection : List<OPENSCSLabelPropertyDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSLabelPropertyDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSLabelPropertyDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSLabelPropertyDataTypeCollection(IEnumerable<OPENSCSLabelPropertyDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSLabelPropertyDataTypeCollection(OPENSCSLabelPropertyDataType[] values)
        {
            if (values != null)
            {
                return new OPENSCSLabelPropertyDataTypeCollection(values);
            }

            return new OPENSCSLabelPropertyDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSLabelPropertyDataType[](OPENSCSLabelPropertyDataTypeCollection values)
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
            return (OPENSCSLabelPropertyDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSLabelPropertyDataTypeCollection clone = new OPENSCSLabelPropertyDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSLabelPropertyDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSSIDClassPropertyDataType Class
    #if (!OPCUA_EXCLUDE_OPENSCSSIDClassPropertyDataType)
    /// <summary>
    /// A description for the OPENSCSSIDClassPropertyDataType DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class OPENSCSSIDClassPropertyDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public OPENSCSSIDClassPropertyDataType()
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
            m_propertyID = null;
            m_propertyDescription = null;
            m_propertyValue = null;
            m_labelProperty = new OPENSCSLabelPropertyDataTypeCollection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// An identification of the SID Class Property.
        /// </summary>
        [DataMember(Name = "PropertyID", IsRequired = false, Order = 1)]
        public string PropertyID
        {
            get { return m_propertyID;  }
            set { m_propertyID = value; }
        }

        /// <summary>
        /// Additional information and description about the SID Class Property.
        /// </summary>
        [DataMember(Name = "PropertyDescription", IsRequired = false, Order = 2)]
        public string PropertyDescription
        {
            get { return m_propertyDescription;  }
            set { m_propertyDescription = value; }
        }

        /// <summary>
        /// Defines value for the specific SID Class Property. The format is not defined in this specification and must be negotiated between Information Providers and Information Requesters during design or change management of a system.
        /// </summary>
        [DataMember(Name = "PropertyValue", IsRequired = false, Order = 3)]
        public string PropertyValue
        {
            get { return m_propertyValue;  }
            set { m_propertyValue = value; }
        }

        /// <summary>
        /// An array of property elements, each of which may have associated label property definitions.
        /// </summary>
        [DataMember(Name = "LabelProperty", IsRequired = false, Order = 4)]
        public OPENSCSLabelPropertyDataTypeCollection LabelProperty
        {
            get
            {
                return m_labelProperty;
            }

            set
            {
                m_labelProperty = value;

                if (value == null)
                {
                    m_labelProperty = new OPENSCSLabelPropertyDataTypeCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OPENSCSSIDClassPropertyDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OPENSCSSIDClassPropertyDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OPENSCSSIDClassPropertyDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteString("PropertyID", PropertyID);
            encoder.WriteString("PropertyDescription", PropertyDescription);
            encoder.WriteString("PropertyValue", PropertyValue);
            encoder.WriteEncodeableArray("LabelProperty", LabelProperty.ToArray(), typeof(OPENSCSLabelPropertyDataType));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            PropertyID = decoder.ReadString("PropertyID");
            PropertyDescription = decoder.ReadString("PropertyDescription");
            PropertyValue = decoder.ReadString("PropertyValue");
            LabelProperty = (OPENSCSLabelPropertyDataTypeCollection)decoder.ReadEncodeableArray("LabelProperty", typeof(OPENSCSLabelPropertyDataType));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OPENSCSSIDClassPropertyDataType value = encodeable as OPENSCSSIDClassPropertyDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_propertyID, value.m_propertyID)) return false;
            if (!Utils.IsEqual(m_propertyDescription, value.m_propertyDescription)) return false;
            if (!Utils.IsEqual(m_propertyValue, value.m_propertyValue)) return false;
            if (!Utils.IsEqual(m_labelProperty, value.m_labelProperty)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (OPENSCSSIDClassPropertyDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSSIDClassPropertyDataType clone = (OPENSCSSIDClassPropertyDataType)base.MemberwiseClone();

            clone.m_propertyID = (string)Utils.Clone(this.m_propertyID);
            clone.m_propertyDescription = (string)Utils.Clone(this.m_propertyDescription);
            clone.m_propertyValue = (string)Utils.Clone(this.m_propertyValue);
            clone.m_labelProperty = (OPENSCSLabelPropertyDataTypeCollection)Utils.Clone(this.m_labelProperty);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_propertyID;
        private string m_propertyDescription;
        private string m_propertyValue;
        private OPENSCSLabelPropertyDataTypeCollection m_labelProperty;
        #endregion
    }

    #region OPENSCSSIDClassPropertyDataTypeCollection Class
    /// <summary>
    /// A collection of OPENSCSSIDClassPropertyDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfOPENSCSSIDClassPropertyDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "OPENSCSSIDClassPropertyDataType")]
    #if !NET_STANDARD
    public partial class OPENSCSSIDClassPropertyDataTypeCollection : List<OPENSCSSIDClassPropertyDataType>, ICloneable
    #else
    public partial class OPENSCSSIDClassPropertyDataTypeCollection : List<OPENSCSSIDClassPropertyDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OPENSCSSIDClassPropertyDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OPENSCSSIDClassPropertyDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OPENSCSSIDClassPropertyDataTypeCollection(IEnumerable<OPENSCSSIDClassPropertyDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OPENSCSSIDClassPropertyDataTypeCollection(OPENSCSSIDClassPropertyDataType[] values)
        {
            if (values != null)
            {
                return new OPENSCSSIDClassPropertyDataTypeCollection(values);
            }

            return new OPENSCSSIDClassPropertyDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OPENSCSSIDClassPropertyDataType[](OPENSCSSIDClassPropertyDataTypeCollection values)
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
            return (OPENSCSSIDClassPropertyDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OPENSCSSIDClassPropertyDataTypeCollection clone = new OPENSCSSIDClassPropertyDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OPENSCSSIDClassPropertyDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OPENSCSAggregationManagerObjectState Class
    #if (!OPCUA_EXCLUDE_OPENSCSAggregationManagerObjectState)
    /// <summary>
    /// Stores an instance of the OPENSCSAggregationManagerObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OPENSCSAggregationManagerObjectState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OPENSCSAggregationManagerObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.OPENSCSAggregationManagerObjectType, Prefix2.Namespaces.Name2, namespaceUris);
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
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRggAABAAAA" +
           "AQArAAAAT1BFTlNDU0FnZ3JlZ2F0aW9uTWFuYWdlck9iamVjdFR5cGVJbnN0YW5jZQEBFgABARYA////" +
           "/wMAAAAEYYIKBAAAAAEAFwAAAEFnZ3JlZ2F0aW9uUGFja2luZ0V2ZW50AQEXAAAvAQEXABcAAAABAf//" +
           "//8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBGAAALgBEGAAAAJYAAAAAAQAoAQEAAAAB" +
           "AAAABAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBGQAALgBEGQAAAJYA" +
           "AAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAGQAAAEFnZ3JlZ2F0aW9uVW5wYWNr" +
           "aW5nRXZlbnQBARoAAC8BARoAGgAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQEbAAAuAEQbAAAAlgAAAAABACgBAQAAAAEAAAAEAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0" +
           "cHV0QXJndW1lbnRzAQEcAAAuAEQcAAAAlgAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABVgiQoC" +
           "AAAAAQAUAAAATWF4QWdncmVnYXRpb25FdmVudHMBAR0AAC4ARB0AAAAAB/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the AggregationPackingEvent Method.
        /// </summary>
        public MethodState AggregationPackingEvent
        {
            get
            {
                return m_aggregationPackingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_aggregationPackingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_aggregationPackingEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the AggregationUnpackingEvent Method.
        /// </summary>
        public MethodState AggregationUnpackingEvent
        {
            get
            {
                return m_aggregationUnpackingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_aggregationUnpackingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_aggregationUnpackingEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the MaxAggregationEvents Property.
        /// </summary>
        public PropertyState<uint> MaxAggregationEvents
        {
            get
            {
                return m_maxAggregationEvents;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxAggregationEvents, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxAggregationEvents = value;
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
            if (m_aggregationPackingEventMethod != null)
            {
                children.Add(m_aggregationPackingEventMethod);
            }

            if (m_aggregationUnpackingEventMethod != null)
            {
                children.Add(m_aggregationUnpackingEventMethod);
            }

            if (m_maxAggregationEvents != null)
            {
                children.Add(m_maxAggregationEvents);
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
                case Prefix2.BrowseNames.AggregationPackingEvent:
                {
                    if (createOrReplace)
                    {
                        if (AggregationPackingEvent == null)
                        {
                            if (replacement == null)
                            {
                                AggregationPackingEvent = new MethodState(this);
                            }
                            else
                            {
                                AggregationPackingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = AggregationPackingEvent;
                    break;
                }

                case Prefix2.BrowseNames.AggregationUnpackingEvent:
                {
                    if (createOrReplace)
                    {
                        if (AggregationUnpackingEvent == null)
                        {
                            if (replacement == null)
                            {
                                AggregationUnpackingEvent = new MethodState(this);
                            }
                            else
                            {
                                AggregationUnpackingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = AggregationUnpackingEvent;
                    break;
                }

                case Prefix2.BrowseNames.MaxAggregationEvents:
                {
                    if (createOrReplace)
                    {
                        if (MaxAggregationEvents == null)
                        {
                            if (replacement == null)
                            {
                                MaxAggregationEvents = new PropertyState<uint>(this);
                            }
                            else
                            {
                                MaxAggregationEvents = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxAggregationEvents;
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
        private MethodState m_aggregationPackingEventMethod;
        private MethodState m_aggregationUnpackingEventMethod;
        private PropertyState<uint> m_maxAggregationEvents;
        #endregion
    }
    #endif
    #endregion

    #region OPENSCSEventManagerObjectState Class
    #if (!OPCUA_EXCLUDE_OPENSCSEventManagerObjectState)
    /// <summary>
    /// Stores an instance of the OPENSCSEventManagerObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OPENSCSEventManagerObjectState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OPENSCSEventManagerObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.OPENSCSEventManagerObjectType, Prefix2.Namespaces.Name2, namespaceUris);
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

            if (EPCISStream != null)
            {
                EPCISStream.Initialize(context, EPCISStream_InitializationString);
            }

            if (LabelsEncodingEvent != null)
            {
                LabelsEncodingEvent.Initialize(context, LabelsEncodingEvent_InitializationString);
            }

            if (LabelsInspectingEvent != null)
            {
                LabelsInspectingEvent.Initialize(context, LabelsInspectingEvent_InitializationString);
            }

            if (LabelsSamplingEvent != null)
            {
                LabelsSamplingEvent.Initialize(context, LabelsSamplingEvent_InitializationString);
            }

            if (LabelsScrappingEvent != null)
            {
                LabelsScrappingEvent.Initialize(context, LabelsScrappingEvent_InitializationString);
            }

            if (SIDCommissioningEvent != null)
            {
                SIDCommissioningEvent.Initialize(context, SIDCommissioningEvent_InitializationString);
            }

            if (SIDDecommissioningEvent != null)
            {
                SIDDecommissioningEvent.Initialize(context, SIDDecommissioningEvent_InitializationString);
            }

            if (SIDDestroyingEvent != null)
            {
                SIDDestroyingEvent.Initialize(context, SIDDestroyingEvent_InitializationString);
            }

            if (SIDInspectingEvent != null)
            {
                SIDInspectingEvent.Initialize(context, SIDInspectingEvent_InitializationString);
            }

            if (SIDShippingEvent != null)
            {
                SIDShippingEvent.Initialize(context, SIDShippingEvent_InitializationString);
            }

            if (SNInvalidatingEvent != null)
            {
                SNInvalidatingEvent.Initialize(context, SNInvalidatingEvent_InitializationString);
            }
        }

        #region Initialization String
        private const string EPCISStream_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRggAoBAAAA" +
           "AQALAAAARVBDSVNTdHJlYW0BAR8AAC8BAIA9HwAAAP////8EAAAAFWCJCgIAAAAAABcAAABDbGllbnRQ" +
           "cm9jZXNzaW5nVGltZW91dAEBIAAALgBEIAAAAAEAIgH/////AQH/////AAAAAARhggoEAAAAAAATAAAA" +
           "R2VuZXJhdGVGaWxlRm9yUmVhZAEBIQAALwEAgj0hAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5w" +
           "dXRBcmd1bWVudHMBASIAAC4ARCIAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBASMAAC4ARCMAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAABGGCCgQAAAAAABQAAABHZW5lcmF0ZUZpbGVGb3JXcml0ZQEBJAAALwEAhT0kAAAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBASUAAC4ARCUAAACWAAAAAAEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBASYAAC4ARCYAAACWAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAAAA4AAABDbG9zZUFuZENvbW1pdAEBJwAA" +
           "LwEAhz0nAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBASgAAC4ARCgAAACW" +
           "AAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "ASkAAC4ARCkAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";

        private const string LabelsEncodingEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQATAAAATGFiZWxzRW5jb2RpbmdFdmVudAEBKgAALwEBKgAqAAAAAQH/////AgAAABdgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBASsAAC4ARCsAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBASwAAC4ARCwAAACWAAAAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAA";

        private const string LabelsInspectingEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQAVAAAATGFiZWxzSW5zcGVjdGluZ0V2ZW50AQEtAAAvAQEtAC0AAAABAf////8CAAAAF2CpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBLgAALgBELgAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAA" +
           "AAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBLwAALgBELwAAAJYAAAAAAQAoAQEAAAABAAAA" +
           "AAAAAAEB/////wAAAAA=";

        private const string LabelsSamplingEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQATAAAATGFiZWxzU2FtcGxpbmdFdmVudAEBMAAALwEBMAAwAAAAAQH/////AgAAABdgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBATEAAC4ARDEAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBATIAAC4ARDIAAACWAAAAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAA";

        private const string LabelsScrappingEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQAUAAAATGFiZWxzU2NyYXBwaW5nRXZlbnQBATMAAC8BATMAMwAAAAEB/////wIAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQE0AAAuAEQ0AAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "ABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE1AAAuAEQ1AAAAlgAAAAABACgBAQAAAAEAAAAA" +
           "AAAAAQH/////AAAAAA==";

        private const string SIDCommissioningEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQAVAAAAU0lEQ29tbWlzc2lvbmluZ0V2ZW50AQE5AAAvAQE5ADkAAAABAf////8CAAAAF2CpCgIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBOgAALgBEOgAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAA" +
           "AAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBOwAALgBEOwAAAJYAAAAAAQAoAQEAAAABAAAA" +
           "AAAAAAEB/////wAAAAA=";

        private const string SIDDecommissioningEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQAXAAAAU0lERGVjb21taXNzaW9uaW5nRXZlbnQBATwAAC8BATwAPAAAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQE9AAAuAEQ9AAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE+AAAuAEQ+AAAAlgAAAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAAA==";

        private const string SIDDestroyingEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQASAAAAU0lERGVzdHJveWluZ0V2ZW50AQE/AAAvAQE/AD8AAAABAf////8CAAAAF2CpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBQAAALgBEQAAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBQQAALgBEQQAAAJYAAAAAAQAoAQEAAAABAAAAAAAA" +
           "AAEB/////wAAAAA=";

        private const string SIDInspectingEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQASAAAAU0lESW5zcGVjdGluZ0V2ZW50AQFCAAAvAQFCAEIAAAABAf////8CAAAAF2CpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBQwAALgBEQwAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAX" +
           "YKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBRAAALgBERAAAAJYAAAAAAQAoAQEAAAABAAAAAAAA" +
           "AAEB/////wAAAAA=";

        private const string SIDShippingEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQAQAAAAU0lEU2hpcHBpbmdFdmVudAEBRQAALwEBRQBFAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBAUYAAC4AREYAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUcAAC4AREcAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAAB" +
           "Af////8AAAAA";

        private const string SNInvalidatingEvent_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRhggoEAAAA" +
           "AQATAAAAU05JbnZhbGlkYXRpbmdFdmVudAEBSAAALwEBSABIAAAAAQH/////AgAAABdgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBAUkAAC4AREkAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUoAAC4AREoAAACWAAAAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAA";

        private const string InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRggAABAAAA" +
           "AQAlAAAAT1BFTlNDU0V2ZW50TWFuYWdlck9iamVjdFR5cGVJbnN0YW5jZQEBHgABAR4A/////w4AAAAE" +
           "YIAKAQAAAAEACwAAAEVQQ0lTU3RyZWFtAQEfAAAvAQCAPR8AAAD/////BAAAABVgiQoCAAAAAAAXAAAA" +
           "Q2xpZW50UHJvY2Vzc2luZ1RpbWVvdXQBASAAAC4ARCAAAAABACIB/////wEB/////wAAAAAEYYIKBAAA" +
           "AAAAEwAAAEdlbmVyYXRlRmlsZUZvclJlYWQBASEAAC8BAII9IQAAAAEB/////wIAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQEiAAAuAEQiAAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "ABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEjAAAuAEQjAAAAlgAAAAABACgBAQAAAAEAAAAA" +
           "AAAAAQH/////AAAAAARhggoEAAAAAAAUAAAAR2VuZXJhdGVGaWxlRm9yV3JpdGUBASQAAC8BAIU9JAAA" +
           "AAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQElAAAuAEQlAAAAlgAAAAABACgB" +
           "AQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEmAAAuAEQm" +
           "AAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAAAOAAAAQ2xvc2VBbmRDb21t" +
           "aXQBAScAAC8BAIc9JwAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEoAAAu" +
           "AEQoAAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJn" +
           "dW1lbnRzAQEpAAAuAEQpAAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAT" +
           "AAAATGFiZWxzRW5jb2RpbmdFdmVudAEBKgAALwEBKgAqAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBASsAAC4ARCsAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBASwAAC4ARCwAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAAB" +
           "Af////8AAAAABGGCCgQAAAABABUAAABMYWJlbHNJbnNwZWN0aW5nRXZlbnQBAS0AAC8BAS0ALQAAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEuAAAuAEQuAAAAlgAAAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEvAAAuAEQvAAAA" +
           "lgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQATAAAATGFiZWxzU2FtcGxpbmdF" +
           "dmVudAEBMAAALwEBMAAwAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBATEA" +
           "AC4ARDEAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBATIAAC4ARDIAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAB" +
           "ABQAAABMYWJlbHNTY3JhcHBpbmdFdmVudAEBMwAALwEBMwAzAAAAAQH/////AgAAABdgqQoCAAAAAAAO" +
           "AAAASW5wdXRBcmd1bWVudHMBATQAAC4ARDQAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBATUAAC4ARDUAAACWAAAAAAEAKAEBAAAAAQAAAAAA" +
           "AAABAf////8AAAAAFWCJCgIAAAABABkAAABNYXhFUENJU2FnZ3JlZ2F0aW9uRXZlbnRzAQE2AAAuAEQ2" +
           "AAAAAAf/////AwP/////AAAAABVgiQoCAAAAAQAXAAAATWF4RVBDSVNPYmplY3RFdmVudFNJRHMBATcA" +
           "AC4ARDcAAAAAB/////8DA/////8AAAAAFWCJCgIAAAABAAkAAABNYXhFdmVudHMBATgAAC4ARDgAAAAA" +
           "B/////8BAf////8AAAAABGGCCgQAAAABABUAAABTSURDb21taXNzaW9uaW5nRXZlbnQBATkAAC8BATkA" +
           "OQAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE6AAAuAEQ6AAAAlgAAAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQE7AAAu" +
           "AEQ7AAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQAXAAAAU0lERGVjb21t" +
           "aXNzaW9uaW5nRXZlbnQBATwAAC8BATwAPAAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQE9AAAuAEQ9AAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQE+AAAuAEQ+AAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "AARhggoEAAAAAQASAAAAU0lERGVzdHJveWluZ0V2ZW50AQE/AAAvAQE/AD8AAAABAf////8CAAAAF2Cp" +
           "CgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBQAAALgBEQAAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBQQAALgBEQQAAAJYAAAAAAQAoAQEA" +
           "AAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAEgAAAFNJREluc3BlY3RpbmdFdmVudAEBQgAALwEB" +
           "QgBCAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAUMAAC4AREMAAACWAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUQA" +
           "AC4AREQAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABAAAABTSURTaGlw" +
           "cGluZ0V2ZW50AQFFAAAvAQFFAEUAAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBRgAALgBERgAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEBRwAALgBERwAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAEAEwAAAFNOSW52YWxpZGF0aW5nRXZlbnQBAUgAAC8BAUgASAAAAAEB/////wIAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQFJAAAuAERJAAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFKAAAuAERKAAAAlgAAAAABACgBAQAAAAEA" +
           "AAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the EPCISStream Object.
        /// </summary>
        public TemporaryFileTransferState EPCISStream
        {
            get
            {
                return m_ePCISStream;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ePCISStream, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ePCISStream = value;
            }
        }

        /// <summary>
        /// A description for the LabelsEncodingEvent Method.
        /// </summary>
        public MethodState LabelsEncodingEvent
        {
            get
            {
                return m_labelsEncodingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_labelsEncodingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_labelsEncodingEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the LabelsInspectingEvent Method.
        /// </summary>
        public MethodState LabelsInspectingEvent
        {
            get
            {
                return m_labelsInspectingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_labelsInspectingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_labelsInspectingEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the LabelsSamplingEvent Method.
        /// </summary>
        public MethodState LabelsSamplingEvent
        {
            get
            {
                return m_labelsSamplingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_labelsSamplingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_labelsSamplingEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the LabelsScrappingEvent Method.
        /// </summary>
        public MethodState LabelsScrappingEvent
        {
            get
            {
                return m_labelsScrappingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_labelsScrappingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_labelsScrappingEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the MaxEPCISaggregationEvents Property.
        /// </summary>
        public PropertyState<uint> MaxEPCISaggregationEvents
        {
            get
            {
                return m_maxEPCISaggregationEvents;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxEPCISaggregationEvents, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxEPCISaggregationEvents = value;
            }
        }

        /// <summary>
        /// A description for the MaxEPCISObjectEventSIDs Property.
        /// </summary>
        public PropertyState<uint> MaxEPCISObjectEventSIDs
        {
            get
            {
                return m_maxEPCISObjectEventSIDs;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxEPCISObjectEventSIDs, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxEPCISObjectEventSIDs = value;
            }
        }

        /// <summary>
        /// A description for the MaxEvents Property.
        /// </summary>
        public PropertyState<uint> MaxEvents
        {
            get
            {
                return m_maxEvents;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxEvents, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxEvents = value;
            }
        }

        /// <summary>
        /// A description for the SIDCommissioningEvent Method.
        /// </summary>
        public MethodState SIDCommissioningEvent
        {
            get
            {
                return m_sIDCommissioningEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIDCommissioningEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIDCommissioningEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the SIDDecommissioningEvent Method.
        /// </summary>
        public MethodState SIDDecommissioningEvent
        {
            get
            {
                return m_sIDDecommissioningEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIDDecommissioningEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIDDecommissioningEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the SIDDestroyingEvent Method.
        /// </summary>
        public MethodState SIDDestroyingEvent
        {
            get
            {
                return m_sIDDestroyingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIDDestroyingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIDDestroyingEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the SIDInspectingEvent Method.
        /// </summary>
        public MethodState SIDInspectingEvent
        {
            get
            {
                return m_sIDInspectingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIDInspectingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIDInspectingEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the SIDShippingEvent Method.
        /// </summary>
        public MethodState SIDShippingEvent
        {
            get
            {
                return m_sIDShippingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIDShippingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIDShippingEventMethod = value;
            }
        }

        /// <summary>
        /// A description for the SNInvalidatingEvent Method.
        /// </summary>
        public MethodState SNInvalidatingEvent
        {
            get
            {
                return m_sNInvalidatingEventMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNInvalidatingEventMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNInvalidatingEventMethod = value;
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
            if (m_ePCISStream != null)
            {
                children.Add(m_ePCISStream);
            }

            if (m_labelsEncodingEventMethod != null)
            {
                children.Add(m_labelsEncodingEventMethod);
            }

            if (m_labelsInspectingEventMethod != null)
            {
                children.Add(m_labelsInspectingEventMethod);
            }

            if (m_labelsSamplingEventMethod != null)
            {
                children.Add(m_labelsSamplingEventMethod);
            }

            if (m_labelsScrappingEventMethod != null)
            {
                children.Add(m_labelsScrappingEventMethod);
            }

            if (m_maxEPCISaggregationEvents != null)
            {
                children.Add(m_maxEPCISaggregationEvents);
            }

            if (m_maxEPCISObjectEventSIDs != null)
            {
                children.Add(m_maxEPCISObjectEventSIDs);
            }

            if (m_maxEvents != null)
            {
                children.Add(m_maxEvents);
            }

            if (m_sIDCommissioningEventMethod != null)
            {
                children.Add(m_sIDCommissioningEventMethod);
            }

            if (m_sIDDecommissioningEventMethod != null)
            {
                children.Add(m_sIDDecommissioningEventMethod);
            }

            if (m_sIDDestroyingEventMethod != null)
            {
                children.Add(m_sIDDestroyingEventMethod);
            }

            if (m_sIDInspectingEventMethod != null)
            {
                children.Add(m_sIDInspectingEventMethod);
            }

            if (m_sIDShippingEventMethod != null)
            {
                children.Add(m_sIDShippingEventMethod);
            }

            if (m_sNInvalidatingEventMethod != null)
            {
                children.Add(m_sNInvalidatingEventMethod);
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
                case Prefix2.BrowseNames.EPCISStream:
                {
                    if (createOrReplace)
                    {
                        if (EPCISStream == null)
                        {
                            if (replacement == null)
                            {
                                EPCISStream = new TemporaryFileTransferState(this);
                            }
                            else
                            {
                                EPCISStream = (TemporaryFileTransferState)replacement;
                            }
                        }
                    }

                    instance = EPCISStream;
                    break;
                }

                case Prefix2.BrowseNames.LabelsEncodingEvent:
                {
                    if (createOrReplace)
                    {
                        if (LabelsEncodingEvent == null)
                        {
                            if (replacement == null)
                            {
                                LabelsEncodingEvent = new MethodState(this);
                            }
                            else
                            {
                                LabelsEncodingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = LabelsEncodingEvent;
                    break;
                }

                case Prefix2.BrowseNames.LabelsInspectingEvent:
                {
                    if (createOrReplace)
                    {
                        if (LabelsInspectingEvent == null)
                        {
                            if (replacement == null)
                            {
                                LabelsInspectingEvent = new MethodState(this);
                            }
                            else
                            {
                                LabelsInspectingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = LabelsInspectingEvent;
                    break;
                }

                case Prefix2.BrowseNames.LabelsSamplingEvent:
                {
                    if (createOrReplace)
                    {
                        if (LabelsSamplingEvent == null)
                        {
                            if (replacement == null)
                            {
                                LabelsSamplingEvent = new MethodState(this);
                            }
                            else
                            {
                                LabelsSamplingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = LabelsSamplingEvent;
                    break;
                }

                case Prefix2.BrowseNames.LabelsScrappingEvent:
                {
                    if (createOrReplace)
                    {
                        if (LabelsScrappingEvent == null)
                        {
                            if (replacement == null)
                            {
                                LabelsScrappingEvent = new MethodState(this);
                            }
                            else
                            {
                                LabelsScrappingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = LabelsScrappingEvent;
                    break;
                }

                case Prefix2.BrowseNames.MaxEPCISaggregationEvents:
                {
                    if (createOrReplace)
                    {
                        if (MaxEPCISaggregationEvents == null)
                        {
                            if (replacement == null)
                            {
                                MaxEPCISaggregationEvents = new PropertyState<uint>(this);
                            }
                            else
                            {
                                MaxEPCISaggregationEvents = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxEPCISaggregationEvents;
                    break;
                }

                case Prefix2.BrowseNames.MaxEPCISObjectEventSIDs:
                {
                    if (createOrReplace)
                    {
                        if (MaxEPCISObjectEventSIDs == null)
                        {
                            if (replacement == null)
                            {
                                MaxEPCISObjectEventSIDs = new PropertyState<uint>(this);
                            }
                            else
                            {
                                MaxEPCISObjectEventSIDs = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxEPCISObjectEventSIDs;
                    break;
                }

                case Prefix2.BrowseNames.MaxEvents:
                {
                    if (createOrReplace)
                    {
                        if (MaxEvents == null)
                        {
                            if (replacement == null)
                            {
                                MaxEvents = new PropertyState<uint>(this);
                            }
                            else
                            {
                                MaxEvents = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxEvents;
                    break;
                }

                case Prefix2.BrowseNames.SIDCommissioningEvent:
                {
                    if (createOrReplace)
                    {
                        if (SIDCommissioningEvent == null)
                        {
                            if (replacement == null)
                            {
                                SIDCommissioningEvent = new MethodState(this);
                            }
                            else
                            {
                                SIDCommissioningEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SIDCommissioningEvent;
                    break;
                }

                case Prefix2.BrowseNames.SIDDecommissioningEvent:
                {
                    if (createOrReplace)
                    {
                        if (SIDDecommissioningEvent == null)
                        {
                            if (replacement == null)
                            {
                                SIDDecommissioningEvent = new MethodState(this);
                            }
                            else
                            {
                                SIDDecommissioningEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SIDDecommissioningEvent;
                    break;
                }

                case Prefix2.BrowseNames.SIDDestroyingEvent:
                {
                    if (createOrReplace)
                    {
                        if (SIDDestroyingEvent == null)
                        {
                            if (replacement == null)
                            {
                                SIDDestroyingEvent = new MethodState(this);
                            }
                            else
                            {
                                SIDDestroyingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SIDDestroyingEvent;
                    break;
                }

                case Prefix2.BrowseNames.SIDInspectingEvent:
                {
                    if (createOrReplace)
                    {
                        if (SIDInspectingEvent == null)
                        {
                            if (replacement == null)
                            {
                                SIDInspectingEvent = new MethodState(this);
                            }
                            else
                            {
                                SIDInspectingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SIDInspectingEvent;
                    break;
                }

                case Prefix2.BrowseNames.SIDShippingEvent:
                {
                    if (createOrReplace)
                    {
                        if (SIDShippingEvent == null)
                        {
                            if (replacement == null)
                            {
                                SIDShippingEvent = new MethodState(this);
                            }
                            else
                            {
                                SIDShippingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SIDShippingEvent;
                    break;
                }

                case Prefix2.BrowseNames.SNInvalidatingEvent:
                {
                    if (createOrReplace)
                    {
                        if (SNInvalidatingEvent == null)
                        {
                            if (replacement == null)
                            {
                                SNInvalidatingEvent = new MethodState(this);
                            }
                            else
                            {
                                SNInvalidatingEvent = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SNInvalidatingEvent;
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
        private TemporaryFileTransferState m_ePCISStream;
        private MethodState m_labelsEncodingEventMethod;
        private MethodState m_labelsInspectingEventMethod;
        private MethodState m_labelsSamplingEventMethod;
        private MethodState m_labelsScrappingEventMethod;
        private PropertyState<uint> m_maxEPCISaggregationEvents;
        private PropertyState<uint> m_maxEPCISObjectEventSIDs;
        private PropertyState<uint> m_maxEvents;
        private MethodState m_sIDCommissioningEventMethod;
        private MethodState m_sIDDecommissioningEventMethod;
        private MethodState m_sIDDestroyingEventMethod;
        private MethodState m_sIDInspectingEventMethod;
        private MethodState m_sIDShippingEventMethod;
        private MethodState m_sNInvalidatingEventMethod;
        #endregion
    }
    #endif
    #endregion

    #region OPENSCSPoolManagerObjectState Class
    #if (!OPCUA_EXCLUDE_OPENSCSPoolManagerObjectState)
    /// <summary>
    /// Stores an instance of the OPENSCSPoolManagerObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OPENSCSPoolManagerObjectState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OPENSCSPoolManagerObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.OPENSCSPoolManagerObjectType, Prefix2.Namespaces.Name2, namespaceUris);
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
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRggAABAAAA" +
           "AQAkAAAAT1BFTlNDU1Bvb2xNYW5hZ2VyT2JqZWN0VHlwZUluc3RhbmNlAQFLAAEBSwD/////DQAAABVg" +
           "iQoCAAAAAQANAAAATWF4U05QdXNoYWJsZQEBTAAALgBETAAAAAAH/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEAEAAAAE1heFNOUmVxdWVzdGFibGUBAU0AAC4ARE0AAAAAB/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AA8AAABNYXhTTlJldHVybmFibGUBAU4AAC4ARE4AAAAAB/////8BAf////8AAAAAF2CJCgIAAAABABUA" +
           "AABQb29sU2VsZWN0aW9uQ3JpdGVyaWEBAU8AAC4ARE8AAAABARIAAQAAAAEAAAAAAAAAAQH/////AAAA" +
           "ABdgiQoCAAAAAQAIAAAAU05Gb3JtYXQBAVAAAC4ARFAAAAAADAEAAAABAAAAAAAAAAEB/////wAAAAAE" +
           "YYIKBAAAAAEAEgAAAFNOUmVxdWVzdEFsbG9jYXRlZAEBUQAALwEBUQBRAAAAAQH/////AgAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVIAAC4ARFIAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
           "//8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVMAAC4ARFMAAACWAAAAAAEAKAEBAAAA" +
           "AQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABQAAABTTlJlcXVlc3RVbmFsbG9jYXRlZAEBVAAALwEB" +
           "VABUAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAVUAAC4ARFUAAACWAAAA" +
           "AAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAVYA" +
           "AC4ARFYAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAABABMAAABTTlJlcXVl" +
           "c3RVbmFzc2lnbmVkAQFXAAAvAQFXAFcAAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3Vt" +
           "ZW50cwEBWAAALgBEWAAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAADwAA" +
           "AE91dHB1dEFyZ3VtZW50cwEBWQAALgBEWQAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAE" +
           "YYIKBAAAAAEAEQAAAFNOUmV0dXJuQWxsb2NhdGVkAQFaAAAvAQFaAFoAAAABAf////8CAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBWwAALgBEWwAAAJYAAAAAAQAoAQEAAAABAAAAAAAAAAEB////" +
           "/wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBXAAALgBEXAAAAJYAAAAAAQAoAQEAAAAB" +
           "AAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAEAEwAAAFNOUmV0dXJuVW5hbGxvY2F0ZWQBAV0AAC8BAV0A" +
           "XQAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFeAAAuAEReAAAAlgAAAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFfAAAu" +
           "AERfAAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAAARhggoEAAAAAQANAAAAU050b0FsbG9j" +
           "YXRlZAEBYAAALwEBYABgAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAWEA" +
           "AC4ARGEAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAWIAAC4ARGIAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAAB" +
           "AAsAAABTTnRvRW5jb2RlZAEBYwAALwEBYwBjAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAWQAAC4ARGQAAACWAAAAAAEAKAEBAAAAAQAAAAMAAAABAf////8AAAAAF2CpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAWUAAC4ARGUAAACWAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8A" +
           "AAAABGGCCgQAAAABAA8AAABTTnRvVW5hbGxvY2F0ZWQBAWYAAC8BAWYAZgAAAAEB/////wIAAAAXYKkK" +
           "AgAAAAAADgAAAElucHV0QXJndW1lbnRzAQFnAAAuAERnAAAAlgAAAAABACgBAQAAAAEAAAAAAAAAAQH/" +
           "////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQFoAAAuAERoAAAAlgAAAAABACgBAQAA" +
           "AAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MaxSNPushable Property.
        /// </summary>
        public PropertyState<uint> MaxSNPushable
        {
            get
            {
                return m_maxSNPushable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxSNPushable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxSNPushable = value;
            }
        }

        /// <summary>
        /// A description for the MaxSNRequestable Property.
        /// </summary>
        public PropertyState<uint> MaxSNRequestable
        {
            get
            {
                return m_maxSNRequestable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxSNRequestable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxSNRequestable = value;
            }
        }

        /// <summary>
        /// A description for the MaxSNReturnable Property.
        /// </summary>
        public PropertyState<uint> MaxSNReturnable
        {
            get
            {
                return m_maxSNReturnable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maxSNReturnable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maxSNReturnable = value;
            }
        }

        /// <summary>
        /// A description for the PoolSelectionCriteria Property.
        /// </summary>
        public PropertyState<OPENSCSKeyValueDataType[]> PoolSelectionCriteria
        {
            get
            {
                return m_poolSelectionCriteria;
            }

            set
            {
                if (!Object.ReferenceEquals(m_poolSelectionCriteria, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_poolSelectionCriteria = value;
            }
        }

        /// <summary>
        /// A description for the SNFormat Property.
        /// </summary>
        public PropertyState<string[]> SNFormat
        {
            get
            {
                return m_sNFormat;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNFormat, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNFormat = value;
            }
        }

        /// <summary>
        /// A description for the SNRequestAllocated Method.
        /// </summary>
        public MethodState SNRequestAllocated
        {
            get
            {
                return m_sNRequestAllocatedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNRequestAllocatedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNRequestAllocatedMethod = value;
            }
        }

        /// <summary>
        /// A description for the SNRequestUnallocated Method.
        /// </summary>
        public MethodState SNRequestUnallocated
        {
            get
            {
                return m_sNRequestUnallocatedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNRequestUnallocatedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNRequestUnallocatedMethod = value;
            }
        }

        /// <summary>
        /// A description for the SNRequestUnassigned Method.
        /// </summary>
        public MethodState SNRequestUnassigned
        {
            get
            {
                return m_sNRequestUnassignedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNRequestUnassignedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNRequestUnassignedMethod = value;
            }
        }

        /// <summary>
        /// A description for the SNReturnAllocated Method.
        /// </summary>
        public MethodState SNReturnAllocated
        {
            get
            {
                return m_sNReturnAllocatedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNReturnAllocatedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNReturnAllocatedMethod = value;
            }
        }

        /// <summary>
        /// A description for the SNReturnUnallocated Method.
        /// </summary>
        public MethodState SNReturnUnallocated
        {
            get
            {
                return m_sNReturnUnallocatedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNReturnUnallocatedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNReturnUnallocatedMethod = value;
            }
        }

        /// <summary>
        /// A description for the SNtoAllocated Method.
        /// </summary>
        public MethodState SNtoAllocated
        {
            get
            {
                return m_sNtoAllocatedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNtoAllocatedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNtoAllocatedMethod = value;
            }
        }

        /// <summary>
        /// A description for the SNtoEncoded Method.
        /// </summary>
        public MethodState SNtoEncoded
        {
            get
            {
                return m_sNtoEncodedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNtoEncodedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNtoEncodedMethod = value;
            }
        }

        /// <summary>
        /// A description for the SNtoUnallocated Method.
        /// </summary>
        public MethodState SNtoUnallocated
        {
            get
            {
                return m_sNtoUnallocatedMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sNtoUnallocatedMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sNtoUnallocatedMethod = value;
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
            if (m_maxSNPushable != null)
            {
                children.Add(m_maxSNPushable);
            }

            if (m_maxSNRequestable != null)
            {
                children.Add(m_maxSNRequestable);
            }

            if (m_maxSNReturnable != null)
            {
                children.Add(m_maxSNReturnable);
            }

            if (m_poolSelectionCriteria != null)
            {
                children.Add(m_poolSelectionCriteria);
            }

            if (m_sNFormat != null)
            {
                children.Add(m_sNFormat);
            }

            if (m_sNRequestAllocatedMethod != null)
            {
                children.Add(m_sNRequestAllocatedMethod);
            }

            if (m_sNRequestUnallocatedMethod != null)
            {
                children.Add(m_sNRequestUnallocatedMethod);
            }

            if (m_sNRequestUnassignedMethod != null)
            {
                children.Add(m_sNRequestUnassignedMethod);
            }

            if (m_sNReturnAllocatedMethod != null)
            {
                children.Add(m_sNReturnAllocatedMethod);
            }

            if (m_sNReturnUnallocatedMethod != null)
            {
                children.Add(m_sNReturnUnallocatedMethod);
            }

            if (m_sNtoAllocatedMethod != null)
            {
                children.Add(m_sNtoAllocatedMethod);
            }

            if (m_sNtoEncodedMethod != null)
            {
                children.Add(m_sNtoEncodedMethod);
            }

            if (m_sNtoUnallocatedMethod != null)
            {
                children.Add(m_sNtoUnallocatedMethod);
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
                case Prefix2.BrowseNames.MaxSNPushable:
                {
                    if (createOrReplace)
                    {
                        if (MaxSNPushable == null)
                        {
                            if (replacement == null)
                            {
                                MaxSNPushable = new PropertyState<uint>(this);
                            }
                            else
                            {
                                MaxSNPushable = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxSNPushable;
                    break;
                }

                case Prefix2.BrowseNames.MaxSNRequestable:
                {
                    if (createOrReplace)
                    {
                        if (MaxSNRequestable == null)
                        {
                            if (replacement == null)
                            {
                                MaxSNRequestable = new PropertyState<uint>(this);
                            }
                            else
                            {
                                MaxSNRequestable = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxSNRequestable;
                    break;
                }

                case Prefix2.BrowseNames.MaxSNReturnable:
                {
                    if (createOrReplace)
                    {
                        if (MaxSNReturnable == null)
                        {
                            if (replacement == null)
                            {
                                MaxSNReturnable = new PropertyState<uint>(this);
                            }
                            else
                            {
                                MaxSNReturnable = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = MaxSNReturnable;
                    break;
                }

                case Prefix2.BrowseNames.PoolSelectionCriteria:
                {
                    if (createOrReplace)
                    {
                        if (PoolSelectionCriteria == null)
                        {
                            if (replacement == null)
                            {
                                PoolSelectionCriteria = new PropertyState<OPENSCSKeyValueDataType[]>(this);
                            }
                            else
                            {
                                PoolSelectionCriteria = (PropertyState<OPENSCSKeyValueDataType[]>)replacement;
                            }
                        }
                    }

                    instance = PoolSelectionCriteria;
                    break;
                }

                case Prefix2.BrowseNames.SNFormat:
                {
                    if (createOrReplace)
                    {
                        if (SNFormat == null)
                        {
                            if (replacement == null)
                            {
                                SNFormat = new PropertyState<string[]>(this);
                            }
                            else
                            {
                                SNFormat = (PropertyState<string[]>)replacement;
                            }
                        }
                    }

                    instance = SNFormat;
                    break;
                }

                case Prefix2.BrowseNames.SNRequestAllocated:
                {
                    if (createOrReplace)
                    {
                        if (SNRequestAllocated == null)
                        {
                            if (replacement == null)
                            {
                                SNRequestAllocated = new MethodState(this);
                            }
                            else
                            {
                                SNRequestAllocated = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SNRequestAllocated;
                    break;
                }

                case Prefix2.BrowseNames.SNRequestUnallocated:
                {
                    if (createOrReplace)
                    {
                        if (SNRequestUnallocated == null)
                        {
                            if (replacement == null)
                            {
                                SNRequestUnallocated = new MethodState(this);
                            }
                            else
                            {
                                SNRequestUnallocated = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SNRequestUnallocated;
                    break;
                }

                case Prefix2.BrowseNames.SNRequestUnassigned:
                {
                    if (createOrReplace)
                    {
                        if (SNRequestUnassigned == null)
                        {
                            if (replacement == null)
                            {
                                SNRequestUnassigned = new MethodState(this);
                            }
                            else
                            {
                                SNRequestUnassigned = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SNRequestUnassigned;
                    break;
                }

                case Prefix2.BrowseNames.SNReturnAllocated:
                {
                    if (createOrReplace)
                    {
                        if (SNReturnAllocated == null)
                        {
                            if (replacement == null)
                            {
                                SNReturnAllocated = new MethodState(this);
                            }
                            else
                            {
                                SNReturnAllocated = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SNReturnAllocated;
                    break;
                }

                case Prefix2.BrowseNames.SNReturnUnallocated:
                {
                    if (createOrReplace)
                    {
                        if (SNReturnUnallocated == null)
                        {
                            if (replacement == null)
                            {
                                SNReturnUnallocated = new MethodState(this);
                            }
                            else
                            {
                                SNReturnUnallocated = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SNReturnUnallocated;
                    break;
                }

                case Prefix2.BrowseNames.SNtoAllocated:
                {
                    if (createOrReplace)
                    {
                        if (SNtoAllocated == null)
                        {
                            if (replacement == null)
                            {
                                SNtoAllocated = new MethodState(this);
                            }
                            else
                            {
                                SNtoAllocated = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SNtoAllocated;
                    break;
                }

                case Prefix2.BrowseNames.SNtoEncoded:
                {
                    if (createOrReplace)
                    {
                        if (SNtoEncoded == null)
                        {
                            if (replacement == null)
                            {
                                SNtoEncoded = new MethodState(this);
                            }
                            else
                            {
                                SNtoEncoded = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SNtoEncoded;
                    break;
                }

                case Prefix2.BrowseNames.SNtoUnallocated:
                {
                    if (createOrReplace)
                    {
                        if (SNtoUnallocated == null)
                        {
                            if (replacement == null)
                            {
                                SNtoUnallocated = new MethodState(this);
                            }
                            else
                            {
                                SNtoUnallocated = (MethodState)replacement;
                            }
                        }
                    }

                    instance = SNtoUnallocated;
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
        private PropertyState<uint> m_maxSNPushable;
        private PropertyState<uint> m_maxSNRequestable;
        private PropertyState<uint> m_maxSNReturnable;
        private PropertyState<OPENSCSKeyValueDataType[]> m_poolSelectionCriteria;
        private PropertyState<string[]> m_sNFormat;
        private MethodState m_sNRequestAllocatedMethod;
        private MethodState m_sNRequestUnallocatedMethod;
        private MethodState m_sNRequestUnassignedMethod;
        private MethodState m_sNReturnAllocatedMethod;
        private MethodState m_sNReturnUnallocatedMethod;
        private MethodState m_sNtoAllocatedMethod;
        private MethodState m_sNtoEncodedMethod;
        private MethodState m_sNtoUnallocatedMethod;
        #endregion
    }
    #endif
    #endregion

    #region OPENSCSSIDClassObjectState Class
    #if (!OPCUA_EXCLUDE_OPENSCSSIDClassObjectState)
    /// <summary>
    /// Stores an instance of the OPENSCSSIDClassObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OPENSCSSIDClassObjectState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OPENSCSSIDClassObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.OPENSCSSIDClassObjectType, Prefix2.Namespaces.Name2, namespaceUris);
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

            if (IntendedUse != null)
            {
                IntendedUse.Initialize(context, IntendedUse_InitializationString);
            }

            if (SIDClassDescription != null)
            {
                SIDClassDescription.Initialize(context, SIDClassDescription_InitializationString);
            }

            if (SIDClassProperty != null)
            {
                SIDClassProperty.Initialize(context, SIDClassProperty_InitializationString);
            }
        }

        #region Initialization String
        private const string IntendedUse_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////xVgiQoCAAAA" +
           "AQALAAAASW50ZW5kZWRVc2UBAWsAAC4ARGsAAAAADP////8BAf////8AAAAA";

        private const string SIDClassDescription_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////xVgiQoCAAAA" +
           "AQATAAAAU0lEQ2xhc3NEZXNjcmlwdGlvbgEBbAAALgBEbAAAAAAM/////wEB/////wAAAAA=";

        private const string SIDClassProperty_InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////xdgiQoCAAAA" +
           "AQAQAAAAU0lEQ2xhc3NQcm9wZXJ0eQEBbwAALgBEbwAAAAEBFQABAAAAAQAAAAAAAAADA/////8AAAAA";

        private const string InitializationString =
           "AQAAACgAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvT1BFTlNDUy1TRVIv/////wRggAABAAAA" +
           "AQAhAAAAT1BFTlNDU1NJRENsYXNzT2JqZWN0VHlwZUluc3RhbmNlAQFpAAEBaQD/////BwAAABVgiQoC" +
           "AAAAAQATAAAAQWxsb3dlZENoYXJhY3RlclNldAEBagAALgBEagAAAAAM/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEACwAAAEludGVuZGVkVXNlAQFrAAAuAERrAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAT" +
           "AAAAU0lEQ2xhc3NEZXNjcmlwdGlvbgEBbAAALgBEbAAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "CgAAAFNJRENsYXNzSUQBAW0AAC4ARG0AAAAADP////8BAf////8AAAAAFWCJCgIAAAABAA0AAABTSURD" +
           "bGFzc093bmVyAQFuAAAuAERuAAAAAAz/////AQH/////AAAAABdgiQoCAAAAAQAQAAAAU0lEQ2xhc3NQ" +
           "cm9wZXJ0eQEBbwAALgBEbwAAAAEBFQABAAAAAQAAAAAAAAADA/////8AAAAAFWCJCgIAAAABABMAAABT" +
           "eW50YXhTcGVjaWZpY2F0aW9uAQFwAAAuAERwAAAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the AllowedCharacterSet Property.
        /// </summary>
        public PropertyState<string> AllowedCharacterSet
        {
            get
            {
                return m_allowedCharacterSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_allowedCharacterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_allowedCharacterSet = value;
            }
        }

        /// <summary>
        /// A description for the IntendedUse Property.
        /// </summary>
        public PropertyState<string> IntendedUse
        {
            get
            {
                return m_ıntendedUse;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ıntendedUse, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ıntendedUse = value;
            }
        }

        /// <summary>
        /// A description for the SIDClassDescription Property.
        /// </summary>
        public PropertyState<string> SIDClassDescription
        {
            get
            {
                return m_sIDClassDescription;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIDClassDescription, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIDClassDescription = value;
            }
        }

        /// <summary>
        /// A description for the SIDClassID Property.
        /// </summary>
        public PropertyState<string> SIDClassID
        {
            get
            {
                return m_sIDClassID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIDClassID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIDClassID = value;
            }
        }

        /// <summary>
        /// A description for the SIDClassOwner Property.
        /// </summary>
        public PropertyState<string> SIDClassOwner
        {
            get
            {
                return m_sIDClassOwner;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIDClassOwner, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIDClassOwner = value;
            }
        }

        /// <summary>
        /// A description for the SIDClassProperty Property.
        /// </summary>
        public PropertyState<OPENSCSSIDClassPropertyDataType[]> SIDClassProperty
        {
            get
            {
                return m_sIDClassProperty;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sIDClassProperty, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sIDClassProperty = value;
            }
        }

        /// <summary>
        /// A description for the SyntaxSpecification Property.
        /// </summary>
        public PropertyState<string> SyntaxSpecification
        {
            get
            {
                return m_syntaxSpecification;
            }

            set
            {
                if (!Object.ReferenceEquals(m_syntaxSpecification, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_syntaxSpecification = value;
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
            if (m_allowedCharacterSet != null)
            {
                children.Add(m_allowedCharacterSet);
            }

            if (m_ıntendedUse != null)
            {
                children.Add(m_ıntendedUse);
            }

            if (m_sIDClassDescription != null)
            {
                children.Add(m_sIDClassDescription);
            }

            if (m_sIDClassID != null)
            {
                children.Add(m_sIDClassID);
            }

            if (m_sIDClassOwner != null)
            {
                children.Add(m_sIDClassOwner);
            }

            if (m_sIDClassProperty != null)
            {
                children.Add(m_sIDClassProperty);
            }

            if (m_syntaxSpecification != null)
            {
                children.Add(m_syntaxSpecification);
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
                case Prefix2.BrowseNames.AllowedCharacterSet:
                {
                    if (createOrReplace)
                    {
                        if (AllowedCharacterSet == null)
                        {
                            if (replacement == null)
                            {
                                AllowedCharacterSet = new PropertyState<string>(this);
                            }
                            else
                            {
                                AllowedCharacterSet = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AllowedCharacterSet;
                    break;
                }

                case Prefix2.BrowseNames.IntendedUse:
                {
                    if (createOrReplace)
                    {
                        if (IntendedUse == null)
                        {
                            if (replacement == null)
                            {
                                IntendedUse = new PropertyState<string>(this);
                            }
                            else
                            {
                                IntendedUse = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = IntendedUse;
                    break;
                }

                case Prefix2.BrowseNames.SIDClassDescription:
                {
                    if (createOrReplace)
                    {
                        if (SIDClassDescription == null)
                        {
                            if (replacement == null)
                            {
                                SIDClassDescription = new PropertyState<string>(this);
                            }
                            else
                            {
                                SIDClassDescription = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SIDClassDescription;
                    break;
                }

                case Prefix2.BrowseNames.SIDClassID:
                {
                    if (createOrReplace)
                    {
                        if (SIDClassID == null)
                        {
                            if (replacement == null)
                            {
                                SIDClassID = new PropertyState<string>(this);
                            }
                            else
                            {
                                SIDClassID = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SIDClassID;
                    break;
                }

                case Prefix2.BrowseNames.SIDClassOwner:
                {
                    if (createOrReplace)
                    {
                        if (SIDClassOwner == null)
                        {
                            if (replacement == null)
                            {
                                SIDClassOwner = new PropertyState<string>(this);
                            }
                            else
                            {
                                SIDClassOwner = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SIDClassOwner;
                    break;
                }

                case Prefix2.BrowseNames.SIDClassProperty:
                {
                    if (createOrReplace)
                    {
                        if (SIDClassProperty == null)
                        {
                            if (replacement == null)
                            {
                                SIDClassProperty = new PropertyState<OPENSCSSIDClassPropertyDataType[]>(this);
                            }
                            else
                            {
                                SIDClassProperty = (PropertyState<OPENSCSSIDClassPropertyDataType[]>)replacement;
                            }
                        }
                    }

                    instance = SIDClassProperty;
                    break;
                }

                case Prefix2.BrowseNames.SyntaxSpecification:
                {
                    if (createOrReplace)
                    {
                        if (SyntaxSpecification == null)
                        {
                            if (replacement == null)
                            {
                                SyntaxSpecification = new PropertyState<string>(this);
                            }
                            else
                            {
                                SyntaxSpecification = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SyntaxSpecification;
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
        private PropertyState<string> m_allowedCharacterSet;
        private PropertyState<string> m_ıntendedUse;
        private PropertyState<string> m_sIDClassDescription;
        private PropertyState<string> m_sIDClassID;
        private PropertyState<string> m_sIDClassOwner;
        private PropertyState<OPENSCSSIDClassPropertyDataType[]> m_sIDClassProperty;
        private PropertyState<string> m_syntaxSpecification;
        #endregion
    }
    #endif
    #endregion
}