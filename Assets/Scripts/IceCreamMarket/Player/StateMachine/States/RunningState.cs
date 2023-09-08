using IceCreamMarket.Interfaces;
using UnityEngine;

namespace IceCreamMarket.Player.StateMachine.States
{
    public class RunningState : IPlayerState
    {
        private PlayerFiniteStateMachine _playerFiniteStateMachine;
        
        public void Enter(PlayerFiniteStateMachine playerFiniteStateMachine)
        {
            _playerFiniteStateMachine = playerFiniteStateMachine;
            _playerFiniteStateMachine.animator.SetTrigger(AnimationTags.PlayerRunning);
        }
        public void Update()
        {
            if (!_playerFiniteStateMachine.joystick.IsTouching())
            {
                _playerFiniteStateMachine.SetIdleState();
                return;
            }
            
            MoveAndRotate();
        }
        private void MoveAndRotate()
        {
            _playerFiniteStateMachine.transform.position += new Vector3(_playerFiniteStateMachine.joystick.GetJoystickDirection().x,0,_playerFiniteStateMachine.joystick.GetJoystickDirection().y) * (_playerFiniteStateMachine.playerData.speed * Time.deltaTime);
            
            _playerFiniteStateMachine.transform.rotation = Quaternion.Euler(0, Mathf.Atan2(_playerFiniteStateMachine.joystick.GetJoystickDirection().x, _playerFiniteStateMachine.joystick.GetJoystickDirection().y) * Mathf.Rad2Deg,0);
        }
        public void Exit()
        {
        }
    }
}
