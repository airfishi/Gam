using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    bool is_inv_open = false;
    bool is_esc_open = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(is_inv_open)
            {
                is_inv_open = false;
                CloseInventory();
            } else
            {
                is_inv_open = true;
                OpenInventory();
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (is_esc_open || is_inv_open)
            {
                is_esc_open = false;
                CloseEsc();
                CloseInventory();
            }
            else
            {
                is_esc_open = true;
                OpenEsc();
            }

        }
    }

    void OpenInventory()
    {
    }

    void CloseInventory()
    {
    }

    void OpenEsc()
    {
    }

    void CloseEsc()
    {
    }
}
