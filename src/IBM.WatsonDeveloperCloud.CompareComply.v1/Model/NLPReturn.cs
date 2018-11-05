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
    /// The analysis of objects returned by the `/v1/element_classification` method.
    /// </summary>
    public class NLPReturn : BaseModel
    {
        /// <summary>
        /// MD5 hash of the input document.
        /// </summary>
        [JsonProperty("hash", NullValueHandling = NullValueHandling.Ignore)]
        public string Hash { get; set; }
        /// <summary>
        /// Information about the input document.
        /// </summary>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public object Document { get; set; }
        /// <summary>
        /// The analysis model used to classify the input document. For the `/v1/element_classification` method, the
        /// only valid value is `contracts`.
        /// </summary>
        [JsonProperty("model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelId { get; set; }
        /// <summary>
        /// The version of the analysis model identified by the value of the `model_id` key.
        /// </summary>
        [JsonProperty("model_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelVersion { get; set; }
        /// <summary>
        /// An array listing each identified element in the input document, along with model analysis.
        /// </summary>
        [JsonProperty("elements", NullValueHandling = NullValueHandling.Ignore)]
        public List<Element> Elements { get; set; }
        /// <summary>
        /// An array describing any tables identified in the input document.
        /// </summary>
        [JsonProperty("tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<TablesArray> Tables { get; set; }
        /// <summary>
        /// An object describing the structure of the input document.
        /// </summary>
        [JsonProperty("doc_structure", NullValueHandling = NullValueHandling.Ignore)]
        public NLPReturnDocStructure DocStructure { get; set; }
        /// <summary>
        /// An array defining the parties affected by the input document.
        /// </summary>
        [JsonProperty("parties", NullValueHandling = NullValueHandling.Ignore)]
        public List<PartiesObject> Parties { get; set; }
        /// <summary>
        /// An array identifying the effective dates of the contract.
        /// </summary>
        [JsonProperty("effective_dates", NullValueHandling = NullValueHandling.Ignore)]
        public List<EffectiveDatesObject> EffectiveDates { get; set; }
        /// <summary>
        /// An array listing the monetary amounts identified in the input document.
        /// </summary>
        [JsonProperty("contract_amounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContractAmtsObject> ContractAmounts { get; set; }
    }

}
