// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The state of assets. </summary>
    public readonly partial struct AssetState : IEquatable<AssetState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssetState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssetState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CandidateValue = "candidate";
        private const string ConfirmedValue = "confirmed";
        private const string DismissedValue = "dismissed";
        private const string CandidateInvestigateValue = "candidateInvestigate";
        private const string AssociatedPartnerValue = "associatedPartner";
        private const string AssociatedThirdpartyValue = "associatedThirdparty";
        private const string ArchivedValue = "archived";

        /// <summary> candidate. </summary>
        public static AssetState Candidate { get; } = new AssetState(CandidateValue);
        /// <summary> confirmed. </summary>
        public static AssetState Confirmed { get; } = new AssetState(ConfirmedValue);
        /// <summary> dismissed. </summary>
        public static AssetState Dismissed { get; } = new AssetState(DismissedValue);
        /// <summary> candidateInvestigate. </summary>
        public static AssetState CandidateInvestigate { get; } = new AssetState(CandidateInvestigateValue);
        /// <summary> associatedPartner. </summary>
        public static AssetState AssociatedPartner { get; } = new AssetState(AssociatedPartnerValue);
        /// <summary> associatedThirdparty. </summary>
        public static AssetState AssociatedThirdparty { get; } = new AssetState(AssociatedThirdpartyValue);
        /// <summary> archived. </summary>
        public static AssetState Archived { get; } = new AssetState(ArchivedValue);
        /// <summary> Determines if two <see cref="AssetState"/> values are the same. </summary>
        public static bool operator ==(AssetState left, AssetState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssetState"/> values are not the same. </summary>
        public static bool operator !=(AssetState left, AssetState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AssetState"/>. </summary>
        public static implicit operator AssetState(string value) => new AssetState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssetState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssetState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
