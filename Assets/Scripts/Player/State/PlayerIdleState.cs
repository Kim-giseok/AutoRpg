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

        if (CheckEnemyRemained())//���� ����������
        {
            //����� �� ��ǥ�� ���
            stateMachine.ChangeState(stateMachine.attackState);
        }
        else //���� ������
        {
            stateMachine.ChangeState(stateMachine.moveState);
        }
    }

    bool CheckEnemyRemained()
    {
        return true;
    }
}
