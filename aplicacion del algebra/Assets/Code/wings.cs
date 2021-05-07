using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wings : MonoBehaviour
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
            new Vector3(0, 0, 0), //C
            new Vector3(0, 0.75f, 0.5f), //B
            new Vector3(0.5f, 0.75f, 0.25f), //E

            new Vector3(0, 0, 0), //C
            new Vector3(0, 0.75f, 0.5f), //B
            new Vector3(-0.5f, 0.75f, 0.25f), //G

            new Vector3(0, 0.75f, 0.5f), //B
            new Vector3(-0.5f, 0.75f, 0.25f), //G
            new Vector3(0, 1.5f, 0.5f), //I

            new Vector3(0, 0.75f, 0.5f), //B
            new Vector3(0.5f, 0.75f, 0.25f), //E
            new Vector3(0, 1.5f, 0.5f), //I

            new Vector3(0, 0, 0), //C
            new Vector3(0, 0.75f, -0.5f), //A
            new Vector3(0.5f, 0.75f, -0.25f), //D

            new Vector3(0, 0, 0), //C
            new Vector3(0, 0.75f, -0.5f), //A
            new Vector3(-0.5f, 0.75f, -0.25f), //F

            new Vector3(0, 1.5f, -0.5f), //H
            new Vector3(0, 0.75f, -0.5f), //A
            new Vector3(0.5f, 0.75f, -0.25f), //D

            new Vector3(0, 1.5f, -0.5f), //H
            new Vector3(0, 0.75f, -0.5f), //A
            new Vector3(-0.5f, 0.75f, -0.25f), //F

            new Vector3(0, 0, 0), //C
            new Vector3(0, 0.75f, 0.5f), //B
            new Vector3(0.5f, 0.75f, 0.25f), //E

            new Vector3(0, 0, 0), //C
            new Vector3(0, 0.75f, 0.5f), //B
            new Vector3(-0.5f, 0.75f, 0.25f), //G

            new Vector3(0, 0.75f, 0.5f), //B
            new Vector3(-0.5f, 0.75f, 0.25f), //G
            new Vector3(0, 1.5f, 0.5f), //I

            new Vector3(0, 0.75f, 0.5f), //B
            new Vector3(0.5f, 0.75f, 0.25f), //E
            new Vector3(0, 1.5f, 0.5f), //I

            new Vector3(0, 0, 0), //C
            new Vector3(0, 0.75f, -0.5f), //A
            new Vector3(0.5f, 0.75f, -0.25f), //D

            new Vector3(0, 0, 0), //C
            new Vector3(0, 0.75f, -0.5f), //A
            new Vector3(-0.5f, 0.75f, -0.25f), //F

            new Vector3(0, 1.5f, -0.5f), //H
            new Vector3(0, 0.75f, -0.5f), //A
            new Vector3(0.5f, 0.75f, -0.25f), //D

            new Vector3(0, 1.5f, -0.5f), //H
            new Vector3(0, 0.75f, -0.5f), //A
            new Vector3(-0.5f, 0.75f, -0.25f), //F
        };



        meshFilter.mesh.vertices = vertex;

        int[] triangles =
        {
            1,0,2,
            3,4,5,
            7,6,8,
            9,10,11,
            12,13,14,
            16,15,17,
            19,18,20,
            21,22,23,

            24,25,26,
            28,27,29,
            30,31,32,
            34,33,35,
            37,36,38,
            39,40,41,
            42,43,44,
            46,45,47
        };

        Vector2[] uvs =
        {
            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),

            new Vector2(0, 0),
            new Vector2(0, 1),
            new Vector2(1, 0),
        };
        meshFilter.mesh.triangles = triangles;
        meshFilter.mesh.uv = uvs;
        meshFilter.mesh.Optimize();
        meshFilter.mesh.RecalculateNormals();

    }

}
