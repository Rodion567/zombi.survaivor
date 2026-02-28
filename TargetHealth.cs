using UnityEngine;

public class TargetHealth : MonoBehaviour
{
    public int maxHits = 5;
    private int currentHits = 0;

    public void TakeHit()
    {
        currentHits++;

        if (currentHits >= maxHits)
        {
            ScoreManager.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
