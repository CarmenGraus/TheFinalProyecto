using UnityEngine;
using System.Collections;

public class vida_script : MonoBehaviour {
	int vidas = 3;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void OnDestroy() {
		gameControl.gamecontrol.vidas = gameControl.gamecontrol.vidas -1 ;
		
	}
}
