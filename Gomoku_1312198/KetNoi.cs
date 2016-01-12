using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quobject.SocketIoClientDotNet.Client;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.ComponentModel;

namespace Gomoku_1312198
{
  public  class KetNoi: INotifyPropertyChanged
    {
        public string mes = string.Empty;
        public int _x;
        public int _y;
        public int _player;

        public event PropertyChangedEventHandler PropertyChanged;

        public KetNoi() { }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Message
        {
            get
            {
                return mes;
            }
            set
            {
                if (value != this.mes)
                {
                    this.mes = value;
                    NotifyPropertyChanged("Message");
                }
            }
        }

        public int Player
        {
            get
            {
                return this._player;
            }
            set
            {
                if (value != this._player)
                {
                    this._player = value;
                }
            }
        }

        public int X
        {
            get
            {
                return this._x;
            }
            set
            {
                if (value != this._x)
                {
                    this._x = value;
                    NotifyPropertyChanged("X");
                }
            }
        }

        public int Y
        {
            get
            {
                return this._y;
            }
            set
            {
                if (value != this._y)
                {
                    this._y = value;
                    NotifyPropertyChanged("Y");
                }
            }
        }
    }

    public static class NhanMessage
    {
        public static KetNoi ketnoi = new KetNoi();
    }
}
