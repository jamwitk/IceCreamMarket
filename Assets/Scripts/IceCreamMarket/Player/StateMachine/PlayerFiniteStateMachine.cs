using IceCreamMarket.Interfaces;
using IceCreamMarket.Player.StateMachine.States;
using Packages.VisualJoystick.Scripts.Utils;
using UnityEngine;
namespace IceCreamMarket.Player.StateMachine
{
    public class PlayerFiniteStateMachine : MonoBehaviour
    {
        
        [Header("References")]
        public Animator animator;
        public VisualJoystick joystick;
        public PlayerData playerData;
        private readonly IdleState _idleState = new IdleState();
        private readonly RunningState _runningState = new RunningState();
        private IPlayerState _currentState;
        
        private void Start()
        {
            SetIdleState();
        }
        private void Update()
        {
            _currentState?.Update();
        }
        public void SetIdleState()
        {
            _currentState?.Exit();
            _currentState = _idleState;
            _currentState.Enter(this);
        }
        public void SetRunningState()
        {
            _currentState?.Exit();
            _currentState = _runningState;
            _currentState.Enter(this);
        }
        
    }
}
