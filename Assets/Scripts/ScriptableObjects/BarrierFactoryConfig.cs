
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "BarrierFactoryConfig", fileName = "BarrierFactoryConfig", order = 0)]
    public class BarrierFactoryConfig : ScriptableObject
    {
        [field:SerializeField] public float SpawnPositionYRange { get; private set; }
        [field:SerializeField] public float BarrierLifeTime { get; private set; }
        [field:SerializeField] public float BarrierSpeed { get; private set; }
        [field:SerializeField] public float SpawnCooldown { get; private set; }
    }
}