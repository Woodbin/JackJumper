using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

	bool grounded = false;						// vytvoření proměné pro zjištování jestli jsme na zemi
	public Transform groundCheck;				// budem pracovat s nějakym objektem groundCheck který je naší postavičce přiřazen v unity
	float groundRadius = 0.2f;					// budem zjičtovat jestli kolem naši postavičky v okruhu 0.2 
	public LayerMask ground;					// co je země ?
	public float jumpForce = 900f;				// vytvorime promenou urcujici silu skoku

	Animator anim;								// budem pouzivat hodnotu anim pro praci s animatorem

	void Start () {
		anim = GetComponent<Animator> ();	 	// priradime anim promene "náš" Animator
	}
	
	void Update(){
		if (grounded && (Input.GetKeyDown (KeyCode.Space))) {									// pokud jsme na zemi a zmáčkneme mezerník
			anim.SetBool("Ground",false);													// v animatoru se Ground nastavi na false
			rigidbody2D.AddForce(new Vector2(0,jumpForce));									// "nakopni postavu"(skoč) směrem  nahoru (y+) dle jumpForce
		}
		
	}

	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, ground);  	// promítneme pod nohy postavičky pomyslný kruh který zjištuje
																							// jestli stojíme na "zemi" pokud ano nastavíme grounded na true
		anim.SetBool ("Ground", grounded);													// v animátoru nastavíme proměnou Ground na aktuální hodnotu grounded

	
	}
}
