using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarregarCena : MonoBehaviour{

    public static CarregarCena instance;
    public Image imagemEscura;
    public float tempoCarregando;
    public bool telaEscura;
    public bool telaClara;
    public GameObject carregaPagina;
   
    void Start(){
        instance = this;
        DontDestroyOnLoad(gameObject);
    }       

    void Update(){
        
        if (telaEscura){
            carregaPagina.SetActive(true);
            imagemEscura.color = new Color(imagemEscura.color.r, imagemEscura.color.g, imagemEscura.color.b, 
                                   Mathf.MoveTowards(imagemEscura.color.a, 1f, tempoCarregando * Time.deltaTime));            
            if (imagemEscura.color.a == 1f){
                telaEscura = false;
            }            
        }        
        
        if (telaClara){
            carregaPagina.SetActive(false);
            imagemEscura.color = new Color(imagemEscura.color.r, imagemEscura.color.g, imagemEscura.color.b, 
                                   Mathf.MoveTowards(imagemEscura.color.a, 0f, tempoCarregando * Time.deltaTime));            
            if (imagemEscura.color.a == 0f){
                telaClara = false;
            }            
        }        
    }
    
    public void EscurecerTela(){
        telaEscura = true;
        telaClara = false;
    }

    public void ClarearTela(){
        telaEscura = false;
        telaClara = true;
    }    
}
