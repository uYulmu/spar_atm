using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DepositBtn : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("ATMDeposit");
    }
}
