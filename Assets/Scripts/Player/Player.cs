using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStat stat;
    PlayerStateMachine stateMachine;
    public CharacterController controller { get; private set; }

    void Awake()
    {
        GameManager.Instance.player = this;
        stat = GetComponent<PlayerStat>();
        controller = GetComponent<CharacterController>();
        stateMachine = new PlayerStateMachine(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        stateMachine.ChangeState(stateMachine.idleState);
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
