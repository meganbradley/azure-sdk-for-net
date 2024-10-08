// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> A value indicating compliance status of the machine for the assigned guest configuration. </summary>
    public readonly partial struct AssignedGuestConfigurationMachineComplianceStatus : IEquatable<AssignedGuestConfigurationMachineComplianceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssignedGuestConfigurationMachineComplianceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssignedGuestConfigurationMachineComplianceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CompliantValue = "Compliant";
        private const string NonCompliantValue = "NonCompliant";
        private const string PendingValue = "Pending";

        /// <summary> Compliant. </summary>
        public static AssignedGuestConfigurationMachineComplianceStatus Compliant { get; } = new AssignedGuestConfigurationMachineComplianceStatus(CompliantValue);
        /// <summary> NonCompliant. </summary>
        public static AssignedGuestConfigurationMachineComplianceStatus NonCompliant { get; } = new AssignedGuestConfigurationMachineComplianceStatus(NonCompliantValue);
        /// <summary> Pending. </summary>
        public static AssignedGuestConfigurationMachineComplianceStatus Pending { get; } = new AssignedGuestConfigurationMachineComplianceStatus(PendingValue);
        /// <summary> Determines if two <see cref="AssignedGuestConfigurationMachineComplianceStatus"/> values are the same. </summary>
        public static bool operator ==(AssignedGuestConfigurationMachineComplianceStatus left, AssignedGuestConfigurationMachineComplianceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssignedGuestConfigurationMachineComplianceStatus"/> values are not the same. </summary>
        public static bool operator !=(AssignedGuestConfigurationMachineComplianceStatus left, AssignedGuestConfigurationMachineComplianceStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AssignedGuestConfigurationMachineComplianceStatus"/>. </summary>
        public static implicit operator AssignedGuestConfigurationMachineComplianceStatus(string value) => new AssignedGuestConfigurationMachineComplianceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssignedGuestConfigurationMachineComplianceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssignedGuestConfigurationMachineComplianceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
