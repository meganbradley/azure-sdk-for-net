// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing the ContainerRegistryWebhook data model.
    /// An object that represents a webhook for a container registry.
    /// </summary>
    public partial class ContainerRegistryWebhookData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ContainerRegistryWebhookData(AzureLocation location) : base(location)
        {
            Actions = new ChangeTrackingList<ContainerRegistryWebhookAction>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="status"> The status of the webhook at the time the operation was called. </param>
        /// <param name="scope"> The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means all events. </param>
        /// <param name="actions"> The list of actions that trigger the webhook to post notifications. </param>
        /// <param name="provisioningState"> The provisioning state of the webhook at the time the operation was called. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryWebhookData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ContainerRegistryWebhookStatus? status, string scope, IList<ContainerRegistryWebhookAction> actions, ContainerRegistryProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Status = status;
            Scope = scope;
            Actions = actions;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookData"/> for deserialization. </summary>
        internal ContainerRegistryWebhookData()
        {
        }

        /// <summary> The status of the webhook at the time the operation was called. </summary>
        [WirePath("properties.status")]
        public ContainerRegistryWebhookStatus? Status { get; set; }
        /// <summary> The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means all events. </summary>
        [WirePath("properties.scope")]
        public string Scope { get; set; }
        /// <summary> The list of actions that trigger the webhook to post notifications. </summary>
        [WirePath("properties.actions")]
        public IList<ContainerRegistryWebhookAction> Actions { get; }
        /// <summary> The provisioning state of the webhook at the time the operation was called. </summary>
        [WirePath("properties.provisioningState")]
        public ContainerRegistryProvisioningState? ProvisioningState { get; }
    }
}
