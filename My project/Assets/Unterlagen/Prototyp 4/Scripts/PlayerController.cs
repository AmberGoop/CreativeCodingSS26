using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 10;
    private Rigidbody playerRB;
    private GameObject focalPoint;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float vInput = Input.GetAxis("Vertical");
        playerRB.AddForce(focalPoint.transform.forward * speed * Time.deltaTime * vInput);
    }
}
