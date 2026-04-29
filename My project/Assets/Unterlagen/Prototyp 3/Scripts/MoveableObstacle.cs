using UnityEngine;

/// <summary>
/// Bewegt ein Hindernis im Welt-Koordinatensystem nach links (-x)
/// </summary>
public class MoveableObstacle : MonoBehaviour
{
    // Bewegunsgeschwindigkeit Hindernis
    public float speed = 30;

    // Update is called once per frame
    void Update()
    {        
        // Verschiebung im WorldSpace
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }
}
