using Scripts.Enemy;
using Scripts.FSM;
using UnityEngine;
using UnityEngine.AI;

namespace Scripts.MyFSM
{
    [CreateAssetMenu(menuName = "FSM/Actions/Chase")]
    public class ChaseAction : FSMAction
    {
        public override void Execute(BaseStateMachine stateMachine)
        {
            var navMeshAgent = stateMachine.GetComponent<NavMeshAgent>();
            var enemySightSensor = stateMachine.GetComponent<EnemySightSensor>();

            navMeshAgent.SetDestination(enemySightSensor.Player.position);
        }
    }
}