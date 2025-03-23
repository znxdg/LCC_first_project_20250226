using UnityEngine;

namespace YuCheng
{

    public class Player:Character
    {
        public override void Awake()
        {
            playerType = true;
            //con = 70;
            //pow = 60;
            //base.Awake();
            //hp = hpMax;
        }

        private void Update()
        {
            con = 70;
            pow = 60;
            base.Awake();
            hp = hpMax;
            Debug.Log(hp); 
        }
    }
}
