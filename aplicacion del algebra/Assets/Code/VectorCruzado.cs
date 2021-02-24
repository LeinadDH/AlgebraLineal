using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCruzado : MonoBehaviour
{
    public Vector3 Figura1, Figura2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Cruzado(Figura1,Figura2));
    }

    public Vector3 Cruzado( Vector3 figura1, Vector3 figura2)
    {
        Vector3 resultado;

        resultado.x = (figura1.y * figura2.z) - (figura1.z * figura2.y);
        resultado.y = (figura1.z * figura2.x) - (figura1.x * figura2.z);
        resultado.z = (figura1.x * figura2.y) - (figura1.y * figura2.x);

        return resultado;

    }
}
