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
    /// An object describing the leading sentences in a section or subsection of the input document.
    /// </summary>
    public class LeadingSentenceObject : BaseModel
    {
        /// <summary>
        /// The text of the leading sentence.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>
        /// The location of the leading sentence as defined by its `begin` and `end` indexes in the input document.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public object Location { get; set; }
        /// <summary>
        /// An array containing objects that specify the `begin` and `end` values of the sentences in the section.
        /// </summary>
        [JsonProperty("element_locations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ElementLocations> ElementLocations { get; set; }
    }

}
