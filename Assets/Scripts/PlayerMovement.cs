using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _forwardSpeed;

    [SerializeField] private float _horizontalSpeed;

    [SerializeField] private Rigidbody _rigidbody;

    private Vector3 _velocity = new Vector3();

    private void Start()
    {
        
    }

    private void Update()
    {
        _velocity.z = _forwardSpeed;
        _velocity.z = _rigidbody.velocity.y;
        _velocity.x = Input.GetAxis("Horizontal") * _horizontalSpeed;
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _velocity;
    }
}
