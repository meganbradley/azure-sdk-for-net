// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Instance view status. </summary>
    public partial class ArcExtensionInstanceViewStatus
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

        /// <summary> Initializes a new instance of <see cref="ArcExtensionInstanceViewStatus"/>. </summary>
        internal ArcExtensionInstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArcExtensionInstanceViewStatus"/>. </summary>
        /// <param name="code"> The status code. </param>
        /// <param name="level"> The level code. </param>
        /// <param name="displayStatus"> The short localizable label for the status. </param>
        /// <param name="message"> The detailed status message, including for alerts and error messages. </param>
        /// <param name="time"> The time of the status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArcExtensionInstanceViewStatus(string code, HciStatusLevelType? level, string displayStatus, string message, DateTimeOffset? time, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Level = level;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status code. </summary>
        [WirePath("code")]
        public string Code { get; }
        /// <summary> The level code. </summary>
        [WirePath("level")]
        public HciStatusLevelType? Level { get; }
        /// <summary> The short localizable label for the status. </summary>
        [WirePath("displayStatus")]
        public string DisplayStatus { get; }
        /// <summary> The detailed status message, including for alerts and error messages. </summary>
        [WirePath("message")]
        public string Message { get; }
        /// <summary> The time of the status. </summary>
        [WirePath("time")]
        public DateTimeOffset? Time { get; }
    }
}
