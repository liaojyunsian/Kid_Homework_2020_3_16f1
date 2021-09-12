using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    /// <summary>
    /// 對話
    /// </summary>
    /// <param name="dialogNPC">對話內容</param>
    private void Dialog(string dialogNPC)
    {

    }

    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns></returns>
    public bool OpenShop()
    {
        return true;
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="itemMoney">道具價格</param>
    /// <returns></returns>
    public int BuyItem(int itemMoney = 100)
    {
        return 0;
    }

    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="taskID">任務編號</param>
    public void GetTask(int taskID)
    {

    }

    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="getTaskItemQuantity">取得任務道具數量</param>
    /// <returns></returns>
    private int TaskRenew(int getTaskItemQuantity = 1)
    {
        return 0;
    }

    /// <summary>
    /// 任務完成
    /// </summary>
    /// <param name="taskID">任務編號</param>
    /// <returns></returns>
    private bool TaskEnd(int taskID)
    {
        return false;
    }

}
