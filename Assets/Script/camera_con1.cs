using UnityEngine;
using System.Collections;

public class camera_con1 : MonoBehaviour {

    public float rotate_speed = 20;

    public GameObject myCamera;
    private float mouse_x;

    // Use this for initialization
    void Start () {
        mouse_x = myCamera.transform.eulerAngles.x;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float r = Input.GetAxisRaw("Mouse X");
        float u = Input.GetAxisRaw("Mouse Y");

        rotate_camera_x(r);
        rotate_camera_y(u);
    }

    void rotate_camera_x(float r)
    {
        transform.Rotate(Vector3.up, r * rotate_speed);
    }

    void rotate_camera_y(float u)
    {
        mouse_x -= u * rotate_speed;           //计算当前摄像机的旋转角度
        myCamera.gameObject.GetComponent<Transform>().transform.localEulerAngles = new Vector3(mouse_x, 0.0f, 0.0f);	//设置摄像机的旋转角度
    }
}
