using UnityEngine;
using UnityEngine.SceneManagement;

public class UISystem_top : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //---public-------------------------------------------------
    /// <summary>
    /// Button_toKeyBoard
    /// </summary>
    public void OnToKeyBoard()
    {
        SceneManager.LoadScene("KeyBoard");
    }

    /// <summary>
    /// Button_toGamePad
    /// </summary>
    public void OnToGamePad()
    {
        SceneManager.LoadScene("GamePad");
    }

    //---private------------------------------------------------

}