﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPrincesa : MonoBehaviour {
	public float velocidade = 4.5f;	 
	public Rigidbody2D rb;
	public static MovimentoPrincesa instance;
    private ControlePersonagem personagem;
    public GameObject imagemTela;

    void Start (){
        personagem = FindObjectOfType(typeof(ControlePersonagem)) as ControlePersonagem;
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
        Vector2 local = personagem.transform.position;
		transform.position = Vector2.MoveTowards(transform.position, local, velocidade * Time.deltaTime);
		float distancia = Vector2.Distance(transform.position, local);

		if(distancia <= 1.5){           
			velocidade = 0;           
		}else{
			velocidade = 4.5f;
		}
	}

    public void AtivandoImagemRosaly(){
        imagemTela.SetActive(true);
    }
}
