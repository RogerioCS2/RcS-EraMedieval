using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ControleCamera : MonoBehaviour {
    public Transform alvo;
    //private ControlePersonagem personagem;
    public Tilemap tileMap;
	private Vector3 limiteInferior;
	private Vector3 limiteSuperior;
	private float limiteAltura;
	private float limiteLargura;
	//public int musicToPlay;
	//private bool musicStarted;

	// Use this for initialization
	void Start(){
        //personagem = FindObjectOfType(typeof(ControlePersonagem)) as ControlePersonagem;
        alvo = FindObjectOfType<ControlePersonagem>().transform;
		limiteAltura = Camera.main.orthographicSize;
		limiteLargura = limiteAltura * Camera.main.aspect;
		tileMap.CompressBounds();
		limiteInferior = tileMap.localBounds.min + new Vector3(limiteLargura, limiteAltura, 0f);
		limiteSuperior = tileMap.localBounds.max + new Vector3(-limiteLargura, -limiteAltura, 0f);
		ControlePersonagem.instance.SetBounds(tileMap.localBounds.min, tileMap.localBounds.max);
	}

	void LateUpdate(){        
       if (alvo == null){
            Debug.Log("Perdeu a referência");
       }else {
            transform.position = new Vector3(alvo.position.x, alvo.position.y, transform.position.z);
       }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, limiteInferior.x, limiteSuperior.x), Mathf.Clamp(transform.position.y, limiteInferior.y, limiteSuperior.y), transform.position.z);
		/*
		if (!musicStarted){
			musicStarted = true;
			AudioManager.instance.PlayBGM(musicToPlay);
		}
		*/
	}
}
