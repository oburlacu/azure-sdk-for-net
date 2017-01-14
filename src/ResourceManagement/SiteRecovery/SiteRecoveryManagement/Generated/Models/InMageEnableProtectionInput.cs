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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// InMage specific enable protection input.
    /// </summary>
    public partial class InMageEnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        private string _datastoreName;
        
        /// <summary>
        /// Optional. The target datastore name.
        /// </summary>
        public string DatastoreName
        {
            get { return this._datastoreName; }
            set { this._datastoreName = value; }
        }
        
        private InMageDiskExclusionInput _diskExclusionInput;
        
        /// <summary>
        /// Optional. The enable disk exclusion input.
        /// </summary>
        public InMageDiskExclusionInput DiskExclusionInput
        {
            get { return this._diskExclusionInput; }
            set { this._diskExclusionInput = value; }
        }
        
        private IList<string> _disksToExclude;
        
        /// <summary>
        /// Optional. The disk exclusion list.
        /// </summary>
        public IList<string> DisksToExclude
        {
            get { return this._disksToExclude; }
            set { this._disksToExclude = value; }
        }
        
        private string _masterTargetId;
        
        /// <summary>
        /// Optional. The Master Target Id.
        /// </summary>
        public string MasterTargetId
        {
            get { return this._masterTargetId; }
            set { this._masterTargetId = value; }
        }
        
        private string _multiVmGroupId;
        
        /// <summary>
        /// Optional. The multi vm group Id.
        /// </summary>
        public string MultiVmGroupId
        {
            get { return this._multiVmGroupId; }
            set { this._multiVmGroupId = value; }
        }
        
        private string _multiVmGroupName;
        
        /// <summary>
        /// Optional. The multi vm group name.
        /// </summary>
        public string MultiVmGroupName
        {
            get { return this._multiVmGroupName; }
            set { this._multiVmGroupName = value; }
        }
        
        private string _processServerId;
        
        /// <summary>
        /// Optional. The Process Server Id.
        /// </summary>
        public string ProcessServerId
        {
            get { return this._processServerId; }
            set { this._processServerId = value; }
        }
        
        private string _retentionDrive;
        
        /// <summary>
        /// Optional. The retention drive to use on the MT.
        /// </summary>
        public string RetentionDrive
        {
            get { return this._retentionDrive; }
            set { this._retentionDrive = value; }
        }
        
        private string _runAsAccountId;
        
        /// <summary>
        /// Optional. The CS account Id.
        /// </summary>
        public string RunAsAccountId
        {
            get { return this._runAsAccountId; }
            set { this._runAsAccountId = value; }
        }
        
        private string _vmFriendlyName;
        
        /// <summary>
        /// Optional. The Vm Name.
        /// </summary>
        public string VmFriendlyName
        {
            get { return this._vmFriendlyName; }
            set { this._vmFriendlyName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the InMageEnableProtectionInput class.
        /// </summary>
        public InMageEnableProtectionInput()
        {
            this.DisksToExclude = new LazyList<string>();
        }
    }
}
