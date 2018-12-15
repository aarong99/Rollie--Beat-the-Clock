using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    public PlayerMovement movement;


    private void OnTriggerEnter()
    {
        //run complete level when player enters end trigger
        gameManager.CompleteLevel();

    }

}
