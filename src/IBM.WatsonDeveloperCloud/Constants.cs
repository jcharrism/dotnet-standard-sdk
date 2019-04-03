﻿/**
* Copyright 2017 IBM Corp. All Rights Reserved.
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

namespace IBM.WatsonDeveloperCloud
{
    /// <summary>
    /// This class holds constant values for the SDK.
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// The version number for this SDK build. Added to the header in 
        /// each request as `User-Agent`.
        /// </summary>
        public static readonly string SDK_VERSION = "watson-apis-dotnet-sdk-2.17.0";
        /// <summary>
        /// A constant used to access custom request headers in the dynamic
        /// customData object.
        /// </summary>
        public static readonly string CUSTOM_REQUEST_HEADERS = "custom_request_headers";
        /// <summary>
        /// A constant used to access response headers in the dynamic
        /// customData object.
        /// </summary>
        public static readonly string RESPONSE_HEADERS = "response_headers";
        /// <summary>
        /// A constnat used to access response json in the dynamic customData
        /// object.
        /// </summary>
        public static readonly string JSON = "json";
    }
}
