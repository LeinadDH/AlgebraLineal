using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icosaedro : MonoBehaviour
{
    public Material material;

    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    Vector3[] vertex;



    int[] triangles;

    List<int> triangles_2;
    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();

        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        meshFilter.mesh = mesh;

        vertex = new[]
        {
           new Vector3(0, 0, 0), //A 0
           new Vector3(2.3f, 0, 0), //b 1
           new Vector3(1.15f, 1.99f, 0), //c 2
           new Vector3(1.15f, -1.48f, 1.33f), //d 3
           new Vector3(3.01f, 1.74f, 1.33f), //e 4
           new Vector3(-0.71f, 1.74f, 1.33f), //f 5
           new Vector3(-0.71f, -0.41f, 2.15f), //g 6
           new Vector3(3.01f, -0.41f, 2.15f), //h 7
           new Vector3(1.15f, 2.81f, 2.15f), //i 8
           new Vector3(1.15f, -0.66f, 3.48f), //j 9
           new Vector3(2.3f, 1.33f, 3.48f), //k 10
           new Vector3(0, 1.33f, 3.48f), // l 11

        };

        /*vertex = new Vector3[3];
        vertex[0] = new Vector3(0, 0, 0);
        vertex[1] = new Vector3(0, 1, 0);
        vertex[2] = new Vector3(1, 0, 0);*/

        meshFilter.mesh.vertices = vertex;

        triangles = new[]
        {
            2, 5, 8,
            2, 0, 5,
            1, 0, 2,
            1, 2, 4,
            1, 3, 0,
            4, 2, 8,
            4, 8, 10,
            4, 10, 7,
            3, 1, 7, 
            1, 4, 7,
            10, 8, 11,
            11, 8, 5,
            11, 5, 6,
            10, 11, 9,
            6, 9, 11,
            6, 3, 9,
            6, 0, 3,
            0, 6, 5,
            3, 7, 9,
            9, 7, 10,

        };

        meshFilter.mesh.triangles = triangles;

    }

}
