using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicle : MonoBehaviour
{
    [SerializeField] private bool isOn = true;
    /* variable que guarda el sonido del vehiculo
    Estas dos variables indicaran el nombre del vehículo y cuantas ruedas tienen ada vehículo 

    [SerializeField] private string sound = "¡broom, broom!";
    [SerializeField] private string name;

    [SerializeField] int numberwheels = 4;

    public bool hasSiren = true;
    
    // Start is called before the first frame update

    [SerializeField] private float gasoline;
    */
    void Start()
    {
        /*

            if (isOn == true)
            {
                if (gasoline <= 10)
                {
                    Debug.Log(message: $"a {name} le queda poca gasolina");
                }
                if (hasSiren == true)
                {
                    Debug.Log(message: sound);
                }
                else
                {
                    Debug.Log(message: $"{name} no tiene sirena");
                }
            }
            else
            {
                Debug.Log(message: $"{name} no esta en marcha");
            }
        */
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == true)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += Vector3.right;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += Vector3.left;
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.position += Vector3.up;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.position += Vector3.down;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += Vector3.forward;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += Vector3.back;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.rotation *= Quaternion.Euler(0, 10, 0);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.rotation *= Quaternion.Euler(0, -10, 0);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.rotation *= Quaternion.Euler(10, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.rotation *= Quaternion.Euler(-10, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                transform.localScale += Vector3.one;
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                transform.localScale += -1 * Vector3.one;
            }

        }
    }
}
