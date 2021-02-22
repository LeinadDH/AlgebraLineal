using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Calculadora : MonoBehaviour
{
    [SerializeField]
    Text Input;

    public GameObject Figura, Figura2;
    string InputString;
    double[] number = new double[2];
    string operatorSymbol;
    double resultado;
    bool DisplayResultado = false;
    string temp = "";
    double Arg;
    double temp1, temp2;
    public float x, y, z, respuesta, potencia, normalizarX, normalizarY, normalizarZ, potencia2, respuesta2, x2, y2, z2, distancia;
    

    public void Buttons()
    {

        if (DisplayResultado == true)
        {
            Input.text = "";
            InputString = "";
            DisplayResultado = false;
        }

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;

        InputString += buttonValue;



        if (double.TryParse(buttonValue, out Arg))
        {

            temp = temp + buttonValue;
            Debug.Log(buttonValue);
            Debug.Log(temp);

        }

        else
        {
            switch (buttonValue)
            {
                case "+":
                    operatorSymbol = buttonValue;
                    double.TryParse(temp, out temp1);
                    number[0] = temp1;
                    temp = "";
                    break;
                case "-":
                    operatorSymbol = buttonValue;
                    double.TryParse(temp, out temp1);
                    number[0] = temp1;
                    temp = "";
                    break;
                case "x":
                    operatorSymbol = buttonValue;
                    double.TryParse(temp, out temp1);
                    number[0] = temp1;
                    temp = "";
                    break;
                case "/":
                    operatorSymbol = buttonValue;
                    double.TryParse(temp, out temp1);
                    number[0] = temp1;
                    temp = "";
                    break;

                case "=":
                    switch (operatorSymbol)
                    {
                        case "+":
                            double.TryParse(temp, out temp2);
                            number[1] = temp2;
                            resultado = number[0] + number[1];
                            temp = "";
                            break;
                        case "-":
                            double.TryParse(temp, out temp2);
                            number[1] = temp2;
                            resultado = number[0] - number[1];
                            temp = "";
                            break;
                        case "x":
                            double.TryParse(temp, out temp2);
                            number[1] = temp2;
                            resultado = number[0] * number[1];
                            temp = "";
                            break;
                        case "/":
                            double.TryParse(temp, out temp2);
                            number[1] = temp2;
                            resultado = number[0] / number[1];
                            temp = "";
                            break;
                    }

                    DisplayResultado = true;
                    InputString = resultado.ToString();
                    break;

            }

            

        }

        Input.text = InputString;

    }

    public void Update()
    {
        potencia = (x * x) + (y * y) + (z * z);
        respuesta = Mathf.Sqrt(potencia);
        normalizarX = x/ respuesta;
        normalizarY = y / respuesta;
        normalizarZ = z / respuesta;

        potencia2 = ((x - x2) * (x - x2)) + ((y - y2) * (y - y2)) + ((z - z2) * (z - z2));
        distancia = Mathf.Sqrt(potencia2);


        figura();
    }

    void figura()
    {
        x = Figura.transform.position.x;
        y = Figura.transform.position.y;
        z = Figura.transform.position.z;

        x2 = Figura2.transform.position.x;
        y2 = Figura2.transform.position.y;
        z2 = Figura2.transform.position.z;
    }
}
