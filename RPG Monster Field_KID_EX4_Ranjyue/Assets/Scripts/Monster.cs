using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public int Attack = 100;
    [Header("血量"), Range(0, 5000)]
    public float hp = 350;
    [Header("掉落道具"), Tooltip("是否掉落") ]
    public string prop = "遊戲物件";
    public bool onFloor =false;
    [Header("掉落道具機率"), Range(0, 1)]
    public float propsprobabilidades =1;


    private AudioClip AudioClip;
    [Header("掉落道具音效")]
    public bool propsound;
    private AudioSource AudioSource;
    private Rigidbody2D Rigidbody2D;
    private Animator animator;


    #endregion
}
