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
        //��ǥ �������� �̵�(�׺�Ž� ���)
        //��ǥ ���������� �Ÿ� Ȯ��
        if (CheckArrived())
        {
            //�׺�Ž��� ����� �����̴� ��ǥ������ �����ϸ� ��ǥ������ �÷��̾� ��ġ�� ����
            stateMachine.ChangeState(stateMachine.idleState); //��ǥ�� �����ϸ� �����·� ��ȯ
        }
    }

    bool CheckArrived()
    {
        return true;
    }
}
