using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCube : MonoBehaviour
{
    public Material material;

    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    int X, Y, Z;

    Vector3[] vertex;

    int[] Cube;

    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();

        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        meshFilter.mesh = mesh;

        vertex = new[]
        {
            new Vector3(0,0,0),
            new Vector3(0,1,0),
            new Vector3(1,0,0),
            new Vector3(1,1,0),

            new Vector3(0,0,1), //tapa inferior
            new Vector3(1,0,0),
            new Vector3(1,0,1),

            
            new Vector3(0,1,1), //tapa superior
            new Vector3(1,1,0),
            new Vector3(1,1,1),
            new Vector3(0,1,0),

            new Vector3(0,0,1),
            new Vector3(0,1,1),
            new Vector3(1,0,1),
            new Vector3(1,1,1),

            new Vector3(0,1,1),
            new Vector3(0,0,1),

            new Vector3(1,0,1),

        };

        meshFilter.mesh.vertices = vertex;

        Cube = new[]
        {
            0,1,2, 
            1,3,2, 

            4,0,5, 
            4,5,6, 

            10, 7, 8,
            8, 7, 9,

            12, 11, 13,
            12, 13, 14,

            15, 0, 16,
            0, 15, 1,

            17, 2, 3,
            17, 8, 9,
        };

        meshFilter.mesh.triangles = Cube;


        for (X = 0; X <= 2; X++)
        {
            for (Y = 0; Y <= 2; Y++)
            {
                for (Z = 0; Z <= 2; Z++)
                {
                    Vector3 Position = transform.TransformPoint(X, Y, Z);
                    Quaternion Rotation = Quaternion.Euler(0, 0, 0);
                    Instantiate(meshFilter, Position, Rotation);
                }    
            }
        }
    }
}
