using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    Player player;

    public PlayerAttackState attackState { get; }
    public PlayerMoveState moveState { get; }

    public PlayerStateMachine(Player player)
    {
        this.player = player;

        attackState = new PlayerAttackState(this);
        moveState = new PlayerMoveState(this);
    }
}
