using Model;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Transform _position;
        [SerializeField] private float _jumpForce;
        [SerializeField] private float _gravity;
        private InputActionMaps _inputActionMaps;

        [Inject]
        private void Construct(InputActionMaps inputActionMaps)
        {
            _inputActionMaps = inputActionMaps;
        }
        
        public override void InstallBindings()
        {
            var instance = new Player(
                new Vector2(_position.position.x, _position.position.y),
                _jumpForce, _gravity, _inputActionMaps);

            Container
                .Bind<Player>()
                .FromInstance(instance)
                .AsSingle();
        }
    }
}