using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackState : PlayerBaseState
{
    public PlayerAttackState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Update()
    {
        base.Update();
        //Ÿ�ٿ��� ����
        //Ÿ�� ���� ü�� Ȯ��
        if (CheckTargetHp())
            stateMachine.ChangeState(stateMachine.idleState); //Ÿ���� ������ idle�� ����        
    }

    bool CheckTargetHp()
    {
        return true;
    }
}
