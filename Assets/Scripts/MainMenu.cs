using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public float mySlider = 1;

    public void PlayGame (){
        //loads next scene (first scene) after play button click
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }
    public void QuitGame () {
        //quits game
        Application.Quit();


    }
    public void OnValueChanged (){
    	AudioListener.volume = mySlider;
    }
}
