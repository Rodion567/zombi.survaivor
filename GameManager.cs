using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int killCount = 0;
    public int killsToWin = 10;

    void Awake()
    {
        instance = this;
    }

    public void AddKill()
    {
        killCount++;

        Debug.Log("Убито: " + killCount);

        if (killCount >= killsToWin)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
