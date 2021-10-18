using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    
    public int playerAge = 35;
    private float playesSpeed = 5.25f;
    public string playerName = "Gingasi";
    [SerializeField] private bool gameOver = false;

    /*
    public int x = 5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;

    public bool isRaining = false;
    */
    // Start is called before the first frame update
    void Start()
    {
        /*  Debug.Log($"suma: {x} + {y} = {x + y}");
          Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
          Debug.Log($"division: {x} / {y} = {x / y}");
          Debug.Log($"multiplicacion: {x} * {y} = {x * y}");
          Debug.Log(message: string.Format("Productor: {0} / {1} = {2}", x, y, x / y));


          if (isRaining == true)
          {
              Debug.Log(message: "lleva paraguas");
          } else 
          {
              Debug.Log(message: "no llueve. No lleves paraguas");
          }
         */

        if (playerAge >= 18)
        {
            Debug.Log(message: "Eres un adulto y gilipollas");
        }
        else if (playerAge >=13)
        {
            Debug.Log(message: "No crezcas, es una trampa");
        }
        else 
        {
            Debug.Log(message: "No eres nada");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
