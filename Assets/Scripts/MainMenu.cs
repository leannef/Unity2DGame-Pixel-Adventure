using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
    	SceneManager.LoadScene(1);	
    }

    public void GoToSettingMenu() {
    	SceneManager.LoadScene("SettingMenu");

    }

    public void GoToMainMenu() {
    	SceneManager.LoadScene("MainMenu");
    

    }

    public void QuitGame() {

    	Debug.Log("Quit!!");
    	Application.Quit();
   	} 

}
