using UnityEngine;

/// <summary>
/// Controller für Enless-Runner mit Sprung-Mechanik
/// </summary>
public class JumpCharacterController : MonoBehaviour
{
    // Sprungstärke
    public float jumpStrength = 10;

    // Multiplikator um die Graviation zu erhöhen
    public float gravityModifier = 2;

    // Audio-Clip für Sprung
    public AudioClip jumpSound;

    // Audio-Clip für Zusammenstoß
    public AudioClip crashSound;

    // Referenz zur Rigidbody-Komponente
    private Rigidbody playerRb;

    // Befindet sich der Spieler auf dem Boden?
    private bool isGrounded = true;
    private bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        // Rigibody-, Animator- und AudioSourc-Komponente auf GameObject suchen 
        // und in Variablen speichern
        playerRb = GetComponent<Rigidbody>();

        // Graviation um einen Faktor zu erhöhen
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // Soll gesprungen werden?
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            // Impulse für Sprung
            playerRb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // Collision mit dem Boden oder einem Hindernis?
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;

        }
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }
}
