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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery
{
    /// <summary>
    /// Definition for Job Operations.
    /// </summary>
    public partial interface IJobOperations
    {
        /// <summary>
        /// Cancel the job.
        /// </summary>
        /// <param name='jobId'>
        /// Job ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> CancelAsync(string jobId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the job details.
        /// </summary>
        /// <param name='jobId'>
        /// Job ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> GetAsync(string jobId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all jobs.
        /// </summary>
        /// <param name='parameters'>
        /// Job query parameter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list Jobs operation.
        /// </returns>
        Task<JobListResponse> ListAsync(JobQueryParameter parameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Restart the Asr job.
        /// </summary>
        /// <param name='jobId'>
        /// Job ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> RestartAsync(string jobId, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Resume the Asr job .
        /// </summary>
        /// <param name='jobId'>
        /// Job ID.
        /// </param>
        /// <param name='resumeJobParameters'>
        /// Resume job parameters.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Job details object.
        /// </returns>
        Task<JobResponse> ResumeAsync(string jobId, ResumeJobParams resumeJobParameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
    }
}
