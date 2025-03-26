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
        //Å¸°Ù¿¡°Ô °ø°Ý
        //Å¸°Ù ³²Àº Ã¼·Â È®ÀÎ
        if (CheckTargetHp())
            stateMachine.ChangeState(stateMachine.idleState); //Å¸°ÙÀÌ Á×À¸¸é idle·Î º¹±Í        
    }

    bool CheckTargetHp()
    {
        return true;
    }
}
