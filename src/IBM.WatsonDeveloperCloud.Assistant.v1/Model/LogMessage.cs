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
    /// Log message details.
    /// </summary>
    public class LogMessage : BaseModel
    {
        /// <summary>
        /// The severity of the log message.
        /// </summary>
        public class LevelValue
        {

            /// <summary>
            /// Const INFO for info
            /// </summary>
            public const string INFO = "info";

            /// <summary>
            /// Const ERROR for error
            /// </summary>
            public const string ERROR = "error";

            /// <summary>
            /// Const WARN for warn
            /// </summary>
            public const string WARN = "warn";
        }

        /// <summary>
        /// The severity of the log message.
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }
        /// <summary>
        /// The text of the log message.
        /// </summary>
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }
    }
}
