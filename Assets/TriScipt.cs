using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriScipt : MonoBehaviour
{
    public GameObject tri;
    public GameObject cube;
    [SerializeField]
    public bool IsOn = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsOn)
        {
            transform.Rotate(Vector3.up * 100 * Time.deltaTime);

            if (cube != null)
            {
                cube.transform.Rotate(Vector3.up * 100 * Time.deltaTime);
            }
        }
    }

    public void Toggle()
    {
        IsOn = !IsOn;
    }
}
