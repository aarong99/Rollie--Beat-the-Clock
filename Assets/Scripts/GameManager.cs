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

        if (gameHasEnded == false)

        {

            gameHasEnded = true;

            Debug.Log("Game Over");

            Invoke("Restart", restartDelay);
        }
    }

    void Restart (){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
