/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// TaskCreateRequest
    /// </summary>
    [DataContract]
    public partial class TaskCreateRequest :  IEquatable<TaskCreateRequest>
    {
        /// <summary>
        /// Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39;
        /// </summary>
        /// <value>Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }

        /// <summary>
        /// Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39;
        /// </summary>
        /// <value>Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCreateRequest" /> class.
        /// </summary>
        /// <param name="orgID">The ID of the organization that owns this Task..</param>
        /// <param name="org">The name of the organization that owns this Task..</param>
        /// <param name="status">Starting state of the task. &#39;inactive&#39; tasks are not run until they are updated to &#39;active&#39; (default to StatusEnum.Active).</param>
        /// <param name="flux">The Flux script to run for this task. (required).</param>
        /// <param name="description">An optional description of the task..</param>
        /// <param name="token">The token to use for authenticating this task when it executes queries. If omitted, uses the token associated with the request that creates the task..</param>
        public TaskCreateRequest(string orgID = default(string), string org = default(string), StatusEnum? status = StatusEnum.Active, string flux = default(string), string description = default(string), string token = default(string))
        {
            // to ensure "flux" is required (not null)
            if (flux == null)
            {
                throw new InvalidDataException("flux is a required property for TaskCreateRequest and cannot be null");
            }
            else
            {
                this.Flux = flux;
            }
            this.OrgID = orgID;
            this.Org = org;
            // use default value if no "status" provided
            if (status == null)
            {
                this.Status = StatusEnum.Active;
            }
            else
            {
                this.Status = status;
            }
            this.Description = description;
            this.Token = token;
        }

        /// <summary>
        /// The ID of the organization that owns this Task.
        /// </summary>
        /// <value>The ID of the organization that owns this Task.</value>
        [DataMember(Name="orgID", EmitDefaultValue=false)]
        public string OrgID { get; set; }

        /// <summary>
        /// The name of the organization that owns this Task.
        /// </summary>
        /// <value>The name of the organization that owns this Task.</value>
        [DataMember(Name="org", EmitDefaultValue=false)]
        public string Org { get; set; }


        /// <summary>
        /// The Flux script to run for this task.
        /// </summary>
        /// <value>The Flux script to run for this task.</value>
        [DataMember(Name="flux", EmitDefaultValue=false)]
        public string Flux { get; set; }

        /// <summary>
        /// An optional description of the task.
        /// </summary>
        /// <value>An optional description of the task.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The token to use for authenticating this task when it executes queries. If omitted, uses the token associated with the request that creates the task.
        /// </summary>
        /// <value>The token to use for authenticating this task when it executes queries. If omitted, uses the token associated with the request that creates the task.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskCreateRequest {\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Flux: ").Append(Flux).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskCreateRequest);
        }

        /// <summary>
        /// Returns true if TaskCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrgID == input.OrgID ||
                    (this.OrgID != null &&
                    this.OrgID.Equals(input.OrgID))
                ) && 
                (
                    this.Org == input.Org ||
                    (this.Org != null &&
                    this.Org.Equals(input.Org))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Flux == input.Flux ||
                    (this.Flux != null &&
                    this.Flux.Equals(input.Flux))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OrgID != null)
                    hashCode = hashCode * 59 + this.OrgID.GetHashCode();
                if (this.Org != null)
                    hashCode = hashCode * 59 + this.Org.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Flux != null)
                    hashCode = hashCode * 59 + this.Flux.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }

    }

}
