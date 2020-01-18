using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivandoDialogo : MonoBehaviour
{
    public string[] linhas;
    private bool dialogoAtivo;
    public bool umaPessoa = true;    

    void Start(){

    }

    void Update(){
        if (dialogoAtivo && Input.GetButtonDown("Fire1") && !ControleDialogo.instance.caixaDialogo.activeInHierarchy)
        {
            ControleDialogo.instance.AtivadorDialogo(linhas, umaPessoa);            
        }
    }

    private void OnTriggerEnter2D(Collider2D objColisao){
        if (objColisao.tag == "Player"){
            dialogoAtivo = true;
        }
    }

    private void OnTriggerExit2D(Collider2D objColisao){
        if (objColisao.tag == "Player"){
            dialogoAtivo = false;
        }
    }
}
