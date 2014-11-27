using UnityEngine;
using System.Collections;

public class pickUp : MonoBehaviour {
	int valueOfCoin = 5;
	void OnTriggerEnter2D(Collider2D something){
		if (something.tag == "Player") {

						//Debug.Log ("mince sebrana!");			//-->TEST!
						gameMaster.currentScore += 1*valueOfCoin;
						Destroy (gameObject);
				}
	}

}