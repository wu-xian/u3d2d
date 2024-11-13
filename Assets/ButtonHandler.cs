using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 引入UI命名空间
using UnityEngine.EventSystems;


public class ButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private int counter = 0;
    private bool isDown = false;


    [SerializeField]
    private Button button233;
    // Start is called before the first frame update
    void Start()
    {
        /*
        var dbgBtn = base.GetComponent<ButtonDBG>();

        ButtonDBG.onClick.AddListener(OnBtnClick);
        */
        Debug.Log("aaaaaaaaa");
        button233.onClick.AddListener(OnButtonClick); ;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDown)
        {
            counter += 1;
            Debug.LogFormat("counter:{0}", counter);

            var bbb = GameObject.FindGameObjectWithTag("bbb");
            if (bbb != null)
            {
                var renderer = bbb.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.material.color = new Color(counter / 300 % 0xff, counter / 500 % 0xff, counter / 700 % 0xff);

                }
            }
        }
    }

    public void OnButtonClick()
    {
        Debug.Log("按钮被点击了！");
        // 在这里添加你想要执行的操作
        var obj = GameObject.FindGameObjectWithTag("aaa");
        Debug.Log(obj);
        obj.transform.Rotate(Vector3.up * 100 * Time.deltaTime);

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        var bbb = GameObject.FindGameObjectWithTag("bbb");
        if (bbb != null)
        {
            bbb.GetComponent<Rigidbody2D>().AddForce(Vector2.up * counter);
            counter = 0;
        }
        isDown = false;
    }
}
