using UnityEngine;

public class WinGame : MonoBehaviour
{

    [SerializeField] private GameObject _winScreen;
    private Score _score;

    private void Start()
    {
        _score = GetComponent<Score>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal") && _score.count >= 5)
        {
            _winScreen.SetActive(true);
            Time.timeScale = 0; 
        }
        
    }
}
