using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    private float _vertical;
    private float _horizontal;
    //public int force = 10;
    public int coins = 0;
    public float jumpForce = 5f;
    private Rigidbody rb;
    private bool isGrounded = true;
    public bool isGameOver = false;

    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }


    private void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Move()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * _vertical);
        transform.Translate(Vector3.right * Time.deltaTime * speed * _horizontal);
    }

    private void Jump()
    { 
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; 
        }
        if (collision.gameObject.CompareTag("GarbageCollector"))
        {
            isGameOver = true;
            Time.timeScale = 0;
            Debug.Log("Вы проиграли");
        }
    }
}
