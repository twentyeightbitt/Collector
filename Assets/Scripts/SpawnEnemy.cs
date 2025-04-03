using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    private GameObject[] islands;
    
    void Start()
    {
        islands = GameObject.FindGameObjectsWithTag("Ground");

        for (int i = 0; i < islands.Length; i++)
        {
            Vector3 position = islands[i].transform.position + new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
}
