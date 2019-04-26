using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour

{
    public Text timeText;

    public float currentTime;

    public float restartDelay = 1f;

    public bool gameHasEnded;



    public GameManager gameManager;

    public PlayerMovement movement;

    public int sceneSave;

    private void OnTriggerEnter()

    {
        //sceneSave = SceneManagement.GetActiveScene().buildIndex;
        //run complete level when player enters end trigger
        gameManager.CompleteLevel();



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
        if (currentTime < 0f){

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