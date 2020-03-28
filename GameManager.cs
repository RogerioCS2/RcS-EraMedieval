using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public StatusPersonagens[] playerStats;
    public bool menuEstaAberto, dialogoEstaAtivo, telaEstaEscura;
    public string[] itensAdquiridos;
    public int[] quantidadeItens;
    public Item[] referenciaItens;

    void Start() {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Update() {
        if (menuEstaAberto || dialogoEstaAtivo || telaEstaEscura)
        {
            ControlePersonagem.instance.podeAndar = false;
        } else {
            ControlePersonagem.instance.podeAndar = true;
        }        
        /*
        //TESTANDO METODO REMOVER E ADICIONAR
        
        if (Input.GetKeyDown(KeyCode.J)){
            AdicionaItemInventario("Oi Sogra");           
        }
        if (Input.GetKeyDown(KeyCode.R)){
            RemoveItemInventario("Oi Sogra");            
        }
        */
        
    }

    public void ativandoMenuRosaly() {
        for (int i = 0; i < playerStats.Length; i++) {
            playerStats[1].gameObject.SetActive(true);
        }
    }

    public void AtivandoMenuRobert() {
        for (int i = 0; i < playerStats.Length; i++) {
            playerStats[2].gameObject.SetActive(true);
        }
    }

    public Item CarregandoItens (string itens){
        for (int i = 0; i< itensAdquiridos.Length; i++) {
            if (referenciaItens[i].itemName == itens) {
                return referenciaItens[i];
            }            
        }
        return null;
    }

    public void OrganizarItens() {
        bool irProximoEspaco = true;
        while (irProximoEspaco) {
            irProximoEspaco = false;
            for (int i = 0; i < itensAdquiridos.Length - 1; i++) {
                if (itensAdquiridos[i] == "") {
                    itensAdquiridos[i] = itensAdquiridos[i + 1];
                    itensAdquiridos[i + 1] = "";
                    quantidadeItens[i] = quantidadeItens[i + 1];
                    quantidadeItens[i + 1] = 0;
                    if (itensAdquiridos[i] != "") {
                        irProximoEspaco = true;
                    }
                }
            }
        }
    }
    
    public void AdicionaItemInventario(string itemAdicionado) {
        int novaPosicaoItem = 0;
        bool estaVazio = false;
        for (int i = 0; i < itensAdquiridos.Length; i++) {
            if (itensAdquiridos[i] == "" || itensAdquiridos[i] == itemAdicionado) {
                novaPosicaoItem = i;
                i = itensAdquiridos.Length;
                estaVazio = true;
            }
        }
        if (estaVazio) {
            bool existeItem = false;
            for (int i = 0; i < referenciaItens.Length; i++) {
                if (referenciaItens[i].itemName == itemAdicionado) {
                    existeItem = true;
                    i = referenciaItens.Length;
                }
            }
            if (existeItem){
                itensAdquiridos[novaPosicaoItem] = itemAdicionado;
                quantidadeItens[novaPosicaoItem]++;
            }else {
                Debug.LogError(itemAdicionado + " O Item Adicionado Não Existe!");
            }
        }
        MenuJogo.instance.ExibirItens();    
    }
    
    public void RemoveItemInventario(string itemRemovido){
        int posicaoItem = 0;
        bool estaVazio = false;

        for (int i = 0; i < itensAdquiridos.Length; i++){
            if (itensAdquiridos[i] == itemRemovido){   
                estaVazio = true;
                posicaoItem = i;
                i = itensAdquiridos.Length;
            }
        }
        if (estaVazio){
            quantidadeItens[posicaoItem]--;
            if (quantidadeItens[posicaoItem] <= 0) {
                itensAdquiridos[posicaoItem] = "";
            }
            MenuJogo.instance.ExibirItens();
        } else {
            Debug.LogError(itemRemovido + " Item Não Encontrado");
        }
    }
}
