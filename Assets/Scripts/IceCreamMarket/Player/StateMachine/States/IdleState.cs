using IceCreamMarket.Interfaces;
using UnityEngine;
namespace IceCreamMarket.Player.StateMachine.States
{
    public class IdleState : IPlayerState
    {
        private PlayerFiniteStateMachine _playerFiniteStateMachine;
        
        public void Enter(PlayerFiniteStateMachine playerFiniteStateMachine)
        {
            _playerFiniteStateMachine = playerFiniteStateMachine;
            playerFiniteStateMachine.animator.SetTrigger(AnimationTags.PlayerIdle);
        }
        public void Update()
        {
            if (_playerFiniteStateMachine.joystick.IsTouching())
            {
                _playerFiniteStateMachine.SetRunningState();
                return;
            }
        }
        public void Exit()
        {
        }
    }
}
