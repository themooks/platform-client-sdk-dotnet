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
    /// SurveyErrorDetails
    /// </summary>
    [DataContract]
    public partial class SurveyErrorDetails :  IEquatable<SurveyErrorDetails>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyErrorDetails" /> class.
        /// </summary>
        /// <param name="FlowDiagnosticInfo">Additional information about any errors that occurred in the survey invite flow..</param>
        /// <param name="SurveyErrorReason">An error code indicating the reason for the survey failure..</param>
        public SurveyErrorDetails(FlowDiagnosticInfo FlowDiagnosticInfo = null, string SurveyErrorReason = null)
        {
            this.FlowDiagnosticInfo = FlowDiagnosticInfo;
            this.SurveyErrorReason = SurveyErrorReason;
            
        }
        
        
        
        /// <summary>
        /// Additional information about any errors that occurred in the survey invite flow.
        /// </summary>
        /// <value>Additional information about any errors that occurred in the survey invite flow.</value>
        [DataMember(Name="flowDiagnosticInfo", EmitDefaultValue=false)]
        public FlowDiagnosticInfo FlowDiagnosticInfo { get; set; }
        
        
        
        /// <summary>
        /// An error code indicating the reason for the survey failure.
        /// </summary>
        /// <value>An error code indicating the reason for the survey failure.</value>
        [DataMember(Name="surveyErrorReason", EmitDefaultValue=false)]
        public string SurveyErrorReason { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SurveyErrorDetails {\n");
            
            sb.Append("  FlowDiagnosticInfo: ").Append(FlowDiagnosticInfo).Append("\n");
            sb.Append("  SurveyErrorReason: ").Append(SurveyErrorReason).Append("\n");
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
            return this.Equals(obj as SurveyErrorDetails);
        }

        /// <summary>
        /// Returns true if SurveyErrorDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of SurveyErrorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurveyErrorDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FlowDiagnosticInfo == other.FlowDiagnosticInfo ||
                    this.FlowDiagnosticInfo != null &&
                    this.FlowDiagnosticInfo.Equals(other.FlowDiagnosticInfo)
                ) &&
                (
                    this.SurveyErrorReason == other.SurveyErrorReason ||
                    this.SurveyErrorReason != null &&
                    this.SurveyErrorReason.Equals(other.SurveyErrorReason)
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
                
                if (this.FlowDiagnosticInfo != null)
                    hash = hash * 59 + this.FlowDiagnosticInfo.GetHashCode();
                
                if (this.SurveyErrorReason != null)
                    hash = hash * 59 + this.SurveyErrorReason.GetHashCode();
                
                return hash;
            }
        }
    }

}
