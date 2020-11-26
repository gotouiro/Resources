using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UISystem_keyBoard : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))           image_A.GetComponent<Image>().color = Color.gray;
        else                                   image_A.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.B))           image_B.GetComponent<Image>().color = Color.gray;
        else                                   image_B.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.C))           image_C.GetComponent<Image>().color = Color.gray;
        else                                   image_C.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.D))           image_D.GetComponent<Image>().color = Color.gray;
        else                                   image_D.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.E))           image_E.GetComponent<Image>().color = Color.gray;
        else                                   image_E.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.Space))       image_Space.GetComponent<Image>().color = Color.gray;
        else                                   image_Space.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.LeftControl)) image_Ctrl.GetComponent<Image>().color = Color.gray;
        else                                   image_Ctrl.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.LeftShift))   image_Shift.GetComponent<Image>().color = Color.gray;
        else                                   image_Shift.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.Escape))      image_Esc.GetComponent<Image>().color = Color.gray;
        else                                   image_Esc.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.LeftAlt))     image_Alt.GetComponent<Image>().color = Color.gray;
        else                                   image_Alt.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.F1))          image_F1.GetComponent<Image>().color = Color.gray;
        else                                   image_F1.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.F2))          image_F2.GetComponent<Image>().color = Color.gray;
        else                                   image_F2.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.F3))          image_F3.GetComponent<Image>().color = Color.gray;
        else                                   image_F3.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.F4))          image_F4.GetComponent<Image>().color = Color.gray;
        else                                   image_F4.GetComponent<Image>().color = Color.white;

        if (Input.GetKey(KeyCode.F5))          image_F5.GetComponent<Image>().color = Color.gray;
        else                                   image_F5.GetComponent<Image>().color = Color.white;

        if (Input.GetMouseButton(0))           image_M0.GetComponent<Image>().color = Color.gray;
        else                                   image_M0.GetComponent<Image>().color = Color.white;

        if (Input.GetMouseButton(1))           image_M1.GetComponent<Image>().color = Color.gray;
        else                                   image_M1.GetComponent<Image>().color = Color.white;

        if (Input.GetMouseButton(2))           image_M2.GetComponent<Image>().color = Color.gray;
        else                                   image_M2.GetComponent<Image>().color = Color.white;

        if (Input.GetMouseButton(3))           image_M3.GetComponent<Image>().color = Color.gray;
        else                                   image_M3.GetComponent<Image>().color = Color.white;

        if (Input.GetMouseButton(4))           image_M4.GetComponent<Image>().color = Color.gray;
        else                                   image_M4.GetComponent<Image>().color = Color.white;

    }

    //---public-------------------------------------------------
    /// <summary>
    /// Button_toGamePad
    /// </summary>
    public void OnToGamePad()
    {
        SceneManager.LoadScene("GamePad");
    }

    //---private------------------------------------------------
    [SerializeField] private GameObject image_A;
    [SerializeField] private GameObject image_B;
    [SerializeField] private GameObject image_C;
    [SerializeField] private GameObject image_D;
    [SerializeField] private GameObject image_E;
    [SerializeField] private GameObject image_Space;
    [SerializeField] private GameObject image_Ctrl;
    [SerializeField] private GameObject image_Shift;
    [SerializeField] private GameObject image_Esc;
    [SerializeField] private GameObject image_Alt;
    [SerializeField] private GameObject image_F1;
    [SerializeField] private GameObject image_F2;
    [SerializeField] private GameObject image_F3;
    [SerializeField] private GameObject image_F4;
    [SerializeField] private GameObject image_F5;
    [SerializeField] private GameObject image_M0;
    [SerializeField] private GameObject image_M1;
    [SerializeField] private GameObject image_M2;
    [SerializeField] private GameObject image_M3;
    [SerializeField] private GameObject image_M4;
}