using UnityEngine;
using UnityEngine.Events;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public float enemySpeed = 2f;
    public UnityEvent onHitPlayer;
    public UnityEvent onDeath;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        transform.Translate(enemySpeed * Time.deltaTime * Vector3.forward);
    }
}
