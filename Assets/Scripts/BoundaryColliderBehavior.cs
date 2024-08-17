using UnityEngine;

namespace TopdownSurvival
{
    public class BoundaryColliderBehavior : MonoBehaviour
    {
        private const string PlayerTag = "Player";

        [SerializeField] private Collider boundaryCollider;

        private Vector3 boundaryCenter;
        private Vector3 boundarySize;

        private void Awake()
        {
            boundaryCenter = transform.position;
            boundarySize = boundaryCollider.bounds.size;
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag(PlayerTag))
            {
                Vector3 newPlayerPosition = other.transform.position;

                newPlayerPosition.x = Mathf.Clamp(newPlayerPosition.x, boundaryCenter.x - boundarySize.x / 2, boundaryCenter.x + boundarySize.x / 2);
                newPlayerPosition.z = Mathf.Clamp(newPlayerPosition.z, boundaryCenter.z - boundarySize.z / 2, boundaryCenter.z + boundarySize.z / 2);

                //update player's position
                other.transform.position = newPlayerPosition;
            }
        }
    }
}