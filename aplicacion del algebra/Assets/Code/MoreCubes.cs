using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreCubes : MonoBehaviour
{

    int X, Y, Z;
    public GameObject TheCube;
    public GameObject RubiksCube;
    [SerializeField] GameObject[] cubesArray;

    // Start is called before the first frame update
    void Start()
    {
        for (X = 0; X <= 2; X++)
        {
            for (Y = 0; Y <= 2; Y++)
            {
                for (Z = 0; Z <= 2; Z++)
                {
                    Vector3 Position = transform.TransformPoint(X, Y, Z);
                    Quaternion Rotation = Quaternion.Euler(0, 0, 0);
                    Instantiate(TheCube, Position, Rotation);
                }
            }
        }

        FindCubes();
    }

    void FindCubes()
    {
        cubesArray = GameObject.FindGameObjectsWithTag("newCube");
        for (int i = 0; i < cubesArray.Length; i++)
        {
            cubesArray[i].gameObject.transform.parent = RubiksCube.transform;
        }

    }
}
