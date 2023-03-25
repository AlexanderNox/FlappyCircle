using Model;
using UnityEngine;
using View;
using Zenject;

namespace Presenters
{
    [RequireComponent(typeof(PlayerView))]
    public class PlayerPresenter : MonoBehaviour
    {
        private PlayerView _playerView;
        private Player _player;

        [Inject]
        private void Construct(Player player) => _player = player;


        private void Awake() => _playerView = GetComponent<PlayerView>();

        private void OnEnable()
        {
            _player.OnEnable();
            _player.Moved += _playerView.SetPosition;
        }


        private void FixedUpdate() => _player.OnFixedUpdate();

        private void OnDisable()
        {
            _player.Moved -= _playerView.SetPosition;
            _player.OnDisable();
        }

        public void OnBarriersTouch() => _player.OnBarriersTouch();
    }
}