using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogeManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField]TextMeshProUGUI textoDelDialogo;
    [SerializeField] TextMeshProUGUI textoBoton;
    [SerializeField] bool hasTalked;

    [SerializeField] string[] frasesDialogo;
    [SerializeField] int posicionFrase;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
         NextFrase();
        }
          
    }

    void OnTriggerEnter(Collider other)
    {
        //al entrar activa la UI de diálogo
        if (other.gameObject.CompareTag("NPC"))
        {
            frasesDialogo = other.gameObject.GetComponent<NPCBehavior>().data.dialogueFrases;
            if (!hasTalked)
            {
                textoDelDialogo.text = "Me voy a comer tu cerebro!";
                dialogueUI.SetActive(true);
            }
            else
            {
                textoDelDialogo.text = "YA HABLAMOS!!";
                dialogueUI.SetActive(true);

            }
        }
        
        
    }

    void OnTriggerExit(Collider other)
    {
        //al salir desactiva la UI de diálogo
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogueUI.SetActive(false);
        }
        
    }

    public void NextFrase()
    {
        if (posicionFrase < frasesDialogo.Length)
        {
            textoDelDialogo.text = frasesDialogo[posicionFrase];
            posicionFrase++;
          
        }
        else
        {
            //dialogueUI.SetActive(false);
            hasTalked = true;
        }
        
    }
}
