using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class MoveAT : ActionTask {

		//public float speed;
		//public Transform point1;
		//public Transform point2;
		//public Vector3 direction;
		public BBParameter<Transform> destination;
        public NavMeshAgent navAgent;
        //public Vector3 pos;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
            //pos = agent.transform.position;
            //na
            //navAgent.isStopped = false;
            navAgent.SetDestination(destination.value.position);

            EndAction(true);
            //direction = destination.value.position - agent.transform.position;
            //agent.transform.position += speed * direction.normalized * Time.deltaTime;

        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}