using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
 // Use this for initialization

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        //if player hits an obstacle
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //disables player movement
            movement.enabled = false;

            //resets scene and player
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
