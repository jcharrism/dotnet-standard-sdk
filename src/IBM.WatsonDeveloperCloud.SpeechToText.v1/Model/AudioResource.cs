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

namespace IBM.WatsonDeveloperCloud.SpeechToText.v1.Model
{
    /// <summary>
    /// AudioResource.
    /// </summary>
    public class AudioResource : BaseModel
    {
        /// <summary>
        /// The status of the audio resource:
        /// * `ok`: The service successfully analyzed the audio data. The data can be used to train the custom model.
        /// * `being_processed`: The service is still analyzing the audio data. The service cannot accept requests to
        /// add new audio resources or to train the custom model until its analysis is complete.
        /// * `invalid`: The audio data is not valid for training the custom model (possibly because it has the wrong
        /// format or sampling rate, or because it is corrupted). For an archive file, the entire archive is invalid if
        /// any of its audio files are invalid.
        /// </summary>
        /// <value>
        /// The status of the audio resource:
        /// * `ok`: The service successfully analyzed the audio data. The data can be used to train the custom model.
        /// * `being_processed`: The service is still analyzing the audio data. The service cannot accept requests to
        /// add new audio resources or to train the custom model until its analysis is complete.
        /// * `invalid`: The audio data is not valid for training the custom model (possibly because it has the wrong
        /// format or sampling rate, or because it is corrupted). For an archive file, the entire archive is invalid if
        /// any of its audio files are invalid.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum OK for ok
            /// </summary>
            [EnumMember(Value = "ok")]
            OK,
            
            /// <summary>
            /// Enum BEING_PROCESSED for being_processed
            /// </summary>
            [EnumMember(Value = "being_processed")]
            BEING_PROCESSED,
            
            /// <summary>
            /// Enum INVALID for invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            INVALID
        }

        /// <summary>
        /// The status of the audio resource:
        /// * `ok`: The service successfully analyzed the audio data. The data can be used to train the custom model.
        /// * `being_processed`: The service is still analyzing the audio data. The service cannot accept requests to
        /// add new audio resources or to train the custom model until its analysis is complete.
        /// * `invalid`: The audio data is not valid for training the custom model (possibly because it has the wrong
        /// format or sampling rate, or because it is corrupted). For an archive file, the entire archive is invalid if
        /// any of its audio files are invalid.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The total seconds of audio in the audio resource. The value is always a whole number.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public double? Duration { get; set; }
        /// <summary>
        /// **For an archive-type resource,** the user-specified name of the resource.
        ///
        /// **For an audio-type resource,** the user-specified name of the resource or the name of the audio file that
        /// the user added for the resource. The value depends on the method that is called.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// An `AudioDetails` object that provides detailed information about the audio resource. The object is empty
        /// until the service finishes processing the audio.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public AudioDetails Details { get; set; }
    }

}
