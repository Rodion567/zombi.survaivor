using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        TargetHealth target = collision.gameObject.GetComponent<TargetHealth>();

        if (target != null)
        {
            target.TakeHit();
        }

        
    }
}