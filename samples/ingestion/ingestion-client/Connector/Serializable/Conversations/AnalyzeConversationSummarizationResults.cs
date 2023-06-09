// <copyright file="AnalyzeConversationSummarizationResults.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
// </copyright>

namespace Connector.Serializable.Language.Conversations
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class AnalyzeConversationSummarizationResults : AnalyzeConversationResultsBase
    {
        [JsonProperty("conversations")]
        public IEnumerable<ConversationsSummaryResult> Conversations { get; set; }
    }
}