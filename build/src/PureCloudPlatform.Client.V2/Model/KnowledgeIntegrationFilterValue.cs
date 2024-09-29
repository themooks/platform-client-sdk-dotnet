using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// KnowledgeIntegrationFilterValue
    /// </summary>
    [DataContract]
    public partial class KnowledgeIntegrationFilterValue :  IEquatable<KnowledgeIntegrationFilterValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeIntegrationFilterValue" /> class.
        /// </summary>
        /// <param name="Key">The key that can be used as a value of a filter setting in a knowledge source..</param>
        /// <param name="Value">The display label of the filter value..</param>
        public KnowledgeIntegrationFilterValue(string Key = null, string Value = null)
        {
            this.Key = Key;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// The key that can be used as a value of a filter setting in a knowledge source.
        /// </summary>
        /// <value>The key that can be used as a value of a filter setting in a knowledge source.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }



        /// <summary>
        /// The display label of the filter value.
        /// </summary>
        /// <value>The display label of the filter value.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeIntegrationFilterValue {\n");

            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as KnowledgeIntegrationFilterValue);
        }

        /// <summary>
        /// Returns true if KnowledgeIntegrationFilterValue instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeIntegrationFilterValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeIntegrationFilterValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
