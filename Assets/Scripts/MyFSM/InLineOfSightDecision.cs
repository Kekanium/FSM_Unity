using Scripts.Enemy;
using Scripts.FSM;
using UnityEngine;

namespace Scripts.MyFSM
{
    [CreateAssetMenu(menuName = "FSM/Decisions/In Line Of Sight")]
    public class InLineOfSightDecision : Decision
    {
        public override bool Decide(BaseStateMachine stateMachine)
        {
            var enemyInLineOfSight = stateMachine.GetComponent<EnemySightSensor>();
            return enemyInLineOfSight.Ping();
        }
    }
}