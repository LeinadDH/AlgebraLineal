using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject Cube;
    public float VectorX, VectorY, VectorZ;
    public float FinalX, FinalY, FinalZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        MoveX();
        MoveY();
        MoveZ();

    }

    void MoveX()
    {
        if (VectorX > FinalX)
        {
            Cube.transform.position = new Vector3(FinalX++, VectorY, VectorZ);
        }
        if (VectorX < FinalX)
        {
            Cube.transform.position = new Vector3(FinalX--, VectorY, VectorZ);
        }
        if (VectorX == FinalX)
        {
            Cube.transform.position = new Vector3(FinalX, VectorY, VectorZ);
        }
    }

    void MoveY()
    {
        if (VectorY > FinalY)
        {
            Cube.transform.position = new Vector3(FinalX, VectorY++, VectorZ);
        }
        if (VectorY < FinalY)
        {
            Cube.transform.position = new Vector3(FinalX, VectorY--, VectorZ);
        }
        if (VectorY == FinalY)
        {
            Cube.transform.position = new Vector3(FinalX, VectorY, VectorZ);
        }
    }

    void MoveZ()
    {
        if (VectorZ > FinalZ)
        {
            Cube.transform.position = new Vector3(FinalX, VectorY, VectorZ++);
        }
        if (VectorZ < FinalZ)
        {
            Cube.transform.position = new Vector3(FinalX, VectorY, VectorZ--);
        }
        if (VectorZ == FinalZ)
        {
            Cube.transform.position = new Vector3(FinalX, VectorY, VectorZ);
        }
    }
}
