using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarregandoObjetos : MonoBehaviour{
    public GameObject canvas;
    public GameObject eduard;
    public GameObject rosaly;
    public GameObject robert;
    //public GameObject gameMan;
    //public GameObject audioMan;
    //public GameObject battleMan;    

    void Start(){
        if (CarregarCena.instance == null){
            CarregarCena.instance = Instantiate(canvas).GetComponent<CarregarCena>();
        }

        CarregandoPersonagens();

        /*
        if (GameManager.instance == null){
            GameManager.instance = Instantiate(gameMan).GetComponent<GameManager>();
        }

        if (AudioManager.instance == null){
            AudioManager.instance = Instantiate(audioMan).GetComponent<AudioManager>();
        }

        if (BattleManager.instance == null){
            BattleManager.instance = Instantiate(battleMan).GetComponent<BattleManager>();
        }
        */
    }

    void Update()
    {
        
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
