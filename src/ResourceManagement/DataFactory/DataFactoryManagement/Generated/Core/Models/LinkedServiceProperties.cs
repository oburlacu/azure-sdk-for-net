// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.DataFactories.Core.Models
{
    /// <summary>
    /// Data factory linkedService properties.
    /// </summary>
    public partial class LinkedServiceProperties
    {
        private uint? _concurrency;
        
        /// <summary>
        /// Optional. The maximum number of concurrent jobs executed on this
        /// compute linked service. If not specified, there is no limit to the
        /// number of concurrent jobs.
        /// </summary>
        public uint? Concurrency
        {
            get { return this._concurrency; }
            set { this._concurrency = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Data factory linkedService description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Error in processing linkedService request.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private string _hubName;
        
        /// <summary>
        /// Optional. The name of the Hub that this linked service belongs to.
        /// </summary>
        public string HubName
        {
            get { return this._hubName; }
            set { this._hubName = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. The provisioning state of the linked service.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. The type of the linked service. May be the name of a
        /// build-in ADF type or a type registered by a user and available to
        /// the data factory this linked service is a member of.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _typeProperties;
        
        /// <summary>
        /// Required. The properties specific to the linked service type.
        /// </summary>
        public string TypeProperties
        {
            get { return this._typeProperties; }
            set { this._typeProperties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LinkedServiceProperties class.
        /// </summary>
        public LinkedServiceProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the LinkedServiceProperties class
        /// with required arguments.
        /// </summary>
        public LinkedServiceProperties(string type, string typeProperties)
            : this()
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            if (typeProperties == null)
            {
                throw new ArgumentNullException("typeProperties");
            }
            this.Type = type;
            this.TypeProperties = typeProperties;
        }
    }
}
