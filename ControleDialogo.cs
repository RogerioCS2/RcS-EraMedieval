using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDialogo : MonoBehaviour{
    public Text textoDialogo;
    public Text textoNome;
    public GameObject caixaDialogo;
    public GameObject caixaNome;
    public string[] linhasDialogo;
    public int linhaDialogoAtual;
    private bool dialogoIniciadoAgora;
    public static ControleDialogo instance;   
    
    void Start(){       
        instance = this;
    }
       
    void Update(){
        if (caixaDialogo.activeInHierarchy){
            GameManager.instance.dialogoEstaAtivo = true;
            if (Input.GetButtonUp("Fire1")){               
                if (!dialogoIniciadoAgora){
                    linhaDialogoAtual++;                    
                    if (linhaDialogoAtual >= linhasDialogo.Length){
                        caixaDialogo.SetActive(false);
                        GameManager.instance.dialogoEstaAtivo = false;
                        //AtivandoRosaly();
                    } else{
                        VerificaNome();
                        textoDialogo.text = linhasDialogo[linhaDialogoAtual];                        
                    }
                }else {
                    dialogoIniciadoAgora = false;                   
                }                   
            }
        }           
    }    
    
    public void AtivadorDialogo(string[] novaLinha, bool umaPessoa) {
        linhasDialogo = novaLinha;        
        linhaDialogoAtual = 0;
        VerificaNome();
        textoDialogo.text = linhasDialogo[linhaDialogoAtual];
        caixaDialogo.SetActive(true);
        dialogoIniciadoAgora = true;
        caixaNome.SetActive(umaPessoa);
        ControlePersonagem.instance.podeAndar = false;
        Debug.Log("Para Seu demonho");
    }
    
    
    public void VerificaNome(){
        if (linhasDialogo[linhaDialogoAtual].StartsWith("n-")){
            textoNome.text = linhasDialogo[linhaDialogoAtual].Replace("n-", "");
            linhaDialogoAtual++;
        }
    }
    /*
    public void AtivandoRosaly() {
        MovimentoPrincesa.instance.AtivandoImagemRosaly();
        GameManager.instance.ativandoMenuRosaly();
    }
    */
    /*
    public void ShouldActivateQuestEnd(string questName, bool markComplete){
        questToMark = questName;
        markQuestComplete = markComplete;
        shouldMarkQuest = true;
    }
    */
}
