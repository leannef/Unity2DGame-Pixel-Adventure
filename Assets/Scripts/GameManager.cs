using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	public Text text;
	int score;
    public float resatrtDelay = 1f;
    bool gameHasEnded = false;
    Animator _animator;


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null ) instance = this;
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void ChangeScore(int fruitValue)
    {
        score += fruitValue;
        text.text = "FRUIT: X" + score.ToString();
    }

    public void completeLevel(){

        Debug.Log("Level Complete !!");  
    }

    public void EndGame(){

        if (gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over !");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    //private void OnTriggerEnter2D(Collider2D other) {
        //if (other.gameObject.CompareTag("Enermy")){
            //Destroy(gameObject);
        //}
    //}

    void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
