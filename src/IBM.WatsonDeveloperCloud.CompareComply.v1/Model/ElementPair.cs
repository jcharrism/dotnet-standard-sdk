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
    /// An array listing details of semantically aligned elements.
    /// </summary>
    public class ElementPair : BaseModel
    {
        /// <summary>
        /// The label of the document (that is, the value of either the `file1_label` or `file2_label` parameters) in
        /// which the element occurs.
        /// </summary>
        [JsonProperty("document_label", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentLabel { get; set; }
        /// <summary>
        /// The text of the sentence in which the element occurs.
        /// </summary>
        [JsonProperty("sentence_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SentenceText { get; set; }
        /// <summary>
        /// The numeric location of the identified element in the document, represented with two integers labeled
        /// `begin` and `end`.
        /// </summary>
        [JsonProperty("sentence", NullValueHandling = NullValueHandling.Ignore)]
        public List<Location> Sentence { get; set; }
        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<Types> Types { get; set; }
        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<Categories> Categories { get; set; }
    }

}
