using UnityEngine;

namespace ZaRefactoritPotom
{
    public class ScoreCounter : MonoBehaviour
    {
        public int Score { get; private set; }

        public void AddScore() => Score++;
    }
}
