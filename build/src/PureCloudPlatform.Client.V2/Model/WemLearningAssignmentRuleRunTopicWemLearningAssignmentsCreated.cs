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
    /// WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated
    /// </summary>
    [DataContract]
    public partial class WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated :  IEquatable<WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated" /> class.
        /// </summary>
        /// <param name="Module">Module.</param>
        public WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated(WemLearningAssignmentRuleRunTopicLearningModuleReference Module = null)
        {
            this.Module = Module;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name="module", EmitDefaultValue=false)]
        public WemLearningAssignmentRuleRunTopicLearningModuleReference Module { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated {\n");
            
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated);
        }

        /// <summary>
        /// Returns true if WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated instances are equal
        /// </summary>
        /// <param name="other">Instance of WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WemLearningAssignmentRuleRunTopicWemLearningAssignmentsCreated other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Module == other.Module ||
                    this.Module != null &&
                    this.Module.Equals(other.Module)
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
                
                if (this.Module != null)
                    hash = hash * 59 + this.Module.GetHashCode();
                
                return hash;
            }
        }
    }

}
