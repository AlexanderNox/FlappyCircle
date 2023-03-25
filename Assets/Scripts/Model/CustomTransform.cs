using System;
using UnityEngine;

namespace Model
{
    public abstract class CustomTransform
    {
        public Vector2 Position { get; private set; }

        public event Action<Vector2> Moved;

        protected CustomTransform(Vector2 position) => SetPosition(position);

        protected void SetPosition(Vector2 position)
        {
            Position = position;
            Moved?.Invoke(Position);
        }
    }
}