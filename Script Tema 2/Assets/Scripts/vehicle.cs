using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicle : MonoBehaviour
{
    // variable que guarda el sonido del vehiculo
    // Estas dos variables indicaran el nombre del vehículo y cuantas ruedas tienen ada vehículo 

    [SerializeField] private string sound = "¡broom, broom!";
    [SerializeField] private string name;

    [SerializeField] int numberwheels = 4;

    public bool hasSiren = true;
    [SerializeField] private bool isOn = false;
    // Start is called before the first frame update

    void Start()
    {
      //  Debug.Log($"{name} tiene {numberwheels} y hace {sound}");

        if (isOn == true)
        {
            Debug.Log(message: $"{name} hace {sound}");
        } else if (hasSiren == true) {
            Debug.Log(message: $"{name} hara {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log(message: $"{name} no está en marcha");
        }

       
       
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
