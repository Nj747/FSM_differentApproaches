using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{
    public override void EnterState(EnemyController enemy)
    {
        // Use for Initialize state
    }
    
    public override void UpdateState(EnemyController enemy)
    {
        // Do something for this Idle State

        // Condition for changing state
        if (enemy.distanceToPlayer <= enemy.aggroDistance)
        {
            enemy.TransitionToState(enemy.AttackState);
        }
    }
}
