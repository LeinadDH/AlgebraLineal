using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D20 : MonoBehaviour
{
    public Material material;

    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    Vector3[] vertex;

    public Texture texture;

    int[] triangles;

    List<int> triangles_2;
    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();

        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;
        Mesh mesh = GetComponent<MeshFilter>().mesh;

        meshFilter.mesh = mesh;

        vertex = new[]
        {
            //triangulo 1
            new Vector3(0,0,0),// A
            new Vector3(1,0,0), // B
            new Vector3(0.5f,0,0.87f), // C
        
            //triangulo 2
            new Vector3(0,0,0),// A
            new Vector3(1,0,0), // B
            new Vector3(0.5f,0.58f,-0.65f), // D
             
            //triangulo 3
            new Vector3(0,0,0),// A
            new Vector3(0.5f,0.58f,-0.65f), // D
            new Vector3(-0.31f,0.93f,-0.18f), // G

            //triangulo 4
            new Vector3(0,0,0),// A
            new Vector3(-0.31f,0.93f,-0.18f), // G
            new Vector3(-0.31f,0.58f,0.76f), // F
          
            //triangulo 5
            new Vector3(0,0,0),// A
            new Vector3(-0.31f,0.58f,0.76f), // F
            new Vector3(0.5f,0,0.87f), // C
           
            //triangulo 6
            new Vector3(1,0,0),// B
            new Vector3(0.5f,0.58f,-0.65f), // D
            new Vector3(1.31f,0.93f,-0.18f), // H

            //triangulo 7
            new Vector3(0.5f,0.58f,-0.65f),// D
            new Vector3(1.31f,0.93f,-0.18f), // H
            new Vector3(0.5f,1.51f,-0.29f), // J

            //triangulo 8
            new Vector3(0.5f,0.58f,-0.65f),// D
            new Vector3(0.5f,1.51f,-0.29f), // J
            new Vector3(-0.31f,0.93f,-0.18f), // G

            //triangulo 9
            new Vector3(0,1.51f,0.58f),// L
            new Vector3(0.5f,1.51f,-0.29f), // J
            new Vector3(-0.31f,0.93f,-0.18f), // G

            //triangulo 10
            new Vector3(0,1.51f,0.58f),// L
            new Vector3(-0.31f,0.58f,0.76f), // F
            new Vector3(-0.31f,0.93f,-0.18f), // G

            //triangulo 11
            new Vector3(0,1.51f,0.58f),// L
            new Vector3(-0.31f,0.58f,0.76f), // F
            new Vector3(0.5f,0.93f,1.22f), // I

            //triangulo 12
            new Vector3(0.5f,0,0.87f), // C
            new Vector3(-0.31f,0.58f,0.76f), // F
            new Vector3(0.5f,0.93f,1.22f), // I

            //triangulo 13
            new Vector3(0.5f,0,0.87f),// C
            new Vector3(1.31f,0.58f,0.76f), // E
            new Vector3(0.5f,0.93f,1.22f), // I

            //triangulo 14
            new Vector3(0.5f,0,0.87f),// C
            new Vector3(1.31f,0.58f,0.76f), // E
            new Vector3(1,0,0), // B

            //triangulo 15
            new Vector3(1.31f,0.93f,-0.18f),// H
            new Vector3(1.31f,0.58f,0.76f), // E
            new Vector3(1,0,0), // B

            //triangulo 16
            new Vector3(1.31f,0.93f,-0.18f),// H
            new Vector3(1.31f,0.58f,0.76f), // E
            new Vector3(1,1.51f,0.58f), // K

            //triangulo 17
            new Vector3(1.31f,0.93f,-0.18f),// H
            new Vector3(0.5f,1.51f,-0.29f), // J
            new Vector3(1,1.51f,0.58f), // K

            //triangulo 18
            new Vector3(0,1.51f,0.58f),// L
            new Vector3(0.5f,1.51f,-0.29f), // J
            new Vector3(1,1.51f,0.58f), // K

            //triangulo 19
            new Vector3(0,1.51f,0.58f),// L
            new Vector3(0.5f,0.93f,1.22f), // I
            new Vector3(1,1.51f,0.58f), // K

            //triangulo 20
            new Vector3(1.31f,0.58f,0.76f),// E
            new Vector3(0.5f,0.93f,1.22f), // I
            new Vector3(1,1.51f,0.58f), // K     
        };

        


        meshFilter.mesh.vertices = vertex;

        int[] triangles = 
        {
            0,1,2,  //triangulo 1
            3,5,4,  //triangulo 2
            6,8,7, //triangulo 3
            11,10,9, //triangulo 4
            14,13,12, //triangulo 5
            16,17,15, //triangulo 6
            18,20,19, //triangulo 7
            21,23,22, //triangulo 8
            24,25,26, //triangulo 9
            27,29,28, //triangulo 10
            30,31,32, //triangulo 11
            33,35,34, //triangulo 12
            36,37,38, //triangulo 13
            39,41,40, //triangulo 14
            42,43,44, //triangulo 15
            45,47,46, //triangulo 16
            48,49,50, //triangulo 17
            51,53,52, //triangulo 18
            54,55,56, //triangulo 19
            57,59,58, //triangulo 20
        };

        Vector2[] uvs =
        {
            //triangulo 1
            new Vector2(0f, 0f),
            new Vector2(0f, 0.5f),
            new Vector2(0.2f, 0f),

            //triangulo 2
            new Vector2(0f, 0.5f),
            new Vector2(0.2f, 0f),
            new Vector2(0.2f, 0.5f),

            //triangulo 3
            new Vector2(0.2f, 0f),
            new Vector2(0.4f, 0f),
            new Vector2(0.2f, 0.5f),

            //triangulo 4
            new Vector2(0.4f, 0.5f),
            new Vector2(0.4f, 0f),
            new Vector2(0.2f, 0.5f),

            //triangulo 5
            new Vector2(0.4f, 0.5f),
            new Vector2(0.4f, 0f),
            new Vector2(0.6f, 0f),

            //triangulo 6
            new Vector2(0.6f, 0f),
            new Vector2(0.4f, 0.5f),
            new Vector2(0.6f, 0.5f),

            //triangulo 7
            new Vector2(0.6f, 0f),
            new Vector2(0.8f, 0f),
            new Vector2(0.6f, 0.5f),

            //triangulo 8
            new Vector2(0.6f, 0.5f),
            new Vector2(0.8f, 0f),
            new Vector2(0.8f, 0.5f),

            //triangulo 9
            new Vector2(0.8f, 0.5f),
            new Vector2(0.8f, 0f),
            new Vector2(1f, 0f),

            //triangulo 10
            new Vector2(1f, 0.5f),
            new Vector2(0.8f, 0.5f),
            new Vector2(1f, 0f),

            //triangulo 11
            new Vector2(0f, 0.5f),
            new Vector2(0f, 1f),
            new Vector2(0.2f, 0.5f),

            //triangulo 12
            new Vector2(0f, 1f),
            new Vector2(0.2f, 0.5f),
            new Vector2(0.2f, 1f),

            //triangulo 13
            new Vector2(0.2f, 0.5f),
            new Vector2(0.2f, 1f),
            new Vector2(0.4f, 0.5f),

            //triangulo 14
            new Vector2(0.2f, 1f),
            new Vector2(0.4f, 0.5f),
            new Vector2(0.4f, 1f),

            //triangulo 15
            new Vector2(0.4f, 0.5f),
            new Vector2(0.4f, 1f),
            new Vector2(0.6f, 0.5f),

            //triangulo 16
            new Vector2(0.4f, 1f),
            new Vector2(0.6f, 0.5f),
            new Vector2(0.6f, 1f),

            //triangulo 17
            new Vector2(0.6f, 0.5f),
            new Vector2(0.6f, 1f),
            new Vector2(0.8f, 0.5f),

            //triangulo 18
            new Vector2(0.6f, 1f),
            new Vector2(0.8f, 0.5f),
            new Vector2(0.8f, 1f),

            //triangulo 19
            new Vector2(0.8f, 0.5f),
            new Vector2(0.8f, 1f),
            new Vector2(1f, 0.5f),

            //triangulo 20
            new Vector2(1f, 0.5f),
            new Vector2(0.8f, 1f),
            new Vector2(1f, 1f),
        };

        meshFilter.mesh.triangles = triangles;
        meshFilter.mesh.uv = uvs;
        meshFilter.mesh.Optimize();
        meshFilter.mesh.RecalculateNormals();

    }

}
