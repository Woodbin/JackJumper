using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public Transform respawnPoint;
	int health;


	void Start () {
		health = gameMaster.currentHealth;
	}

	void Update () {
		if (health < gameMaster.currentHealth) {
						health = gameMaster.currentHealth;
				}
		if (health > gameMaster.currentHealth) {
			transform.position = respawnPoint.position;
			health = gameMaster.currentHealth;
				}

	}
}
