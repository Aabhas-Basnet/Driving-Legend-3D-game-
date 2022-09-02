using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    public Player_Movement movement;

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Collider")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<AudioManager>().Play("Collider");
        }
    }
}
