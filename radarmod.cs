using EFT;
using UnityEngine;
using UnityEngine.UI;
using Comfort.Common;
using BepInEx;

namespace radarmod
{
    [BepInPlugin("AT.radarmod", "AT.心跳仪(radarmod)", "1.0.0")]
    public class MyFirstBepInExMod : BaseUnityPlugin
    {
    }
    public class radarmod : MonoBehaviour
    {
        public Image radarback;
        public Image enemy01;
        public Image enemy02;
        public Image enemy03;
        public Image enemy04;
        public Image enemy05;
        public Image enemy06;
        public Image enemy07;
        public Image enemy08;
        public Image enemy09;
        public Image enemy10;
        private Transform player;
        private Transform[] AItarget;
        private int target;
        private static GameWorld gameWorld;
        private static bool Entermap() => Singleton<GameWorld>.Instantiated;
        void Start()
        {
            AItarget = new Transform[999];
            target = 0;
            if (Entermap())
            {
                gameWorld = Singleton<GameWorld>.Instance;
            }          
        }
        void Update()
        {           
            if (Entermap() && gameWorld.AllPlayers.Count >= 2)
            {
                player = gameWorld.MainPlayer.Transform.Original;
                radarback.GetComponent<RectTransform>().eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y, player.eulerAngles.y + 180);
                becomezero();
                for (int i = 1; i < gameWorld.AllPlayers.Count; i++)//获取全部AI
                {
                    AItarget[i]= gameWorld.AllPlayers[i].Transform.Original; 
                    float dis = Vector3.Distance(player.position, AItarget[i].position);
                    float x = (AItarget[i].position.x - player.transform.position.x) / 100;
                    float z = (AItarget[i].position.z - player.transform.position.z) / 100;
                    //float y = (AItarget[i].position.y - player.transform.position.y); 
                    if (dis <= 60)
                    {
                        target++;
                        if (target == 1)
                        {
                            enemy01.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 2)
                        {
                            enemy02.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 3)
                        {
                            enemy03.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 4)
                        {
                            enemy04.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 5)
                        {
                            enemy05.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 6)
                        {
                            enemy06.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 7)
                        {
                            enemy07.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 8)
                        {
                            enemy08.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 9)
                        {
                            enemy09.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 10)
                        {
                            enemy10.GetComponent<RectTransform>().anchoredPosition = new Vector2(-x * 0.2f, -z * 0.2f);
                        }
                        if (target == 10)
                        {
                            target = 0 ;
                        }
                    }      
                }
            }           
        }
        private void becomezero()
        {
            enemy01.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            enemy02.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            enemy03.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            enemy04.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            enemy05.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            enemy06.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            enemy07.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            enemy08.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            enemy09.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            enemy10.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        }
    }
}
