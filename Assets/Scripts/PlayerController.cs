using UnityEngine;

namespace TopdownSurvival
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 10;

        private float horizontalAxis;
        private float verticalAxis;
        private float moveHorizontal;
        private float moveVertical;

        private void Update()
        {
            HandlePlayerControls();
        }

        private void HandlePlayerControls()
        {
            horizontalAxis = Input.GetAxisRaw("Horizontal");
            verticalAxis = Input.GetAxisRaw("Vertical");

            moveHorizontal = horizontalAxis * moveSpeed * Time.deltaTime;
            moveVertical = verticalAxis * moveSpeed * Time.deltaTime;

            transform.Translate(moveHorizontal, 0, moveVertical);
        }
    }
}