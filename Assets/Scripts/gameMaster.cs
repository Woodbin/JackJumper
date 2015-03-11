using UnityEngine;
using System.Collections;

public class gameMaster : MonoBehaviour {
	public static int currentScore = 0;
	public static int currentHealth = 2;
	int sizeX= 100;
	int sizeY= 25;
	public int positionY=5;
	void OnGUI () {
		GUI.Box (new Rect((Screen.width/2)-sizeX/2,positionY,sizeX,sizeY), "Score: "+currentScore);
		GUI.Box (new Rect (0, 0, sizeX, sizeY), "životy: "+ currentHealth);
	}



	void Start(){
		currentScore = 0;
	}

	void Update(){
		if (currentHealth <= 0) {
			Application.LoadLevel("gameover");			
		}
	}
}
