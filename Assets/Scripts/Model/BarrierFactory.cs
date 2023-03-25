using System;
using System.Collections;
using Infrastructure;
using ScriptableObjects;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Model
{
    public class BarrierFactory 
    {
        private readonly float _spawnPositionYRange;
        private readonly Vector2 _spawnPosition;
        private readonly float _barrierLifeTime;
        private readonly float _barrierSpeed;
        private readonly float _spawnCooldown;
        private readonly ICoroutineRunner _coroutineRunner;

        public event Action<Barrier> Created;

        public BarrierFactory(BarrierFactoryConfig barrierFactoryConfig, 
            Vector2 spawnPosition, ICoroutineRunner coroutineRunner)
        {
            _spawnPositionYRange = barrierFactoryConfig.SpawnPositionYRange;
            _barrierLifeTime = barrierFactoryConfig.BarrierLifeTime;
            _barrierSpeed = barrierFactoryConfig.BarrierSpeed;
            _spawnCooldown = barrierFactoryConfig.SpawnCooldown;
            _spawnPosition = spawnPosition;
            _coroutineRunner = coroutineRunner;
        }

        public void Start() => _coroutineRunner.StartCoroutine(SpawnCoroutine());

        public IEnumerator SpawnCoroutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(_spawnCooldown);
                Create();
            }
        }

        private void Create()
        {
            var newBarrier = new Barrier(
                new Vector2(_spawnPosition.x, GetSpawnPositionY()), 
                _barrierLifeTime, _barrierSpeed);
            
            Created?.Invoke(newBarrier);
        }

        private float GetSpawnPositionY() => 
            _spawnPosition.y + Random.Range(-_spawnPositionYRange, _spawnPositionYRange);
    }
}