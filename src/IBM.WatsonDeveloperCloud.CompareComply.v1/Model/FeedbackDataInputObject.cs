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
    /// An array containing feedback data for submission.
    /// </summary>
    public class FeedbackDataInputObject : BaseModel
    {
        /// <summary>
        /// A string identifying the user adding the feedback. The only permitted value is `element_classification`.
        /// </summary>
        [JsonProperty("feedback_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FeedbackType { get; set; }
        /// <summary>
        /// An optional string identifying the title of the document.
        /// </summary>
        [JsonProperty("document_title", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentTitle { get; set; }
        /// <summary>
        /// An optional string identifying the model ID. The only permitted value is `contracts`.
        /// </summary>
        [JsonProperty("model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelId { get; set; }
        /// <summary>
        /// An optional string identifying the version of the model used.
        /// </summary>
        [JsonProperty("model_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelVersion { get; set; }
        /// <summary>
        /// Gets or Sets OriginalLabels
        /// </summary>
        [JsonProperty("original_labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<OriginalLabelsIn> OriginalLabels { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedLabels
        /// </summary>
        [JsonProperty("updated_labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdatedLabelsIn> UpdatedLabels { get; set; }
    }

}
