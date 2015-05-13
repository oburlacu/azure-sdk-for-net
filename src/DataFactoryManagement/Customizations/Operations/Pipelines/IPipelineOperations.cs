﻿// 
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

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    /// <summary>
    /// Operations for managing pipelines.
    /// </summary>
    public interface IPipelineOperations
    {
        /// <summary>
        /// Create or update a pipeline instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update pipeline operation response.
        /// </returns>
        Task<PipelineCreateOrUpdateResponse> BeginCreateOrUpdateAsync(
            string resourceGroupName,
            string dataFactoryName,
            PipelineCreateOrUpdateParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Create a new pipeline instance with raw JSON content.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='dataPipelineName'>
        /// A unique pipeline instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create a pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update pipeline operation response.
        /// </returns>
        Task<PipelineCreateOrUpdateResponse> BeginCreateOrUpdateWithRawJsonContentAsync(
            string resourceGroupName,
            string dataFactoryName,
            string dataPipelineName,
            PipelineCreateOrUpdateWithRawJsonContentParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Delete a pipeline instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='dataPipelineName'>
        /// Name of the data pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginDeleteAsync(
            string resourceGroupName,
            string dataFactoryName,
            string dataPipelineName,
            CancellationToken cancellationToken);

        /// <summary>
        /// Create or update a pipeline instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update pipeline operation response.
        /// </returns>
        Task<PipelineCreateOrUpdateResponse> CreateOrUpdateAsync(
            string resourceGroupName,
            string dataFactoryName,
            PipelineCreateOrUpdateParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Create a new pipeline instance with raw JSON content.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='dataPipelineName'>
        /// A unique pipeline instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update pipeline operation response.
        /// </returns>
        Task<PipelineCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(
            string resourceGroupName,
            string dataFactoryName,
            string dataPipelineName,
            PipelineCreateOrUpdateWithRawJsonContentParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Delete a pipeline instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='dataPipelineName'>
        /// Name of the data pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> DeleteAsync(
            string resourceGroupName,
            string dataFactoryName,
            string dataPipelineName,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets a pipeline instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='dataPipelineName'>
        /// Name of the data pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get pipeline operation response.
        /// </returns>
        Task<PipelineGetResponse> GetAsync(
            string resourceGroupName,
            string dataFactoryName,
            string dataPipelineName,
            CancellationToken cancellationToken);

        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The create or update pipeline operation response.
        /// </returns>
        Task<PipelineCreateOrUpdateResponse> GetCreateOrUpdateStatusAsync(
            string operationStatusLink,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets the first page of pipeline instances with the link to the next
        /// page.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List pipeline operation response.
        /// </returns>
        Task<PipelineListResponse> ListAsync(
            string resourceGroupName,
            string dataFactoryName,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets the next page of pipeline instances with the link to the next
        /// page.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next pipelines page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List pipeline operation response.
        /// </returns>
        Task<PipelineListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);

        /// <summary>
        /// Resume a suspended pipeline.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='dataPipelineName'>
        /// Name of the data pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> ResumeAsync(
            string resourceGroupName,
            string dataFactoryName,
            string dataPipelineName,
            CancellationToken cancellationToken);

        /// <summary>
        /// Sets the active period of a pipeline.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='dataPipelineName'>
        /// Name of the data pipeline.
        /// </param>
        /// <param name='parameters'>
        /// Parameters required to set the active period of a pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> SetActivePeriodAsync(
            string resourceGroupName,
            string dataFactoryName,
            string dataPipelineName,
            PipelineSetActivePeriodParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Suspend a running pipeline.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='dataPipelineName'>
        /// Name of the data pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> SuspendAsync(
            string resourceGroupName,
            string dataFactoryName,
            string dataPipelineName,
            CancellationToken cancellationToken);
    }
}