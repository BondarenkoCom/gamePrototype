using System;
using System.Collections.Generic;
using System.Text;

namespace enemyLogic
{
    public partial class NpcData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MessageInBattle { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public byte[] Sprite { get; set; }
    }
}
