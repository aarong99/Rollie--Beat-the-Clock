using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LComplete : MonoBehaviour

{
    //score members
    public Text timeText;

    public float currentTime;

    public float restartDelay = 1f;

    public bool gameHasEnded;

    //end trigger members
    public GameManager gameManager;

    public PlayerMovement movement;

    public void OnTriggerEnter()
    {

        if (currentTime <= 7.0)
        {
            //run ad
            Debug.Log("Run ad");
            gameManager.CompleteLevel();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Debug.Log("Don't run ad")
            gameManager.CompleteLevel();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Start()

    {
        //declares timer start
        currentTime = 10f;

    }
    // Update is called once per frame
    void Update()

    {
        //decrements timer count by 1 every second
        currentTime -= 1 * Time.deltaTime;

        timeText.text = currentTime.ToString("0.0");
        //prints time up if time runs out
        if (currentTime < 0f) {

            timeText.text = "TIME UP";
            //restarts the scene and player
            Invoke("Restart", restartDelay);

        }
    }

    void Restart()
    {
        //restart function to reset the scene and player
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
