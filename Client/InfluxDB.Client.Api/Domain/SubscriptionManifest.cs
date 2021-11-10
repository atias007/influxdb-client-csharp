/* 
 * Influx OSS API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 2.0.0
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
    /// SubscriptionManifest
    /// </summary>
    [DataContract]
    public partial class SubscriptionManifest :  IEquatable<SubscriptionManifest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionManifest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionManifest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionManifest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="destinations">destinations (required).</param>
        public SubscriptionManifest(string name = default(string), string mode = default(string), List<string> destinations = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SubscriptionManifest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "mode" is required (not null)
            if (mode == null)
            {
                throw new InvalidDataException("mode is a required property for SubscriptionManifest and cannot be null");
            }
            else
            {
                this.Mode = mode;
            }
            // to ensure "destinations" is required (not null)
            if (destinations == null)
            {
                throw new InvalidDataException("destinations is a required property for SubscriptionManifest and cannot be null");
            }
            else
            {
                this.Destinations = destinations;
            }
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets Destinations
        /// </summary>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<string> Destinations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionManifest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
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
            return this.Equals(input as SubscriptionManifest);
        }

        /// <summary>
        /// Returns true if SubscriptionManifest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionManifest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionManifest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
                return hashCode;
            }
        }

    }

}