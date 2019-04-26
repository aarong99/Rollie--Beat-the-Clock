using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    public PlayerMovement movement;

    public int sceneSave;

    private void OnTriggerEnter()
    {
    	sceneSave = SceneManagement.GetActiveScene().buildIndex;
        //run complete level when player enters end trigger
        gameManager.CompleteLevel();

    }

}
           
