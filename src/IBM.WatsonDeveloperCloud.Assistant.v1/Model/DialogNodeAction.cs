/**
* Copyright 2018 IBM Corp. All Rights Reserved.
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

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IBM.WatsonDeveloperCloud.Assistant.v1.Model
{
    /// <summary>
    /// DialogNodeAction.
    /// </summary>
    public class DialogNodeAction : BaseModel
    {
        /// <summary>
        /// The type of action to invoke.
        /// </summary>
        /// <value>
        /// The type of action to invoke.
        /// </value>
        public class ActionTypeValue
        {

            /// <summary>
            /// Enum CLIENT for client
            /// </summary>
            public const string CLIENT = "client";

            /// <summary>
            /// Enum SERVER for server
            /// </summary>
            public const string SERVER = "server";

            /// <summary>
            /// Enum CLOUD_FUNCTION for cloud_function
            /// </summary>
            public const string CLOUD_FUNCTION = "cloud_function";

            /// <summary>
            /// Enum WEB_ACTION for web_action
            /// </summary>
            public const string WEB_ACTION = "web_action";
        }

        /// <summary>
        /// The type of action to invoke.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionType { get; set; }
        /// <summary>
        /// The name of the action.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// A map of key/value pairs to be provided to the action.
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Parameters { get; set; }
        /// <summary>
        /// The location in the dialog context where the result of the action is stored.
        /// </summary>
        [JsonProperty("result_variable", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultVariable { get; set; }
        /// <summary>
        /// The name of the context variable that the client application will use to pass in credentials for the action.
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public string Credentials { get; set; }
    }

}
