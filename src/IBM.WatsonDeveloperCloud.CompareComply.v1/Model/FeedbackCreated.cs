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
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.CompareComply.v1.Model
{
    /// <summary>
    /// An object that lists information about the document and the submitted feedback.
    /// </summary>
    public class FeedbackCreated : BaseModel
    {
        /// <summary>
        /// The unique ID of the feedback object.
        /// </summary>
        [JsonProperty("feedback_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FeedbackId { get; set; }
        /// <summary>
        /// An optional string identifying the person submitting feedback.
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }
        /// <summary>
        /// The type of feedback that was created. The only current value is `element_classification`.
        /// </summary>
        [JsonProperty("feedback_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FeedbackType { get; set; }
        /// <summary>
        /// Gets or Sets FeedbackData
        /// </summary>
        [JsonProperty("feedback_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<FeedbackDataOutputObject> FeedbackData { get; set; }
    }

}
