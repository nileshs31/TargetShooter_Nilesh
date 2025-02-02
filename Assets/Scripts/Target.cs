using UnityEngine;
public class Target : MonoBehaviour
{
    // This method should be called when the target is hit by a projectile.
    public void Hit()
    {
        EventBus.TargetHit(this);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Hit();
        }
    }
}