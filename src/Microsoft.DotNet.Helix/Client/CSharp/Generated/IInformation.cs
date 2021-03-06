// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Information operations.
    /// </summary>
    public partial interface IInformation
    {
        /// <summary>
        /// Return queue info queried from Tags on Azure scaleset. The info
        /// includes:
        /// 1. Whether the queue exists.
        /// 2. Friendly description (if available) of queue, otherwise
        /// instructions how to fix that (ping dnceng)
        /// 3. Path to place the Jenkins workspace on disk.
        /// 4. Whether queue is used for internal customers only.
        /// 5. What OS the machines in the group use (windows/linux/osx).
        /// 6. List of users to which this queue is restricted, “all” if the
        /// queue is NOT restricted.
        /// 7. If the machine is on premises
        /// 8. What is the current Queue Depth (Number of messages still in the
        /// queue)
        /// </summary>
        /// <param name='queueId'>
        /// .NET Helix Queue Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<QueueInfo>> QueueInfoMethodWithHttpMessagesAsync(string queueId, Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Return queue info queried from Tags on Azure scaleset. The info
        /// includes:
        /// 1. Whether the queue exists.
        /// 2. Friendly description (if available) of queue, otherwise
        /// instructions how to fix that (ping dnceng)
        /// 3. Path to place the Jenkins workspace on disk.
        /// 4. Whether queue is used for internal customers only.
        /// 5. What OS the machines in the group use (windows/linux/osx).
        /// 6. List of users to which this queue is restricted, “all” if the
        /// queue is NOT restricted.
        /// 7. If the machine is on premises
        /// 8. What is the current Queue Depth (Number of messages still in the
        /// queue)
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<IList<QueueInfo>>> QueueInfoListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
