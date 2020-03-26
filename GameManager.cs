using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public static GameManager instance;
    public StatusPersonagens[] playerStats;
    public bool menuEstaAberto, dialogoEstaAtivo, telaEstaEscura/*, shopActive, battleActive*/;
    public string[] itensAdquiridos;
    public int[] numeroItens;
    public Item[] referenciaItens;
      
    void Start(){
        instance = this;
        DontDestroyOnLoad(gameObject);        
    }

    void Update(){
        if (menuEstaAberto || dialogoEstaAtivo || telaEstaEscura)
        {
            ControlePersonagem.instance.podeAndar = false;
        }  else {
            ControlePersonagem.instance.podeAndar = true;
        }
    }

    public void ativandoMenuRosaly() {
        for (int i = 0; i < playerStats.Length; i++) {
            playerStats[1].gameObject.SetActive(true);
        }
    }
    public void AtivandoMenuRobert() {
        for (int i = 0; i < playerStats.Length; i++)        {
            playerStats[2].gameObject.SetActive(true);
        }
    }    
}
