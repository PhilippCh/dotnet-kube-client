using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models.Tracked
{
    /// <summary>
    ///     ReplicaSetStatus represents the current status of a ReplicaSet.
    /// </summary>
    public partial class ReplicaSetStatusV1Beta1 : Models.ReplicaSetStatusV1Beta1, ITracked
    {
        /// <summary>
        ///     ObservedGeneration reflects the generation of the most recently observed ReplicaSet.
        /// </summary>
        [JsonProperty("observedGeneration")]
        [YamlMember(Alias = "observedGeneration")]
        public override int ObservedGeneration
        {
            get
            {
                return base.ObservedGeneration;
            }
            set
            {
                base.ObservedGeneration = value;

                __ModifiedProperties__.Add("ObservedGeneration");
            }
        }


        /// <summary>
        ///     The number of available replicas (ready for at least minReadySeconds) for this replica set.
        /// </summary>
        [JsonProperty("availableReplicas")]
        [YamlMember(Alias = "availableReplicas")]
        public override int AvailableReplicas
        {
            get
            {
                return base.AvailableReplicas;
            }
            set
            {
                base.AvailableReplicas = value;

                __ModifiedProperties__.Add("AvailableReplicas");
            }
        }


        /// <summary>
        ///     Represents the latest available observations of a replica set's current state.
        /// </summary>
        [MergeStrategy(Key = "type")]
        [YamlMember(Alias = "conditions")]
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public override List<Models.ReplicaSetConditionV1Beta1> Conditions { get; set; } = new List<Models.ReplicaSetConditionV1Beta1>();

        /// <summary>
        ///     The number of pods that have labels matching the labels of the pod template of the replicaset.
        /// </summary>
        [JsonProperty("fullyLabeledReplicas")]
        [YamlMember(Alias = "fullyLabeledReplicas")]
        public override int FullyLabeledReplicas
        {
            get
            {
                return base.FullyLabeledReplicas;
            }
            set
            {
                base.FullyLabeledReplicas = value;

                __ModifiedProperties__.Add("FullyLabeledReplicas");
            }
        }


        /// <summary>
        ///     The number of ready replicas for this replica set.
        /// </summary>
        [JsonProperty("readyReplicas")]
        [YamlMember(Alias = "readyReplicas")]
        public override int ReadyReplicas
        {
            get
            {
                return base.ReadyReplicas;
            }
            set
            {
                base.ReadyReplicas = value;

                __ModifiedProperties__.Add("ReadyReplicas");
            }
        }


        /// <summary>
        ///     Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
        /// </summary>
        [JsonProperty("replicas")]
        [YamlMember(Alias = "replicas")]
        public override int Replicas
        {
            get
            {
                return base.Replicas;
            }
            set
            {
                base.Replicas = value;

                __ModifiedProperties__.Add("Replicas");
            }
        }


        /// <summary>
        ///     Names of model properties that have been modified.
        /// </summary>
        [JsonIgnore, YamlIgnore]
        public HashSet<string> __ModifiedProperties__ { get; } = new HashSet<string>();
    }
}
