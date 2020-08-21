using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneText : MonoBehaviour
{
	public Text sceneText;


    // Update is called once per frame
    void Update()
    {
        sceneText.text = "SCENE: " + SceneManager.GetActiveScene().buildIndex.ToString();
    }
}
