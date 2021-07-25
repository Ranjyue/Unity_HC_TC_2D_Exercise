using UnityEngine;

public class NPC : MonoBehaviour
{
    #region KID Unity 作業 05:    練習 C# NPC 方法定義
    // ------------- 開始分割線 ------------- //

    private void Start()
    {

        TaskUpdate(0);
        BuyProp(0);

    }

    // ------------- 私人分割線 ------------- //

    /// <summary>
    /// 對話
    /// </summary>
    /// <param name="bocadillo">對話的內容</param>
    private void AddChat( string bocadillo)
    {
       
    }
    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="taskprop">獲得任務道具數量預設為 1</param>
    private void TaskUpdate(int taskprop = 1)
    {
        print("獲得任務道具數量：" + taskprop);
    }
    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="tasknumber">任務編號</param>
    private bool MissionAccomplished()
    {
        return false;
    }

    // ------------- 公開分割線 ------------- //

    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns>是否開店為已開啟</returns>
    public bool OpenStore()
    {
        return true;
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="propvalue">道具價錢預設為 100</param>
    public void BuyProp(int propvalue = 100)
    {
        print("購買道具:" + propvalue);
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="tasknumber">任務編號</param>
    public void GetTask(string tasknumber)
    {
        print("取得任務:" + tasknumber);
    }




    #endregion
}
