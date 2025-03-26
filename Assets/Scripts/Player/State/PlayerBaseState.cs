using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBaseState : IState
{
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter()
    {
    }

    public virtual void Exit()
    {
    }

    public virtual void PhysicsUpdate()
    {
    }

    public virtual void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveDir = GetDir();

        Move(moveDir);
    }

    Vector3 GetDir()
    {
        return (stateMachine.Target.transform.position - stateMachine.player.transform.position).normalized;
    }

    void Move(Vector3 dir)
    {
        stateMachine.player.controller.Move(dir * Time.deltaTime);
    }
}
