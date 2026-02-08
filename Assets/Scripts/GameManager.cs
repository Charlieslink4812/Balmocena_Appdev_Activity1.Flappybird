using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Fix 1: Added this so SceneManager works

public class GameManager : MonoBehaviour
{
    // Fix 2: Changed "public class GameManager : instance;" to a static variable
    public static GameManager instance;

    [SerializeField] private GameObject _gameOverCanvas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        // Fix 3: Capitalized "Time" and "timeScale", removed extra space
        Time.timeScale = 1f;
    }

    public void Gameover()
    {
        _gameOverCanvas.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        // Fix 4: Fixed typo "GetActiveScence" -> "GetActiveScene"
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}