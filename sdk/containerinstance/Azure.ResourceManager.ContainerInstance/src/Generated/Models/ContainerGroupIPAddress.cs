// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> IP address for the container group. </summary>
    public partial class ContainerGroupIPAddress
    {
        /// <summary> Initializes a new instance of ContainerGroupIPAddress. </summary>
        /// <param name="ports"> The list of ports exposed on the container group. </param>
        /// <param name="addressType"> Specifies if the IP is exposed to the public internet or private VNET. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ports"/> is null. </exception>
        public ContainerGroupIPAddress(IEnumerable<ContainerGroupPort> ports, ContainerGroupIPAddressType addressType)
        {
            if (ports == null)
            {
                throw new ArgumentNullException(nameof(ports));
            }

            Ports = ports.ToList();
            AddressType = addressType;
        }

        /// <summary> Initializes a new instance of ContainerGroupIPAddress. </summary>
        /// <param name="ports"> The list of ports exposed on the container group. </param>
        /// <param name="addressType"> Specifies if the IP is exposed to the public internet or private VNET. </param>
        /// <param name="ip"> The IP exposed to the public internet. </param>
        /// <param name="dnsNameLabel"> The Dns name label for the IP. </param>
        /// <param name="dnsNameLabelReusePolicy"> The value representing the security enum. </param>
        /// <param name="fqdn"> The FQDN for the IP. </param>
        internal ContainerGroupIPAddress(IList<ContainerGroupPort> ports, ContainerGroupIPAddressType addressType, IPAddress ip, string dnsNameLabel, AutoGeneratedDomainNameLabelScope? dnsNameLabelReusePolicy, string fqdn)
        {
            Ports = ports;
            AddressType = addressType;
            IP = ip;
            DnsNameLabel = dnsNameLabel;
            DnsNameLabelReusePolicy = dnsNameLabelReusePolicy;
            Fqdn = fqdn;
        }

        /// <summary> The list of ports exposed on the container group. </summary>
        public IList<ContainerGroupPort> Ports { get; }
        /// <summary> Specifies if the IP is exposed to the public internet or private VNET. </summary>
        public ContainerGroupIPAddressType AddressType { get; set; }
        /// <summary> The IP exposed to the public internet. </summary>
        public IPAddress IP { get; set; }
        /// <summary> The Dns name label for the IP. </summary>
        public string DnsNameLabel { get; set; }
        /// <summary> The value representing the security enum. </summary>
        public AutoGeneratedDomainNameLabelScope? DnsNameLabelReusePolicy { get; set; }
        /// <summary> The FQDN for the IP. </summary>
        public string Fqdn { get; }
    }
}
