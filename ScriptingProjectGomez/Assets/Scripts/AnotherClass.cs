using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour

{
    public int apples;
    public int bananas;

    int stapler;
    int sellotape;

    public void FruitMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit Total: " + answer);
    }

    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies Total: " + answer);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
