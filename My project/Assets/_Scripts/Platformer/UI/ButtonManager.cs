using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public void NewGame()
    {
        Debug.Log("Iniciando nuevo juego");
    }
    public void Continue()
    {
        Debug.Log("Continuando juego");
    }
    public void LoadGame()
    {
        Debug.Log("Cargando juego");
    }
    public void ExitGame()
    {
        Debug.Log("Saliendo del juego");
    }
}
