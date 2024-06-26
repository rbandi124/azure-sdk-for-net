// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The BillingBenefitsExtendedStatusInfo. </summary>
    public partial class BillingBenefitsExtendedStatusInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsExtendedStatusInfo"/>. </summary>
        internal BillingBenefitsExtendedStatusInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsExtendedStatusInfo"/>. </summary>
        /// <param name="statusCode"> Status code providing additional information. </param>
        /// <param name="message"> The message giving detailed information about the status code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingBenefitsExtendedStatusInfo(string statusCode, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StatusCode = statusCode;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Status code providing additional information. </summary>
        public string StatusCode { get; }
        /// <summary> The message giving detailed information about the status code. </summary>
        public string Message { get; }
    }
}
