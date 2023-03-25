using Model;
using UnityEngine;
using Zenject;

namespace Presenters.Barrier
{
    public class BarrierPresenterFactory : MonoBehaviour
    {
        [SerializeField] private BarrierPresenter _barrierPrefab;
        private BarrierFactory _barrierFactory;

        [Inject]
        private void Construct(BarrierFactory barrierFactory) => _barrierFactory = barrierFactory;

        private void OnEnable() => _barrierFactory.Created += Create;

        private void OnDisable() => _barrierFactory.Created -= Create;

        private void Create(Model.Barrier barrier)
        {
            BarrierPresenter instance = Instantiate(_barrierPrefab);
            instance.Init(barrier);
        }
    }
}