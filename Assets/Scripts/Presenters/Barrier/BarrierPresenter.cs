using UnityEngine;
using View;

namespace Presenters.Barrier
{
    [RequireComponent(typeof(BarrierView))]
    public class BarrierPresenter : MonoBehaviour
    {
        [SerializeField] private BarrierPresenterPart[] _barrierPresenterParts; 
        private BarrierView _barrierView;
        private Model.Barrier _barrier;

        private void Awake() => _barrierView = GetComponent<BarrierView>();

        public void Init(Model.Barrier barrier)
        {
            _barrier = barrier;
            enabled = true;
            _barrierView.SetPosition(_barrier.Position);
        }
        
        private void OnEnable()
        {
            _barrier.Moved += _barrierView.SetPosition;
            _barrier.Destroyed += _barrierView.Destroy;

            foreach (var barrierPresenterPart in _barrierPresenterParts)
                barrierPresenterPart.OnTriggerEntered2D += TriggerEnter2D;
            
        }

        private void FixedUpdate()
        {
            _barrier.FixedUpdate();
        }

        private void OnDisable()
        {
            _barrier.Moved -= _barrierView.SetPosition;
            _barrier.Destroyed -= _barrierView.Destroy;
            
            foreach (var barrierPresenterPart in _barrierPresenterParts)
                barrierPresenterPart.OnTriggerEntered2D -= TriggerEnter2D;
        }

        private void TriggerEnter2D(Collider2D  col)
        {
            _barrier.OnTriggerEnter2D(col);
        }
    }
}