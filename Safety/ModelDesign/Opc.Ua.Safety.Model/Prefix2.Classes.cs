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
        /// The identifier for the NonSafetyDataPlaceholderDataType DataType.
        /// </summary>
        public const uint NonSafetyDataPlaceholderDataType = 1;
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
        /// The identifier for the SafetyProviderType_ReadSafetyData Method.
        /// </summary>
        public const uint SafetyProviderType_ReadSafetyData = 11;

        /// <summary>
        /// The identifier for the SafetyProviderType_ReadSafetyDiagnostics Method.
        /// </summary>
        public const uint SafetyProviderType_ReadSafetyDiagnostics = 14;
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
        /// The identifier for the SafetyProviderType_Parameters Object.
        /// </summary>
        public const uint SafetyProviderType_Parameters = 4;

        /// <summary>
        /// The identifier for the SafetyDeviceSet Object.
        /// </summary>
        public const uint SafetyDeviceSet = 23;

        /// <summary>
        /// The identifier for the NonSafetyDataPlaceholderDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint NonSafetyDataPlaceholderDataType_Encoding_DefaultXml = 24;

        /// <summary>
        /// The identifier for the NonSafetyDataPlaceholderDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint NonSafetyDataPlaceholderDataType_Encoding_DefaultBinary = 31;
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
        /// The identifier for the SafetyObjectsType ObjectType.
        /// </summary>
        public const uint SafetyObjectsType = 2;

        /// <summary>
        /// The identifier for the SafetyProviderType ObjectType.
        /// </summary>
        public const uint SafetyProviderType = 3;

        /// <summary>
        /// The identifier for the SafetyParametersType ObjectType.
        /// </summary>
        public const uint SafetyParametersType = 16;
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
        /// The identifier for the SafetyProviderType_Parameters_SafetyBaseID Variable.
        /// </summary>
        public const uint SafetyProviderType_Parameters_SafetyBaseID = 5;

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_SafetyProviderDelay Variable.
        /// </summary>
        public const uint SafetyProviderType_Parameters_SafetyProviderDelay = 6;

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_SafetyProviderID Variable.
        /// </summary>
        public const uint SafetyProviderType_Parameters_SafetyProviderID = 7;

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_SafetyProviderLevel Variable.
        /// </summary>
        public const uint SafetyProviderType_Parameters_SafetyProviderLevel = 8;

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_StructureIdentifier Variable.
        /// </summary>
        public const uint SafetyProviderType_Parameters_StructureIdentifier = 9;

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_StructureSignatureVersion Variable.
        /// </summary>
        public const uint SafetyProviderType_Parameters_StructureSignatureVersion = 10;

        /// <summary>
        /// The identifier for the SafetyProviderType_ReadSafetyData_InputArguments Variable.
        /// </summary>
        public const uint SafetyProviderType_ReadSafetyData_InputArguments = 12;

        /// <summary>
        /// The identifier for the SafetyProviderType_ReadSafetyData_OutputArguments Variable.
        /// </summary>
        public const uint SafetyProviderType_ReadSafetyData_OutputArguments = 13;

        /// <summary>
        /// The identifier for the SafetyProviderType_ReadSafetyDiagnostics_OutputArguments Variable.
        /// </summary>
        public const uint SafetyProviderType_ReadSafetyDiagnostics_OutputArguments = 15;

        /// <summary>
        /// The identifier for the SafetyParametersType_SafetyBaseID Variable.
        /// </summary>
        public const uint SafetyParametersType_SafetyBaseID = 17;

        /// <summary>
        /// The identifier for the SafetyParametersType_SafetyProviderDelay Variable.
        /// </summary>
        public const uint SafetyParametersType_SafetyProviderDelay = 18;

        /// <summary>
        /// The identifier for the SafetyParametersType_SafetyProviderID Variable.
        /// </summary>
        public const uint SafetyParametersType_SafetyProviderID = 19;

        /// <summary>
        /// The identifier for the SafetyParametersType_SafetyProviderLevel Variable.
        /// </summary>
        public const uint SafetyParametersType_SafetyProviderLevel = 20;

        /// <summary>
        /// The identifier for the SafetyParametersType_StructureIdentifier Variable.
        /// </summary>
        public const uint SafetyParametersType_StructureIdentifier = 21;

        /// <summary>
        /// The identifier for the SafetyParametersType_StructureSignatureVersion Variable.
        /// </summary>
        public const uint SafetyParametersType_StructureSignatureVersion = 22;

        /// <summary>
        /// The identifier for the Name2_XmlSchema Variable.
        /// </summary>
        public const uint Name2_XmlSchema = 25;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint Name2_XmlSchema_NamespaceUri = 27;

        /// <summary>
        /// The identifier for the Name2_XmlSchema_NonSafetyDataPlaceholderDataType Variable.
        /// </summary>
        public const uint Name2_XmlSchema_NonSafetyDataPlaceholderDataType = 28;

        /// <summary>
        /// The identifier for the Name2_BinarySchema Variable.
        /// </summary>
        public const uint Name2_BinarySchema = 32;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint Name2_BinarySchema_NamespaceUri = 34;

        /// <summary>
        /// The identifier for the Name2_BinarySchema_NonSafetyDataPlaceholderDataType Variable.
        /// </summary>
        public const uint Name2_BinarySchema_NonSafetyDataPlaceholderDataType = 35;
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
        /// The identifier for the NonSafetyDataPlaceholderDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NonSafetyDataPlaceholderDataType = new ExpandedNodeId(Prefix2.DataTypes.NonSafetyDataPlaceholderDataType, Prefix2.Namespaces.Name2);
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
        /// The identifier for the SafetyProviderType_ReadSafetyData Method.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_ReadSafetyData = new ExpandedNodeId(Prefix2.Methods.SafetyProviderType_ReadSafetyData, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType_ReadSafetyDiagnostics Method.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_ReadSafetyDiagnostics = new ExpandedNodeId(Prefix2.Methods.SafetyProviderType_ReadSafetyDiagnostics, Prefix2.Namespaces.Name2);
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
        /// The identifier for the SafetyProviderType_Parameters Object.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_Parameters = new ExpandedNodeId(Prefix2.Objects.SafetyProviderType_Parameters, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyDeviceSet Object.
        /// </summary>
        public static readonly ExpandedNodeId SafetyDeviceSet = new ExpandedNodeId(Prefix2.Objects.SafetyDeviceSet, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the NonSafetyDataPlaceholderDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId NonSafetyDataPlaceholderDataType_Encoding_DefaultXml = new ExpandedNodeId(Prefix2.Objects.NonSafetyDataPlaceholderDataType_Encoding_DefaultXml, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the NonSafetyDataPlaceholderDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId NonSafetyDataPlaceholderDataType_Encoding_DefaultBinary = new ExpandedNodeId(Prefix2.Objects.NonSafetyDataPlaceholderDataType_Encoding_DefaultBinary, Prefix2.Namespaces.Name2);
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
        /// The identifier for the SafetyObjectsType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SafetyObjectsType = new ExpandedNodeId(Prefix2.ObjectTypes.SafetyObjectsType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType = new ExpandedNodeId(Prefix2.ObjectTypes.SafetyProviderType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyParametersType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SafetyParametersType = new ExpandedNodeId(Prefix2.ObjectTypes.SafetyParametersType, Prefix2.Namespaces.Name2);
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
        /// The identifier for the SafetyProviderType_Parameters_SafetyBaseID Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_Parameters_SafetyBaseID = new ExpandedNodeId(Prefix2.Variables.SafetyProviderType_Parameters_SafetyBaseID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_SafetyProviderDelay Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_Parameters_SafetyProviderDelay = new ExpandedNodeId(Prefix2.Variables.SafetyProviderType_Parameters_SafetyProviderDelay, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_SafetyProviderID Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_Parameters_SafetyProviderID = new ExpandedNodeId(Prefix2.Variables.SafetyProviderType_Parameters_SafetyProviderID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_SafetyProviderLevel Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_Parameters_SafetyProviderLevel = new ExpandedNodeId(Prefix2.Variables.SafetyProviderType_Parameters_SafetyProviderLevel, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_StructureIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_Parameters_StructureIdentifier = new ExpandedNodeId(Prefix2.Variables.SafetyProviderType_Parameters_StructureIdentifier, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType_Parameters_StructureSignatureVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_Parameters_StructureSignatureVersion = new ExpandedNodeId(Prefix2.Variables.SafetyProviderType_Parameters_StructureSignatureVersion, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType_ReadSafetyData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_ReadSafetyData_InputArguments = new ExpandedNodeId(Prefix2.Variables.SafetyProviderType_ReadSafetyData_InputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType_ReadSafetyData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_ReadSafetyData_OutputArguments = new ExpandedNodeId(Prefix2.Variables.SafetyProviderType_ReadSafetyData_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyProviderType_ReadSafetyDiagnostics_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyProviderType_ReadSafetyDiagnostics_OutputArguments = new ExpandedNodeId(Prefix2.Variables.SafetyProviderType_ReadSafetyDiagnostics_OutputArguments, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyParametersType_SafetyBaseID Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyParametersType_SafetyBaseID = new ExpandedNodeId(Prefix2.Variables.SafetyParametersType_SafetyBaseID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyParametersType_SafetyProviderDelay Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyParametersType_SafetyProviderDelay = new ExpandedNodeId(Prefix2.Variables.SafetyParametersType_SafetyProviderDelay, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyParametersType_SafetyProviderID Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyParametersType_SafetyProviderID = new ExpandedNodeId(Prefix2.Variables.SafetyParametersType_SafetyProviderID, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyParametersType_SafetyProviderLevel Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyParametersType_SafetyProviderLevel = new ExpandedNodeId(Prefix2.Variables.SafetyParametersType_SafetyProviderLevel, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyParametersType_StructureIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyParametersType_StructureIdentifier = new ExpandedNodeId(Prefix2.Variables.SafetyParametersType_StructureIdentifier, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the SafetyParametersType_StructureSignatureVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId SafetyParametersType_StructureSignatureVersion = new ExpandedNodeId(Prefix2.Variables.SafetyParametersType_StructureSignatureVersion, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_NamespaceUri = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_NamespaceUri, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_XmlSchema_NonSafetyDataPlaceholderDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_XmlSchema_NonSafetyDataPlaceholderDataType = new ExpandedNodeId(Prefix2.Variables.Name2_XmlSchema_NonSafetyDataPlaceholderDataType, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_NamespaceUri = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_NamespaceUri, Prefix2.Namespaces.Name2);

        /// <summary>
        /// The identifier for the Name2_BinarySchema_NonSafetyDataPlaceholderDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Name2_BinarySchema_NonSafetyDataPlaceholderDataType = new ExpandedNodeId(Prefix2.Variables.Name2_BinarySchema_NonSafetyDataPlaceholderDataType, Prefix2.Namespaces.Name2);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Name2_BinarySchema component.
        /// </summary>
        public const string Name2_BinarySchema = "Prefix2";

        /// <summary>
        /// The BrowseName for the Name2_XmlSchema component.
        /// </summary>
        public const string Name2_XmlSchema = "Prefix2";

        /// <summary>
        /// The BrowseName for the NonSafetyDataPlaceholderDataType component.
        /// </summary>
        public const string NonSafetyDataPlaceholderDataType = "NonSafetyDataPlaceholderDataType";

        /// <summary>
        /// The BrowseName for the Parameters component.
        /// </summary>
        public const string Parameters = "Parameters";

        /// <summary>
        /// The BrowseName for the ReadSafetyData component.
        /// </summary>
        public const string ReadSafetyData = "ReadSafetyData";

        /// <summary>
        /// The BrowseName for the ReadSafetyDiagnostics component.
        /// </summary>
        public const string ReadSafetyDiagnostics = "ReadSafetyDiagnostics";

        /// <summary>
        /// The BrowseName for the SafetyBaseID component.
        /// </summary>
        public const string SafetyBaseID = "SafetyBaseID";

        /// <summary>
        /// The BrowseName for the SafetyDeviceSet component.
        /// </summary>
        public const string SafetyDeviceSet = "SafetyDeviceSet";

        /// <summary>
        /// The BrowseName for the SafetyObjectsType component.
        /// </summary>
        public const string SafetyObjectsType = "SafetyObjectsType";

        /// <summary>
        /// The BrowseName for the SafetyParametersType component.
        /// </summary>
        public const string SafetyParametersType = "SafetyParametersType";

        /// <summary>
        /// The BrowseName for the SafetyProviderDelay component.
        /// </summary>
        public const string SafetyProviderDelay = "SafetyProviderDelay";

        /// <summary>
        /// The BrowseName for the SafetyProviderID component.
        /// </summary>
        public const string SafetyProviderID = "SafetyProviderID";

        /// <summary>
        /// The BrowseName for the SafetyProviderLevel component.
        /// </summary>
        public const string SafetyProviderLevel = "SafetyProviderLevel";

        /// <summary>
        /// The BrowseName for the SafetyProviderType component.
        /// </summary>
        public const string SafetyProviderType = "SafetyProviderType";

        /// <summary>
        /// The BrowseName for the StructureIdentifier component.
        /// </summary>
        public const string StructureIdentifier = "StructureIdentifier";

        /// <summary>
        /// The BrowseName for the StructureSignatureVersion component.
        /// </summary>
        public const string StructureSignatureVersion = "StructureSignatureVersion";
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
        public const string Name2Xsd = "http://opcfoundation.org/UA/Safety";

        /// <summary>
        /// The URI for the Name2Xsd namespace (.NET code namespace is 'Prefix2').
        /// </summary>
        public const string Name2Xsd = "http://opcfoundation.org/UA/Safety";
    }
    #endregion

    #region NonSafetyDataPlaceholderDataType Class
    #if (!OPCUA_EXCLUDE_NonSafetyDataPlaceholderDataType)
    /// <summary>
    /// Dummy structure to be used when no non-safety data are used
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Prefix2.Namespaces.Name2Xsd)]
    public partial class NonSafetyDataPlaceholderDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public NonSafetyDataPlaceholderDataType()
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
            m_dummy = true;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Dummy variable to avoid empty structures
        /// </summary>
        [DataMember(Name = "Dummy", IsRequired = false, Order = 1)]
        public bool Dummy
        {
            get { return m_dummy;  }
            set { m_dummy = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.NonSafetyDataPlaceholderDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.NonSafetyDataPlaceholderDataType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.NonSafetyDataPlaceholderDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            encoder.WriteBoolean("Dummy", Dummy);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Prefix2.Namespaces.Name2Xsd);

            Dummy = decoder.ReadBoolean("Dummy");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            NonSafetyDataPlaceholderDataType value = encodeable as NonSafetyDataPlaceholderDataType;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_dummy, value.m_dummy)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (NonSafetyDataPlaceholderDataType)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            NonSafetyDataPlaceholderDataType clone = (NonSafetyDataPlaceholderDataType)base.MemberwiseClone();

            clone.m_dummy = (bool)Utils.Clone(this.m_dummy);

            return clone;
        }
        #endregion

        #region Private Fields
        private bool m_dummy;
        #endregion
    }

    #region NonSafetyDataPlaceholderDataTypeCollection Class
    /// <summary>
    /// A collection of NonSafetyDataPlaceholderDataType objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfNonSafetyDataPlaceholderDataType", Namespace = Prefix2.Namespaces.Name2Xsd, ItemName = "NonSafetyDataPlaceholderDataType")]
    #if !NET_STANDARD
    public partial class NonSafetyDataPlaceholderDataTypeCollection : List<NonSafetyDataPlaceholderDataType>, ICloneable
    #else
    public partial class NonSafetyDataPlaceholderDataTypeCollection : List<NonSafetyDataPlaceholderDataType>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public NonSafetyDataPlaceholderDataTypeCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public NonSafetyDataPlaceholderDataTypeCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public NonSafetyDataPlaceholderDataTypeCollection(IEnumerable<NonSafetyDataPlaceholderDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator NonSafetyDataPlaceholderDataTypeCollection(NonSafetyDataPlaceholderDataType[] values)
        {
            if (values != null)
            {
                return new NonSafetyDataPlaceholderDataTypeCollection(values);
            }

            return new NonSafetyDataPlaceholderDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator NonSafetyDataPlaceholderDataType[](NonSafetyDataPlaceholderDataTypeCollection values)
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
            return (NonSafetyDataPlaceholderDataTypeCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            NonSafetyDataPlaceholderDataTypeCollection clone = new NonSafetyDataPlaceholderDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((NonSafetyDataPlaceholderDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region SafetyObjectsState Class
    #if (!OPCUA_EXCLUDE_SafetyObjectsState)
    /// <summary>
    /// Stores an instance of the SafetyObjectsType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SafetyObjectsState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SafetyObjectsState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.SafetyObjectsType, Prefix2.Namespaces.Name2, namespaceUris);
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
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2FmZXR5/////wRggAABAAAAAQAZAAAA" +
           "U2FmZXR5T2JqZWN0c1R5cGVJbnN0YW5jZQEBAgABAQIA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SafetyProviderState Class
    #if (!OPCUA_EXCLUDE_SafetyProviderState)
    /// <summary>
    /// Stores an instance of the SafetyProviderType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SafetyProviderState : SafetyObjectsState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SafetyProviderState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.SafetyProviderType, Prefix2.Namespaces.Name2, namespaceUris);
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
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2FmZXR5/////wRggAABAAAAAQAaAAAA" +
           "U2FmZXR5UHJvdmlkZXJUeXBlSW5zdGFuY2UBAQMAAQEDAP////8DAAAAJGCACgEAAAABAAoAAABQYXJh" +
           "bWV0ZXJzAQEEAAMAAAAAKAAAAFNhZmV0eSBwYXJhbWV0ZXJzIG9mIHRoaXMgU2FmZXR5UHJvdmlkZXIA" +
           "LwEBEAAEAAAA/////wYAAAA1YIkKAgAAAAEADAAAAFNhZmV0eUJhc2VJRAEBBQADAAAAAB0AAABCYXNl" +
           "LUlEIG9mIHRoZSBTYWZldHlQcm92aWRlcgAuAEQFAAAAAA7/////AwP/////AAAAADVgiQoCAAAAAQAT" +
           "AAAAU2FmZXR5UHJvdmlkZXJEZWxheQEBBgADAAAAAIYAAABTYWZldHlQcm92aWRlckRlbGF5IGlzIHRo" +
           "ZSBtYXhpbXVtIHRpbWUgYXQgdGhlIFNhZmV0eVByb3ZpZGVyIGZyb20gcmVjZWl2aW5nIHRoZSBSZXF1" +
           "ZXN0U1BEVSB0byBzdGFydCB0aGUgdHJhbnNtaXNzaW9uIG9mIFJlc3BvbnNlU1BEVQAuAEQGAAAAAAf/" +
           "////AwP/////AAAAADVgiQoCAAAAAQAQAAAAU2FmZXR5UHJvdmlkZXJJRAEBBwADAAAAACEAAABQcm92" +
           "aWRlci1JRCBvZiB0aGUgU2FmZXR5UHJvdmlkZXIALgBEBwAAAAAH/////wMD/////wAAAAA1YIkKAgAA" +
           "AAEAEwAAAFNhZmV0eVByb3ZpZGVyTGV2ZWwBAQgAAwAAAABVAAAAVGhlIG1heGltYWwgU0lMIHRoZSBT" +
           "YWZldHlQcm92aWRlciBpbXBsZW1lbnRhdGlvbiAoaGFyZHdhcmUgJiBzb2Z0d2FyZSkgaXMgY2FwYWJs" +
           "ZSBvZgAuAEQIAAAAAAP/////AwP/////AAAAADVgiQoCAAAAAQATAAAAU3RydWN0dXJlSWRlbnRpZmll" +
           "cgEBCQADAAAAACAAAABJZGVudGlmaWVyIG9mIHRoZSBzdHJ1Y3R1cmUgdHlwZQAuAEQJAAAAAAz/////" +
           "AwP/////AAAAADVgiQoCAAAAAQAZAAAAU3RydWN0dXJlU2lnbmF0dXJlVmVyc2lvbgEBCgADAAAAAD8A" +
           "AABWZXJzaW9uIG9mIHRoZSBhbGdvcml0aG0gZm9yIGNhbGN1bGF0aW5nIHRoZSBTdHJ1Y3R1cmVTaWdu" +
           "YXR1cmUALgBECgAAAAAF/////wMD/////wAAAAAkYYIKBAAAAAEADgAAAFJlYWRTYWZldHlEYXRhAQEL" +
           "AAMAAAAAJwAAAFJlYWRzIHNhZmUgZGF0YSBmcm9tIHRoZSBTYWZldHlQcm92aWRlcgAvAQELAAsAAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBDAAALgBEDAAAAJYAAAAAAQAoAQEA" +
           "AAABAAAAAwAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBDQAALgBEDQAA" +
           "AJYAAAAAAQAoAQEAAAABAAAACQAAAAEB/////wAAAAAkYYIKBAAAAAEAFQAAAFJlYWRTYWZldHlEaWFn" +
           "bm9zdGljcwEBDgADAAAAACAAAABTZXJ2ZXMgYXMgYSBkaWFnbm9zdGljIGludGVyZmFjZQAvAQEOAA4A" +
           "AAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQ8AAC4ARA8AAACWAAAAAAEA" +
           "KAEBAAAAAQAAAAwAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Safety parameters of this SafetyProvider
        /// </summary>
        public SafetyParametersState Parameters
        {
            get
            {
                return m_parameters;
            }

            set
            {
                if (!Object.ReferenceEquals(m_parameters, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameters = value;
            }
        }

        /// <summary>
        /// Reads safe data from the SafetyProvider
        /// </summary>
        public MethodState ReadSafetyData
        {
            get
            {
                return m_readSafetyDataMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_readSafetyDataMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_readSafetyDataMethod = value;
            }
        }

        /// <summary>
        /// Serves as a diagnostic interface
        /// </summary>
        public MethodState ReadSafetyDiagnostics
        {
            get
            {
                return m_readSafetyDiagnosticsMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_readSafetyDiagnosticsMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_readSafetyDiagnosticsMethod = value;
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
            if (m_parameters != null)
            {
                children.Add(m_parameters);
            }

            if (m_readSafetyDataMethod != null)
            {
                children.Add(m_readSafetyDataMethod);
            }

            if (m_readSafetyDiagnosticsMethod != null)
            {
                children.Add(m_readSafetyDiagnosticsMethod);
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
                case Prefix2.BrowseNames.Parameters:
                {
                    if (createOrReplace)
                    {
                        if (Parameters == null)
                        {
                            if (replacement == null)
                            {
                                Parameters = new SafetyParametersState(this);
                            }
                            else
                            {
                                Parameters = (SafetyParametersState)replacement;
                            }
                        }
                    }

                    instance = Parameters;
                    break;
                }

                case Prefix2.BrowseNames.ReadSafetyData:
                {
                    if (createOrReplace)
                    {
                        if (ReadSafetyData == null)
                        {
                            if (replacement == null)
                            {
                                ReadSafetyData = new MethodState(this);
                            }
                            else
                            {
                                ReadSafetyData = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ReadSafetyData;
                    break;
                }

                case Prefix2.BrowseNames.ReadSafetyDiagnostics:
                {
                    if (createOrReplace)
                    {
                        if (ReadSafetyDiagnostics == null)
                        {
                            if (replacement == null)
                            {
                                ReadSafetyDiagnostics = new MethodState(this);
                            }
                            else
                            {
                                ReadSafetyDiagnostics = (MethodState)replacement;
                            }
                        }
                    }

                    instance = ReadSafetyDiagnostics;
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
        private SafetyParametersState m_parameters;
        private MethodState m_readSafetyDataMethod;
        private MethodState m_readSafetyDiagnosticsMethod;
        #endregion
    }
    #endif
    #endregion

    #region SafetyParametersState Class
    #if (!OPCUA_EXCLUDE_SafetyParametersState)
    /// <summary>
    /// Stores an instance of the SafetyParametersType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SafetyParametersState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SafetyParametersState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Prefix2.ObjectTypes.SafetyParametersType, Prefix2.Namespaces.Name2, namespaceUris);
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
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvU2FmZXR5/////wRggAABAAAAAQAcAAAA" +
           "U2FmZXR5UGFyYW1ldGVyc1R5cGVJbnN0YW5jZQEBEAABARAA/////wYAAAA1YIkKAgAAAAEADAAAAFNh" +
           "ZmV0eUJhc2VJRAEBEQADAAAAAB0AAABCYXNlLUlEIG9mIHRoZSBTYWZldHlQcm92aWRlcgAuAEQRAAAA" +
           "AA7/////AwP/////AAAAADVgiQoCAAAAAQATAAAAU2FmZXR5UHJvdmlkZXJEZWxheQEBEgADAAAAAIYA" +
           "AABTYWZldHlQcm92aWRlckRlbGF5IGlzIHRoZSBtYXhpbXVtIHRpbWUgYXQgdGhlIFNhZmV0eVByb3Zp" +
           "ZGVyIGZyb20gcmVjZWl2aW5nIHRoZSBSZXF1ZXN0U1BEVSB0byBzdGFydCB0aGUgdHJhbnNtaXNzaW9u" +
           "IG9mIFJlc3BvbnNlU1BEVQAuAEQSAAAAAAf/////AwP/////AAAAADVgiQoCAAAAAQAQAAAAU2FmZXR5" +
           "UHJvdmlkZXJJRAEBEwADAAAAACEAAABQcm92aWRlci1JRCBvZiB0aGUgU2FmZXR5UHJvdmlkZXIALgBE" +
           "EwAAAAAH/////wMD/////wAAAAA1YIkKAgAAAAEAEwAAAFNhZmV0eVByb3ZpZGVyTGV2ZWwBARQAAwAA" +
           "AABVAAAAVGhlIG1heGltYWwgU0lMIHRoZSBTYWZldHlQcm92aWRlciBpbXBsZW1lbnRhdGlvbiAoaGFy" +
           "ZHdhcmUgJiBzb2Z0d2FyZSkgaXMgY2FwYWJsZSBvZgAuAEQUAAAAAAP/////AwP/////AAAAADVgiQoC" +
           "AAAAAQATAAAAU3RydWN0dXJlSWRlbnRpZmllcgEBFQADAAAAACAAAABJZGVudGlmaWVyIG9mIHRoZSBz" +
           "dHJ1Y3R1cmUgdHlwZQAuAEQVAAAAAAz/////AwP/////AAAAADVgiQoCAAAAAQAZAAAAU3RydWN0dXJl" +
           "U2lnbmF0dXJlVmVyc2lvbgEBFgADAAAAAD8AAABWZXJzaW9uIG9mIHRoZSBhbGdvcml0aG0gZm9yIGNh" +
           "bGN1bGF0aW5nIHRoZSBTdHJ1Y3R1cmVTaWduYXR1cmUALgBEFgAAAAAF/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// Base-ID of the SafetyProvider
        /// </summary>
        public PropertyState<Guid> SafetyBaseID
        {
            get
            {
                return m_safetyBaseID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_safetyBaseID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_safetyBaseID = value;
            }
        }

        /// <summary>
        /// SafetyProviderDelay is the maximum time at the SafetyProvider from receiving the RequestSPDU to start the transmission of ResponseSPDU
        /// </summary>
        public PropertyState<uint> SafetyProviderDelay
        {
            get
            {
                return m_safetyProviderDelay;
            }

            set
            {
                if (!Object.ReferenceEquals(m_safetyProviderDelay, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_safetyProviderDelay = value;
            }
        }

        /// <summary>
        /// Provider-ID of the SafetyProvider
        /// </summary>
        public PropertyState<uint> SafetyProviderID
        {
            get
            {
                return m_safetyProviderID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_safetyProviderID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_safetyProviderID = value;
            }
        }

        /// <summary>
        /// The maximal SIL the SafetyProvider implementation (hardware & software) is capable of
        /// </summary>
        public PropertyState<byte> SafetyProviderLevel
        {
            get
            {
                return m_safetyProviderLevel;
            }

            set
            {
                if (!Object.ReferenceEquals(m_safetyProviderLevel, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_safetyProviderLevel = value;
            }
        }

        /// <summary>
        /// Identifier of the structure type
        /// </summary>
        public PropertyState<string> StructureIdentifier
        {
            get
            {
                return m_structureIdentifier;
            }

            set
            {
                if (!Object.ReferenceEquals(m_structureIdentifier, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_structureIdentifier = value;
            }
        }

        /// <summary>
        /// Version of the algorithm for calculating the StructureSignature
        /// </summary>
        public PropertyState<ushort> StructureSignatureVersion
        {
            get
            {
                return m_structureSignatureVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_structureSignatureVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_structureSignatureVersion = value;
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
            if (m_safetyBaseID != null)
            {
                children.Add(m_safetyBaseID);
            }

            if (m_safetyProviderDelay != null)
            {
                children.Add(m_safetyProviderDelay);
            }

            if (m_safetyProviderID != null)
            {
                children.Add(m_safetyProviderID);
            }

            if (m_safetyProviderLevel != null)
            {
                children.Add(m_safetyProviderLevel);
            }

            if (m_structureIdentifier != null)
            {
                children.Add(m_structureIdentifier);
            }

            if (m_structureSignatureVersion != null)
            {
                children.Add(m_structureSignatureVersion);
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
                case Prefix2.BrowseNames.SafetyBaseID:
                {
                    if (createOrReplace)
                    {
                        if (SafetyBaseID == null)
                        {
                            if (replacement == null)
                            {
                                SafetyBaseID = new PropertyState<Guid>(this);
                            }
                            else
                            {
                                SafetyBaseID = (PropertyState<Guid>)replacement;
                            }
                        }
                    }

                    instance = SafetyBaseID;
                    break;
                }

                case Prefix2.BrowseNames.SafetyProviderDelay:
                {
                    if (createOrReplace)
                    {
                        if (SafetyProviderDelay == null)
                        {
                            if (replacement == null)
                            {
                                SafetyProviderDelay = new PropertyState<uint>(this);
                            }
                            else
                            {
                                SafetyProviderDelay = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = SafetyProviderDelay;
                    break;
                }

                case Prefix2.BrowseNames.SafetyProviderID:
                {
                    if (createOrReplace)
                    {
                        if (SafetyProviderID == null)
                        {
                            if (replacement == null)
                            {
                                SafetyProviderID = new PropertyState<uint>(this);
                            }
                            else
                            {
                                SafetyProviderID = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = SafetyProviderID;
                    break;
                }

                case Prefix2.BrowseNames.SafetyProviderLevel:
                {
                    if (createOrReplace)
                    {
                        if (SafetyProviderLevel == null)
                        {
                            if (replacement == null)
                            {
                                SafetyProviderLevel = new PropertyState<byte>(this);
                            }
                            else
                            {
                                SafetyProviderLevel = (PropertyState<byte>)replacement;
                            }
                        }
                    }

                    instance = SafetyProviderLevel;
                    break;
                }

                case Prefix2.BrowseNames.StructureIdentifier:
                {
                    if (createOrReplace)
                    {
                        if (StructureIdentifier == null)
                        {
                            if (replacement == null)
                            {
                                StructureIdentifier = new PropertyState<string>(this);
                            }
                            else
                            {
                                StructureIdentifier = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = StructureIdentifier;
                    break;
                }

                case Prefix2.BrowseNames.StructureSignatureVersion:
                {
                    if (createOrReplace)
                    {
                        if (StructureSignatureVersion == null)
                        {
                            if (replacement == null)
                            {
                                StructureSignatureVersion = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                StructureSignatureVersion = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = StructureSignatureVersion;
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
        private PropertyState<Guid> m_safetyBaseID;
        private PropertyState<uint> m_safetyProviderDelay;
        private PropertyState<uint> m_safetyProviderID;
        private PropertyState<byte> m_safetyProviderLevel;
        private PropertyState<string> m_structureIdentifier;
        private PropertyState<ushort> m_structureSignatureVersion;
        #endregion
    }
    #endif
    #endregion
}