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
    /// ConversationCobrowseEventTopicCobrowseMediaParticipant
    /// </summary>
    [DataContract]
    public partial class ConversationCobrowseEventTopicCobrowseMediaParticipant :  IEquatable<ConversationCobrowseEventTopicCobrowseMediaParticipant>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alerting for "alerting"
            /// </summary>
            [EnumMember(Value = "alerting")]
            Alerting,
            
            /// <summary>
            /// Enum Dialing for "dialing"
            /// </summary>
            [EnumMember(Value = "dialing")]
            Dialing,
            
            /// <summary>
            /// Enum Contacting for "contacting"
            /// </summary>
            [EnumMember(Value = "contacting")]
            Contacting,
            
            /// <summary>
            /// Enum Offering for "offering"
            /// </summary>
            [EnumMember(Value = "offering")]
            Offering,
            
            /// <summary>
            /// Enum Connected for "connected"
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "disconnected"
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected,
            
            /// <summary>
            /// Enum Terminated for "terminated"
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated,
            
            /// <summary>
            /// Enum Converting for "converting"
            /// </summary>
            [EnumMember(Value = "converting")]
            Converting,
            
            /// <summary>
            /// Enum Uploading for "uploading"
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading,
            
            /// <summary>
            /// Enum Transmitting for "transmitting"
            /// </summary>
            [EnumMember(Value = "transmitting")]
            Transmitting,
            
            /// <summary>
            /// Enum Scheduled for "scheduled"
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None
        }
        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InitialStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alerting for "alerting"
            /// </summary>
            [EnumMember(Value = "alerting")]
            Alerting,
            
            /// <summary>
            /// Enum Dialing for "dialing"
            /// </summary>
            [EnumMember(Value = "dialing")]
            Dialing,
            
            /// <summary>
            /// Enum Contacting for "contacting"
            /// </summary>
            [EnumMember(Value = "contacting")]
            Contacting,
            
            /// <summary>
            /// Enum Offering for "offering"
            /// </summary>
            [EnumMember(Value = "offering")]
            Offering,
            
            /// <summary>
            /// Enum Connected for "connected"
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "disconnected"
            /// </summary>
            [EnumMember(Value = "disconnected")]
            Disconnected,
            
            /// <summary>
            /// Enum Terminated for "terminated"
            /// </summary>
            [EnumMember(Value = "terminated")]
            Terminated,
            
            /// <summary>
            /// Enum Converting for "converting"
            /// </summary>
            [EnumMember(Value = "converting")]
            Converting,
            
            /// <summary>
            /// Enum Uploading for "uploading"
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading,
            
            /// <summary>
            /// Enum Transmitting for "transmitting"
            /// </summary>
            [EnumMember(Value = "transmitting")]
            Transmitting,
            
            /// <summary>
            /// Enum Scheduled for "scheduled"
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None
        }
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DisconnectTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Endpoint for "endpoint"
            /// </summary>
            [EnumMember(Value = "endpoint")]
            Endpoint,
            
            /// <summary>
            /// Enum Client for "client"
            /// </summary>
            [EnumMember(Value = "client")]
            Client,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System,
            
            /// <summary>
            /// Enum Transfer for "transfer"
            /// </summary>
            [EnumMember(Value = "transfer")]
            Transfer,
            
            /// <summary>
            /// Enum Timeout for "timeout"
            /// </summary>
            [EnumMember(Value = "timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Transferconference for "transfer.conference"
            /// </summary>
            [EnumMember(Value = "transfer.conference")]
            Transferconference,
            
            /// <summary>
            /// Enum Transferconsult for "transfer.consult"
            /// </summary>
            [EnumMember(Value = "transfer.consult")]
            Transferconsult,
            
            /// <summary>
            /// Enum Transferforward for "transfer.forward"
            /// </summary>
            [EnumMember(Value = "transfer.forward")]
            Transferforward,
            
            /// <summary>
            /// Enum Transfernoanswer for "transfer.noanswer"
            /// </summary>
            [EnumMember(Value = "transfer.noanswer")]
            Transfernoanswer,
            
            /// <summary>
            /// Enum Transfernotavailable for "transfer.notavailable"
            /// </summary>
            [EnumMember(Value = "transfer.notavailable")]
            Transfernotavailable,
            
            /// <summary>
            /// Enum Transportfailure for "transport.failure"
            /// </summary>
            [EnumMember(Value = "transport.failure")]
            Transportfailure,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error,
            
            /// <summary>
            /// Enum Peer for "peer"
            /// </summary>
            [EnumMember(Value = "peer")]
            Peer,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other,
            
            /// <summary>
            /// Enum Spam for "spam"
            /// </summary>
            [EnumMember(Value = "spam")]
            Spam,
            
            /// <summary>
            /// Enum Uncallable for "uncallable"
            /// </summary>
            [EnumMember(Value = "uncallable")]
            Uncallable
        }
        /// <summary>
        /// Gets or Sets FlaggedReason
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FlaggedReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum General for "general"
            /// </summary>
            [EnumMember(Value = "general")]
            General
        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [DataMember(Name="initialState", EmitDefaultValue=false)]
        public InitialStateEnum? InitialState { get; set; }
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// Gets or Sets FlaggedReason
        /// </summary>
        [DataMember(Name="flaggedReason", EmitDefaultValue=false)]
        public FlaggedReasonEnum? FlaggedReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCobrowseEventTopicCobrowseMediaParticipant" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Address">Address.</param>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="ConnectedTime">ConnectedTime.</param>
        /// <param name="EndTime">EndTime.</param>
        /// <param name="StartHoldTime">StartHoldTime.</param>
        /// <param name="Purpose">Purpose.</param>
        /// <param name="State">State.</param>
        /// <param name="InitialState">InitialState.</param>
        /// <param name="Direction">Direction.</param>
        /// <param name="DisconnectType">DisconnectType.</param>
        /// <param name="Held">Held.</param>
        /// <param name="WrapupRequired">WrapupRequired.</param>
        /// <param name="WrapupPrompt">WrapupPrompt.</param>
        /// <param name="User">User.</param>
        /// <param name="Queue">Queue.</param>
        /// <param name="Team">Team.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="ErrorInfo">ErrorInfo.</param>
        /// <param name="Script">Script.</param>
        /// <param name="WrapupTimeoutMs">WrapupTimeoutMs.</param>
        /// <param name="WrapupSkipped">WrapupSkipped.</param>
        /// <param name="AlertingTimeoutMs">AlertingTimeoutMs.</param>
        /// <param name="Provider">Provider.</param>
        /// <param name="ExternalContact">ExternalContact.</param>
        /// <param name="ExternalOrganization">ExternalOrganization.</param>
        /// <param name="Wrapup">Wrapup.</param>
        /// <param name="ConversationRoutingData">ConversationRoutingData.</param>
        /// <param name="Peer">Peer.</param>
        /// <param name="ScreenRecordingState">ScreenRecordingState.</param>
        /// <param name="FlaggedReason">FlaggedReason.</param>
        /// <param name="JourneyContext">JourneyContext.</param>
        /// <param name="StartAcwTime">StartAcwTime.</param>
        /// <param name="EndAcwTime">EndAcwTime.</param>
        /// <param name="MediaRoles">MediaRoles.</param>
        /// <param name="QueueMediaSettings">QueueMediaSettings.</param>
        /// <param name="CobrowseSessionId">CobrowseSessionId.</param>
        /// <param name="CobrowseRole">CobrowseRole.</param>
        /// <param name="ViewerUrl">ViewerUrl.</param>
        /// <param name="ProviderEventTime">ProviderEventTime.</param>
        /// <param name="Controlling">Controlling.</param>
        public ConversationCobrowseEventTopicCobrowseMediaParticipant(string Id = null, string Name = null, string Address = null, DateTime? StartTime = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, DateTime? StartHoldTime = null, string Purpose = null, StateEnum? State = null, InitialStateEnum? InitialState = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, bool? Held = null, bool? WrapupRequired = null, string WrapupPrompt = null, ConversationCobrowseEventTopicUriReference User = null, ConversationCobrowseEventTopicUriReference Queue = null, ConversationCobrowseEventTopicUriReference Team = null, Dictionary<string, string> Attributes = null, ConversationCobrowseEventTopicErrorBody ErrorInfo = null, ConversationCobrowseEventTopicUriReference Script = null, int? WrapupTimeoutMs = null, bool? WrapupSkipped = null, int? AlertingTimeoutMs = null, string Provider = null, ConversationCobrowseEventTopicUriReference ExternalContact = null, ConversationCobrowseEventTopicUriReference ExternalOrganization = null, ConversationCobrowseEventTopicWrapup Wrapup = null, ConversationCobrowseEventTopicConversationRoutingData ConversationRoutingData = null, string Peer = null, string ScreenRecordingState = null, FlaggedReasonEnum? FlaggedReason = null, ConversationCobrowseEventTopicJourneyContext JourneyContext = null, DateTime? StartAcwTime = null, DateTime? EndAcwTime = null, List<string> MediaRoles = null, ConversationCobrowseEventTopicQueueMediaSettings QueueMediaSettings = null, string CobrowseSessionId = null, string CobrowseRole = null, string ViewerUrl = null, DateTime? ProviderEventTime = null, List<string> Controlling = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.StartTime = StartTime;
            this.ConnectedTime = ConnectedTime;
            this.EndTime = EndTime;
            this.StartHoldTime = StartHoldTime;
            this.Purpose = Purpose;
            this.State = State;
            this.InitialState = InitialState;
            this.Direction = Direction;
            this.DisconnectType = DisconnectType;
            this.Held = Held;
            this.WrapupRequired = WrapupRequired;
            this.WrapupPrompt = WrapupPrompt;
            this.User = User;
            this.Queue = Queue;
            this.Team = Team;
            this.Attributes = Attributes;
            this.ErrorInfo = ErrorInfo;
            this.Script = Script;
            this.WrapupTimeoutMs = WrapupTimeoutMs;
            this.WrapupSkipped = WrapupSkipped;
            this.AlertingTimeoutMs = AlertingTimeoutMs;
            this.Provider = Provider;
            this.ExternalContact = ExternalContact;
            this.ExternalOrganization = ExternalOrganization;
            this.Wrapup = Wrapup;
            this.ConversationRoutingData = ConversationRoutingData;
            this.Peer = Peer;
            this.ScreenRecordingState = ScreenRecordingState;
            this.FlaggedReason = FlaggedReason;
            this.JourneyContext = JourneyContext;
            this.StartAcwTime = StartAcwTime;
            this.EndAcwTime = EndAcwTime;
            this.MediaRoles = MediaRoles;
            this.QueueMediaSettings = QueueMediaSettings;
            this.CobrowseSessionId = CobrowseSessionId;
            this.CobrowseRole = CobrowseRole;
            this.ViewerUrl = ViewerUrl;
            this.ProviderEventTime = ProviderEventTime;
            this.Controlling = Controlling;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }



        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }



        /// <summary>
        /// Gets or Sets ConnectedTime
        /// </summary>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }



        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }



        /// <summary>
        /// Gets or Sets StartHoldTime
        /// </summary>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }



        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }











        /// <summary>
        /// Gets or Sets Held
        /// </summary>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }



        /// <summary>
        /// Gets or Sets WrapupRequired
        /// </summary>
        [DataMember(Name="wrapupRequired", EmitDefaultValue=false)]
        public bool? WrapupRequired { get; set; }



        /// <summary>
        /// Gets or Sets WrapupPrompt
        /// </summary>
        [DataMember(Name="wrapupPrompt", EmitDefaultValue=false)]
        public string WrapupPrompt { get; set; }



        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicUriReference User { get; set; }



        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicUriReference Queue { get; set; }



        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicUriReference Team { get; set; }



        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }



        /// <summary>
        /// Gets or Sets ErrorInfo
        /// </summary>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicErrorBody ErrorInfo { get; set; }



        /// <summary>
        /// Gets or Sets Script
        /// </summary>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicUriReference Script { get; set; }



        /// <summary>
        /// Gets or Sets WrapupTimeoutMs
        /// </summary>
        [DataMember(Name="wrapupTimeoutMs", EmitDefaultValue=false)]
        public int? WrapupTimeoutMs { get; set; }



        /// <summary>
        /// Gets or Sets WrapupSkipped
        /// </summary>
        [DataMember(Name="wrapupSkipped", EmitDefaultValue=false)]
        public bool? WrapupSkipped { get; set; }



        /// <summary>
        /// Gets or Sets AlertingTimeoutMs
        /// </summary>
        [DataMember(Name="alertingTimeoutMs", EmitDefaultValue=false)]
        public int? AlertingTimeoutMs { get; set; }



        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }



        /// <summary>
        /// Gets or Sets ExternalContact
        /// </summary>
        [DataMember(Name="externalContact", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicUriReference ExternalContact { get; set; }



        /// <summary>
        /// Gets or Sets ExternalOrganization
        /// </summary>
        [DataMember(Name="externalOrganization", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicUriReference ExternalOrganization { get; set; }



        /// <summary>
        /// Gets or Sets Wrapup
        /// </summary>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicWrapup Wrapup { get; set; }



        /// <summary>
        /// Gets or Sets ConversationRoutingData
        /// </summary>
        [DataMember(Name="conversationRoutingData", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicConversationRoutingData ConversationRoutingData { get; set; }



        /// <summary>
        /// Gets or Sets Peer
        /// </summary>
        [DataMember(Name="peer", EmitDefaultValue=false)]
        public string Peer { get; set; }



        /// <summary>
        /// Gets or Sets ScreenRecordingState
        /// </summary>
        [DataMember(Name="screenRecordingState", EmitDefaultValue=false)]
        public string ScreenRecordingState { get; set; }





        /// <summary>
        /// Gets or Sets JourneyContext
        /// </summary>
        [DataMember(Name="journeyContext", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicJourneyContext JourneyContext { get; set; }



        /// <summary>
        /// Gets or Sets StartAcwTime
        /// </summary>
        [DataMember(Name="startAcwTime", EmitDefaultValue=false)]
        public DateTime? StartAcwTime { get; set; }



        /// <summary>
        /// Gets or Sets EndAcwTime
        /// </summary>
        [DataMember(Name="endAcwTime", EmitDefaultValue=false)]
        public DateTime? EndAcwTime { get; set; }



        /// <summary>
        /// Gets or Sets MediaRoles
        /// </summary>
        [DataMember(Name="mediaRoles", EmitDefaultValue=false)]
        public List<string> MediaRoles { get; set; }



        /// <summary>
        /// Gets or Sets QueueMediaSettings
        /// </summary>
        [DataMember(Name="queueMediaSettings", EmitDefaultValue=false)]
        public ConversationCobrowseEventTopicQueueMediaSettings QueueMediaSettings { get; set; }



        /// <summary>
        /// Gets or Sets CobrowseSessionId
        /// </summary>
        [DataMember(Name="cobrowseSessionId", EmitDefaultValue=false)]
        public string CobrowseSessionId { get; set; }



        /// <summary>
        /// Gets or Sets CobrowseRole
        /// </summary>
        [DataMember(Name="cobrowseRole", EmitDefaultValue=false)]
        public string CobrowseRole { get; set; }



        /// <summary>
        /// Gets or Sets ViewerUrl
        /// </summary>
        [DataMember(Name="viewerUrl", EmitDefaultValue=false)]
        public string ViewerUrl { get; set; }



        /// <summary>
        /// Gets or Sets ProviderEventTime
        /// </summary>
        [DataMember(Name="providerEventTime", EmitDefaultValue=false)]
        public DateTime? ProviderEventTime { get; set; }



        /// <summary>
        /// Gets or Sets Controlling
        /// </summary>
        [DataMember(Name="controlling", EmitDefaultValue=false)]
        public List<string> Controlling { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationCobrowseEventTopicCobrowseMediaParticipant {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  InitialState: ").Append(InitialState).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
            sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
            sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
            sb.Append("  AlertingTimeoutMs: ").Append(AlertingTimeoutMs).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
            sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
            sb.Append("  ConversationRoutingData: ").Append(ConversationRoutingData).Append("\n");
            sb.Append("  Peer: ").Append(Peer).Append("\n");
            sb.Append("  ScreenRecordingState: ").Append(ScreenRecordingState).Append("\n");
            sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
            sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
            sb.Append("  StartAcwTime: ").Append(StartAcwTime).Append("\n");
            sb.Append("  EndAcwTime: ").Append(EndAcwTime).Append("\n");
            sb.Append("  MediaRoles: ").Append(MediaRoles).Append("\n");
            sb.Append("  QueueMediaSettings: ").Append(QueueMediaSettings).Append("\n");
            sb.Append("  CobrowseSessionId: ").Append(CobrowseSessionId).Append("\n");
            sb.Append("  CobrowseRole: ").Append(CobrowseRole).Append("\n");
            sb.Append("  ViewerUrl: ").Append(ViewerUrl).Append("\n");
            sb.Append("  ProviderEventTime: ").Append(ProviderEventTime).Append("\n");
            sb.Append("  Controlling: ").Append(Controlling).Append("\n");
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
            return this.Equals(obj as ConversationCobrowseEventTopicCobrowseMediaParticipant);
        }

        /// <summary>
        /// Returns true if ConversationCobrowseEventTopicCobrowseMediaParticipant instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationCobrowseEventTopicCobrowseMediaParticipant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationCobrowseEventTopicCobrowseMediaParticipant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.StartHoldTime == other.StartHoldTime ||
                    this.StartHoldTime != null &&
                    this.StartHoldTime.Equals(other.StartHoldTime)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.InitialState == other.InitialState ||
                    this.InitialState != null &&
                    this.InitialState.Equals(other.InitialState)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
                ) &&
                (
                    this.WrapupRequired == other.WrapupRequired ||
                    this.WrapupRequired != null &&
                    this.WrapupRequired.Equals(other.WrapupRequired)
                ) &&
                (
                    this.WrapupPrompt == other.WrapupPrompt ||
                    this.WrapupPrompt != null &&
                    this.WrapupPrompt.Equals(other.WrapupPrompt)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
                ) &&
                (
                    this.Script == other.Script ||
                    this.Script != null &&
                    this.Script.Equals(other.Script)
                ) &&
                (
                    this.WrapupTimeoutMs == other.WrapupTimeoutMs ||
                    this.WrapupTimeoutMs != null &&
                    this.WrapupTimeoutMs.Equals(other.WrapupTimeoutMs)
                ) &&
                (
                    this.WrapupSkipped == other.WrapupSkipped ||
                    this.WrapupSkipped != null &&
                    this.WrapupSkipped.Equals(other.WrapupSkipped)
                ) &&
                (
                    this.AlertingTimeoutMs == other.AlertingTimeoutMs ||
                    this.AlertingTimeoutMs != null &&
                    this.AlertingTimeoutMs.Equals(other.AlertingTimeoutMs)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.ExternalContact == other.ExternalContact ||
                    this.ExternalContact != null &&
                    this.ExternalContact.Equals(other.ExternalContact)
                ) &&
                (
                    this.ExternalOrganization == other.ExternalOrganization ||
                    this.ExternalOrganization != null &&
                    this.ExternalOrganization.Equals(other.ExternalOrganization)
                ) &&
                (
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
                ) &&
                (
                    this.ConversationRoutingData == other.ConversationRoutingData ||
                    this.ConversationRoutingData != null &&
                    this.ConversationRoutingData.Equals(other.ConversationRoutingData)
                ) &&
                (
                    this.Peer == other.Peer ||
                    this.Peer != null &&
                    this.Peer.Equals(other.Peer)
                ) &&
                (
                    this.ScreenRecordingState == other.ScreenRecordingState ||
                    this.ScreenRecordingState != null &&
                    this.ScreenRecordingState.Equals(other.ScreenRecordingState)
                ) &&
                (
                    this.FlaggedReason == other.FlaggedReason ||
                    this.FlaggedReason != null &&
                    this.FlaggedReason.Equals(other.FlaggedReason)
                ) &&
                (
                    this.JourneyContext == other.JourneyContext ||
                    this.JourneyContext != null &&
                    this.JourneyContext.Equals(other.JourneyContext)
                ) &&
                (
                    this.StartAcwTime == other.StartAcwTime ||
                    this.StartAcwTime != null &&
                    this.StartAcwTime.Equals(other.StartAcwTime)
                ) &&
                (
                    this.EndAcwTime == other.EndAcwTime ||
                    this.EndAcwTime != null &&
                    this.EndAcwTime.Equals(other.EndAcwTime)
                ) &&
                (
                    this.MediaRoles == other.MediaRoles ||
                    this.MediaRoles != null &&
                    this.MediaRoles.SequenceEqual(other.MediaRoles)
                ) &&
                (
                    this.QueueMediaSettings == other.QueueMediaSettings ||
                    this.QueueMediaSettings != null &&
                    this.QueueMediaSettings.Equals(other.QueueMediaSettings)
                ) &&
                (
                    this.CobrowseSessionId == other.CobrowseSessionId ||
                    this.CobrowseSessionId != null &&
                    this.CobrowseSessionId.Equals(other.CobrowseSessionId)
                ) &&
                (
                    this.CobrowseRole == other.CobrowseRole ||
                    this.CobrowseRole != null &&
                    this.CobrowseRole.Equals(other.CobrowseRole)
                ) &&
                (
                    this.ViewerUrl == other.ViewerUrl ||
                    this.ViewerUrl != null &&
                    this.ViewerUrl.Equals(other.ViewerUrl)
                ) &&
                (
                    this.ProviderEventTime == other.ProviderEventTime ||
                    this.ProviderEventTime != null &&
                    this.ProviderEventTime.Equals(other.ProviderEventTime)
                ) &&
                (
                    this.Controlling == other.Controlling ||
                    this.Controlling != null &&
                    this.Controlling.SequenceEqual(other.Controlling)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();

                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();

                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();

                if (this.StartHoldTime != null)
                    hash = hash * 59 + this.StartHoldTime.GetHashCode();

                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.InitialState != null)
                    hash = hash * 59 + this.InitialState.GetHashCode();

                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();

                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();

                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();

                if (this.WrapupRequired != null)
                    hash = hash * 59 + this.WrapupRequired.GetHashCode();

                if (this.WrapupPrompt != null)
                    hash = hash * 59 + this.WrapupPrompt.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();

                if (this.Script != null)
                    hash = hash * 59 + this.Script.GetHashCode();

                if (this.WrapupTimeoutMs != null)
                    hash = hash * 59 + this.WrapupTimeoutMs.GetHashCode();

                if (this.WrapupSkipped != null)
                    hash = hash * 59 + this.WrapupSkipped.GetHashCode();

                if (this.AlertingTimeoutMs != null)
                    hash = hash * 59 + this.AlertingTimeoutMs.GetHashCode();

                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();

                if (this.ExternalContact != null)
                    hash = hash * 59 + this.ExternalContact.GetHashCode();

                if (this.ExternalOrganization != null)
                    hash = hash * 59 + this.ExternalOrganization.GetHashCode();

                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();

                if (this.ConversationRoutingData != null)
                    hash = hash * 59 + this.ConversationRoutingData.GetHashCode();

                if (this.Peer != null)
                    hash = hash * 59 + this.Peer.GetHashCode();

                if (this.ScreenRecordingState != null)
                    hash = hash * 59 + this.ScreenRecordingState.GetHashCode();

                if (this.FlaggedReason != null)
                    hash = hash * 59 + this.FlaggedReason.GetHashCode();

                if (this.JourneyContext != null)
                    hash = hash * 59 + this.JourneyContext.GetHashCode();

                if (this.StartAcwTime != null)
                    hash = hash * 59 + this.StartAcwTime.GetHashCode();

                if (this.EndAcwTime != null)
                    hash = hash * 59 + this.EndAcwTime.GetHashCode();

                if (this.MediaRoles != null)
                    hash = hash * 59 + this.MediaRoles.GetHashCode();

                if (this.QueueMediaSettings != null)
                    hash = hash * 59 + this.QueueMediaSettings.GetHashCode();

                if (this.CobrowseSessionId != null)
                    hash = hash * 59 + this.CobrowseSessionId.GetHashCode();

                if (this.CobrowseRole != null)
                    hash = hash * 59 + this.CobrowseRole.GetHashCode();

                if (this.ViewerUrl != null)
                    hash = hash * 59 + this.ViewerUrl.GetHashCode();

                if (this.ProviderEventTime != null)
                    hash = hash * 59 + this.ProviderEventTime.GetHashCode();

                if (this.Controlling != null)
                    hash = hash * 59 + this.Controlling.GetHashCode();

                return hash;
            }
        }
    }

}
