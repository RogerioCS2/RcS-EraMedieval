using UnityEngine;

public class Entrada : MonoBehaviour{
    public string transitionName;
    private CarregarCena carregarCena;

    void Start()    {
        carregarCena = FindObjectOfType(typeof(CarregarCena)) as CarregarCena;              
        if (transitionName == ControlePersonagem.instance.areaTransitionName){
            ControlePersonagem.instance.transform.position = transform.position;
            MovimentoMago.instance.transform.position = transform.position;
            MovimentoPrincesa.instance.transform.position = transform.position;
        }
        carregarCena.ClarearTela();
        CarregarCena.instance.ClarearTela();  
        //GameManager.instance.fadingBetweenAreas = false;
    }

    void Update(){
        
    }   
}
