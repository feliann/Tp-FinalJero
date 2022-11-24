using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    // Acá cree las variables de tiempo

    public Text txt_timeFloored;
    float currentTime;
    void Update()
    {
        // Acá el current time empieza al ampezar la escena

        currentTime = Time.timeSinceLevelLoad;

        // Acá convierto el tiempo en un String

        txt_timeFloored.text = Mathf.Floor(currentTime).ToString();

        // Acá pongo un if para que el usuario gane cuando llegue a 20 puntos

        if(currentTime > 10)
        {
            SceneManager.LoadScene("FinalWin");
        }
      
    }
}
