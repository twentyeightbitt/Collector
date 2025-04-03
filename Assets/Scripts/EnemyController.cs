using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform _player;
    private Vector3 _direction;
    public float speed = 6f;
    public float attackRange = 3f;
    private float _distanceToPlayer;


    void Start()
    {
        _player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        _distanceToPlayer = Vector3.Distance(transform.position, _player.position);
        if (_distanceToPlayer <= attackRange)
        {
            _direction = (_player.position - transform.position).normalized;

            transform.Translate(_direction * Time.deltaTime * speed);
        }
    }
}
