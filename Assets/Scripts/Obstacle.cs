using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Debug.Log("CollisionEnter: " + collision.rigidbody.name);
        }
        else
        {
            var normal = collision.GetContact(0).normal;
            collision.rigidbody.AddForce(normal * 30, ForceMode.Impulse);
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
