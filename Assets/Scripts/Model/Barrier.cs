using System;
using UnityEngine;

namespace Model
{
    public class Barrier : CustomTransform
    {
        private readonly float _speed;
        private float _lifeTime;

        public event Action Destroyed;

        public Barrier(Vector2 position, float lifeTime, float speed) : base(position)
        {
            _lifeTime = lifeTime;
            _speed = speed;
        }

        public void FixedUpdate()
        {
            _lifeTime -= Time.fixedDeltaTime;
            if (_lifeTime <= 0)
                Destroy();

            SetPosition(new Vector2(Position.x - _speed * Time.fixedDeltaTime, Position.y));
        }

        private void Destroy() => Destroyed?.Invoke();
        
        public void OnTriggerEnter2D(Collider2D  col)
        {
            if (col.gameObject.TryGetComponent(out ICandie candie))
                candie.Die();
        }
    }
}