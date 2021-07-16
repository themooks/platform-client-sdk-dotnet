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
    /// TrunkMetricsTopicTrunkMetricsQoS
    /// </summary>
    [DataContract]
    public partial class TrunkMetricsTopicTrunkMetricsQoS :  IEquatable<TrunkMetricsTopicTrunkMetricsQoS>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkMetricsTopicTrunkMetricsQoS" /> class.
        /// </summary>
        /// <param name="MismatchCount">MismatchCount.</param>
        public TrunkMetricsTopicTrunkMetricsQoS(int? MismatchCount = null)
        {
            this.MismatchCount = MismatchCount;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets MismatchCount
        /// </summary>
        [DataMember(Name="mismatchCount", EmitDefaultValue=false)]
        public int? MismatchCount { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkMetricsTopicTrunkMetricsQoS {\n");
            
            sb.Append("  MismatchCount: ").Append(MismatchCount).Append("\n");
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
            return this.Equals(obj as TrunkMetricsTopicTrunkMetricsQoS);
        }

        /// <summary>
        /// Returns true if TrunkMetricsTopicTrunkMetricsQoS instances are equal
        /// </summary>
        /// <param name="other">Instance of TrunkMetricsTopicTrunkMetricsQoS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkMetricsTopicTrunkMetricsQoS other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MismatchCount == other.MismatchCount ||
                    this.MismatchCount != null &&
                    this.MismatchCount.Equals(other.MismatchCount)
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
                
                if (this.MismatchCount != null)
                    hash = hash * 59 + this.MismatchCount.GetHashCode();
                
                return hash;
            }
        }
    }

}
