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
    /// A message request formatted for the Watson Assistant service.
    /// </summary>
    public class MessageRequest : BaseModel
    {
        /// <summary>
        /// The user input.
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Input { get; set; }
        /// <summary>
        /// Whether to return more than one intent. Set to `true` to return all matching intents.
        /// </summary>
        [JsonProperty("alternate_intents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlternateIntents { get; set; }
        /// <summary>
        /// State information for the conversation. To maintain state, include the context from the previous response.
        /// </summary>
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Context { get; set; }
        /// <summary>
        /// Entities to use when evaluating the message. Include entities from the previous response to continue using
        /// those entities rather than detecting entities in the new input.
        /// </summary>
        [JsonProperty("entities", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuntimeEntity> Entities { get; set; }
        /// <summary>
        /// Intents to use when evaluating the user input. Include intents from the previous response to continue using
        /// those intents rather than trying to recognize intents in the new input.
        /// </summary>
        [JsonProperty("intents", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuntimeIntent> Intents { get; set; }
        /// <summary>
        /// An output object that includes the response to the user, the dialog nodes that were triggered, and messages
        /// from the log.
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Output { get; set; }
    }

}
