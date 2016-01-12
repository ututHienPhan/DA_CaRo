using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gomoku_1312198
{
    enum LuatChoi
    {
        None,
        International,
        Vietnamese,
    }


    class Option
    {
       // private LuatChoi gamePlay = LuatChoi.None;//Luật chơi
        private Player whoPlayWith = Player.None;//Kiểu chơi
        private string playerA = "";//Tên người chơi thứ 1
        private string playerB = "";//Tên người chơi thứ 2
        private Player luotChoi = Player.Human;//Lượt đi

        public Player LuotChoi
        {
            get { return this.luotChoi; }
            set { this.luotChoi = value; }
        }
        //public LuatChoi GamePlay
        //{
        //    get { return this.gamePlay; }
        //    set { this.gamePlay = value; }
        //}
        public Player WhoPlayWith
        {
            get { return this.whoPlayWith; }
            set { this.whoPlayWith = value; }
        }


        public string PlayerAName
        {
            get { return this.playerA; }
            set { this.playerA = value; }
        }
        public string PlayerBName
        {
            get { return this.playerB; }
            set { this.playerB = value; }
        }
        public Option()
        {

        }
    }
}
