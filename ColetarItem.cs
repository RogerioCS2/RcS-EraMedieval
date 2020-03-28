using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarItem : MonoBehaviour
{
    private bool pegarItem;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        if (pegarItem && Input.GetButtonDown("Fire1") && ControlePersonagem.instance.podeAndar){
            GameManager.instance.AdicionaItemInventario(GetComponent<Item>().itemName);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D calisao){
        if (calisao.tag == "Player"){
            pegarItem = true;
        }
    }

    private void OnTriggerExit2D(Collider2D calisao){
        if (calisao.tag == "Player"){
            pegarItem = false;
        }
    }
}
