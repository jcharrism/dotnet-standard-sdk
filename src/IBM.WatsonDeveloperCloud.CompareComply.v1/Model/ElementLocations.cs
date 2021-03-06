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

using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.CompareComply.v1.Model
{
    /// <summary>
    /// A list of `begin` and `end` indexes that indicate the locations of the elements in the input document.
    /// </summary>
    public class ElementLocations : BaseModel
    {
        /// <summary>
        /// An integer that indicates the starting position of the element in the input document.
        /// </summary>
        [JsonProperty("begin", NullValueHandling = NullValueHandling.Ignore)]
        public long? Begin { get; set; }
        /// <summary>
        /// An integer that indicates the ending position of the element in the input document.
        /// </summary>
        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public long? End { get; set; }
    }

}
