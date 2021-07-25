using UnityEngine;

public class NPC : MonoBehaviour
{
    #region KID Unity �@�~ 05:    �m�� C# NPC ��k�w�q
    // ------------- �}�l���νu ------------- //

    private void Start()
    {

        TaskUpdate(0);
        BuyProp(0);

    }

    // ------------- �p�H���νu ------------- //

    /// <summary>
    /// ���
    /// </summary>
    /// <param name="bocadillo">��ܪ����e</param>
    private void AddChat( string bocadillo)
    {
       
    }
    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="taskprop">��o���ȹD��ƶq�w�]�� 1</param>
    private void TaskUpdate(int taskprop = 1)
    {
        print("��o���ȹD��ƶq�G" + taskprop);
    }
    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="tasknumber">���Ƚs��</param>
    private bool MissionAccomplished()
    {
        return false;
    }

    // ------------- ���}���νu ------------- //

    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns>�O�_�}�����w�}��</returns>
    public bool OpenStore()
    {
        return true;
    }
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="propvalue">�D������w�]�� 100</param>
    public void BuyProp(int propvalue = 100)
    {
        print("�ʶR�D��:" + propvalue);
    }
    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="tasknumber">���Ƚs��</param>
    public void GetTask(string tasknumber)
    {
        print("���o����:" + tasknumber);
    }




    #endregion
}
