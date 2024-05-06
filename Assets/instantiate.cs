using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{
    public GameObject cube;  
  
 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

          if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            Vector3 boop = Input.mousePosition;
         /*   {
                Debug.Log(boop.x + boop.y);
            }*/

            Instantiate(cube, boop, Quaternion.identity);
         
        }

    }
}
