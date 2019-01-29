/**
* Copyright 2019 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;

namespace IBM.WatsonDeveloperCloud.Common
{
    public class Utils
    {
        /// <summary>
        /// The version number for this SDK build. Added to the header in 
        /// each request as `User-Agent`.
        /// </summary>
        public const string SDK_VERSION = "watson-apis-dotnet-sdk/2.13.0";

        /// <summary>
        /// Get a dictionary of default headers to use with service calls.
        /// </summary>
        /// <returns>Default headers</returns>
        public static Dictionary<string, string> GetDefaultHeaders()
        {
            return GetDefaultHeaders(null, null);
        }

        /// <summary>
        /// Get a dictionary of default headers to use with service calls.
        /// </summary>
        /// <param name="serviceName">The name of the service being used.</param>
        /// <param name="operationName">The operation being called.</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetDefaultHeaders(string serviceName, string operationName)
        {
            Dictionary<string, string> defaultHeaders = new Dictionary<string, string>();

            defaultHeaders.Add("User-Agent",
                string.Format(
                    "{0} {1} {2}",
                    SDK_VERSION,
                    System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                    System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription
                ));

            if (!string.IsNullOrEmpty(serviceName) && !string.IsNullOrEmpty(operationName))
            {
                defaultHeaders.Add("X-IBMCloud-SDK-Analytics",
                    string.Format(
                        "operation_id={0};service_name={1};async=false",
                        operationName, 
                        serviceName));
            }

            return defaultHeaders;
        }
    }
}
