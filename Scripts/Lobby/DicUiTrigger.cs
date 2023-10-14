using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicUiTrigger : MonoBehaviour
{
    public GameObject DicUi;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && other.gameObject.GetComponent<PhotonView>().IsMine)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None; // 마우스 커서 락
            DicUi.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && other.gameObject.GetComponent<PhotonView>().IsMine)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked; // 마우스 커서 락
            DicUi.SetActive(false);
        }
    }
}
