using UnityEngine;
using System.Collections;

public class kill_hand : MonoBehaviour {


	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();	 	
	}

	void OnTriggerEnter2D(Collider2D something){
		if (something.tag == "Player") {

				anim.SetTrigger("snatching");
				gameMaster.currentHealth -=1;
				}

	}
}
