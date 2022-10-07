// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MapTest
    /// </summary>
    public partial class MapTest : IEquatable<MapTest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapTest" /> class.
        /// </summary>
        /// <param name="mapMapOfString">mapMapOfString</param>
        /// <param name="mapOfEnumString">mapOfEnumString</param>
        /// <param name="directMap">directMap</param>
        /// <param name="indirectMap">indirectMap</param>
        public MapTest(Dictionary<string, Dictionary<string, string>> mapMapOfString = default, Dictionary<string, MapTest.InnerEnum> mapOfEnumString = default, Dictionary<string, bool> directMap = default, Dictionary<string, bool> indirectMap = default)
        {
            MapMapOfString = mapMapOfString;
            MapOfEnumString = mapOfEnumString;
            DirectMap = directMap;
            IndirectMap = indirectMap;
        }

        /// <summary>
        /// Defines Inner
        /// </summary>
        public enum InnerEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            [EnumMember(Value = "UPPER")]
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            [EnumMember(Value = "lower")]
            Lower = 2

        }

        /// <summary>
        /// Gets or Sets MapMapOfString
        /// </summary>
        [JsonPropertyName("map_map_of_string")]
        public Dictionary<string, Dictionary<string, string>> MapMapOfString { get; set; }

        /// <summary>
        /// Gets or Sets MapOfEnumString
        /// </summary>
        [JsonPropertyName("map_of_enum_string")]
        public Dictionary<string, MapTest.InnerEnum> MapOfEnumString { get; set; }

        /// <summary>
        /// Gets or Sets DirectMap
        /// </summary>
        [JsonPropertyName("direct_map")]
        public Dictionary<string, bool> DirectMap { get; set; }

        /// <summary>
        /// Gets or Sets IndirectMap
        /// </summary>
        [JsonPropertyName("indirect_map")]
        public Dictionary<string, bool> IndirectMap { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; set; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MapTest {\n");
            sb.Append("  MapMapOfString: ").Append(MapMapOfString).Append("\n");
            sb.Append("  MapOfEnumString: ").Append(MapOfEnumString).Append("\n");
            sb.Append("  DirectMap: ").Append(DirectMap).Append("\n");
            sb.Append("  IndirectMap: ").Append(IndirectMap).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as MapTest).AreEqual;
        }

        /// <summary>
        /// Returns true if MapTest instances are equal
        /// </summary>
        /// <param name="input">Instance of MapTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapTest input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                if (this.MapMapOfString != null)
                {
                    hashCode = (hashCode * 59) + this.MapMapOfString.GetHashCode();
                }
                if (this.MapOfEnumString != null)
                {
                    hashCode = (hashCode * 59) + this.MapOfEnumString.GetHashCode();
                }
                if (this.DirectMap != null)
                {
                    hashCode = (hashCode * 59) + this.DirectMap.GetHashCode();
                }
                if (this.IndirectMap != null)
                {
                    hashCode = (hashCode * 59) + this.IndirectMap.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
