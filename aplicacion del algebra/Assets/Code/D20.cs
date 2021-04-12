using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D20 : MonoBehaviour
{
    public Material material;

    float A = 1.48f;
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
           new Vector3(0 + A, 0 + A, 0 + A), //A 0
           new Vector3(2.3f + A, 0 + A, 0 + A), //b 1
           new Vector3(1.15f + A, 1.99f + A, 0 + A), //c 2
           new Vector3(1.15f + A, -1.48f + A, 1.33f + A), //d 3
           new Vector3(3.01f + A, 1.74f + A, 1.33f + A), //e 4
           new Vector3(-0.71f + A, 1.74f + A, 1.33f + A), //f 5
           new Vector3(-0.71f + A, -0.41f + A, 2.15f + A), //g 6
           new Vector3(3.01f + A, -0.41f + A, 2.15f + A), //h 7
           new Vector3(1.15f + A, 2.81f + A, 2.15f + A), //i 8
           new Vector3(1.15f + A, -0.66f + A, 3.48f + A), //j 9
           new Vector3(2.3f + A, 1.33f + A, 3.48f + A), //k 10
           new Vector3(0 + A, 1.33f + A, 3.48f + A), // l 11

           new Vector3(0 + A, 0 + A, 0 + A), //A 0
           new Vector3(2.3f + A, 0 + A, 0 + A), //b 1
           new Vector3(1.15f + A, 1.99f + A, 0 + A), //c 2
           new Vector3(1.15f + A, -1.48f + A, 1.33f + A), //d 3
           new Vector3(3.01f + A, 1.74f + A, 1.33f + A), //e 4
           new Vector3(-0.71f + A, 1.74f + A, 1.33f + A), //f 5
        };

        


        meshFilter.mesh.vertices = vertex;

        int[] triangles = 
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

        Vector2[] uvs =
        {
            new Vector2(0f, 0f),
            new Vector2(0f, 0.5f),
            new Vector2(0f, 1f),

            new Vector2(0.2f, 0f),
            new Vector2(0.2f, 0.5f),
            new Vector2(0.2f, 1f),

            new Vector2(0.4f, 0f),
            new Vector2(0.4f, 0.5f),
            new Vector2(0.4f, 1f),

            new Vector2(0.6f, 0f),
            new Vector2(0.6f, 0.5f),
            new Vector2(0.6f, 1f),

            new Vector2(0.8f, 0f),
            new Vector2(0.8f, 0.5f),
            new Vector2(0.8f, 1f),

            new Vector2(1f, 0f),
            new Vector2(1f, 0.5f),
            new Vector2(1f, 1f),
        };


        meshFilter.mesh.triangles = triangles;
        meshFilter.mesh.uv = uvs;
        meshFilter.mesh.Optimize();
        meshFilter.mesh.RecalculateNormals();

    }

}
