using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int count = 0;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        updateScore(0);
    }
    
    private void updateScore(int score)
    {
        count += score;
        scoreText.text = "Coins: " + count.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            updateScore(1);
            Destroy(other.gameObject);
        }

    }
}
