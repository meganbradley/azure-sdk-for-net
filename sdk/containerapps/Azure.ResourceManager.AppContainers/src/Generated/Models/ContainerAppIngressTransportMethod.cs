// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Ingress transport protocol. </summary>
    public readonly partial struct ContainerAppIngressTransportMethod : IEquatable<ContainerAppIngressTransportMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppIngressTransportMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppIngressTransportMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string HttpValue = "http";
        private const string Http2Value = "http2";
        private const string TcpValue = "tcp";

        /// <summary> auto. </summary>
        public static ContainerAppIngressTransportMethod Auto { get; } = new ContainerAppIngressTransportMethod(AutoValue);
        /// <summary> http. </summary>
        public static ContainerAppIngressTransportMethod Http { get; } = new ContainerAppIngressTransportMethod(HttpValue);
        /// <summary> http2. </summary>
        public static ContainerAppIngressTransportMethod Http2 { get; } = new ContainerAppIngressTransportMethod(Http2Value);
        /// <summary> tcp. </summary>
        public static ContainerAppIngressTransportMethod Tcp { get; } = new ContainerAppIngressTransportMethod(TcpValue);
        /// <summary> Determines if two <see cref="ContainerAppIngressTransportMethod"/> values are the same. </summary>
        public static bool operator ==(ContainerAppIngressTransportMethod left, ContainerAppIngressTransportMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppIngressTransportMethod"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppIngressTransportMethod left, ContainerAppIngressTransportMethod right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerAppIngressTransportMethod"/>. </summary>
        public static implicit operator ContainerAppIngressTransportMethod(string value) => new ContainerAppIngressTransportMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppIngressTransportMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppIngressTransportMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
