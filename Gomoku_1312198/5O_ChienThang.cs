using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gomoku_1312198
{
    class _5O_ChienThang
    {

        //5 ô liên tiếp
        public Node[] GiaTri;
        int thuTu;
        public _5O_ChienThang()
        {
            GiaTri = new Node[10];
            for (int i = 0; i < 10; i++)
            {
                GiaTri[i] = new Node();
            }
            thuTu = 0;
        }
        public void Add(Node n)
        {
            GiaTri[thuTu] = n;
            thuTu++;
        }
        public void Reset()
        {
            thuTu = 0;
            GiaTri = new Node[10];
            for (int i = 0; i < 10; i++)
            {
                GiaTri[i] = new Node();
            }
        }
    }
}
