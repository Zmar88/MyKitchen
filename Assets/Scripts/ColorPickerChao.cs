using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickerChao : MonoBehaviour {
    public Material[] CorChao;
    new Renderer renderer;


    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    public void chaoAzulejo1()
    {
        renderer.material = CorChao[0];
    }

    public void chaoAzulejo2()
    {
        renderer.material = CorChao[1];
    }


    public void chaoAzulejo3()
    {
        renderer.material = CorChao[2];
    }

    public void chaoMadeira1()
    {
        renderer.material = CorChao[3];
    }

    public void chaoMadeira2()
    {
        renderer.material = CorChao[4];
    }
}
 
