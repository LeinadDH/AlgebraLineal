using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTwo : MonoBehaviour
{
    public GameObject Cube;
    public GameObject pivote;

    public Vector3 posTemp;

    public float Angle;
    public float Z, Y, X;
    public Vector3 Position, firstPosition;

    public float timer;
    public bool Rotate = false;

    private float[,] matrizX;
    private float[,] matrizY;
    private float[,] matrizZ;

    // Start is called before the first frame update
    void Start()
    {
        Cube.SetActive(false);

        Angle = 3;

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

    public void Update()
    {
        timer = Time.time;

        if (timer >= 89f)
        {
            Cube.SetActive(true);
        }
        if (timer >= 212)
        {
            Cube.transform.position = firstPosition;
        }

        for (int i = 0; i < 140; i++)
            {
                if (i < 2)
                {

                    posTemp = pivote.transform.position;
                    pivote.transform.position = new Vector3(0, 0, 0);

                    Position = Cube.transform.position;

                    Z = (Position.z * matrizY[0, 0]) + (Position.x * matrizY[2, 0]);
                    X = (Position.z * matrizY[0, 2]) + (Position.x * matrizY[2, 2]);

                    Cube.transform.position = new Vector3(X, Position.y, Z);
                    pivote.transform.position = posTemp;

                    posTemp = pivote.transform.position;
                    pivote.transform.position = new Vector3(0, 0, 0);

                    Position = Cube.transform.position;

                    Y = (Position.y * matrizX[1, 1]) + (Position.z * matrizX[2, 1]);
                    Z = (Position.y * matrizX[1, 2]) + (Position.z * matrizX[2, 2]);

                    Cube.transform.position = new Vector3(Position.x, Y, Z);
                    pivote.transform.position = posTemp;
                }
        }
    }
}
