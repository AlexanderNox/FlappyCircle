using Infrastructure;
using Model;
using ScriptableObjects;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class BarrierFactoryInstaller : MonoInstaller, ICoroutineRunner
    {
        [SerializeField] private Transform _spawnPosition;
        [SerializeField] private BarrierFactoryConfig _barrierFactoryConfig;
        public override void InstallBindings()
        {
            var instance = new BarrierFactory(_barrierFactoryConfig,
                new Vector2(_spawnPosition.position.x, _spawnPosition.position.y),
                this);

            Container
                .Bind<BarrierFactory>()
                .FromInstance(instance)
                .AsSingle();
        }
    }
}