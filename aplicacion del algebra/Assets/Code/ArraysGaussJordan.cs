using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysGaussJordan : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 Delta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Cube.transform.position = Array(Cube.transform.position);
        }
    }

    Vector3 Array (Vector3 Position)
    {
        float x = (Position.x * 1) + (Position.y * 0) + (Position.z * 0) + (Delta.x * 1);
        float y = (Position.x * 0) + (Position.y * 1) + (Position.z * 0) + (Delta.y * 1);
        float z = (Position.x * 0) + (Position.y * 0) + (Position.z * 1) + (Delta.z * 1);

        return new Vector3(x, y, z);
    }
}
