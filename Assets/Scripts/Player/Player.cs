using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStat stat;
    PlayerStateMachine stateMachine;

    void Awake()
    {
        stat = GetComponent<PlayerStat>();
        stateMachine = new PlayerStateMachine(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        stateMachine.ChangeState(stateMachine.moveState);
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.Update();
    }

    void FixedUpdate()
    {
        stateMachine.PhysicsUpdate();
    }
}
