using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameManager : MonoBehaviour
{
    [Header("Настройки победы")]
    public int zombiesToWin = 10;       // сколько нужно убить
    private int zombiesKilled = 0;

    public float timeToWin = 180f;      // 3 минуты в секундах
    private float timer = 0f;

    void Update()
    {
        // Считаем время
        timer += Time.deltaTime;
        if (timer >= timeToWin)
        {
            WinGame();
        }
    }

    // Вызываем, когда зомби умирает
    public void ZombieKilled()
    {
        zombiesKilled++;
        Debug.Log("Зомби убито: " + zombiesKilled);

        if (zombiesKilled >= zombiesToWin)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        Debug.Log("Победа! Загружаем сцену WinScene");
        SceneManager.LoadScene("Win"); // <- имя вашей сцены победы
    }
}
