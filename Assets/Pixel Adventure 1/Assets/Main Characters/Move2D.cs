using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Move2D : MonoBehaviour
{
    public float walkSpeed = 5.0f;
    public float jumpScalar = 19;
    public bool faceRight = true;
	public float lowJump = 2f;
	public float falling = 2.5f;
	public LayerMask groundLayer;
	
    private bool isDead = false;


    Rigidbody2D rigid2D;
    Animator _animator;

    void Awake () {
        rigid2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
 
    }

    void Start(){
    	_animator.SetTrigger("isAppearing");

    }

	void Update () {

		if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()){

	    	Vector2 jumpForce = new Vector2(0, jumpScalar);
	    	rigid2D.AddForce(jumpForce, ForceMode2D.Impulse);     
		}
	}

    void FixedUpdate(){
    	float move = Input.GetAxis("Horizontal");
    	transform.position += new Vector3(move, 0 ,0) * Time.deltaTime * walkSpeed;
		
		if (move == 0){
			_animator.SetBool("isRunning", false);
			_animator.SetBool("isIdle", true);
		}else{
			_animator.SetBool("isRunning", true);
			_animator.SetBool("isIdle", false);
		}

    	//setAnimationState();

    	if (move < 0 && faceRight) Flip();
    	if (move > 0 && !faceRight) Flip();

    	if (rigid2D.velocity.y < 0 ){
    		rigid2D.velocity += Vector2.up * Physics2D.gravity.y * (falling - 1) * Time.deltaTime;
    	} else if (rigid2D.velocity.y > 0 && !Input.GetKeyDown(KeyCode.Space)){
    		rigid2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJump - 1) * Time.deltaTime;
    	}
    	//r2d.velocity.magnitude < 0.01f (Stick on Wall?)
    }

    void Flip(){
    	faceRight = !faceRight;
    	transform.Rotate(Vector3.up * 180);
    }

	bool IsGrounded() {
	    Vector2 position = transform.position;
	    Vector2 direction = Vector2.down;
	    float distance = 1.0f;
	    
	    RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
	    if (hit.collider != null) {
	        return true;
	    }
	    
	    return false;
	}



	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("fruits")){
			Destroy(other.gameObject);
		}
	}




}
