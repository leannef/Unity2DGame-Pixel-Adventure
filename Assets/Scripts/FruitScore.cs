using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitScore : MonoBehaviour
{
	public static FruitScore instance;
	public Text text;
	int score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null ) instance = this;
    }

    // Update is called once per frame
    public void ChangeScore(int fruitValue)
    {
        score += fruitValue;
        text.text = "FRUIT: X" + score.ToString();
    }
}
