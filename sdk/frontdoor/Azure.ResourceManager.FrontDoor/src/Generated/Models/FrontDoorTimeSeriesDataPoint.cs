// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines a timeseries datapoint used in a timeseries. </summary>
    public partial class FrontDoorTimeSeriesDataPoint
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

        /// <summary> Initializes a new instance of <see cref="FrontDoorTimeSeriesDataPoint"/>. </summary>
        public FrontDoorTimeSeriesDataPoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorTimeSeriesDataPoint"/>. </summary>
        /// <param name="dateTimeUtc"> The DateTime of the Timeseries data point in UTC. </param>
        /// <param name="value"> The Value of the Timeseries data point. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorTimeSeriesDataPoint(DateTimeOffset? dateTimeUtc, float? value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DateTimeUtc = dateTimeUtc;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The DateTime of the Timeseries data point in UTC. </summary>
        public DateTimeOffset? DateTimeUtc { get; set; }
        /// <summary> The Value of the Timeseries data point. </summary>
        public float? Value { get; set; }
    }
}
