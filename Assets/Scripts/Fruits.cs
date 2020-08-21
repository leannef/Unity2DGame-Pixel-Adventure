using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{

	
	public int fruitValue = 1;
	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")){
			GameManager.instance.ChangeScore(fruitValue);
		}
	}
}
