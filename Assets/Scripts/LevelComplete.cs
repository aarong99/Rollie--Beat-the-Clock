using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public Text timeText;

    public float currentTime;

    void stopTimer(){

        timeText.text = currentTime.ToString("0.0");
        Debug.Log(timeText.text);

    }


    // Use this for initialization
    void LoadNextLevel(){
        //loads next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
