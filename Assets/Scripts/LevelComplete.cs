using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    // Use this for initialization
    void LoadNextLevel(){
        //loads next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
