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
    /// UpdateWorkspace.
    /// </summary>
    public class UpdateWorkspace : BaseModel
    {
        /// <summary>
        /// The name of the workspace. This string cannot contain carriage return, newline, or tab characters, and it
        /// must be no longer than 64 characters.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// The description of the workspace. This string cannot contain carriage return, newline, or tab characters,
        /// and it must be no longer than 128 characters.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>
        /// The language of the workspace.
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }
        /// <summary>
        /// An array of objects defining the intents for the workspace.
        /// </summary>
        [JsonProperty("intents", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateIntent> Intents { get; set; }
        /// <summary>
        /// An array of objects defining the entities for the workspace.
        /// </summary>
        [JsonProperty("entities", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateEntity> Entities { get; set; }
        /// <summary>
        /// An array of objects defining the nodes in the dialog.
        /// </summary>
        [JsonProperty("dialog_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateDialogNode> DialogNodes { get; set; }
        /// <summary>
        /// An array of objects defining input examples that have been marked as irrelevant input.
        /// </summary>
        [JsonProperty("counterexamples", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateCounterexample> Counterexamples { get; set; }
        /// <summary>
        /// Any metadata related to the workspace.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public object Metadata { get; set; }
        /// <summary>
        /// Whether training data from the workspace can be used by IBM for general service improvements. `true`
        /// indicates that workspace training data is not to be used.
        /// </summary>
        [JsonProperty("learning_opt_out", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LearningOptOut { get; set; }
        /// <summary>
        /// Global settings for the workspace.
        /// </summary>
        [JsonProperty("system_settings", NullValueHandling = NullValueHandling.Ignore)]
        public WorkspaceSystemSettings SystemSettings { get; set; }
    }

}
