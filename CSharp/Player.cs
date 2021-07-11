using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{

    public enum PlayerType
    {
         None = 0,
         Knight = 1,
         Archer = 2,
         Mage = 3
    }
    class Player : Creature
    {
        protected PlayerType type = PlayerType.None;

        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }
        public PlayerType GetPlayerType() { return type; }
        
    }

    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight) //자기 부모의 클래스 생성자 호출
        {
            SetInfo(100, 10);
        }
    }
    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}
