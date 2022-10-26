using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatements : MonoBehaviour
{
    float coffeeTemp = 85.0f;
    float hLim = 70.0f;
    float cLim = 40.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            tempTest();

        coffeeTemp -= Time.deltaTime * 5f;
    }

    void tempTest()
    {
        if (coffeeTemp > hLim)
        {
            print("Coffee is far too hot!");
        }
        else if (coffeeTemp < cLim)
        {
            print("Coffee is far too cold!");
        }
        else
        {
            print("Coffee is ready to drink!");
        }
    }
}
