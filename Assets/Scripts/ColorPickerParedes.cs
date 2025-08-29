using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickerParedes : MonoBehaviour {
    public Material[] CorParedes;
    new Renderer renderer;


    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    public void paredeBranco()
    {
        renderer.material = CorParedes[0];
    }

    public void paredeAzulejo1()
    {
        renderer.material = CorParedes[2];
    }


    public void paredeAzulejo2()
    {
        renderer.material = CorParedes[3];
    }

    public void paredeAzulejo3()
    {
        renderer.material = CorParedes[1];
    }


}
 
