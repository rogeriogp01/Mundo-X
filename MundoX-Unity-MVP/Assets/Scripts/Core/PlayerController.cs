using UnityEngine;

namespace MundoX.Core
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private CharacterController characterController;
        [SerializeField] private float moveSpeed = 4.5f;
        [SerializeField] private float turnSpeed = 8f;

        private Vector3 _velocity;

        private void Reset()
        {
            characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            var input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            var movement = new Vector3(input.x, 0, input.y);

            if (movement.sqrMagnitude > 0.01f)
            {
                var direction = Camera.main.transform.TransformDirection(movement);
                direction.y = 0;
                direction.Normalize();

                var targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

                _velocity = direction * moveSpeed;
                characterController.Move(_velocity * Time.deltaTime);
            }
        }
    }
}
