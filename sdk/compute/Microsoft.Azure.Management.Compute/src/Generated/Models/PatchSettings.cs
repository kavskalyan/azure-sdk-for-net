// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PatchSettings
    {
        /// <summary>
        /// Initializes a new instance of the PatchSettings class.
        /// </summary>
        public PatchSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchSettings class.
        /// </summary>
        /// <param name="patchMode">Specifies the mode of in-guest patching to
        /// IaaS virtual machine.&lt;br /&gt;&lt;br /&gt; Possible values
        /// are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the
        /// application of patches to a virtual machine. You do this by
        /// applying patches manually inside the VM. In this mode, automatic
        /// updates are disabled; the property
        /// WindowsConfiguration.enableAutomaticUpdates must be false&lt;br
        /// /&gt;&lt;br /&gt; **AutomaticByOS** - The virtual machine will
        /// automatically be updated by the OS. The property
        /// WindowsConfiguration.enableAutomaticUpdates must be true. &lt;br
        /// /&gt;&lt;br /&gt; ** AutomaticByPlatform** - the virtual machine
        /// will automatically updated by the OS. The properties
        /// provisionVMAgent and WindowsConfiguration.enableAutomaticUpdates
        /// must be true. Possible values include: 'Manual', 'AutomaticByOS',
        /// 'AutomaticByPlatform'</param>
        public PatchSettings(string patchMode = default(string))
        {
            PatchMode = patchMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the mode of in-guest patching to IaaS
        /// virtual machine.&amp;lt;br /&amp;gt;&amp;lt;br /&amp;gt; Possible
        /// values are:&amp;lt;br /&amp;gt;&amp;lt;br /&amp;gt; **Manual** -
        /// You  control the application of patches to a virtual machine. You
        /// do this by applying patches manually inside the VM. In this mode,
        /// automatic updates are disabled; the property
        /// WindowsConfiguration.enableAutomaticUpdates must be false&amp;lt;br
        /// /&amp;gt;&amp;lt;br /&amp;gt; **AutomaticByOS** - The virtual
        /// machine will automatically be updated by the OS. The property
        /// WindowsConfiguration.enableAutomaticUpdates must be true.
        /// &amp;lt;br /&amp;gt;&amp;lt;br /&amp;gt; ** AutomaticByPlatform** -
        /// the virtual machine will automatically updated by the OS. The
        /// properties provisionVMAgent and
        /// WindowsConfiguration.enableAutomaticUpdates must be true. Possible
        /// values include: 'Manual', 'AutomaticByOS', 'AutomaticByPlatform'
        /// </summary>
        [JsonProperty(PropertyName = "PatchMode")]
        public string PatchMode { get; set; }

    }
}
