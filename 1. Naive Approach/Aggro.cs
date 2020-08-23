using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aggro : MonoBehaviour
{
    StateHandler stateHandler;

    private void Awake()
    {
        stateHandler = GetComponent<StateHandler>();
    }

    void Update()
    {
        Debug.Log("Aggro State");

        float distanceToPlayer = Vector3.Distance(transform.position, stateHandler.playerTransform.position);
        if (distanceToPlayer > stateHandler.aggroDistance)
        {
            stateHandler.CurrentState = EnemyStates.Idle;
        }
    }
}
