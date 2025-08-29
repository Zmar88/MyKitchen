using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    //Variaveis
    float rotationOnX;
    float mouseSensivity = 90f;
    public Transform player;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = 0;
        float m_X = 0;
        if (Input.GetMouseButton(1))
        {
            //Input vindo do rato
             mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;
             m_X = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;


            //Esconde o cursor do rato
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        else
        {
            //Mostra o cursor do rato
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        //Mover a camara para cima e para baixo
        rotationOnX -= mouseY;
        rotationOnX = Mathf.Clamp(rotationOnX, -90f, 90f);
        transform.localEulerAngles = new Vector3(rotationOnX, 0f, 0f);

        //Mover a camara para a esquerda e para a direita
        player.Rotate(Vector3.up * m_X);
    }
}
