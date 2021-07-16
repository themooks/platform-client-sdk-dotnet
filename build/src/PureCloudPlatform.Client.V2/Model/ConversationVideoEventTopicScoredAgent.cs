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
    /// ConversationVideoEventTopicScoredAgent
    /// </summary>
    [DataContract]
    public partial class ConversationVideoEventTopicScoredAgent :  IEquatable<ConversationVideoEventTopicScoredAgent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationVideoEventTopicScoredAgent" /> class.
        /// </summary>
        /// <param name="Agent">Agent.</param>
        /// <param name="Score">Score.</param>
        public ConversationVideoEventTopicScoredAgent(ConversationVideoEventTopicUriReference Agent = null, int? Score = null)
        {
            this.Agent = Agent;
            this.Score = Score;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public ConversationVideoEventTopicUriReference Agent { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public int? Score { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationVideoEventTopicScoredAgent {\n");
            
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(obj as ConversationVideoEventTopicScoredAgent);
        }

        /// <summary>
        /// Returns true if ConversationVideoEventTopicScoredAgent instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationVideoEventTopicScoredAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationVideoEventTopicScoredAgent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
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
                
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();
                
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                
                return hash;
            }
        }
    }

}
