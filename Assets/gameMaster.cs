using UnityEngine;
using System.Collections;

public class gameMaster : MonoBehaviour {
	public static int currentScore = 0;
	int sizeX= 100;
	int sizeY= 25;
	int positionY=0;
	void OnGUI () {
		//Debug.Log (currentScore);  -->test
		GUI.Box (new Rect((Screen.width/2)-sizeX/2,positionY,sizeX,sizeY), "Score: "+currentScore);

	}

}
