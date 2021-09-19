using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScenesController : MonoBehaviour
{
    public int sceneID;

    public void CambiarEscena(){
        Debug.Log("Se cambiara a la escena: " + sceneID);
        SceneManager.LoadScene(sceneID);
        
    }
}
