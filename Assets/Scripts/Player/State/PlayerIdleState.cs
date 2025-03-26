using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Update()
    {
        base.Update();

        if (CheckRemainedEnemy())//적이 남아있으면
        {
            //가까운 적 목표로 삼기
            stateMachine.ChangeState(stateMachine.attackState);
        }
        else //적이 없으면
        {
            stateMachine.ChangeState(stateMachine.moveState);
        }
    }

    bool CheckRemainedEnemy()
    {
        return true;
    }
}
