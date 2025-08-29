using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickerMetais : MonoBehaviour
{
    public Material[] CorMetais;
    new Renderer renderer;


    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    public void metalPreto()
    {
        renderer.material = CorMetais[0];
    }

    public void metalBranco()
    {
        renderer.material = CorMetais[1];
    }


    public void metalAluminio()
    {
        renderer.material = CorMetais[2];
    }

}
