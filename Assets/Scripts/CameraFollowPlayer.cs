using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
	public Transform target;
	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	[SerializeField]
	float leftLimit;
	[SerializeField]
	float rightLimit;
	[SerializeField]
	float topLimit;
	[SerializeField]
	float botLimit;

    void Update(){
    	Vector3 desriredPos = target.position + offset;
    	Vector3 smoothPos = Vector3.Lerp(transform.position, desriredPos, smoothSpeed);
    	transform.position = smoothPos;
    	//transform.LookAt(target);
	   	transform.position = new Vector3 (
		 	Mathf.Clamp (transform.position.x, leftLimit, rightLimit), 
		 	Mathf.Clamp (transform.position.y, botLimit, topLimit), 
	 		transform.position.z
	 	);
    
    }
}
