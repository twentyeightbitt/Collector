using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField]private GameObject _gameOverScreen;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
            _gameOverScreen.SetActive(true);
        }
    }
}
