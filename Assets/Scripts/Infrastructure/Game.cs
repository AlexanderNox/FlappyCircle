using Model;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Infrastructure
{
    public class Game : MonoBehaviour
    {
        private Player _player;

        [Inject]
        private void Construct(Player player)
        {
            _player = player;
        }

        private void OnEnable()
        {
            _player.Died += Reload;
        }

        private void OnDisable()
        {
            _player.Died -= Reload;
        }

        public void Reload()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}