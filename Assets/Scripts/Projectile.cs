using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 5f;

    private void Start()
    {
        // Destroy projectile after lifeTime seconds to avoid clutter.
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        // Move the projectile forward in local space.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}