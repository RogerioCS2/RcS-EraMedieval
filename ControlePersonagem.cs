using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{

	public Rigidbody2D rb;
	public float velocidade;
	//public Animator myAnim;
	public static ControlePersonagem instance;
	public string areaTransitionName;
	private Vector3 limiteInferior;
	private Vector3 limiteSuperior;

	public bool canMove = true;

	// Use this for initialization
	void Start(){
		
		if (instance == null){
			instance = this;
		}else{
			if (instance != this){
				Destroy(gameObject);
			}
		}
		DontDestroyOnLoad(gameObject);
	}

	// Update is called once per frame
	void Update(){
		//if (canMove){
			rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * velocidade;
		//}else{
		//	theRB.velocity = Vector2.zero;
		//}
		//myAnim.SetFloat("moveX", theRB.velocity.x);
		//myAnim.SetFloat("moveY", theRB.velocity.y);
		/*
		if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1){
			if (canMove){
				myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
				myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
			}
		}
        */
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, limiteInferior.x, limiteSuperior.x), Mathf.Clamp(transform.position.y, limiteInferior.y, limiteSuperior.y), transform.position.z);		
	}
	
	public void SetBounds(Vector3 baixo, Vector3 cima){
		limiteInferior = baixo + new Vector3(1f, .5f, 0f);
		limiteSuperior = cima + new Vector3(-1f, -1.5f, 0f);
	}
	
}
