using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyStates
{
    Idle,
    Aggro
}

public class StateHandler : MonoBehaviour
{
    #region CurrentState Property
    private EnemyStates _currentState;
    public EnemyStates CurrentState
    {
        set { _currentState = value; }
        get { return _currentState; }
    }
    #endregion

    public Transform playerTransform;
    public float aggroDistance = 10f;

    Aggro aggroState;
    Idle idleState;

    private void Awake()
    {
        // x defecto
        _currentState = EnemyStates.Idle;

        aggroState = GetComponent<Aggro>();
        idleState = GetComponent<Idle>();
    }

    void Update()
    {
        switch (_currentState)
        {
            case EnemyStates.Idle:
                idleState.enabled = true;
                aggroState.enabled = false;
                break;

            case EnemyStates.Aggro:
                idleState.enabled = false;
                aggroState.enabled = true;
                break;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.25f);
        Gizmos.DrawSphere(transform.position, aggroDistance);
    }
}
