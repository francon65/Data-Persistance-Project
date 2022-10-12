using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] TMP_InputField tMP_InputField;
    public void LoadScene()
    {
        Manager.PlayerName = tMP_InputField.text;
        SceneManager.LoadScene(1);
    }
}
