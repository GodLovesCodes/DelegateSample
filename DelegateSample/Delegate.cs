using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    public delegate int Calculate(int x, int y);
    public Calculate myCalculate;

    private void Start()
    {
        DoCalculate(2, 5, Add);
        DoCalculate(4, 7, Multiply);

        // lambda expression
        Calculate calculate = new Calculate((a, b) => { return a - b; });
        print(calculate(9, 3));

        // event handler
        myCalculate += Add;
        myCalculate += Multiply;
        myCalculate -= Multiply;
        myCalculate(3, 8);
    }

    private void DoCalculate(int x, int y, Calculate calculate)
    {
        int result = calculate(x, y);
        print($"cal : {result}");
    }

    private int Add(int x, int y)
    {
        print($"x + y = {x + y}");
        return x + y;
    }

    private int Multiply(int x, int y)
    {
        print($"x * y = {x * y}");
        return x * y;
    }
}
