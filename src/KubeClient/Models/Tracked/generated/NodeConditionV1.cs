using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models.Tracked
{
    /// <summary>
    ///     NodeCondition contains condition information for a node.
    /// </summary>
    public partial class NodeConditionV1 : Models.NodeConditionV1, ITracked
    {
        /// <summary>
        ///     Last time we got an update on a given condition.
        /// </summary>
        [JsonProperty("lastHeartbeatTime")]
        [YamlMember(Alias = "lastHeartbeatTime")]
        public override DateTime? LastHeartbeatTime
        {
            get
            {
                return base.LastHeartbeatTime;
            }
            set
            {
                base.LastHeartbeatTime = value;

                __ModifiedProperties__.Add("LastHeartbeatTime");
            }
        }


        /// <summary>
        ///     Last time the condition transit from one status to another.
        /// </summary>
        [JsonProperty("lastTransitionTime")]
        [YamlMember(Alias = "lastTransitionTime")]
        public override DateTime? LastTransitionTime
        {
            get
            {
                return base.LastTransitionTime;
            }
            set
            {
                base.LastTransitionTime = value;

                __ModifiedProperties__.Add("LastTransitionTime");
            }
        }


        /// <summary>
        ///     Human readable message indicating details about last transition.
        /// </summary>
        [JsonProperty("message")]
        [YamlMember(Alias = "message")]
        public override string Message
        {
            get
            {
                return base.Message;
            }
            set
            {
                base.Message = value;

                __ModifiedProperties__.Add("Message");
            }
        }


        /// <summary>
        ///     Type of node condition.
        /// </summary>
        [JsonProperty("type")]
        [YamlMember(Alias = "type")]
        public override string Type
        {
            get
            {
                return base.Type;
            }
            set
            {
                base.Type = value;

                __ModifiedProperties__.Add("Type");
            }
        }


        /// <summary>
        ///     (brief) reason for the condition's last transition.
        /// </summary>
        [JsonProperty("reason")]
        [YamlMember(Alias = "reason")]
        public override string Reason
        {
            get
            {
                return base.Reason;
            }
            set
            {
                base.Reason = value;

                __ModifiedProperties__.Add("Reason");
            }
        }


        /// <summary>
        ///     Status of the condition, one of True, False, Unknown.
        /// </summary>
        [JsonProperty("status")]
        [YamlMember(Alias = "status")]
        public override string Status
        {
            get
            {
                return base.Status;
            }
            set
            {
                base.Status = value;

                __ModifiedProperties__.Add("Status");
            }
        }


        /// <summary>
        ///     Names of model properties that have been modified.
        /// </summary>
        [JsonIgnore, YamlIgnore]
        public HashSet<string> __ModifiedProperties__ { get; } = new HashSet<string>();
    }
}
