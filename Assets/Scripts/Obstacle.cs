using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            Debug.Log("CollisionEnter: " + collision.rigidbody.name);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            Debug.Log("CollisionExit: " + collision.rigidbody.name);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            Debug.Log("CollisionStay: " + collision.rigidbody.name);
        }
    }
}
