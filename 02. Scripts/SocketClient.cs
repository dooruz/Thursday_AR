using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BestHTTP.SocketIO3;
using BestHTTP.SocketIO3.Events;


public class SocketClient : MonoBehaviour
{
    [SerializeField] private string Address = "";
    private SocketManager socketManager = null;
    object test;
    public Animator anim;
    //anim = CharacterController;
    //string ttt;
    public Text FullText;
    public Text ConvoText;

    public GameObject character;
    public GameObject nreaCam;

    private void Start()
    {
        SocketIO3Connect();
        anim = GetComponent<Animator>();

        ConvoText.text = "자음모음";
        FullText.text = "안녕하세요 아이(Aei)입니다!";

        Debug.Log("통역 시작");
    }

    private void SocketIO3Connect()
    {
        SocketOptions options = new SocketOptions();
        options.AutoConnect = false;

        socketManager = new SocketManager(new System.Uri(Address), options);
        socketManager.Open();

        socketManager.Socket.On<ConnectResponse>(SocketIOEventTypes.Connect, OnConnected);
        socketManager.Socket.On("PlayerConnected", PlayerConnected);
        socketManager.Socket.On<string>("message", OnMessage);
        socketManager.Socket.On<string>("message", OnFullmessage);
        //socketManager.Socket.On<string>("message", (arg) => Debug.Log(arg));  //?????? ?????? ??????

    }
      private void OnConnected(ConnectResponse res)
    {
        Debug.Log("Connected! Socket.IO");
    }

    private void PlayerConnected()
    {
        Debug.Log("Player Connected!!");
    }

    private void Update()
    {
        character.transform.position = new Vector3(nreaCam.transform.position.x,
            nreaCam.transform.position.y, nreaCam.transform.position.z );

        //character.transform.Rotate(new Vector3(nreaCam.transform.rotation.x, nreaCam.transform.rotation.y, nreaCam.transform.rotation.z), Space.World);
        character.transform.rotation = nreaCam.transform.rotation;
        //character.transform.LookAt(nreaCam.transform);

    }

    void OnFullmessage(string message)
    {
        FullText.text = message;

    }

    void OnMessage(string message)
    {
        //Debug.Log("Text Message received from server: " + message);

        if (message != null)
        {
            //FullText.text = message;
            //ConvoText.text = message;

            // 자음
            // ㄱ
            if (message == "ㄱ")
            {
                anim.SetInteger("idle", 1);
                Debug.Log("기역");
                
            }
            // ㄴ 
            else if (message == "ㄴ")
            {
                Debug.Log("니은");
                anim.SetInteger("idle", 2);
            }
            // ㄷ 
            else if (message == "ㄷ")
            {
                Debug.Log("디귿");
                anim.SetInteger("idle", 3);
            }
            // ㄹ 
            else if (message == "ㄹ")
            {
                Debug.Log("리을");
                anim.SetInteger("idle", 4);
            }
            // ㅁ 
            else if (message == "ㅁ")
            {
                Debug.Log("미음");
                anim.SetInteger("idle", 5);
            }
            // ㅂ
            else if (message == "ㅂ")
            {
                Debug.Log("비읍");
                anim.SetInteger("idle", 6);
            }
            // ㅅ
            else if (message == "ㅅ")
            {
                Debug.Log("시옷");
                anim.SetInteger("idle", 7);
            }
            // ㅇ
            else if (message == "ㅇ")
            {
                Debug.Log("이응");
                anim.SetInteger("idle", 8);
            }
            // ㅈ
            else if (message == "ㅈ")
            {
                Debug.Log("지읒");
                anim.SetInteger("idle", 9);
            }
            // ㅊ
            else if (message == "ㅊ")
            {
                Debug.Log("치읓");
                anim.SetInteger("idle", 10);
            }
            // ㅋ
            else if (message == "ㅋ")
            {
                Debug.Log("키읔");
                anim.SetInteger("idle", 11);
            }
            // ㅌ
            else if (message == "ㅌ")
            {
                Debug.Log("티읕");
                anim.SetInteger("idle", 12);
            }
            // ㅍ
            else if (message == "ㅍ")
            {
                Debug.Log("피읖");
                anim.SetInteger("idle", 13);
            }
            // ㅎ
            else if (message == "ㅎ")
            {
                Debug.Log("히읗");
                anim.SetInteger("idle", 14);
            }
            // ㄲ
            else if (message == "ㄲ")
            {
                Debug.Log("쌍기역");
                anim.SetInteger("idle", 15);
            }
            // ㄸ
            else if (message == "ㄸ")
            {
                Debug.Log("쌍디");
                anim.SetInteger("idle", 16);
            }
            // ㅃ
            else if (message == "ㅃ")
            {
                Debug.Log("쌍비읍");
                anim.SetInteger("idle", 17);
            }
            // ㅆ
            else if (message == "ㅆ")
            {
                Debug.Log("쌍시옷");
                anim.SetInteger("idle", 18);
            }
            // ㅉ
            else if (message == "ㅉ")
            {
                Debug.Log("쌍지읒");
                anim.SetInteger("idle", 19);
            }

            // 모음
            // ㅏ 
            else if (message == "ㅏ")
            {
                anim.SetInteger("idle", 20);
                Debug.Log("아");
                
            }
            // ㅑ
            else if (message == "ㅑ")
            {
                Debug.Log("ㅑ ");
                anim.SetInteger("idle", 21);
            }
            // ㅓ
            else if (message == "ㅓ")
            {
                Debug.Log("어");
                anim.SetInteger("idle", 22);
            }
            // ㅕ
            else if (message == "ㅕ")
            {
                Debug.Log("여");
                anim.SetInteger("idle", 23);
            }
            // ㅗ
            else if (message == "ㅗ")
            {
                Debug.Log("오");
                anim.SetInteger("idle", 24);
            }
            // ㅛ
            else if (message == "ㅛ")
            {
                Debug.Log("요");
                anim.SetInteger("idle", 25);
            }
            // ㅜ
            else if (message == "ㅜ")
            {
                Debug.Log("우");
                anim.SetInteger("idle", 26);
            }
            // ㅠ
            else if (message == "ㅠ")
            {
                Debug.Log("유");
                anim.SetInteger("idle", 27);
            }
            // ㅡ
            else if (message == "ㅡ")
            {
                Debug.Log("으");
                anim.SetInteger("idle", 28);
            }
            // ㅣ
            else if (message == "ㅣ")
            {
                Debug.Log("이");
                anim.SetInteger("idle", 29);
            }
            // ㅐ
            else if (message == "ㅐ")
            {
                Debug.Log("애");
                anim.SetInteger("idle", 30);
            }
            // ㅒ
            else if (message == "ㅒ")
            {
                Debug.Log("얘");
                anim.SetInteger("idle", 31);
            }
            // ㅔ
            else if (message == "ㅔ")
            {
                Debug.Log("에");
                anim.SetInteger("idle", 32);
            }
            // ㅖ
            else if (message == "ㅖ")
            {
                Debug.Log("예");
                anim.SetInteger("idle", 33);
            }
            // ㅢ
            else if (message == "ㅢ")
            {
                Debug.Log("의");
                anim.SetInteger("idle", 34);
            }
            // ㅚ
            else if (message == "ㅚ")
            {
                Debug.Log("외");
                anim.SetInteger("idle", 35);
            }
            // ㅟ
            else if (message == "ㅟ")
            {
                Debug.Log("위");
                anim.SetInteger("idle", 36);
            }

            //추후제작
            // ㅘ
            else if (message == "ㅘ")
            {
                Debug.Log("와");
                anim.SetInteger("idle", 24);
                anim.SetInteger("idle", 20);
            }

            // ㅝ
            else if (message == "ㅝ")
            {
                Debug.Log("워");
                anim.SetInteger("idle", 26);
                anim.SetInteger("idle", 22);
            }

            // ㅙ
            else if (message == "ㅙ")
            {
                Debug.Log("왜");
                anim.SetInteger("idle", 24);
                anim.SetInteger("idle", 30);
            }

            // ㅞ
            else if (message == "ㅞ")
            {
                Debug.Log("웨");
                anim.SetInteger("idle", 26);
                anim.SetInteger("idle", 32);
            }
            else
            {
                Debug.Log(message);
            }

        }

    }

    private void OnApplicationPause(bool pause)
    {
        print("");
    }

    private void Destory()
    {
        if (this.socketManager != null)
        {
            this.socketManager.Close();
            this.socketManager = null;
        }
    }


}