using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercice : MonoBehaviour
{
    // Creacion variables
    [Header("Numeros")]
    public int a;
    public int b;
    private int result;

    public string textName;

    // Start is called before the first frame update
    void Start()
    {
        Suma();
    }

    // Sumad e dos numeros
    public void Suma()
    {
        result = a + b;
        // Escribe el resultado en consola
        Debug.Log("El resultado es: " + result);
        Debug.Log(string.Format("El {1} es {0}", result, textName));
    }
}
