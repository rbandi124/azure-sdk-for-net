// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// A List custom alert rule.
    /// Please note <see cref="ListCustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AllowlistCustomAlertRule"/>, <see cref="ConnectionFromIPNotAllowed"/>, <see cref="ConnectionToIPNotAllowed"/>, <see cref="DenylistCustomAlertRule"/>, <see cref="LocalUserNotAllowed"/> and <see cref="ProcessNotAllowed"/>.
    /// </summary>
    public partial class ListCustomAlertRule : CustomAlertRule
    {
        /// <summary> Initializes a new instance of <see cref="ListCustomAlertRule"/>. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        public ListCustomAlertRule(bool isEnabled) : base(isEnabled)
        {
            RuleType = "ListCustomAlertRule";
        }

        /// <summary> Initializes a new instance of <see cref="ListCustomAlertRule"/>. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="valueType"> The value type of the items in the list. </param>
        internal ListCustomAlertRule(string displayName, string description, bool isEnabled, string ruleType, IDictionary<string, BinaryData> serializedAdditionalRawData, SecurityValueType? valueType) : base(displayName, description, isEnabled, ruleType, serializedAdditionalRawData)
        {
            ValueType = valueType;
            RuleType = ruleType ?? "ListCustomAlertRule";
        }

        /// <summary> Initializes a new instance of <see cref="ListCustomAlertRule"/> for deserialization. </summary>
        internal ListCustomAlertRule()
        {
        }

        /// <summary> The value type of the items in the list. </summary>
        public SecurityValueType? ValueType { get; }
    }
}
