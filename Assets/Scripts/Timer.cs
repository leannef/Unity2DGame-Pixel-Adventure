using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    
	public float seconds = 3;
	public Text countdownDisplay;
    public GameManager gameManager;
    public GameObject timeupText;
    public GameObject myPlayer;


    private void Start()
    {
        timeupText.SetActive(false);
        // Starts the timer automatically
        countdownDisplay.text = "TIME: " + seconds.ToString();
    }

    void Update(){
    	seconds -= Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();   
        }
        

        if (seconds > 0){
            countdownDisplay.text = "TIME: " + Mathf.Round(seconds).ToString();
            
        }else{

            timeupText.SetActive(true);
            myPlayer.SetActive(false);
            Debug.Log(" Time up");

            countdownDisplay.text = "TIME: 0";
            Invoke("ChangeScene", 3.0f);
        }
    }

    void ChangeScene(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
