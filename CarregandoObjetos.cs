using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregandoObjetos : MonoBehaviour{
    public GameObject canvas;
    public GameObject eduard;
    public GameObject rosaly;
    public GameObject robert;
    public GameObject gameManager;
    private float esperar = 10f;

    void Start(){
        if (GameManager.instance == null) {
            Instantiate(gameManager);
        }

        if (CarregarCena.instance == null){
            CarregarCena.instance = Instantiate(canvas).GetComponent<CarregarCena>();
        }       

        CarregandoPersonagens();
    }

    void Update(){
        
    }    

    public void CarregandoPersonagens(){
        if (ControlePersonagem.instance == null){
            ControlePersonagem clone = Instantiate(eduard).GetComponent<ControlePersonagem>();
            ControlePersonagem.instance = clone;
        }
        
        if (MovimentoPrincesa.instance == null){
            MovimentoPrincesa clone = Instantiate(rosaly).GetComponent<MovimentoPrincesa>();
            MovimentoPrincesa.instance = clone;
        }

        if (MovimentoMago.instance == null){
            MovimentoMago clone = Instantiate(robert).GetComponent<MovimentoMago>();
            MovimentoMago.instance = clone;
        }        
    }
}
