using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoMago : MonoBehaviour {
	public float velocidade;
	public Transform eduard;
	public Rigidbody2D rb;
	public static MovimentoMago instance;
	public string areaTransitionName;

	void Start (){
		if (instance == null){
			instance = this;
		}else{
			if (instance != this){
				Destroy(gameObject);
			}
		}
		DontDestroyOnLoad(gameObject);
	}	

	void Update () {
		CaminhaComEduard();
	}

	public void CaminhaComEduard(){
		transform.position = Vector2.MoveTowards(transform.position, eduard.position, velocidade * Time.deltaTime);
		float distancia = Vector2.Distance(transform.position, eduard.position);

		if(distancia <= 3){
			velocidade = 0;
		}else{
			velocidade = 5;
		}
	}
}
