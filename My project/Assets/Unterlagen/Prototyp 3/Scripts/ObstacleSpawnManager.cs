using UnityEditor.Build;
using UnityEngine;

public class ObstacleSpawnManager : MonoBehaviour
{
    // Prefab vom Hindernis
    public GameObject obstaclePrefab;

    // Position an der die Hindernisse erzeugt werden
    public Vector3 spawnPosition;

    // Zeit zwischen den Spawnvorgängen
    public float spawnInterval;
    private JumpCharacterController playerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnInterval, spawnInterval);
        playerScript = GameObject.Find("Player").GetComponent<JumpCharacterController>();
    }
    void Update()
    {
        if (playerScript.IsGameOver()) { CancelInvoke("SpawnObstacle"); }
    }
    /// <summary>
    /// Neues Hindernis im Level erzeugens
    /// </summary>
    void SpawnObstacle() 
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);       
    }
}
