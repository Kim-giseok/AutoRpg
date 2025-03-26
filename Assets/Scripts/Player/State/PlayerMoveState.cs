using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : PlayerBaseState
{
    public PlayerMoveState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Update()
    {
        base.Update();
        //목표 지점으로 이동(네비매쉬 사용)
        //목표 지점까지의 거리 확인
        if (CheckArrived())
        {
            //네비매쉬를 사용할 예정이니 목표지점에 도달하면 목표지점을 플레이어 위치로 변경
            stateMachine.ChangeState(stateMachine.idleState); //목표에 도달하면 통상상태로 전환
        }
    }

    bool CheckArrived()
    {
        return true;
    }
}
