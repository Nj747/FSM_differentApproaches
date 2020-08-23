using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    StateHandler stateHandler;

    private void Awake()
    {
        stateHandler = GetComponent<StateHandler>();
    }

    void Update()
    {
        Debug.Log("Idle State");

        float distanceToPlayer = Vector3.Distance(transform.position, stateHandler.playerTransform.position);
        if (distanceToPlayer <= stateHandler.aggroDistance)
        {
            stateHandler.CurrentState = EnemyStates.Aggro;
        }
        
    }
}
