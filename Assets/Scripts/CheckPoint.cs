using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckPoint : MonoBehaviour
{
 	Animator _animator;
	public GameManager gameManager;

	void Start()
    {
    	_animator = GetComponent<Animator>();
    }

	// Start is called before the first frame update
	private void OnTriggerEnter2D(Collider2D other) {
		gameManager.completeLevel();

       	if (other.gameObject.CompareTag("Player")){
       		_animator.SetTrigger("isComplete");
       		//add some conditions....
       		//SceneManager.LoadScene(2);
       	}
	}

}
