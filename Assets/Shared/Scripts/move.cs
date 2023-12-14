using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class move : MonoBehaviour
{
    float vertical;
    float horizontal;
    float speed;
    Rigidbody2D rb;
    public float jumpPower = 10f;
    Animator anm;
    Vector2 look;
    public GameObject bulletPrefab;
    int health;
    int maxHealth = 5;
    bool isInvincible = false;
    float invincibleTime = 1;
    float invicibleTimmer;





    void Start()
    {
        health = maxHealth;
        speed = 10.0f;
        rb = GetComponent<Rigidbody2D>();
        anm = GetComponent<Animator>();
        look = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateController();
        UpdateAnimation();
        HeathUI.GetInstance().Change(health);

    }


    void Jump()
    {
        if (!isOnGround())
        {
            Debug.Log("xin cha");
            return;
        }
       
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + jumpPower);

    }


    void UpdateController()
    {
        horizontal = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * horizontal, rb.velocity.y);


        if (Input.GetKeyDown(KeyCode.Space))
            Jump();

        if (!Mathf.Approximately(rb.velocity.x, 0.0f))
        {
            look = new Vector2(rb.velocity.x, 0);
            look.Normalize();
        }
        if (Input.GetKeyDown(KeyCode.C) && GameConfig.GetInstance().UseStar())
        {
            Launch();
        }
        if (isInvincible)
            invicibleTimmer -= Time.deltaTime;
        if (invicibleTimmer < 0)
            isInvincible = false;
    }

    void UpdateAnimation()
    {

        anm.SetFloat("lookx", look.x);
        anm.SetFloat("looky", 0);
        anm.SetFloat("vx", rb.velocity.x);
        anm.SetFloat("vy", rb.velocity.y);
    }


    void Launch()
    {
        GameObject bulletObject = Instantiate(bulletPrefab, rb.position, Quaternion.identity);
        Bullet bullet = bulletObject.GetComponent<Bullet>();
        bullet.Launch(look, 500);
    }


    bool isOnGround()
    {
        bool mid = Physics2D.Raycast(rb.position + Vector2.left, Vector2.down, 1.9f, LayerMask.GetMask("Ground"));
        bool left = Physics2D.Raycast(rb.position, Vector2.down, 1.9f, LayerMask.GetMask("Ground"));
        bool right = Physics2D.Raycast(rb.position + Vector2.right, Vector2.down, 1.9f, LayerMask.GetMask("Ground"));
        return mid || left || right;
    }


    public void ChangeHealth(int h)
    {
        if(h > 0)
        {
            health = Mathf.Clamp(health + h, 0, 100);
            
        }
        else
        {
            if (isInvincible)
                return;
            anm.SetTrigger("hurt");
            health = Mathf.Clamp(health + h, 0, 100);
            isInvincible = true;
            invicibleTimmer = invincibleTime;
            rb.velocity = new Vector2(0,0);
        }
        Debug.Log(health);
    }



    public int getCurrentHealth()
    {
        return health;
    }

    public int getMaxHealth()
    {
        return maxHealth;
    }


}