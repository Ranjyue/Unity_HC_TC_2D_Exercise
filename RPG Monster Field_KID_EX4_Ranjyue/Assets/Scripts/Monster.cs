using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    #region ���
    [Header("���ʳt��"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("�����O"), Range(0, 500)]
    public int Attack = 100;
    [Header("��q"), Range(0, 5000)]
    public float hp = 350;
    [Header("�����D��"), Tooltip("�O�_����") ]
    public string prop = "�C������";
    public bool onFloor =false;
    [Header("�����D����v"), Range(0, 1)]
    public float propsprobabilidades =1;


    private AudioClip AudioClip;
    [Header("�����D�㭵��")]
    public bool propsound;
    private AudioSource AudioSource;
    private Rigidbody2D Rigidbody2D;
    private Animator animator;


    #endregion
}
