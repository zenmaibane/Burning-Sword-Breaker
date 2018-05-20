using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject breakPrefab;
    void OnCollisionEnter(Collision c)
    {
        Instantiate(breakPrefab, gameObject.transform.position, breakPrefab.transform.rotation);
        Destroy(gameObject, 0.05f);
    }
}
