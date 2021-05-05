using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject Cube;

    float Angle = 10;
    public float Z, Y, X;
    public Vector3 Position, firstPosition;


    private float[,] matrizX;
    private float[,] matrizY;
    private float[,] matrizZ;

    // Start is called before the first frame update
    void Start()
    {
        Position = Cube.transform.position;
        firstPosition = Cube.transform.position;

        matrizX = new float[4, 4]
        {
            {1, 0, 0, 0},
            {0, Mathf.Cos(Angle), -Mathf.Sin(Angle), 0},
            {0, Mathf.Sin(Angle), Mathf.Cos(Angle), 0},
            {0, 0, 0, 1}
        };

        matrizY = new float[4, 4]
        {
            {Mathf.Cos(Angle), 0, Mathf.Sin(Angle), 0},
            {0, 1, 0, 0},
            {-Mathf.Sin(Angle), 0, Mathf.Cos(Angle), 0},
            {0, 0, 0, 1}
        };

        matrizZ = new float[4, 4]
        {
            {Mathf.Cos(Angle), -Mathf.Sin(Angle), 0, 0},
            {Mathf.Sin(Angle), Mathf.Cos(Angle), 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };
    }

    public void RotateX()
    {
        Position = Cube.transform.position;

        Y = (Position.y * matrizX[1, 1]) + (Position.z * matrizX[2, 1]);
        Z = (Position.y * matrizX[1, 2]) + (Position.z * matrizX[2, 2]);

        Cube.transform.position = new Vector3(Position.x, Y, Z);
    }

    public void RotateY()
    {
        Position = Cube.transform.position;

        Z = (Position.z * matrizY[0, 0]) + (Position.x * matrizY[2, 0]);
        X = (Position.z * matrizY[0, 2]) + (Position.x * matrizY[2, 2]);

        Cube.transform.position = new Vector3(X, Position.y, Z);
    }

    public void RotateZ()
    {
        Position = Cube.transform.position;

        X = (Position.x * matrizZ[0, 0]) + (Position.y * matrizZ[1, 0]);
        Y = (Position.x * matrizZ[0, 1]) + (Position.y * matrizZ[1, 1]);

        Cube.transform.position = new Vector3(X, Y, Position.z);
    }

}
