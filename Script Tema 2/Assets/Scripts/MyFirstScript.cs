using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public Vector3 Mypos;

    public string hello; 

    // Start is called before the first frame update
    void Start()
    {
        HelloWorld();
        hello = GetHello();
        Debug.Log(hello);
        /*
        Mypos = new Vector3(x: 2, y: 1, z: 0);
        Mypos = Vector3.zero;
        Mypos = Vector3.one;
        Mypos = Vector3.up;
        Mypos = Vector3.down;
        Mypos = Vector3.right;
        Mypos = Vector3.left;
        Mypos = Vector3.forward;
        Mypos = Vector3.back;
        */
        transform.position = Mypos;
        
        
    }
    
    // Update is called once per frame
    void Update()
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
            transform.localScale += -1 *Vector3.one;
        }

    }
    public void HelloWorld()
    { 
       Debug.Log(message:"¡Hola Mundo!");
    }
    public string GetHello ()
    { return "Hola"; }

}
