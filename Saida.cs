using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saida : MonoBehaviour{

	public string areaToLoad;
	public string areaTransitionName;
	public Entrada entrada;
	public float waitToLoad = 3f;
    private bool shouldLoadAfterFade;

	void Start () {
        //entrada.transitionName = areaTransitionName;
    }

	void Update () {
		
		if(shouldLoadAfterFade){
            waitToLoad -= Time.deltaTime;
            if(waitToLoad <= 0){
                shouldLoadAfterFade = false;
                SceneManager.LoadScene(areaToLoad);
            }
        }        
	}

    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player") {
            shouldLoadAfterFade = true;
            //GameManager.instance.fadingBetweenAreas = true;
            CarregarCena.instance.EscurecerTela();
            ControlePersonagem.instance.areaTransitionName = areaTransitionName;
        }
    }
}
