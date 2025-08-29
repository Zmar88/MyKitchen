using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickerArmarios : MonoBehaviour {
    public Material[] CorArmarios;
    new Renderer renderer;


    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    public void armarioPreto()
    {
        renderer.material = CorArmarios[0];
    }

    public void armariocastanho()
    {
        renderer.material = CorArmarios[2];
    }


    public void armariocastanhoClaro()
    {
        renderer.material = CorArmarios[3];
    }

    public void armarioBranco()
    {
        renderer.material = CorArmarios[1];
    }


}
 
