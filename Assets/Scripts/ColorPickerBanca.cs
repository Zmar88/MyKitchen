using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickerBanca : MonoBehaviour {
    public Material[] CorBanca;
    new Renderer renderer;


    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    public void banca1()
    {
        renderer.material = CorBanca[0];
    }

    public void banca2()
    {
        renderer.material = CorBanca[2];
    }


    public void banca3()
    {
        renderer.material = CorBanca[3];
    }

    public void banca4()
    {
        renderer.material = CorBanca[1];
    }


}
 
