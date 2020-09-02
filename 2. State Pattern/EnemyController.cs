using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform playerTransform;
    public float distanceToPlayer;
    public float aggroDistance = 10.0f;

    private EnemyBaseState currentState;
    public EnemyBaseState CurrentState
    {
        get { return currentState; }
    }

    public readonly EnemyIdleState IdleState = new EnemyIdleState();
    public readonly EnemyAttackState AttackState = new EnemyAttackState();
    // keep adding states

    private void Start()
    {
        TransitionToState(IdleState);
    }

    public void TransitionToState(EnemyBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);
        currentState.UpdateState(this);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.25f);
        Gizmos.DrawSphere(transform.position, aggroDistance);
    }
}
