using UnityEngine;
using System.Collections;

public class gameMaster : MonoBehaviour {
	public static int currentScore = 0;
	int sizeX= 100;
	int sizeY= 25;
	public int positionY=5;
	void OnGUI () {
		GUI.Box (new Rect((Screen.width/2)-sizeX/2,positionY,sizeX,sizeY), "Score: "+currentScore);

	}

}
