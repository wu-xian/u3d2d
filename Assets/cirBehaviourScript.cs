using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cirBehaviourScript : MonoBehaviour
{
    public GameObject cir;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cir != null)
        {
            // cir.transform.Translate(0f, -0.01f, 0f);

            var rb = GetComponent<Rigidbody>();
            if (cir.transform.position.y <= -20f)
            {
                cir.transform.position = new Vector3(2f, 10f, 0f);
                if (rb != null)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                    rb.drag = 10f;  // 高阻力，适合立即停止物体
                }
            }
            // else
            // {
            //     rb.drag = 0f;
            // }
        }
    }
}
