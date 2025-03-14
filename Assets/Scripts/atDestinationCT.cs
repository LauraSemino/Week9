using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions {

	public class atDestinationCT : ConditionTask {

        public Transform point1;
        public Transform point2;
        //public BBParameter<Transform> destination;
        public BBParameter<Transform> destination;
        public NavMeshAgent navAgent;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			//destination = point1;
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			NavMeshHit hit;
			//NavMesh.SamplePosition(destination.value.position, out hit, 400f, NavMesh.AllAreas);
			
			Debug.Log((destination.value.position - agent.transform.position).magnitude);
			if((point1.position - agent.transform.position).magnitude <= 0.5f)
			{
				Debug.Log("change");
				destination.value = point2;
                
            }
            if ((point2.position - agent.transform.position).magnitude <= 0.5f)
            {
                Debug.Log("change");
                destination.value = point1;

            }

            return true;
		}
	}
}