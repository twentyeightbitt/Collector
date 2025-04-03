using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;

    public void Play()
    {
        _startMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Collector");
    }
}
