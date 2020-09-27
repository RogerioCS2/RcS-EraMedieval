using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleMissoes : MonoBehaviour{

    public string[] marcadorMissoesPendentes;
    public bool[] marcadorMissoesCompletas;
    public static ControleMissoes controleMissoes;
    
    void Start(){
        controleMissoes = this; //Instanciado a propria classe nela mesma;
        marcadorMissoesCompletas = new bool[marcadorMissoesPendentes.Length];
    }

    // Update is called once per frame
    void Update(){
        //SOMENTE UTILIZADO PARA TESTAR AS FUÇÕES DA MISSÃO
        if (Input.GetKeyDown(KeyCode.M)) {
            Debug.Log("A Missão Está Completa " + MissaoEstaCompleta("Missao de Teste"));
        }        
    }

    public int BuscaNumeroMissao(string missao){
        for (int i = 0; i < marcadorMissoesPendentes.Length; i++) {
            if (marcadorMissoesPendentes[i] == missao) {
                return i;
            }
        }
        Debug.LogError("A missão " + missao + " Não Existe");
        return 0;
    }
     
    public bool MissaoEstaCompleta(string missao) {
        int numeroMissao = BuscaNumeroMissao(missao);
        if (numeroMissao != 0) {
            return marcadorMissoesCompletas[numeroMissao];
        }
        return false;
    }

    public void MarcarMissaoCompleta(string missao) {
       int numeroMissao = BuscaNumeroMissao(missao);
       marcadorMissoesCompletas[numeroMissao] = true; 
    }

    public void MissaoNaoCompleta(string missao){
        int numeroMissao = BuscaNumeroMissao(missao);
        marcadorMissoesCompletas[numeroMissao] = false;
    }
}
