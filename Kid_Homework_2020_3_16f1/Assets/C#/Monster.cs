using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �Ǫ����O
/// �x�s�Ǫ����
/// </summary>
public class Monster : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("�����O"), Range(0, 500)]
    public float attack = 100f;
    [Header("��q"), Range(0, 5000)]
    public float hp = 350f;
    [Header("�l�ܽd��"), Range(0, 50)]
    public float trackingRange = 30;
    [Header("�l�ܦ첾(����)(�T���V�q)")]
    public Vector3 v3TrackingOffset;
    [Header("�����D��(GameObject)")]
    public GameObject dropitem;
    [Header("�����D����v"),Range(0,1)]
    public float dropitemChance;
    [Header("�����D�㭵��")]
    public AudioClip dropitemSound;
    [Header("���˭���")]
    public AudioClip damageSound;
    [Header("��������")]
    public AudioClip attackSound;


    private AudioSource audioSource;
    private Rigidbody2D rigidbody2D_1;
    private Animator animator;
}
