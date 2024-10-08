// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Access Mode of the resource association. </summary>
    public readonly partial struct EventHubsResourceAssociationAccessMode : IEquatable<EventHubsResourceAssociationAccessMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubsResourceAssociationAccessMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubsResourceAssociationAccessMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoAssociationModeValue = "NoAssociationMode";
        private const string EnforcedModeValue = "EnforcedMode";
        private const string LearningModeValue = "LearningMode";
        private const string AuditModeValue = "AuditMode";
        private const string UnspecifiedModeValue = "UnspecifiedMode";

        /// <summary> NoAssociationMode. </summary>
        public static EventHubsResourceAssociationAccessMode NoAssociationMode { get; } = new EventHubsResourceAssociationAccessMode(NoAssociationModeValue);
        /// <summary> EnforcedMode. </summary>
        public static EventHubsResourceAssociationAccessMode EnforcedMode { get; } = new EventHubsResourceAssociationAccessMode(EnforcedModeValue);
        /// <summary> LearningMode. </summary>
        public static EventHubsResourceAssociationAccessMode LearningMode { get; } = new EventHubsResourceAssociationAccessMode(LearningModeValue);
        /// <summary> AuditMode. </summary>
        public static EventHubsResourceAssociationAccessMode AuditMode { get; } = new EventHubsResourceAssociationAccessMode(AuditModeValue);
        /// <summary> UnspecifiedMode. </summary>
        public static EventHubsResourceAssociationAccessMode UnspecifiedMode { get; } = new EventHubsResourceAssociationAccessMode(UnspecifiedModeValue);
        /// <summary> Determines if two <see cref="EventHubsResourceAssociationAccessMode"/> values are the same. </summary>
        public static bool operator ==(EventHubsResourceAssociationAccessMode left, EventHubsResourceAssociationAccessMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubsResourceAssociationAccessMode"/> values are not the same. </summary>
        public static bool operator !=(EventHubsResourceAssociationAccessMode left, EventHubsResourceAssociationAccessMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventHubsResourceAssociationAccessMode"/>. </summary>
        public static implicit operator EventHubsResourceAssociationAccessMode(string value) => new EventHubsResourceAssociationAccessMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubsResourceAssociationAccessMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubsResourceAssociationAccessMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
