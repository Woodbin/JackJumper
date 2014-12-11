using UnityEngine;
using System.Collections;

public class kill_border : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D something){
		if (something.tag == "Player") {
			gameMaster.currentHealth -=1;
		}
		
	}
}
