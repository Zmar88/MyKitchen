using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickerCarpetes : MonoBehaviour
{
    public Material[] CorCarpetes;
    new Renderer renderer;


    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    public void carpete1()
    {
        renderer.material = CorCarpetes[0];
    }

    public void carpete2()
    {
        renderer.material = CorCarpetes[1];
    }


    public void carpete3()
    {
        renderer.material = CorCarpetes[2];
    }

}
