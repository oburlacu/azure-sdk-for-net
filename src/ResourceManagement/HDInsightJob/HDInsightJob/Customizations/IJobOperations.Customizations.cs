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

using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System;
using Microsoft.Azure.Management.HDInsight.Job.Models;

namespace Microsoft.Azure.Management.HDInsight.Job
{
    /// <summary>
    /// Operations for managing jobs against HDInsight clusters.
    /// </summary>
    public partial interface IJobOperations
    {
        /// <summary>
        /// Gets the output from the execution of an individual jobDetails.
        /// </summary>
        /// <param name="jobId">
        /// Required. The id of the job.
        /// </param>
        /// <param name="storageAccess">
        /// Required. The storage account object of type IStorageAccess.
        /// </param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// The output of an individual jobDetails by jobId.
        /// </returns>
        Task<Stream> GetJobOutputAsync(string jobId, IStorageAccess storageAccess, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the error logs from the execution of an individual jobDetails.
        /// </summary>
        /// <param name="jobId">
        /// Required. The id of the job.
        /// </param>
        /// <param name="storageAccess">
        /// Required. The storage account object of type IStorageAccess.
        /// </param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// The error logs of an individual jobDetails by jobId.
        /// </returns>
        Task<Stream> GetJobErrorLogsAsync(string jobId, IStorageAccess storageAccess, CancellationToken cancellationToken);
    }
}
