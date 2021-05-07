using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArraysGaussJordan : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 Delta;
    public float timer;
    public bool MoveZ = false;
    public bool MoveX = false;
    public bool MoveY = false;
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
            MoveZ = true;
        }
        if(timer >= 89f)
        {
            MoveZ = false; 
            Delta.z = 0;
            
        }
        if (timer >= 96f)
        {
            MoveY = true;
        }
        if (timer >= 129f)
        {
            MoveY = false;
            Delta.y = 0;
        }
        if (timer >= 156f)
        {
            MoveX = true;
        }
        if (timer >= 212)
        {
            MoveX = false;
            Delta.x = 0;
            Cube.transform.position = new Vector3(0, 0, 0);
        }
        if (timer >= 223)
        {
            reloadScene = true;
        }

        if (MoveZ == true)
        {
            if (Delta.z == 0)
            {
                Delta.z = 0.05f;
            }
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

        if (MoveX == true)
        {
            if (Delta.x == 0)
            {
                Delta.x = 0.02f;
            }
            if (Cube.transform.position.x >= 7.5f)
            {
                Delta.x = -0.02f;
            }
            if (Cube.transform.position.x <= -7.5f)
            {
                Delta.x = 0.02f;
            }
            for (int i = 0; i < 140; i++)
            {
                if (i < 1)
                {
                    Cube.transform.position = Array(Cube.transform.position);
                }
            }
        }

        if (MoveY == true)
        {
            if (Delta.y == 0)
            {
                Delta.y = 0.005f;
            }
            if (Cube.transform.position.y >= 2.5f)
            {
                Delta.y = -0.005f;
            }
            if (Cube.transform.position.y <= -2.5f)
            {
                Delta.y = 0.005f;
            }
            for (int i = 0; i < 280; i++)
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
