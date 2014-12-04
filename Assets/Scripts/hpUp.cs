using UnityEngine;
using System.Collections;

public class hpUp : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D something){
		if (gameMaster.currentHealth < 3) {
						if (something.tag == "Player") {
			
								//Debug.Log ("mince sebrana!");			//-->TEST!
								gameMaster.currentHealth += 1;
								Destroy (gameObject);
						}
				}
	}
}
