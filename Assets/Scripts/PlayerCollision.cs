using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; 
    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {

            FindObjectOfType<AudioManager>().Play("collision_sound");
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver("collision");
        }
    }
}
