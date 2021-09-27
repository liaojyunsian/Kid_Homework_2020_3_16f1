using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 怪物類別
/// 儲存怪物資料
/// </summary>
public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public float attack = 100f;
    [Header("血量"), Range(0, 5000)]
    public float hp = 350f;
    [Header("追蹤範圍"), Range(0, 50)]
    public float trackingRange = 30;
    [Header("追蹤位移(偏移)(三維向量)")]
    public Vector3 v3TrackingOffset;
    [Header("掉落道具(GameObject)")]
    public GameObject dropitem;
    [Header("掉落道具機率"),Range(0,1)]
    public float dropitemChance;
    [Header("掉落道具音效")]
    public AudioClip dropitemSound;
    [Header("受傷音效")]
    public AudioClip damageSound;
    [Header("攻擊音效")]
    public AudioClip attackSound;


    private AudioSource audioSource;
    private Rigidbody2D rigidbody2D_1;
    private Animator animator;
}
