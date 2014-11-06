using UnityEngine;
using System.Collections;

public class play_move : MonoBehaviour {

	public float maxSpeed = 100f;
	bool facingRight = true;

	//Animator anim;

	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
				float movex = Input.GetAxis ("Horizontal");
				float movey = Input.GetAxis ("Vertical");
				rigidbody2D.velocity = new Vector2 (movex * maxSpeed, movey * maxSpeed);

		//anim.SetFloat ("Speed", Mathf.Abs (movex));

				
		if (movex > 0 && !facingRight)
						Flip ();
				else if (movex < 0 && facingRight)
						Flip ();
		}
	

		         void Flip(){
			facingRight = !facingRight;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;

		
		} 

}
