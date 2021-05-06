using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen : MonoBehaviour
{
    public Material material;

    float alinear = 1.5f;
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
            //Rojo
            new Vector3(0, -0.1f - alinear, 0), //A -
            new Vector3(0.25f, 0.5f - alinear, 0.5f), //B -
            new Vector3(0, 0.8f - alinear, 0.75f), //D -

            //Rojo
            new Vector3(0, -0.1f - alinear, 0), //A -
            new Vector3(0, 0.8f - alinear, 0.75f), //D -
            new Vector3(-0.25f , 0.5f - alinear, 0.5f), //C -

            //Rojo
            new Vector3(0, 0.8f - alinear, 0.75f), //D -
            new Vector3(-0.25f, 0.5f - alinear, 0.5f), //C -
            new Vector3(-0.7f, 1 - alinear, 0.5f), //H -

            //Rojo
            new Vector3(0.25f, 0.5f - alinear, 0.5f), //B -
            new Vector3(0, 0.8f - alinear, 0.75f), //D -
            new Vector3(0.7f, 1 - alinear, 0.5f), //G -

            //Morado
            new Vector3(0.25f, 0.5f - alinear, 0.5f), //B -
            new Vector3(0.7f, 1 - alinear, 0.5f), //G -
            new Vector3(0.4f, 0.1f - alinear, 0), //E -

            //Morado
            new Vector3(-0.25f, 0.5f - alinear, 0.5f), //C -
            new Vector3(-0.7f, 1 - alinear, 0.5f), //H -
            new Vector3(-0.4f, 0.1f - alinear, 0), //F -

            //Morado
            new Vector3(0, -0.1f - alinear, 0), //A -
            new Vector3(0.25f, 0.5f - alinear, 0.5f), //B -
            new Vector3(0.4f, 0.1f - alinear, 0), //E  -

            //Morado
            new Vector3(0, -0.1f - alinear, 0), //A -
            new Vector3(-0.25f, 0.5f - alinear, 0.5f), //C -
            new Vector3(-0.4f, 0.1f - alinear, 0), //F -

            //Rojo
            new Vector3(0, 0.8f - alinear, 0.75f), //D -
            new Vector3(0.7f, 1 - alinear, 0.5f), //G -
            new Vector3(0.25f, 1.25f - alinear, 0.75f), //I -

            //Rojo
            new Vector3(0, 0.8f - alinear, 0.75f), //D-
            new Vector3(-0.7f, 1 - alinear, 0.5f), //H  -
            new Vector3(-0.25f, 1.25f - alinear, 0.75f), //J -

            //Rojo
            new Vector3(0, 0.8f - alinear, 0.75f), //D -
            new Vector3(0.25f, 1.25f - alinear, 0.75f), //I -
            new Vector3(0, 1.3f - alinear, 1f), //K -

            //Rojo
            new Vector3(0, 0.8f - alinear, 0.75f), //D -
            new Vector3(-0.25f, 1.25f - alinear, 0.75f), //J -
            new Vector3(0, 1.3f - alinear, 1f), //K -

            //Morado
            new Vector3(-0.7f, 1 - alinear, 0.5f), //H -
            new Vector3(-0.4f, 0.1f - alinear, 0), //F -
            new Vector3(-0.8f, 0.6f - alinear, 0), //L -

            //Morado
            new Vector3(0.7f, 1 - alinear, 0.5f), //G -
            new Vector3(0.4f, 0.1f - alinear, 0), //E -
            new Vector3(0.8f, 0.6f - alinear, 0), //M -

            //Verde
            new Vector3(-0.7f, 1 - alinear, 0.5f), //H -
            new Vector3(-1.2f, 1.25f - alinear, 0), //N -
            new Vector3(-0.8f, 0.6f - alinear, 0), //L -

            //Verde
            new Vector3(0.7f, 1 - alinear, 0.5f), //G -
            new Vector3(1.2f, 1.25f - alinear, 0), //O -
            new Vector3(0.8f, 0.6f - alinear, 0), //M -

            //Morado
            new Vector3(0.7f, 1 - alinear, 0.5f), //G -
            new Vector3(1.2f, 1.25f - alinear, 0), //O  -
            new Vector3(0.7f, 1.5f - alinear, 0.5f), //P -

            //Morado
            new Vector3(-0.7f, 1 - alinear, 0.5f), //H -
            new Vector3(-1.2f, 1.25f - alinear, 0), //N -
            new Vector3(-0.7f, 1.5f - alinear, 0.5f), //Q -

            //Rojo
            new Vector3(0.25f, 1.25f - alinear, 0.75f), //I
            new Vector3(0, 1.3f - alinear, 1f), //K
            new Vector3(0.7f, 1.5f - alinear, 0.5f), //P

            //Rojo
            new Vector3(-0.25f, 1.25f - alinear, 0.75f), //J
            new Vector3(0, 1.3f - alinear, 1f), //K
            new Vector3(-0.7f, 1.5f - alinear, 0.5f), //Q

            //Rojo
            new Vector3(0.7f, 1 - alinear, 0.5f), //G
            new Vector3(0.25f, 1.25f - alinear, 0.75f), //I
            new Vector3(0.7f, 1.5f - alinear, 0.5f), //P

            //Rojo
            new Vector3(-0.25f, 1.25f - alinear, 0.75f), //J
            new Vector3(-0.7f, 1.5f - alinear, 0.5f), //Q
            new Vector3(-0.7f, 1 - alinear, 0.5f), //H

            //Rojo
            new Vector3(0, 1.3f - alinear, 1f), //K
            new Vector3(0.7f, 1.5f - alinear, 0.5f), //P
            new Vector3(0.3f, 1.8f - alinear, 0.75f), //R

            //Rojo
            new Vector3(0, 1.3f - alinear, 1f), //K
            new Vector3(-0.7f, 1.5f - alinear, 0.5f), //Q
            new Vector3(-0.3f, 1.8f - alinear, 0.75f), //S

            //Rojo
            new Vector3(0, 1.3f - alinear, 1f), //K
            new Vector3(0.3f, 1.8f - alinear, 0.75f), //R
            new Vector3(0, 2.4f - alinear, 0.25f), //T

            //Rojo
            new Vector3(0, 1.3f - alinear, 1f), //K
            new Vector3(-0.3f, 1.8f - alinear, 0.75f), //S
            new Vector3(0, 2.4f - alinear, 0.25f), //T

            //Rojo
            new Vector3(-0.7f, 1.5f - alinear, 0.5f), //Q
            new Vector3(-0.3f, 1.8f - alinear, 0.75f), //S
            new Vector3(-0.7f, 2.2f - alinear, 0.5f), //V

            //rojo
            new Vector3(0.7f, 1.5f - alinear, 0.5f), //P
            new Vector3(0.3f, 1.8f - alinear, 0.75f), //R
            new Vector3(0.7f, 2.2f - alinear, 0.5f), //U

            //Rojo
            new Vector3(0.7f, 2.2f - alinear, 0.5f), //U
            new Vector3(0.3f, 1.8f - alinear, 0.75f), //R
            new Vector3(0, 2.4f - alinear, 0.25f), //T

            //Rojo
            new Vector3(-0.3f, 1.8f - alinear, 0.75f), //S
            new Vector3(-0.7f, 2.2f - alinear, 0.5f), //V
            new Vector3(0, 2.4f - alinear, 0.25f), //T

            //Rojo
            new Vector3(-0.7f, 1.5f - alinear, 0.5f), //Q
            new Vector3(-1.4f, 1.8f - alinear, 0), //Z
            new Vector3(-0.7f, 2.2f - alinear, 0.5f), //V

            //Rojo
            new Vector3(0.7f, 1.5f - alinear, 0.5f), //P
            new Vector3(1.4f, 1.8f - alinear, 0), //W
            new Vector3(0.7f, 2.2f - alinear, 0.5f), //U

            //Morado
            new Vector3(0.7f, 1.5f - alinear, 0.5f), //P
            new Vector3(1.4f, 1.8f - alinear, 0), //W
            new Vector3(1.2f, 1.25f - alinear, 0), //O

            //Morado
            new Vector3(-0.7f, 1.5f - alinear, 0.5f), //Q
            new Vector3(-1.4f, 1.8f - alinear, 0), //Z
            new Vector3(-1.2f, 1.25f - alinear, 0), //N
            
            //Rojo
            new Vector3(0.7f, 2.2f - alinear, 0.5f), //U
            new Vector3(0, 2.4f - alinear, 0.25f), //T
            new Vector3(0.4f, 2.8f - alinear, 0), //B1

            //Rojo
            new Vector3(-0.7f, 2.2f - alinear, 0.5f), //V
            new Vector3(0, 2.4f - alinear, 0.25f), //T
            new Vector3(-0.4f, 2.8f - alinear, 0), //A1

            //Morado
            new Vector3(0, 2.4f - alinear, 0.25f), //T
            new Vector3(0.4f, 2.8f - alinear, 0), //B1
            new Vector3(-0.4f, 2.8f - alinear, 0), //A1

            //Rojo
            new Vector3(1.4f, 1.8f - alinear, 0), //W
            new Vector3(0.7f, 2.2f - alinear, 0.5f), //U
            new Vector3(1.4f, 2.8f - alinear, 0), //C1

            //Rojo
            new Vector3(-1.4f, 1.8f - alinear, 0), //Z
            new Vector3(-0.7f, 2.2f - alinear, 0.5f), //V
            new Vector3(-1.4f, 2.8f - alinear, 0), //D1

            //Rojo
            new Vector3(0.7f, 2.2f - alinear, 0.5f), //U
            new Vector3(1.4f, 2.8f - alinear, 0), //C1
            new Vector3(0.4f, 2.8f - alinear, 0), //B1

            //Rojo
            new Vector3(-0.7f, 2.2f - alinear, 0.5f), //V
            new Vector3(-1.4f, 2.8f - alinear, 0), //D1
            new Vector3(-0.4f, 2.8f - alinear, 0), //A1

            //Morado
            new Vector3(1.4f, 2.8f - alinear, 0), //C1
            new Vector3(1.4f, 1.8f - alinear, 0), //W
            new Vector3(1.8f, 2.5f - alinear, -0.25f), //J1

            //Morado
            new Vector3(-1.4f, 1.8f - alinear, 0), //Z
            new Vector3(-1.4f, 2.8f - alinear, 0), //D1
            new Vector3(-1.8f, 2.5f - alinear, -0.25f), //K1

            //Amarillo
            new Vector3(1.4f, 2.8f - alinear, 0), //C1
            new Vector3(1.6f, 3.1f - alinear, -0.25f), //M1
            new Vector3(1.8f, 2.5f - alinear, -0.25f), //J1

            //Morado
            new Vector3(-1.6f, 3.1f - alinear, -0.25f), //L1
            new Vector3(-1.4f, 2.8f - alinear, 0), //D1
            new Vector3(-1.8f, 2.5f - alinear, -0.25f), //K1

            //Morado
            new Vector3(1.4f, 1.8f - alinear, 0), //W
            new Vector3(1.8f, 2.5f - alinear, -0.25f), //J1
            new Vector3(1.6f, 1.5f - alinear, -0.25f), //N1

            //Morado
            new Vector3(-1.4f, 1.8f - alinear, 0), //Z
            new Vector3(-1.8f, 2.5f - alinear, -0.25f), //K1
            new Vector3(-1.6f, 1.5f - alinear, -0.25f), //O1

            //Morado
            new Vector3(1.4f, 1.8f - alinear, 0), //W
            new Vector3(1.6f, 1.5f - alinear, -0.25f), //N1
            new Vector3(1.2f, 1.25f - alinear, 0), //O

            //Morado
            new Vector3(-1.4f, 1.8f - alinear, 0), //Z
            new Vector3(-1.6f, 1.5f - alinear, -0.25f), //O1
            new Vector3(-1.2f, 1.25f - alinear, 0), //N

            //Verde
            new Vector3(1.6f, 1.5f - alinear, -0.25f), //N1
            new Vector3(1.2f, 1.25f - alinear, 0), //O
            new Vector3(1.4f, 1f - alinear, -0.25f), //P1

            //verde
            new Vector3(-1.6f, 1.5f - alinear, -0.25f), //O1
            new Vector3(-1.2f, 1.25f - alinear, 0), //N
            new Vector3(-1.4f, 1f - alinear, -0.25f), //Q1

            //Verde
            new Vector3(-1.2f, 1.25f - alinear, 0), //N
            new Vector3(-1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(-0.8f, 0.6f - alinear, 0), //L

            //Verde
            new Vector3(1.2f, 1.25f - alinear, 0), //O
            new Vector3(1.4f, 1f - alinear, -0.25f), //P1
            new Vector3(0.8f, 0.6f - alinear, 0), //M

            //Morado
            new Vector3(1.4f, 1f - alinear, -0.25f), //P1
            new Vector3(0.8f, 0.6f - alinear, 0), //M
            new Vector3(1f, 0.5f - alinear, -0.25f), //S1

            //Morado
            new Vector3(-1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(-0.8f, 0.6f - alinear, 0), //L
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1

            //Morado 
            new Vector3(-0.8f, 0.6f - alinear, 0), //L
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(-0.4f, 0.1f - alinear, 0), //F

            //Morado
            new Vector3(0.8f, 0.6f - alinear, 0), //M
            new Vector3(1f, 0.5f - alinear, -0.25f), //S1
            new Vector3(0.4f, 0.1f - alinear, 0), //E

            //Morado 
            new Vector3(0.4f, 2.8f - alinear, 0), //B1
            new Vector3(-0.4f, 2.8f - alinear, 0), //A1
            new Vector3(0, 3f - alinear, 0), //G1

            //Morado
            new Vector3(0, -0.1f - alinear, 0), //A
            new Vector3(0, -0.1f - alinear, -0.25f), //Z1
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //W1

            //Morado
            new Vector3(0, -0.1f - alinear, 0), //A
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //W1
            new Vector3(0.4f, 0.1f - alinear, 0), //E

            //Morado
            new Vector3(0, -0.1f - alinear, 0), //A
            new Vector3(0, -0.1f - alinear, -0.25f), //Z1
            new Vector3(-0.4f, 0.1f - alinear, 0), //F

            //Morado
            new Vector3(0, -0.1f - alinear, -0.25f), //Z1
            new Vector3(-0.4f, 0.1f - alinear, 0), //F
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1

            //Morado
            new Vector3(-0.4f, 0.1f - alinear, 0), //F
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1

            //Morado
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //W1
            new Vector3(0.4f, 0.1f - alinear, 0), //E
            new Vector3(1f, 0.5f - alinear, -0.25f), //S1

            //Morado
            new Vector3(0, -0.1f - alinear, -0.25f), //Z1
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(0, -0.1f - alinear, -0.75f), //U1

            //Morado
            new Vector3(0, -0.1f - alinear, -0.25f), //Z1
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //W1
            new Vector3(0, -0.1f - alinear, -0.75f), //U1

            //Morado
            new Vector3(1.6f, 3.1f - alinear, -0.25f), //M1
            new Vector3(1.2f, 3.4f - alinear, -0.75f), //A2
            new Vector3(1.2f, 3.4f - alinear, -0.25f), //XD

            //Morado
            new Vector3(-1.6f, 3.1f - alinear, -0.25f), //L1
            new Vector3(-1.2f, 3.4f - alinear, -0.75f), //B2
            new Vector3(-1.2f, 3.4f - alinear, -0.25f), //XD2

            //Morado
            new Vector3(1.6f, 3.1f - alinear, -0.25f), //M1
            new Vector3(1.4f, 2.8f - alinear, 0), //C1
            new Vector3(1.2f, 3.4f - alinear, -0.25f), //XD

            //mORADO
            new Vector3(1.4f, 2.8f - alinear, 0), //C1
            new Vector3(1.2f, 3.4f - alinear, -0.25f), //XD
            new Vector3(0.8f, 3.3f - alinear, -0.25f), //XD'nt

            //mORADO
            new Vector3(1.4f, 2.8f - alinear, 0), //C1
            new Vector3(0.8f, 3.3f - alinear, -0.25f), //XD'nt
            new Vector3(0.4f, 2.8f - alinear, 0), //B1

            //Morado
            new Vector3(0.8f, 3.3f - alinear, -0.25f), //XD'nt
            new Vector3(0.4f, 2.8f - alinear, 0), //B1
            new Vector3(0, 3f - alinear, 0), //G1

            //Morado
            new Vector3(0.8f, 3.3f - alinear, -0.25f), //XD'nt
            new Vector3(0, 3f - alinear, 0), //G1
            new Vector3(0, 3f - alinear, -0.25f), //T1

            //Morado
            new Vector3(-1.6f, 3.1f - alinear, -0.25f), //L1
            new Vector3(-1.4f, 2.8f - alinear, 0), //D1
            new Vector3(-1.2f, 3.4f - alinear, -0.25f), //XD2

            //mORADO
            new Vector3(-1.4f, 2.8f - alinear, 0), //D1
            new Vector3(-1.2f, 3.4f - alinear, -0.25f), //XD2
            new Vector3(-0.8f, 3.3f - alinear, -0.25f), //XD'nt2

            //mORADO
            new Vector3(-1.4f, 2.8f - alinear, 0), //D1
            new Vector3(-0.4f, 2.8f - alinear, 0), //A1
            new Vector3(-0.8f, 3.3f - alinear, -0.25f), //XD'nt2

            //Morado
            new Vector3(0, 3f - alinear , 0), //G1
            new Vector3(-0.4f, 2.8f - alinear, 0), //A1
            new Vector3(-0.8f, 3.3f - alinear, -0.25f), //XD'nt2

            //Morado
            new Vector3(-0.8f, 3.3f - alinear, -0.25f), //XD'nt2
            new Vector3(0, 3f - alinear, 0), //G1
            new Vector3(0, 3f - alinear, -0.25f), //T1

            //Morado
            new Vector3(0.8f, 3.3f - alinear, -0.25f), //XD'nt
            new Vector3(0.8f, 3.3f - alinear, -0.75f), //E2
            new Vector3(0, 3f - alinear, -0.25f), //T1

            //Morado
            new Vector3(-0.8f, 3.3f - alinear, -0.25f), //XD'nt2
            new Vector3(-0.8f, 3.3f - alinear, -0.75f), //F2
            new Vector3(0, 3f - alinear, -0.25f), //T1

            //Morado
            new Vector3(0.8f, 3.3f - alinear, -0.75f), //E2
            new Vector3(0, 3f - alinear, -0.25f), //T1
            new Vector3(0, 3f - alinear, -0.75f), //G2

            //Morado
            new Vector3(-0.8f, 3.3f - alinear, -0.75f), //F2
            new Vector3(0, 3f - alinear, -0.25f), //T1
            new Vector3(0, 3f - alinear, -0.75f), //G2

            //mORADO
            new Vector3(0.8f, 3.3f - alinear, -0.75f), //E2
            new Vector3(1.2f, 3.4f - alinear, -0.25f), //XD
            new Vector3(0.8f, 3.3f - alinear, -0.25f), //XD'nt

            //mORADO
            new Vector3(-0.8f, 3.3f - alinear, -0.75f), //F2
            new Vector3(-1.2f, 3.4f - alinear, -0.25f), //XD2
            new Vector3(-0.8f, 3.3f - alinear, -0.25f), //XD'nt2

            //mORADO
            new Vector3(0.8f, 3.3f - alinear, -0.75f), //E2
            new Vector3(1.2f, 3.4f - alinear, -0.25f), //XD
            new Vector3(1.2f, 3.4f - alinear, -0.75f), //A2

            //mORADO
            new Vector3(-0.8f, 3.3f - alinear, -0.75f), //D2
            new Vector3(-1.2f, 3.4f - alinear, -0.25f), //XD2
            new Vector3(-1.2f, 3.4f - alinear, -0.75f), //B2

            //Morado
            new Vector3(1.2f, 3.4f - alinear, -0.75f), //A2
            new Vector3(1.6f, 3.1f - alinear, -0.25f), //M1
            new Vector3(1.6f, 3.1f - alinear, -0.75f), //C2

            //Morado
            new Vector3(-1.2f, 3.4f - alinear, -0.75f), //B2
            new Vector3(-1.6f, 3.1f - alinear, -0.25f), //L1
            new Vector3(-1.6f, 3.1f - alinear, -0.75f), //D2

            //Morado
            new Vector3(-1.6f, 3.1f - alinear, -0.25f), //L1
            new Vector3(-1.6f, 3.1f - alinear, -0.75f), //D2
            new Vector3(-1.8f, 2.5f - alinear, -0.75f), //I2

            //Morado
            new Vector3(1.6f, 3.1f - alinear, -0.25f), //M1
            new Vector3(1.6f, 3.1f - alinear, -0.75f), //C2
            new Vector3(1.8f, 2.5f - alinear, -0.75f), //H2

            //Morado
            new Vector3(1.6f, 3.1f - alinear, -0.25f), //M1
            new Vector3(1.8f, 2.5f - alinear, -0.75f), //H2
            new Vector3(1.8f, 2.5f - alinear, -0.25f), //J1

            //Morado
            new Vector3(-1.6f, 3.1f - alinear, -0.25f), //L1
            new Vector3(-1.8f, 2.5f - alinear, -0.75f), //I2
            new Vector3(-1.8f, 2.5f - alinear, -0.25f), //K1

            //Morado
            new Vector3(1.8f, 2.5f - alinear, -0.75f), //H2
            new Vector3(1.8f, 2.5f - alinear, -0.25f), //J1
            new Vector3(1.6f, 1.5f - alinear, -0.75f), //J2

            //Morado
            new Vector3(-1.8f, 2.5f - alinear, -0.75f), //I2
            new Vector3(-1.8f, 2.5f - alinear, -0.25f), //k1
            new Vector3(-1.6f, 1.5f - alinear, -0.75f), //K2

            //Morado
            new Vector3(1.8f, 2.5f - alinear, -0.25f), //J1
            new Vector3(1.6f, 1.5f - alinear, -0.75f), //J2
            new Vector3(1.6f, 1.5f - alinear, -0.25f), //N1

            //Morado
            new Vector3(-1.8f, 2.5f - alinear, -0.25f), //k1
            new Vector3(-1.6f, 1.5f - alinear, -0.75f), //K2
            new Vector3(-1.6f, 1.5f - alinear, -0.25f), //O1

            //Morado
            new Vector3(1.6f, 1.5f - alinear, -0.75f), //J2
            new Vector3(1.6f, 1.5f - alinear, -0.25f), //N1
            new Vector3(1.4f, 1 - alinear, -0.75f), //M2

            //Morado
            new Vector3(-1.6f, 1.5f - alinear, -0.75f), //K2
            new Vector3(-1.6f, 1.5f - alinear, -0.25f), //O1
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2

            //Morado
            new Vector3(1.4f, 1 - alinear, -0.75f), //M2
            new Vector3(1.4f, 1f - alinear, -0.25f), //P1
            new Vector3(1.6f, 1.5f - alinear, -0.25f), //N1

            //Morado
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(-1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(-1.6f, 1.5f - alinear, -0.25f), //O1

            //Morado
            new Vector3(1.4f, 1 - alinear, -0.75f), //M2
            new Vector3(1.4f, 1f - alinear, -0.25f), //P1
            new Vector3(1f, 0.5f - alinear, -0.25f), //S1

            //Morado
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(-1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1

            //Morado
            new Vector3(1.4f, 1 - alinear, -0.75f), //M2
            new Vector3(1f, 0.5f - alinear, -0.25f), //S1
            new Vector3(1f, 0.5f - alinear, -0.75f), //O2

            //Morado
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(-1f, 0.5f - alinear, -0.75f), //N2

            //Morado
            new Vector3(1f, 0.5f - alinear, -0.25f), //S1
            new Vector3(1f, 0.5f - alinear, -0.75f), //O2
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //W1

            //Morado
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(-1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1

            //Morado
            new Vector3(1f, 0.5f - alinear, -0.75f), //O2
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //W1
            new Vector3(0.4f, 0.1f - alinear, -0.75f), //Q2

            //Morado
            new Vector3(-1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(-0.4f, 0.1f - alinear, -0.75f), //P2

            //Morado
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //W1
            new Vector3(0.4f, 0.1f - alinear, -0.75f), //Q2
            new Vector3(0, -0.1f - alinear, -0.75f), //U1

            //Morado
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(-0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(0, -0.1f - alinear, -0.75f), //U1

            //Negro
            new Vector3(0.4f, 0.1f - alinear, -0.75f), //Q2
            new Vector3(0, -0.1f - alinear, -0.75f), //U1
            new Vector3(0, 1 - alinear, -0.75f), //R2

            //Negro
            new Vector3(-0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(0, -0.1f - alinear, -0.75f), //U1
            new Vector3(0, 1 - alinear, -0.75f), //R2

            //Negro
            new Vector3(0.4f, 0.1f - alinear, -0.75f), //Q2
            new Vector3(0, 1 - alinear, -0.75f), //R2
            new Vector3(0.75f, 1 - alinear, -0.75f), //S2

            //Negro
            new Vector3(-0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(0, 1 - alinear, -0.75f), //R2
            new Vector3(-0.75f, 1 - alinear, -0.75f), //T2

            //Negro
            new Vector3(0.4f, 0.1f - alinear, -0.75f), //Q2
            new Vector3(0.75f, 1 - alinear, -0.75f), //S2
            new Vector3(1f, 0.5f - alinear, -0.75f), //O2

            //Negro
            new Vector3(-0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(-0.75f, 1 - alinear, -0.75f), //T2
            new Vector3(-1f, 0.5f - alinear, -0.75f), //N2

            //Negro
            new Vector3(0.75f, 1 - alinear, -0.75f), //S2
            new Vector3(1f, 0.5f - alinear, -0.75f), //O2
            new Vector3(1.4f, 1 - alinear, -0.75f), //M2

            //Negro
            new Vector3(-0.75f, 1 - alinear, -0.75f), //T2
            new Vector3(-1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2

            //Negro
            new Vector3(-0.75f, 1 - alinear, -0.75f), //T2
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(-0.75f, 2 - alinear, -0.75f), //U2

            //Negro
            new Vector3(-0.75f, 1 - alinear, -0.75f), //T2
            new Vector3(0, 1 - alinear, -0.75f), //R2
            new Vector3(0, 2 - alinear, -0.75f), //W2

            //Negro
            new Vector3(0.75f, 1 - alinear, -0.75f), //S2
            new Vector3(0, 1 - alinear, -0.75f), //R2
            new Vector3(0.75f, 2 - alinear, -0.75f), //V2

            //Negro
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(-0.75f, 2 - alinear, -0.75f), //U2
            new Vector3(-1.6f, 1.5f - alinear, -0.75f), //K2

            //Negro
            new Vector3(-0.75f, 1 - alinear, -0.75f), //T2
            new Vector3(-0.75f, 2 - alinear, -0.75f), //U2
            new Vector3(0, 2 - alinear, -0.75f), //W2

            //Negro
            new Vector3(0, 1 - alinear, -0.75f), //R2
            new Vector3(0, 2 - alinear, -0.75f), //W2
            new Vector3(0.75f, 2 - alinear, -0.75f), //V2

            //Negro
            new Vector3(0.75f, 1 - alinear, -0.75f), //S2
            new Vector3(1.4f, 1 - alinear, -0.75f), //M2
            new Vector3(0.75f, 2 - alinear, -0.75f), //V2

            //Negro
            new Vector3(1.4f, 1 - alinear, -0.75f), //M2
            new Vector3(0.75f, 2 - alinear, -0.75f), //V2
            new Vector3(1.6f, 1.5f - alinear, -0.75f), //J2

            //Negro
            new Vector3(-0.75f, 2 - alinear, -0.75f), //U2
            new Vector3(-1.6f, 1.5f - alinear, -0.75f), //K2
            new Vector3(-1.8f, 2.5f - alinear, -0.75f), //I2

            //Negro
            new Vector3(0.75f, 2 - alinear, -0.75f), //V2
            new Vector3(1.6f, 1.5f - alinear, -0.75f), //J2
            new Vector3(1.8f, 2.5f - alinear, -0.75f), //H2

            //Negro
            new Vector3(-1.2f, 3.4f - alinear, -0.75f), //B2
            new Vector3(-1.6f, 3.1f - alinear, -0.75f), //D2
            new Vector3(-0.75f, 3f - alinear, -0.75f), //A3

            //Negro
            new Vector3(-1.2f, 3.4f - alinear, -0.75f), //B2
            new Vector3(-0.75f, 3f - alinear, -0.75f), //A3
            new Vector3(-0.8f, 3.3f - alinear, -0.75f), //F2

            //Negro
            new Vector3(-0.75f, 3f - alinear, -0.75f), //A3
            new Vector3(-0.8f, 3.3f - alinear, -0.75f), //F2
            new Vector3(0, 3f - alinear, -0.75f), //G2

            //Negro
            new Vector3(0, 3f - alinear, -0.75f), //G2
            new Vector3(0.75f, 3f - alinear, -0.75f), //Z3
            new Vector3(0.8f, 3.3f - alinear, -0.75f), //E2

            //Negro
            new Vector3(0.75f, 3f - alinear, -0.75f), //Z3
            new Vector3(0.8f, 3.3f - alinear, -0.75f), //E2
            new Vector3(1.2f, 3.4f - alinear, -0.75f), //A2

            //Negro
            new Vector3(0.75f, 3f - alinear, -0.75f), //Z3
            new Vector3(1.2f, 3.4f - alinear, -0.75f), //A2
            new Vector3(1.6f, 3.1f - alinear, -0.75f), //C2

            //Negro
            new Vector3(-0.75f, 3f - alinear, -0.75f), //A3
            new Vector3(-0.75f, 2 - alinear, -0.75f), //U2
            new Vector3(0, 2 - alinear, -0.75f), //W2

            //Negro
            new Vector3(0, 2 - alinear, -0.75f), //W2
            new Vector3(0.75f, 2 - alinear, -0.75f), //V2
            new Vector3(0.75f, 3f - alinear, -0.75f), //Z3

            //Negro
            new Vector3(-0.75f, 3f - alinear, -0.75f), //A3
            new Vector3(0, 3f - alinear, -0.75f), //G2
            new Vector3(0, 2 - alinear, -0.75f), //W2

            //Negro
            new Vector3(0.75f, 3f - alinear, -0.75f), //Z3
            new Vector3(0, 3f - alinear, -0.75f), //G2
            new Vector3(0, 2 - alinear, -0.75f), //W2

            //Negro
            new Vector3(0.75f, 2 - alinear, -0.75f), //V2
            new Vector3(0.75f, 3f - alinear, -0.75f), //Z3
            new Vector3(1.8f, 2.5f - alinear, -0.75f), //H2

            //Negro
            new Vector3(0.75f, 3f - alinear, -0.75f), //Z3
            new Vector3(1.8f, 2.5f - alinear, -0.75f), //H2
            new Vector3(1.6f, 3.1f - alinear, -0.75f), //C2

            //Negro
            new Vector3(-0.75f, 2 - alinear, -0.75f), //U2
            new Vector3(-1.6f, 3.1f - alinear, -0.75f), //D2
            new Vector3(-0.75f, 3f - alinear, -0.75f), //A3

            //Negro
            new Vector3(-0.75f, 2 - alinear, -0.75f), //U2
            new Vector3(-1.6f, 3.1f - alinear, -0.75f), //D2
            new Vector3(-1.8f, 2.5f - alinear, -0.75f), //I2

            ////////////////////////////////////////////////////////

            //Amarillo
            new Vector3(1.2f, 3.4f - alinear, -0.25f), //XD
            new Vector3(0.8f, 3.3f - alinear, -0.25f), //XD'nt
            new Vector3(1.2f, 4.5f - alinear, -0.5f), //C3

            //Amarillo
            new Vector3(1.6f, 3.1f - alinear, -0.25f), //M1
            new Vector3(1.2f, 3.4f - alinear, -0.25f), //XD
            new Vector3(1.2f, 4.5f - alinear, -0.5f), //C3

            //Amarillo
            new Vector3(1.6f, 3.1f - alinear, -0.25f), //M1
            new Vector3(1.6f, 3.1f - alinear, -0.75f), //C2
            new Vector3(1.2f, 4.5f - alinear, -0.5f), //C3

            //Amarillo
            new Vector3(1.6f, 3.1f - alinear, -0.75f), //C2
            new Vector3(1.2f, 3.4f - alinear, -0.75f), //A2
            new Vector3(1.2f, 4.5f - alinear, -0.5f), //C3

            //Amarillo
            new Vector3(0.8f, 3.3f - alinear, -0.75f), //E2
            new Vector3(1.2f, 3.4f - alinear, -0.75f), //A2
            new Vector3(1.2f, 4.5f - alinear, -0.5f), //C3

            //Amarillo
            new Vector3(0.8f, 3.3f - alinear, -0.75f), //E2
            new Vector3(0.8f, 3.3f - alinear, -0.25f), //XD'nt
            new Vector3(1.2f, 4.5f - alinear, -0.5f), //C3

            //Amarillo
            new Vector3(-1.2f, 3.4f - alinear, -0.25f), //XD2
            new Vector3(-0.8f, 3.3f - alinear, -0.25f), //XD'nt2
            new Vector3(-1.2f, 4.5f - alinear, -0.5f), //B3

            //Amarillo
            new Vector3(-1.6f, 3.1f - alinear, -0.25f), //L1
            new Vector3(-1.2f, 3.4f - alinear, -0.25f), //XD2
            new Vector3(-1.2f, 4.5f - alinear, -0.5f), //B3

            //amarillo
            new Vector3(-1.6f, 3.1f - alinear, -0.75f), //D2
            new Vector3(-1.2f, 4.5f - alinear, -0.5f), //B3
            new Vector3(-1.6f, 3.1f - alinear, -0.25f), //L1

            //Amarillo
            new Vector3(-1.6f, 3.1f - alinear, -0.75f), //D2
            new Vector3(-1.2f, 3.3f - alinear, -0.75f), //B2
            new Vector3(-1.2f, 4.5f - alinear, -0.5f), //B3

            //Amarillo
            new Vector3(-1.2f, 3.3f - alinear, -0.75f), //B2
            new Vector3(-0.8f, 3.1f - alinear, -0.75f), //F2
            new Vector3(-1.2f, 4.5f - alinear, -0.5f), //B3

            //Amarillo
            new Vector3(-0.8f, 3.1f - alinear, -0.75f), //F2
            new Vector3(-1.2f, 4.5f - alinear, -0.5f), //B3
            new Vector3(-1.2f, 3.4f - alinear, -0.25f), //XD2

            //Amarillo
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(0, -0.1f - alinear, -0.25f), //Z1
            new Vector3(-0.8f, -1f - alinear, -0.5f), //E3

            //Amarillo
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(-0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(-0.8f, -1f - alinear, -0.5f), //E3

            //Amarillo
            new Vector3(0, -0.1f - alinear, -0.75f), //U1
            new Vector3(-0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(-0.8f, -1f - alinear, -0.5f), //E3

            //Amarillo
            new Vector3(0, -0.1f - alinear, -0.75f), //U1
            new Vector3(0, -0.1f - alinear, -0.25f), //Z1
            new Vector3(-0.8f, -1f - alinear, -0.5f), //E3

            //Amarillo
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //W1
            new Vector3(0, -0.1f - alinear, -0.25f), //Z1
            new Vector3(0.8f, -1f - alinear, -0.5f), //D3

            //Amarillo
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(0.8f, -1f - alinear, -0.5f), //D3

            //Amarillo
            new Vector3(0, -0.1f - alinear, -0.75f), //U1
            new Vector3(0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(0.8f, -1f - alinear, -0.5f), //D3

            //Amarillo
            new Vector3(0, -0.1f - alinear, -0.75f), //U1
            new Vector3(0, -0.1f - alinear, -0.25f), //Z1
            new Vector3(0.8f, -1f - alinear, -0.5f), //D3

            //Amarillo
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(-1.5f, -0.5f - alinear, -0.5f), //G3

            //Amarillo
            new Vector3(-1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(-1.5f, -0.5f - alinear, -0.5f), //G3

            //Amarillo
            new Vector3(-0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(-1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(-1.5f, -0.5f - alinear, -0.5f), //G3

            //Amarillo
            new Vector3(-0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(-0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(-1.5f, -0.5f - alinear, -0.5f), //G3

            //Amarillo
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(1.5f, -0.5f - alinear, -0.5f), //G3

            //Amarillo
            new Vector3(1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(1.5f, -0.5f - alinear, -0.5f), //G3

            //Amarillo
            new Vector3(0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(1.5f, -0.5f - alinear, -0.5f), //G3

            //Amarillo
            new Vector3(0.4f, 0.1f - alinear, -0.25f), //V1
            new Vector3(0.4f, 0.1f - alinear, -0.75f), //P2
            new Vector3(1.5f, -0.5f - alinear, -0.5f), //G3

            //Amarillo
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(-1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(-2.2f, 0.2f - alinear, -0.5f), //H3

            //Amarillo
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(-1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(-2.2f, 0.2f - alinear, -0.5f), //H3

            //Amarillo
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(-1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(-2.2f, 0.2f - alinear, -0.5f), //H3

            //Amarillo
            new Vector3(-1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(-1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(-2.2f, 0.2f - alinear, -0.5f), //H3

            //Amarillo
            new Vector3(1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(2.2f, 0.2f - alinear, -0.5f), //H3

            //Amarillo
            new Vector3(1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(2.2f, 0.2f - alinear, -0.5f), //H3

            //Amarillo
            new Vector3(1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(2.2f, 0.2f - alinear, -0.5f), //H3

            //Amarillo
            new Vector3(1f, 0.5f - alinear, -0.25f), //R1
            new Vector3(1f, 0.5f - alinear, -0.75f), //N2
            new Vector3(2.2f, 0.2f - alinear, -0.5f), //H3

            //Amarillo
            new Vector3(-1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(-1.6f, 1.5f - alinear, -0.25f), //O1
            new Vector3(-2.6f, 1f - alinear, -0.5f), //K3

            //Amarillo
            new Vector3(-1.6f, 1.5f - alinear, -0.75f), //K2
            new Vector3(-1.6f, 1.5f - alinear, -0.25f), //O1
            new Vector3(-2.6f, 1f - alinear, -0.5f), //K3

            //Amarillo
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(-1.6f, 1.5f - alinear, -0.75f), //K2
            new Vector3(-2.6f, 1f - alinear, -0.5f), //K3

            //Amarillo
            new Vector3(-1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(-1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(-2.6f, 1f - alinear, -0.5f), //K3

            //Amarillo
            new Vector3(1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(1.6f, 1.5f - alinear, -0.25f), //O1
            new Vector3(2.6f, 1f - alinear, -0.5f), //K3

            //Amarillo
            new Vector3(1.6f, 1.5f - alinear, -0.75f), //K2
            new Vector3(1.6f, 1.5f - alinear, -0.25f), //O1
            new Vector3(2.6f, 1f - alinear, -0.5f), //K3

            //Amarillo
            new Vector3(1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(1.6f, 1.5f - alinear, -0.75f), //K2
            new Vector3(2.6f, 1f - alinear, -0.5f), //K3

            //Amarillo
            new Vector3(1.4f, 1f - alinear, -0.25f), //Q1
            new Vector3(1.4f, 1 - alinear, -0.75f), //L2
            new Vector3(2.6f, 1f - alinear, -0.5f), //K3
        };



        meshFilter.mesh.vertices = vertex;

        int[] triangles = {
            0, 1, 2, // front
			3, 4, 5,
            7, 6, 8, // back
			10, 9, 11,
            13, 12, 14, //top
			15, 16, 17,
            19, 18, 20, //bottom
			21, 22, 23,
            24, 25, 26,
            28, 27, 29,
            30, 31, 32,
            34, 33, 35,
            37, 36, 38,
            39, 40, 41,
            42, 43, 44,
            46, 45, 47,
            48, 49, 50,
            52, 51, 53,
            55, 54, 56,
            57, 58, 59,
            61, 60, 62,
            63, 64, 65,
            66, 67, 68,
            70, 69, 71,
            72, 73, 74,
            76, 75, 77,
            78, 79, 80,
            82, 81, 83,
            85, 84, 86,
            88, 87, 89,
            91, 90, 92,
            93, 94, 95,
            97, 96, 98,
            99, 100, 101,
            103, 102, 104,
            105, 106, 107,
            108, 109, 110,
            112, 111, 113,
            114, 115, 116,
            117, 118, 119,
            121, 120, 122,
            123, 124, 125,
            126, 127, 128,
            130, 129, 131,
            133, 132, 134,
            136, 135, 137,
            138, 139, 140,
            142, 141, 143,
            144, 145, 146,
            147, 148, 149,
            151, 150, 152, 
            153, 154, 155,
            157, 156, 158,
            159, 160, 161,
            163, 162, 164,
            165, 166, 167,
            169, 168, 170,
            172, 171, 173,
            174, 175, 176,
            177, 178, 179,
            181, 180, 182,
            183, 184, 185,
            187, 186, 188,
            190, 189, 191,
            192, 193, 194,
            196, 195, 197,
            198, 199, 200,
            202, 201, 203,
            205, 204, 206,
            207, 208, 209,
            210, 211, 212,
            214, 213, 215,
            217, 216, 218,
            219, 220, 221,
            223, 222, 224,
            225, 226, 227,
            229, 228, 230,
            231, 232, 233,
            234, 235, 236,
            238, 237, 239,
            241, 240, 242,
            243, 244, 245,
            247, 246, 248,
            249, 250, 251,
            252, 253, 254,
            256, 255, 257,
            258, 259, 260,
            262, 261, 263,
            264, 265, 266,
            268, 267, 269,
            271, 270, 272,
            273, 274, 275,
            276, 277, 278, 
            280, 279, 281,
            283, 282, 284,
            285, 286, 287,
            288, 289, 290,
            292, 291, 293,
            295, 294, 296,
            297, 298, 299,
            300, 301, 302,
            304, 303, 305,
            306, 307, 308,
            310, 309, 311,
            313, 312, 314,
            315, 316, 317,
            318, 319, 320,
            322, 321, 323,
            325, 324, 326,
            327, 328, 329,
            330, 331, 332,
            334, 333, 335,
            336, 337, 338,
            340, 339, 341,
            342, 343, 344,
            346, 345, 347,
            349, 348, 350,
            351, 352, 353,
            354, 355, 356,
            358, 357, 359,
            360, 361, 362,
            364, 363, 365,
            366, 367, 368,
            369, 370, 371,
            373, 372, 374,
            375, 376, 377,
            378, 379, 380,
            382, 381, 383,
            385, 384, 386,
            388, 387, 389,
            390, 391, 392,
            394, 393, 395,
            396, 397, 398,
            399, 400, 401,
            403, 402, 404,
            406, 405, 407,
            408, 409, 410,
            412, 411, 413,
            414, 415, 416,
            418, 417, 419,
            420, 421, 422,
            424, 423, 425,
            427, 426, 428,
            430, 429, 431,
            432, 433, 434,
            435, 436, 437,
            439, 438, 440,
            441, 442, 443,
            444, 445, 446,
            447, 448, 449,
            451, 450, 452,
            454, 453, 455,
            457, 456, 458,
            459, 460, 461,
            463, 462, 464,
            465, 466, 467,
            469, 468, 470,
            471, 472, 473,
            474, 475, 476,
            478, 477, 479,
            480, 481, 482,
            484, 483, 485,
            486, 487, 488,
            490, 489, 491,
            493, 492, 494,
            496, 495, 497,
            499, 498, 500,
            501, 502, 503,
            504, 505, 506,
            507, 508, 509,
            510, 511, 512,
            514, 513, 515,
            516, 517, 518,
            520, 519, 521,
            523, 522, 524,
            525, 526, 527,
            529, 528, 530,
            531, 532, 533,
            534, 535, 536, 
            538, 537, 539,
            541, 540, 542,
            544, 543, 545,
            547, 546, 548,
            549, 550, 551,
            552, 553, 554,
            555, 556, 557,
        };

        Vector2[] uvs =
        {
            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.6f, 0f), //Verde
            new Vector2(0.6f, 1f), //Verde
            new Vector2(0.8f, 0f), //Verde

            new Vector2(0.6f, 0f), //Verde
            new Vector2(0.6f, 1f), //Verde
            new Vector2(0.8f, 0f), //Verde

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.4f, 0f), //Rojo
            new Vector2(0.4f, 1f), //Rojo
            new Vector2(0.6f, 0f), //Rojo

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.6f, 0f), //Verde
            new Vector2(0.6f, 1f), //Verde
            new Vector2(0.8f, 0f), //Verde

            new Vector2(0.6f, 0f), //Verde
            new Vector2(0.6f, 1f), //Verde
            new Vector2(0.8f, 0f), //Verde

            new Vector2(0.6f, 0f), //Verde
            new Vector2(0.6f, 1f), //Verde
            new Vector2(0.8f, 0f), //Verde

            new Vector2(0.6f, 0f), //Verde
            new Vector2(0.6f, 1f), //Verde
            new Vector2(0.8f, 0f), //Verde

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.2f, 0f), //Morado
            new Vector2(0.2f, 1f), //Morado
            new Vector2(0.4f, 0f), //Morado

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0.8f, 0f), //Negro
            new Vector2(0.8f, 1f), //Negro
            new Vector2(1f, 0f), //Negro

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo

            new Vector2(0f, 0f), //Amarillo
            new Vector2(0f, 1f), //Amarillo
            new Vector2(0.2f, 0f), //Amarillo
        };

        meshFilter.mesh.triangles = triangles;
        meshFilter.mesh.uv = uvs;
        meshFilter.mesh.Optimize();
        meshFilter.mesh.RecalculateNormals();

    }

}
