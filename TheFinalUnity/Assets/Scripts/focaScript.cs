using UnityEngine;
using System.Collections;



public class focaScript : MonoBehaviour {
	public int salud = 100;
	public bool vida;
	private int maxsalud;
	public bool muerte;
	public GameObject Foca1;
	public float tiempoespera = 3;
	float timer = 0;
	public AudioClip deadSound;
	//private Text texto;

	// Use this for initialization
	void Start () {
		//texto = GameObject.Find ("text_vidas").GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		if (salud <= 0) {
			Destroy (gameObject);
		}
		if (Time.time > timer) {
			Destroy (Foca1, tiempoespera*3);
			timer = Time.time+tiempoespera;  //Para que desaparezcan las focas y no se acumulen
		}
	}
	
	void OnMouseDown(){
		salud = salud - 100;
		
	}
	void OnDestroy() {
		gameControl.gamecontrol.vidas = gameControl.gamecontrol.vidas -1 ;
		AudioSource.PlayClipAtPoint(deadSound, transform.position);
		//texto.text = gameControl.gamecontrol.vidas.ToString ();
	}
		}