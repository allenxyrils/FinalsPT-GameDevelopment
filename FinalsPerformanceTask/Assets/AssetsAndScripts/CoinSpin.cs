using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    public Vector3 RotateAmount;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(RotateAmount);
    }

}
