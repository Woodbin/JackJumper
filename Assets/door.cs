using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	Animator anim;
	public string nextLevel;
	void Start () {
		anim = GetComponent<Animator> ();	 	
	}

	void Update () {
				if (gameMaster.currentScore >= 100) {
						anim.SetBool ("open", true);

				}
		}
	void OnTriggerEnter2D(Collider2D something){
		
		if(anim.GetBool ("open")){	
			if(something.tag == "Player"){
				Application.LoadLevel(nextLevel);
			}
		}
	}
	
}