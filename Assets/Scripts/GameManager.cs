using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public PlayerMovement movement;

    public void CompleteLevel()

    {
        //enables the level complete screen
        completeLevelUI.SetActive(true);

    }

    public void EndGame () {
        //before game is over,
        if (gameHasEnded == false)

        {
            //after game over trigger,
            gameHasEnded = true;
            //calls restart function
            Invoke("Restart", restartDelay);
        }
    }

    void Restart (){
        //loads current scene again
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
