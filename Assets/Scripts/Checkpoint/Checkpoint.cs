using UnityEngine;

namespace Scripts.Checkpoint
{
    public class Checkpoint : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Destroy(this.gameObject);
        }
    }
}

