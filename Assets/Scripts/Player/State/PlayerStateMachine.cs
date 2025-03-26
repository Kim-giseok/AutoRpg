using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public Player player { get; private set; }
    public GameObject Target;

    public PlayerIdleState idleState { get; }
    public PlayerAttackState attackState { get; }
    public PlayerMoveState moveState { get; }

    public PlayerStateMachine(Player player)
    {
        this.player = player;

        idleState = new PlayerIdleState(this);
        attackState = new PlayerAttackState(this);
        moveState = new PlayerMoveState(this);
    }
}
