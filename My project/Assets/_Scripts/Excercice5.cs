using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercice5 : MonoBehaviour
{
    private SpriteRenderer renderer;

    // Almacenar posicion del circulo rojo
    public GameObject redCircle;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        transform.position = redCircle.transform.position;
        ChangeColor();
    }

 

    public void ChangeColor()
    {
        renderer.color = Color.red;
        Debug.Log(string.Format("La posicion del circulo es: {0} y su color es: {1}", transform.position, "red"));
    }

}

