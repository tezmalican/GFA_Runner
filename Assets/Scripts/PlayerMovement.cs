using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _forwardSpeed;
    //public float Speed => _speed;

    [SerializeField] private float _horizontalSpeed;

    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private float _jumpPower;

    private Vector3 _velocity = new Vector3();

    [SerializeField] private float _maxHorizontalDistance;

    private bool _isGrounded;

    private void Update()
    {
        if (!GameInstance.Instance.IsGameStarted)
        {
            _velocity = Vector3.zero;

            return;
        }

        _velocity.z = _forwardSpeed;
        _velocity.y = _rigidbody.velocity.y;
        _velocity.x = Input.GetAxis("Horizontal") * _horizontalSpeed;

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _velocity.y = _jumpPower;
            //_rigidbody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
            _isGrounded = false;
        }
    }

    private void FixedUpdate()
        {
            _rigidbody.velocity = _velocity;
            if (Mathf.Abs(_rigidbody.position.x) > _maxHorizontalDistance)
            {
                var clampedPosition = _rigidbody.position;
                clampedPosition.x = Mathf.Clamp(clampedPosition.x, -_maxHorizontalDistance, _maxHorizontalDistance);

                _rigidbody.position = clampedPosition;
                _velocity.x = 0;
            }

            _isGrounded = Physics.Raycast(_rigidbody.position, Vector3.down, 1.05f);
        }
}
