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
    /// BuScheduleListing
    /// </summary>
    [DataContract]
    public partial class BuScheduleListing :  IEquatable<BuScheduleListing>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuScheduleListing" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        public BuScheduleListing(List<BuScheduleListItem> Entities = null)
        {
            this.Entities = Entities;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<BuScheduleListItem> Entities { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuScheduleListing {\n");
            
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as BuScheduleListing);
        }

        /// <summary>
        /// Returns true if BuScheduleListing instances are equal
        /// </summary>
        /// <param name="other">Instance of BuScheduleListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuScheduleListing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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
                
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();
                
                return hash;
            }
        }
    }

}
