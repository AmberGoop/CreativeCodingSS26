using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody enemyRB;
    public float speed = 50;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemyRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = player.transform.position - transform.position;
        enemyRB.AddForce(lookDirection.normalized * speed * Time.deltaTime);
    }
}
