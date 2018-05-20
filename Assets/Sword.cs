using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
	private Vector3 preMousePos;
    void Start()
    {
		preMousePos = Input.mousePosition;
    }
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 deltaMouse = mousePos - preMousePos;
        transform.Rotate(0, deltaMouse.x * 0.1f, deltaMouse.y * -0.1f);
        preMousePos = mousePos;
    }
}
