using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    /// <summary>
    /// ���
    /// </summary>
    /// <param name="dialogNPC">��ܤ��e</param>
    private void Dialog(string dialogNPC)
    {

    }

    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns></returns>
    public bool OpenShop()
    {
        return true;
    }

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="itemMoney">�D�����</param>
    /// <returns></returns>
    public int BuyItem(int itemMoney = 100)
    {
        return 0;
    }

    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="taskID">���Ƚs��</param>
    public void GetTask(int taskID)
    {

    }

    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="getTaskItemQuantity">���o���ȹD��ƶq</param>
    /// <returns></returns>
    private int TaskRenew(int getTaskItemQuantity = 1)
    {
        return 0;
    }

    /// <summary>
    /// ���ȧ���
    /// </summary>
    /// <param name="taskID">���Ƚs��</param>
    /// <returns></returns>
    private bool TaskEnd(int taskID)
    {
        return false;
    }

}
