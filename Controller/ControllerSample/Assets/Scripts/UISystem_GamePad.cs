using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UISystem_GamePad : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.JoystickButton0)) image_A.GetComponent<Image>().color = Color.gray;
        else                                       image_A.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.JoystickButton1)) image_B.GetComponent<Image>().color = Color.gray;
        else                                       image_B.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.JoystickButton2)) image_X.GetComponent<Image>().color = Color.gray;
        else                                       image_X.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.JoystickButton3)) image_Y.GetComponent<Image>().color = Color.gray;
        else                                       image_Y.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.JoystickButton4)) image_LB.GetComponent<Image>().color = Color.gray;
        else                                       image_LB.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.JoystickButton5)) image_RB.GetComponent<Image>().color = Color.gray;
        else                                       image_RB.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.JoystickButton6)) image_Back.GetComponent<Image>().color = Color.gray;
        else                                       image_Back.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.JoystickButton7)) image_Start.GetComponent<Image>().color = Color.gray;
        else                                       image_Start.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.JoystickButton8)) image_LeftStick.GetComponent<Image>().color = Color.gray;
        else                                       image_LeftStick.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.JoystickButton9)) image_RightStick.GetComponent<Image>().color = Color.gray;
        else                                       image_RightStick.GetComponent<Image>().color = Color.white;

        slider_XAxis.GetComponent<Slider>().value = Input.GetAxis("X axis");
        slider_YAxis.GetComponent<Slider>().value = Input.GetAxis("Y axis");
        slider_3rdAxis.GetComponent<Slider>().value = Input.GetAxis("3rd axis");
        slider_4thAxis.GetComponent<Slider>().value = Input.GetAxis("4th axis");
        slider_5thAxis.GetComponent<Slider>().value = Input.GetAxis("5th axis");
        slider_6thAxis.GetComponent<Slider>().value = Input.GetAxis("6th axis");
        slider_7thAxis.GetComponent<Slider>().value = Input.GetAxis("7th axis");
    }

    //---public----------------------------------------------------
    /// <summary>
    /// Button_toKeyBoard
    /// </summary>
    public void OnToKeyBoard()
    {
        SceneManager.LoadScene("KeyBoard");
    }

    //---private---------------------------------------------------
    [SerializeField] private GameObject image_A;
    [SerializeField] private GameObject image_B;
    [SerializeField] private GameObject image_X;
    [SerializeField] private GameObject image_Y;
    [SerializeField] private GameObject image_LB;
    [SerializeField] private GameObject image_RB;
    [SerializeField] private GameObject image_Back;
    [SerializeField] private GameObject image_Start;
    [SerializeField] private GameObject image_LeftStick;
    [SerializeField] private GameObject image_RightStick;
    [SerializeField] private GameObject slider_XAxis;
    [SerializeField] private GameObject slider_YAxis;
    [SerializeField] private GameObject slider_3rdAxis;
    [SerializeField] private GameObject slider_4thAxis;
    [SerializeField] private GameObject slider_5thAxis;
    [SerializeField] private GameObject slider_6thAxis;
    [SerializeField] private GameObject slider_7thAxis;
}