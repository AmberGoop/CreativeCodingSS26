using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float detectionRange;
    public float dodgeSpeed;

    private Rigidbody enemyRb;
    private GameObject player;
    private bool awake = false;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToPlayer = player.transform.position - transform.position;
        if(directionToPlayer.magnitude<detectionRange&&!awake) { awake = true; enemyRb.AddForce(directionToPlayer.normalized * speed * Time.deltaTime * dodgeSpeed); }
        if (awake)
        {
            enemyRb.AddForce(directionToPlayer.normalized * speed * Time.deltaTime);
        }
        
    }

}
