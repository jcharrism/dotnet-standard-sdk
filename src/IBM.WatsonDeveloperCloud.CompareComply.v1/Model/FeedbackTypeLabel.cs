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

using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IBM.WatsonDeveloperCloud.CompareComply.v1.Model
{
    /// <summary>
    /// An object containing information about the submitted feedback.
    /// </summary>
    public class FeedbackTypeLabel : BaseModel
    {
        /// <summary>
        /// A string that lists the modification status of the label. Possible values are `added`, `removed`, and
        /// `unchanged`.
        /// </summary>
        /// <value>
        /// A string that lists the modification status of the label. Possible values are `added`, `removed`, and
        /// `unchanged`.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModificationEnum
        {
            
            /// <summary>
            /// Enum ADDED for added
            /// </summary>
            [EnumMember(Value = "added")]
            ADDED,
            
            /// <summary>
            /// Enum REMOVED for removed
            /// </summary>
            [EnumMember(Value = "removed")]
            REMOVED,
            
            /// <summary>
            /// Enum UNCHANGED for unchanged
            /// </summary>
            [EnumMember(Value = "unchanged")]
            UNCHANGED
        }

        /// <summary>
        /// A string that lists the modification status of the label. Possible values are `added`, `removed`, and
        /// `unchanged`.
        /// </summary>
        [JsonProperty("modification", NullValueHandling = NullValueHandling.Ignore)]
        public ModificationEnum? Modification { get; set; }
        /// <summary>
        /// An array listing the `nature` and `party` of the element.
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeLabel> Label { get; set; }
        /// <summary>
        /// The strings listed in the `provenance_ids` array are hashed values that you can send to IBM to provide
        /// feedback or receive support about the part of the analysis associated with the element.
        /// </summary>
        [JsonProperty("provenance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProvenanceIDs> ProvenanceIds { get; set; }
    }

}
