using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WithdrawBtn : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("ATMWithdraw");
    }
}
