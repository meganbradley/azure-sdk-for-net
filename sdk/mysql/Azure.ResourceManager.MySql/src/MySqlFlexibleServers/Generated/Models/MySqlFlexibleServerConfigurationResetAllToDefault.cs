// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Whether to reset all server parameters to default. </summary>
    public readonly partial struct MySqlFlexibleServerConfigurationResetAllToDefault : IEquatable<MySqlFlexibleServerConfigurationResetAllToDefault>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerConfigurationResetAllToDefault"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MySqlFlexibleServerConfigurationResetAllToDefault(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static MySqlFlexibleServerConfigurationResetAllToDefault True { get; } = new MySqlFlexibleServerConfigurationResetAllToDefault(TrueValue);
        /// <summary> False. </summary>
        public static MySqlFlexibleServerConfigurationResetAllToDefault False { get; } = new MySqlFlexibleServerConfigurationResetAllToDefault(FalseValue);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerConfigurationResetAllToDefault"/> values are the same. </summary>
        public static bool operator ==(MySqlFlexibleServerConfigurationResetAllToDefault left, MySqlFlexibleServerConfigurationResetAllToDefault right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerConfigurationResetAllToDefault"/> values are not the same. </summary>
        public static bool operator !=(MySqlFlexibleServerConfigurationResetAllToDefault left, MySqlFlexibleServerConfigurationResetAllToDefault right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MySqlFlexibleServerConfigurationResetAllToDefault"/>. </summary>
        public static implicit operator MySqlFlexibleServerConfigurationResetAllToDefault(string value) => new MySqlFlexibleServerConfigurationResetAllToDefault(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MySqlFlexibleServerConfigurationResetAllToDefault other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MySqlFlexibleServerConfigurationResetAllToDefault other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
