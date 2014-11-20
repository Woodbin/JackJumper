using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

	public Transform target;					//vytvorime cil pro kameru
	public float distance = 3.0f;				//kolik muzeme ujit aniz by se kamera pohla
	public float height =3.0f;					//vyska kterou muzeme ujit aniz by se kamera pohla
	public float damping = 5.0f;				//spozděni pro pohyb kamery

	
	// Update is called once per frame
	void Update () {
		Vector3 wantedPosition = target.TransformPoint (0, height, -distance);							//ziskani pozice kterou chceme
																										//z pozice cíle(hráče)
		transform.position = Vector3.Lerp (transform.position,wantedPosition,Time.deltaTime*damping);	//nastaveni pozice kterou chci (hráče)
																										
	}
}
