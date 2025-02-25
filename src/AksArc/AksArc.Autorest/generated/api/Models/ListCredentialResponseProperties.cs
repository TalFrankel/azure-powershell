// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Extensions;

    public partial class ListCredentialResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IListCredentialResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IListCredentialResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Kubeconfig" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICredentialResult> _kubeconfig;

        /// <summary>Base64-encoded Kubernetes configuration file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICredentialResult> Kubeconfig { get => this._kubeconfig; }

        /// <summary>Internal Acessors for Kubeconfig</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICredentialResult> Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IListCredentialResponsePropertiesInternal.Kubeconfig { get => this._kubeconfig; set { {_kubeconfig = value;} } }

        /// <summary>Creates an new <see cref="ListCredentialResponseProperties" /> instance.</summary>
        public ListCredentialResponseProperties()
        {

        }
    }
    public partial interface IListCredentialResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IJsonSerializable
    {
        /// <summary>Base64-encoded Kubernetes configuration file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Base64-encoded Kubernetes configuration file.",
        SerializedName = @"kubeconfigs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICredentialResult) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICredentialResult> Kubeconfig { get;  }

    }
    internal partial interface IListCredentialResponsePropertiesInternal

    {
        /// <summary>Base64-encoded Kubernetes configuration file.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ICredentialResult> Kubeconfig { get; set; }

    }
}