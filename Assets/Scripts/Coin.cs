using UnityEngine;

public class Coin : MonoBehaviour
{
    public int rotationSpeed = 70;
    void Update()
    {
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);
    }
}
