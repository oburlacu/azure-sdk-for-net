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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// Operations for managing Users.
    /// </summary>
    public partial interface IUsersOperations
    {
        /// <summary>
        /// Creates new user.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='uid'>
        /// Identifier of the user.
        /// </param>
        /// <param name='parameters'>
        /// Create or update parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> CreateAsync(string resourceGroupName, string serviceName, string uid, UserCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes specific user.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='uid'>
        /// Identifier of the user.
        /// </param>
        /// <param name='etag'>
        /// ETag.
        /// </param>
        /// <param name='deleteSubscriptions'>
        /// Whether to delete user's subscription or not.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string serviceName, string uid, string etag, bool deleteSubscriptions, CancellationToken cancellationToken);
        
        /// <summary>
        /// Generates SSO URL.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='uid'>
        /// Identifier of the user.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Generate SSO Url operations response details.
        /// </returns>
        Task<GenerateSsoUrlResponse> GenerateSsoUrlAsync(string resourceGroupName, string serviceName, string uid, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets specific user.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='uid'>
        /// Identifier of the user.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Get User operation response details.
        /// </returns>
        Task<UserGetResponse> GetAsync(string resourceGroupName, string serviceName, string uid, CancellationToken cancellationToken);
        
        /// <summary>
        /// List all users.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List Users operation response details.
        /// </returns>
        Task<UserListResponse> ListAsync(string resourceGroupName, string serviceName, QueryParameters query, CancellationToken cancellationToken);
        
        /// <summary>
        /// List all users.
        /// </summary>
        /// <param name='nextLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List Users operation response details.
        /// </returns>
        Task<UserListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates specific user.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='uid'>
        /// Identifier of the user.
        /// </param>
        /// <param name='parameters'>
        /// Update parameters.
        /// </param>
        /// <param name='etag'>
        /// ETag.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> UpdateAsync(string resourceGroupName, string serviceName, string uid, UserUpdateParameters parameters, string etag, CancellationToken cancellationToken);
    }
}