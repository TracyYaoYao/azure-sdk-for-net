// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a mailbox entity. </summary>
    public partial class MailboxEntity : EntityData
    {
        /// <summary> Initializes a new instance of MailboxEntity. </summary>
        public MailboxEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = EntityKind.Mailbox;
        }

        /// <summary> Initializes a new instance of MailboxEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="mailboxPrimaryAddress"> The mailbox&apos;s primary address. </param>
        /// <param name="displayName"> The mailbox&apos;s display name. </param>
        /// <param name="upn"> The mailbox&apos;s UPN. </param>
        /// <param name="externalDirectoryObjectId"> The AzureAD identifier of mailbox. Similar to AadUserId in account entity but this property is specific to mailbox object on office side. </param>
        internal MailboxEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string mailboxPrimaryAddress, string displayName, string upn, Guid? externalDirectoryObjectId) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            MailboxPrimaryAddress = mailboxPrimaryAddress;
            DisplayName = displayName;
            Upn = upn;
            ExternalDirectoryObjectId = externalDirectoryObjectId;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The mailbox&apos;s primary address. </summary>
        public string MailboxPrimaryAddress { get; }
        /// <summary> The mailbox&apos;s display name. </summary>
        public string DisplayName { get; }
        /// <summary> The mailbox&apos;s UPN. </summary>
        public string Upn { get; }
        /// <summary> The AzureAD identifier of mailbox. Similar to AadUserId in account entity but this property is specific to mailbox object on office side. </summary>
        public Guid? ExternalDirectoryObjectId { get; }
    }
}
