using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Model
{
    public class Player
    {
        private const int VelocityLimit = 3;
        private readonly InputActionMaps _inputActionMaps;
        private readonly float _jumpForce;
        private readonly float _gravity;
        private Vector2 _position;
        private Vector2 _velocity;

        public event Action<Vector2> Moved;
        public event Action Died;

        public Player(Vector2 position, float jumpForce, float gravity, InputActionMaps inputActionMaps)
        {
            _inputActionMaps = inputActionMaps;
            _jumpForce = jumpForce;
            _gravity = gravity;
            SetPosition(position);
        }

        public void OnEnable() => _inputActionMaps.Main.Jump.performed += OnJump;

        public void OnDisable() => _inputActionMaps.Main.Jump.performed -= OnJump;

        public void OnFixedUpdate()
        {
            var newPosition = ApplyPhysics(_position);
            Debug.Log($"Velocity: {_velocity}");
            SetPosition(newPosition);
        }

        public void OnBarriersTouch() => Died?.Invoke();
        private void OnJump(InputAction.CallbackContext obj) => Jump();

        private void Jump() => _velocity += new Vector2(0, _jumpForce);


        private Vector2 ApplyPhysics(Vector2 position)
        {
            _velocity.y -= _gravity;
            _velocity = LimitVelocity(_velocity);
            Debug.Log($"TimeDelta: {Time.fixedDeltaTime}");
            var newPositionStep = _velocity * Time.fixedDeltaTime;

            return position + newPositionStep;
        }

        private Vector2 LimitVelocity(Vector2 velocity)
        {
            if (velocity.y > VelocityLimit)
                velocity.y = VelocityLimit;
            else if (velocity.y < -VelocityLimit)
                velocity.y = -VelocityLimit;

            return velocity;
        }

        private void SetPosition(Vector2 position)
        {
            _position = position;
            Moved?.Invoke(_position);
        }
    }
}