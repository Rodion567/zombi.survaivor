using UnityEngine;

public class bulet : MonoBehaviour
{
    public float damage = 25f;

    void OnCollisionEnter(Collision collision)
    {
        Health target = collision.gameObject.GetComponent<Health>();
        if (target != null)
        {
            target.TakeDamage(damage);
        }
        Destroy(gameObject); // пуля уничтожается после попадания
    }
}