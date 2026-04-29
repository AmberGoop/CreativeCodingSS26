using UnityEngine;

/// <summary>
/// Bewegt ein Hindernis im Welt-Koordinatensystem nach links (-x)
/// </summary>
public class MoveableObstacle : MonoBehaviour
{
    // Bewegunsgeschwindigkeit Hindernis
    public float speed = 30;
    private JumpCharacterController playerScript;

    void Start()
    {

        playerScript = GameObject.Find("Player").GetComponent<JumpCharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        // Verschiebung im WorldSpace

        if (playerScript.IsGameOver()) { return; }
        if (transform.position.x < -20) { Destroy(gameObject); }
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }
}
