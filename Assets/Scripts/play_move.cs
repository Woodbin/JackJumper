using UnityEngine;
using System.Collections;

public class play_move : MonoBehaviour {

	public float maxSpeed = 100f;				// vytvorime maximalni rychlost jakou nase postavicka muze mit
	bool facingRight = true;					// hodnota pro zjistovani jestli kouka postavicka do prava

	Animator anim;								// budem pouzivat hodnotu anim pro praci s animatorem


	void Start () {
		anim = GetComponent<Animator> ();	 	// priradime anim promene "náš" Animator
	}

	void FixedUpdate () {

		float movex = Input.GetAxis ("Horizontal");											// zjisti jestli hrac uziva klavesy/tlacitka pro horizontalni pohyb
																							// a zjisteny pohyb uloz do promene movex (+ je pohyb vpravo - vlevo)
		rigidbody2D.velocity = new Vector2 (movex * maxSpeed,  rigidbody2D.velocity.y);		// s vyuzitim komponenty rigidbody2d pohni s postavickou dle stisknute
																							// klavesy (pohyb po ose X) ... pohyb po ose Y je ovlivnen akorat gravitaci
		anim.SetFloat ("Speed", Mathf.Abs (movex));											// v animatoru nastavime promenou Speed na aktualni rychlost
																							// v animatoru pak dle rychlosti prechazime z behu do idle stavu

				
		if (movex > 0 && !facingRight)														// jdes doprava a nekoukas doprava ? 
						Flip ();															// zavolej proceduru Flip() ktera te otoci
				else if (movex < 0 && facingRight)											// jdes doleva a koukas doprava ? 
						Flip ();															// zavolej proceduru Flip() ktera te otoci
		}
	

		         void Flip(){
			facingRight = !facingRight;														// pokud koukas doprava nastav hodnotu na nekoukas doprava a opacne
			Vector3 theScale = transform.localScale;										// do promene theScale uloz meritko nasi postavicky 
			theScale.x *= -1;																// Xovou hodnotu meritka vynásob -1 -> trik kterým postavicku otocite
			transform.localScale = theScale;												// stare meritko nahradime novym (theScale)

		
		} 

}
