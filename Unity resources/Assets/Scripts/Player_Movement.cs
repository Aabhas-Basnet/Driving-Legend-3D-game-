using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float forwardForce = 10000f;
    public float sidewaysForce = 10000f;
    public Rigidbody rb;

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(- sidewaysForce * Time.deltaTime, 0, 0);
        }


        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, - forwardForce * Time.deltaTime);
        }

        if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        
        }

        if (Input.GetKey("r"))
        {
            FindObjectOfType<GameManager>().EndGame(); 
        }

    }
}
