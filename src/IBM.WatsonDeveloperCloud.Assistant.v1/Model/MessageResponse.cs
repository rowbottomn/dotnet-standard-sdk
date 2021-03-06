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

namespace IBM.WatsonDeveloperCloud.Assistant.v1.Model
{
    /// <summary>
    /// A response from the Watson Assistant service.
    /// </summary>
    public class MessageResponse : BaseModel
    {
        /// <summary>
        /// The text of the user input.
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Input { get; set; }
        /// <summary>
        /// An array of intents recognized in the user input, sorted in descending order of confidence.
        /// </summary>
        [JsonProperty("intents", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Intents { get; set; }
        /// <summary>
        /// An array of entities identified in the user input.
        /// </summary>
        [JsonProperty("entities", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Entities { get; set; }
        /// <summary>
        /// Whether to return more than one intent. A value of `true` indicates that all matching intents are returned.
        /// </summary>
        [JsonProperty("alternate_intents", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic AlternateIntents { get; set; }
        /// <summary>
        /// State information for the conversation. To maintain state, include the context from the previous response.
        /// </summary>
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Context { get; set; }
        /// <summary>
        /// An output object that includes the response to the user, the dialog nodes that were triggered, and messages
        /// from the log.
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Output { get; set; }
        /// <summary>
        /// An array of objects describing any actions requested by the dialog node.
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Actions { get; set; }
    }

}
