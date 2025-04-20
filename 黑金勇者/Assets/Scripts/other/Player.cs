using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //移動 跳躍
    [SerializeField] private float MoveSpeed=10;

    private bool facingRight;
    public float JumpImpulse = 7f;
    public ContactFilter2D ContactFilter;
    private bool m_ShouldJump;
    private float m_SideSpeed;
    public bool IsGrounded => myRbody.IsTouching(ContactFilter);
    public float AgainstGravityScale = 1f;
    public float FallGravityScale = 2f;
    public bool C3Walk;
    //玩家的HP
    public int HP;
    public Image[] heart;

    //結局
    public GameObject gameover;

    private Rigidbody2D myRbody;
    private Animator ani;
    private GM GM;
    private SE SE;
    private SE2 SE2;
    private BGM BGM;
    private float 播放秒數, 停止播放秒數 = 0.5f;

    //特效
    public GameObject box,PS1, PS2;

    private Achievement SA;

    void Start(){
        myRbody = GetComponent<Rigidbody2D> ();
        ani = GetComponent<Animator> ();
        GM = GameObject.Find("GM").GetComponent<GM>();
        SE = GameObject.Find("SE").GetComponent<SE>();
        SE2 = GameObject.Find("SE2").GetComponent<SE2>();
        BGM = GameObject.Find("BGM").GetComponent<BGM>();
        SA = GameObject.Find("GM").GetComponent<Achievement>();

        C3Walk = true;
    }
    void Update()
    {
        if (GM.controls == true)
        {
            if(C3Walk == true)
            {
                if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                {
                    m_ShouldJump = true;
                    //ani.SetTrigger("Jump");
                }

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    ani.SetTrigger("Attack");
                }
            }
        }
        else
        {
            ani.SetFloat("Walk", 0);
            myRbody.velocity = new Vector2(0 * MoveSpeed, myRbody.velocity.y);
        }
    }
    void FixedUpdate () 
    {
        if (GM.controls == true)
        {
            if (C3Walk == true)
            {
                float H = Input.GetAxis("Horizontal");
                ani.SetFloat("Walk", Mathf.Abs(H));
                myRbody.velocity = new Vector2(H * MoveSpeed, myRbody.velocity.y);
                Flip(H);
            }
        }


        if (m_ShouldJump && IsGrounded)
        {
            myRbody.AddForce(Vector2.up * JumpImpulse, ForceMode2D.Impulse);
            myRbody.velocity = new Vector2(m_SideSpeed, myRbody.velocity.y);
            m_ShouldJump = false;
            m_SideSpeed = 0f;
        }
        var direction = Vector2.Dot(myRbody.velocity, Physics2D.gravity);
        myRbody.gravityScale = direction > 0f ? FallGravityScale : AgainstGravityScale;
    }
    


    private void Flip(float h){
        if (h < 0 && !facingRight || h > 0 && facingRight) {
            facingRight = !facingRight;
            Vector3 scale=transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }

    public void 補血(int 增加量)
    {
        HP += 增加量;
        if (HP > 10) HP = 10;
        GameObject m = Instantiate(PS1, transform.position, transform.rotation);
        m.transform.parent = box.transform;
        更新生命圖片(HP);
    }

    public void 受傷(int 傷害值){
        ani.SetTrigger("Hit");
        HP -= 傷害值;
        更新生命圖片(HP);
        if (HP <= 0)
        {
            Playerdead();
        }
    }

    public void 更新生命圖片(int 目前生命值){
        for (int i = 0; i < heart.Length; i++){
            if (i < 目前生命值){
                heart[i].enabled = true;
            }
            else{
                heart[i].enabled = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == "DEADZONE"){
            Playerdead();
        }
        if (coll.gameObject.tag == "木板")
        {
            SE2.PLAYboard();
        }
        if (coll.gameObject.tag == "水上木板")
        {
            SE.PLAYboardwater();
        }
        if (coll.gameObject.tag == "地板")
        {
            Instantiate(PS2, transform.position, transform.rotation);
        }
        if (coll.gameObject.tag == "青苔")
        {
            if (Time.time >= 播放秒數)
            {
                SE.PLAYmoss();
                播放秒數 = Time.time + 停止播放秒數;
            }
        }
    }

    void Playerdead()
    {
        BGM.PLAYgameover();
        SA.Death();
        gameover.SetActive(true);
        Destroy(gameObject);
    }

    public void Sound()
    {
        SE2.PLAYatt();
    }
}
