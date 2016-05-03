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
    /// Hyper V Replica Azure Provider specific entity details.
    /// </summary>
    public partial class HyperVReplicaAzureReplicationDetails : ReplicationProviderSpecificSettings
    {
        private IList<AzureVmDiskDetails> _azureVMDiskDetails;
        
        /// <summary>
        /// Optional. Gets or sets Azure VM Disk details.
        /// </summary>
        public IList<AzureVmDiskDetails> AzureVMDiskDetails
        {
            get { return this._azureVMDiskDetails; }
            set { this._azureVMDiskDetails = value; }
        }
        
        private string _encryption;
        
        /// <summary>
        /// Optional. Gets or sets the encryption info.
        /// </summary>
        public string Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }
        
        private InitialReplicationDetails _initialReplicationDetails;
        
        /// <summary>
        /// Optional. Gets or sets initial replication details.
        /// </summary>
        public InitialReplicationDetails InitialReplicationDetails
        {
            get { return this._initialReplicationDetails; }
            set { this._initialReplicationDetails = value; }
        }
        
        private System.DateTime? _lastReplicatedTime;
        
        /// <summary>
        /// Optional. Gets or sets the Last replication time.
        /// </summary>
        public System.DateTime? LastReplicatedTime
        {
            get { return this._lastReplicatedTime; }
            set { this._lastReplicatedTime = value; }
        }
        
        private OSDetails _oSDetails;
        
        /// <summary>
        /// Optional. Type of the OS on the VM.
        /// </summary>
        public OSDetails OSDetails
        {
            get { return this._oSDetails; }
            set { this._oSDetails = value; }
        }
        
        private string _recoveryAzureStorageAccount;
        
        /// <summary>
        /// Optional. Gets or sets the recovery Azure storage account.
        /// </summary>
        public string RecoveryAzureStorageAccount
        {
            get { return this._recoveryAzureStorageAccount; }
            set { this._recoveryAzureStorageAccount = value; }
        }
        
        private string _recoveryAzureVMName;
        
        /// <summary>
        /// Optional. Gets or sets Recovery Azure given name.
        /// </summary>
        public string RecoveryAzureVMName
        {
            get { return this._recoveryAzureVMName; }
            set { this._recoveryAzureVMName = value; }
        }
        
        private string _recoveryAzureVMSize;
        
        /// <summary>
        /// Optional. Gets or sets the Recovery Azure VM size.
        /// </summary>
        public string RecoveryAzureVMSize
        {
            get { return this._recoveryAzureVMSize; }
            set { this._recoveryAzureVMSize = value; }
        }
        
        private string _selectedRecoveryAzureNetworkId;
        
        /// <summary>
        /// Optional. Gets or sets the selected recovery azure network Id.
        /// </summary>
        public string SelectedRecoveryAzureNetworkId
        {
            get { return this._selectedRecoveryAzureNetworkId; }
            set { this._selectedRecoveryAzureNetworkId = value; }
        }
        
        private int _sourceVmCPUCount;
        
        /// <summary>
        /// Optional. Gets or sets the CPU count of the VM on the primary side.
        /// </summary>
        public int SourceVmCPUCount
        {
            get { return this._sourceVmCPUCount; }
            set { this._sourceVmCPUCount = value; }
        }
        
        private int _sourceVmRAMSizeInMB;
        
        /// <summary>
        /// Optional. Gets or sets the RAM size of the VM on the primary side.
        /// </summary>
        public int SourceVmRAMSizeInMB
        {
            get { return this._sourceVmRAMSizeInMB; }
            set { this._sourceVmRAMSizeInMB = value; }
        }
        
        private string _vmId;
        
        /// <summary>
        /// Optional. Virtual machine Id.
        /// </summary>
        public string VmId
        {
            get { return this._vmId; }
            set { this._vmId = value; }
        }
        
        private IList<VMNicDetails> _vMNics;
        
        /// <summary>
        /// Optional. Gets or sets the network details.
        /// </summary>
        public IList<VMNicDetails> VMNics
        {
            get { return this._vMNics; }
            set { this._vMNics = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureReplicationDetails class.
        /// </summary>
        public HyperVReplicaAzureReplicationDetails()
        {
            this.AzureVMDiskDetails = new LazyList<AzureVmDiskDetails>();
            this.VMNics = new LazyList<VMNicDetails>();
        }
    }
}
