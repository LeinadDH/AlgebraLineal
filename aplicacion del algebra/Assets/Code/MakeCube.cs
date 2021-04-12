using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCube : MonoBehaviour
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
        float size = 1f;
        vertex = new[]
        {
            new Vector3(0, size, 0),
            new Vector3(0, 0, 0),
            new Vector3(size, size, 0),
            new Vector3(size, 0, 0),

            new Vector3(0, 0, size),
            new Vector3(size, 0, size),
            new Vector3(0, size, size),
            new Vector3(size, size, size),

            new Vector3(0, size, 0),
            new Vector3(size, size, 0),

            new Vector3(0, size, 0),
            new Vector3(0, size, size),

            new Vector3(size, size, 0),
            new Vector3(size, size, size),

            };



        meshFilter.mesh.vertices = vertex;

        int[] triangles = {
            0, 2, 1, // front
			1, 2, 3,
            4, 5, 6, // back
			5, 7, 6,
            6, 7, 8, //top
			7, 9 ,8,
            1, 3, 4, //bottom
			3, 5, 4,
            1, 11,10,// left
			1, 4, 11,
            3, 12, 5,//right
			5, 12, 13


        };

        Vector2[] uvs = 
        {
            new Vector2(0, 0.66f),
            new Vector2(0.25f, 0.66f),
            new Vector2(0, 0.33f),
            new Vector2(0.25f, 0.33f),

            new Vector2(0.5f, 0.66f),
            new Vector2(0.5f, 0.33f),
            new Vector2(0.75f, 0.66f),
            new Vector2(0.75f, 0.33f),

            new Vector2(1, 0.66f),
            new Vector2(1, 0.33f),

            new Vector2(0.25f, 1),
            new Vector2(0.5f, 1),

            new Vector2(0.25f, 0),
            new Vector2(0.5f, 0),
        };
        meshFilter.mesh.triangles = triangles;
        meshFilter.mesh.uv = uvs;
        meshFilter.mesh.Optimize();
        meshFilter.mesh.RecalculateNormals();

    }

}
