using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArraysGaussJordan : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 Delta;
    public float timer;
    public bool Move = false;
    public bool reloadScene = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        if (timer >= 34f)
        {
            Move = true;
        }
        if(timer >= 89f)
        {
            Move = false;
        }
        if (timer >= 96f)
        {
            Move = true;
        }
        if (timer >= 212)
        {
            Delta.z = 0;
        }
        if (timer >= 223)
        {
            reloadScene = true;
        }

        if (Move == true)
        {
            if (Cube.transform.position.z >= 3.5f)
            {
                Delta.z = -0.05f;
            }
            if (Cube.transform.position.z <= -10f)
            {
                Delta.z = 0.05f;
            }
            for (int i = 0; i < 140; i++)
            {
                if (i < 1)
                {
                    Cube.transform.position = Array(Cube.transform.position);
                }
            }
        }

        if (reloadScene == true)
        {
            SceneManager.LoadScene("Cube");
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
