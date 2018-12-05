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
    /// The original labeling from the input document, without the submitted feedback.
    /// </summary>
    public class OriginalLabelsOut : BaseModel
    {
        /// <summary>
        /// A string identifying the type of modification the feedback entry in the `updated_labels` array. Possible
        /// values are `added`, `not_changed`, and `removed`.
        /// </summary>
        /// <value>
        /// A string identifying the type of modification the feedback entry in the `updated_labels` array. Possible
        /// values are `added`, `not_changed`, and `removed`.
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
            /// Enum NOT_CHANGED for not_changed
            /// </summary>
            [EnumMember(Value = "not_changed")]
            NOT_CHANGED,
            
            /// <summary>
            /// Enum REMOVED for removed
            /// </summary>
            [EnumMember(Value = "removed")]
            REMOVED
        }

        /// <summary>
        /// A string identifying the type of modification the feedback entry in the `updated_labels` array. Possible
        /// values are `added`, `not_changed`, and `removed`.
        /// </summary>
        [JsonProperty("modification", NullValueHandling = NullValueHandling.Ignore)]
        public ModificationEnum? Modification { get; set; }
        /// <summary>
        /// Description of the action specified by the element and whom it affects.
        /// </summary>
        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<TypeLabel> Types { get; set; }
        /// <summary>
        /// List of functional categories into which the element falls; in other words, the subject matter of the
        /// element.
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<Category> Categories { get; set; }
    }

}
