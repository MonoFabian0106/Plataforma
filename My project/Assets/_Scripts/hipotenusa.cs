using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hipotenusa : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        float a = 3f;
        float b = 4f;

        float hipotenusa = Mathf.Sqrt(a * a + b * b);
        Debug.Log("La hipotenusa es: " + hipotenusa);
    }

    
}
