using IceCreamMarket.Player.StateMachine;
namespace IceCreamMarket.Interfaces
{
    public interface IPlayerState
    {
        void Enter(PlayerFiniteStateMachine playerFiniteStateMachine);
        void Update();
        void Exit();
    }
}
