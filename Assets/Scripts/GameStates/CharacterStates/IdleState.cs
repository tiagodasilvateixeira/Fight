using Controllers;
using UnityEngine;

namespace States
{
    public class IdleState : CharacterState
    {
        public IdleState(Character playerController) : base(playerController)
        {
            PlayerController = playerController;
        }

        public override void EnterState()
        {
            Debug.Log($"{PlayerController.Name} in IdleState");
        }

        public override void Update()
        {
            CharacterStateSetter.CheckWalkCommand();
            CharacterStateSetter.CheckJumpCommand();
            CharacterStateSetter.CheckPunchCommand();
            CharacterStateSetter.CheckKickCommand();
            CharacterStateSetter.CheckBlockCommand();

            PlayerController.Idle();
        }
    }
}