﻿using System.ComponentModel;
using Newtonsoft.Json;

namespace stellar_dotnet_sdk.responses.operations
{
    /// <summary>
    /// Abstract class for operation responses.
    /// See: https://www.stellar.org/developers/horizon/reference/resources/operation.html
    /// <seealso cref="requests.OperationsRequestBuilder"/>
    /// <seealso cref="Server"/>
    /// </summary>
    [JsonConverter(typeof(OperationDeserializer))]
    public abstract class OperationResponse : Response, IPagingToken
    {
        /// <summary>
        /// Id of the operation
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long Id { get; private set; }

        /// <summary>
        /// Source Account of Operation
        /// </summary>
        [JsonProperty(PropertyName = "source_account")]
        public string SourceAccount { get; private set; }

        [JsonProperty(PropertyName = "source_account_muxed")]
        public string SourceAccountMuxed { get; private set; }

        [JsonProperty(PropertyName = "source_account_muxed_id")]
        public long? SourceAccountMuxedID { get; private set; }

        /// <summary>
        /// Paging Token of Paging
        /// </summary>
        [JsonProperty(PropertyName = "paging_token")]
        public string PagingToken { get; private set; }

        /// <summary>
        /// Returns operation type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        [JsonProperty(PropertyName = "type_i")]
        public virtual int TypeId { get; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; private set; }

        /// <summary>
        /// Returns transaction hash of transaction this operation belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "transaction_hash")]
        public string TransactionHash { get; private set; }

        /// <summary>
        /// Returns whether the operation transaction was successful.
        /// </summary>
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "transaction_successful", DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool TransactionSuccessful { get; private set; }

        /// <summary>
        /// Links of Paging
        /// </summary>
        [JsonProperty(PropertyName = "_links")]
        public OperationResponseLinks Links { get; private set; }
    }
}
