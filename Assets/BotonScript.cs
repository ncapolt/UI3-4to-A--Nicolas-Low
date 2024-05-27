using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonScript : MonoBehaviour
{
    public InputField contraseña;
    public Text Bienvenido;
    public string contra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Ingresecontraseña()
    {
    if (contraseña.text == contra)
        {
            Debug.Log("Access granted");
        }
     else
            Debug.Log("Access denied");
    }
}
