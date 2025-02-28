// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// Capacity pool resource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CapacityPool : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the CapacityPool class.
        /// </summary>
        public CapacityPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityPool class.
        /// </summary>

        /// <param name="id">Fully qualified resource ID for the resource. E.g.
        /// &#34;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&#34;
        /// </param>

        /// <param name="name">The name of the resource
        /// </param>

        /// <param name="type">The type of the resource. E.g. &#34;Microsoft.Compute/virtualMachines&#34; or
        /// &#34;Microsoft.Storage/storageAccounts&#34;
        /// </param>

        /// <param name="systemData">Azure Resource Manager metadata containing createdBy and modifiedBy
        /// information.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="location">The geo-location where the resource lives
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="serviceLevel">The service level of the file system
        /// Possible values include: &#39;Standard&#39;, &#39;Premium&#39;, &#39;Ultra&#39;, &#39;StandardZRS&#39;</param>

        /// <param name="qosType">The qos type of the pool
        /// Possible values include: &#39;Auto&#39;, &#39;Manual&#39;</param>

        /// <param name="encryptionType">Encryption type of the capacity pool, set encryption type for data at rest
        /// for this pool and all volumes in it. This value can only be set when
        /// creating new pool.
        /// Possible values include: &#39;Single&#39;, &#39;Double&#39;</param>

        /// <param name="poolId">UUID v4 used to identify the Pool
        /// </param>

        /// <param name="size">Provisioned size of the pool (in bytes). Allowed values are in 1TiB chunks
        /// (value must be multiply of 4398046511104).
        /// </param>

        /// <param name="provisioningState">Azure lifecycle management
        /// </param>

        /// <param name="totalThroughputMibps">Total throughput of pool in MiB/s
        /// </param>

        /// <param name="utilizedThroughputMibps">Utilized throughput of pool in MiB/s
        /// </param>

        /// <param name="coolAccess">If enabled (true) the pool can contain cool Access enabled volumes.
        /// </param>
        public CapacityPool(string location, string serviceLevel, long size, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string etag = default(string), string qosType = default(string), string encryptionType = default(string), string poolId = default(string), string provisioningState = default(string), double? totalThroughputMibps = default(double?), double? utilizedThroughputMibps = default(double?), bool? coolAccess = default(bool?))

        : base(location, id, name, type, systemData, tags)
        {
            this.Etag = etag;
            this.ServiceLevel = serviceLevel;
            this.QosType = qosType;
            this.EncryptionType = encryptionType;
            this.PoolId = poolId;
            this.Size = size;
            this.ProvisioningState = provisioningState;
            this.TotalThroughputMibps = totalThroughputMibps;
            this.UtilizedThroughputMibps = utilizedThroughputMibps;
            this.CoolAccess = coolAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets or sets the service level of the file system Possible values include: &#39;Standard&#39;, &#39;Premium&#39;, &#39;Ultra&#39;, &#39;StandardZRS&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceLevel")]
        public string ServiceLevel {get; set; }

        /// <summary>
        /// Gets or sets the qos type of the pool Possible values include: &#39;Auto&#39;, &#39;Manual&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.qosType")]
        public string QosType {get; set; }

        /// <summary>
        /// Gets or sets encryption type of the capacity pool, set encryption type for
        /// data at rest for this pool and all volumes in it. This value can only be
        /// set when creating new pool. Possible values include: &#39;Single&#39;, &#39;Double&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.encryptionType")]
        public string EncryptionType {get; set; }

        /// <summary>
        /// Gets uUID v4 used to identify the Pool
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.poolId")]
        public string PoolId {get; private set; }

        /// <summary>
        /// Gets or sets provisioned size of the pool (in bytes). Allowed values are in
        /// 1TiB chunks (value must be multiply of 4398046511104).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.size")]
        public long Size {get; set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets total throughput of pool in MiB/s
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.totalThroughputMibps")]
        public double? TotalThroughputMibps {get; private set; }

        /// <summary>
        /// Gets utilized throughput of pool in MiB/s
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.utilizedThroughputMibps")]
        public double? UtilizedThroughputMibps {get; private set; }

        /// <summary>
        /// Gets or sets if enabled (true) the pool can contain cool Access enabled
        /// volumes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.coolAccess")]
        public bool? CoolAccess {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.ServiceLevel == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ServiceLevel");
            }




            if (this.PoolId != null)
            {
                if (this.PoolId.Length > 36)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MaxLength, "PoolId", 36);
                }
                if (this.PoolId.Length < 36)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MinLength, "PoolId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.PoolId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.Pattern, "PoolId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }

        }
    }
}