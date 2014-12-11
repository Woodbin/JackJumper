using UnityEngine;
using System.Collections;

public class kill_hand : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D something){
		if (something.tag == "Player") {
						animation["snatch"].wrapMode = WrapMode.Once;
						animation.Play("snatch");
						gameMaster.currentHealth -=1;
				}

	}
}
