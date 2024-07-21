using B_Bussiness_Layer.IServies;
using C_Data_Access_Layer.IRepostories;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bussiness_Layer.Services
{
    public class ChatLieuService : IChatLieuService
    {
        ChatLieuRepostory _Rep;
        public ChatLieuService()
        {
            _Rep = new ChatLieuRepostory();
        }
        public List<Chatlieu> GetAll(string? txtSearch, string? searchType)
        {
            return _Rep.GetAll(txtSearch, searchType);
        }

        public Chatlieu GetByID(int id)
        {
            return _Rep.GetByID(id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            if (id == 0 || id == null)
            {
                return false;
            }

            return _Rep.Khoa_MoKhoa(id);
        }

        public bool Sua(int id, Chatlieu chatlieu)
        {
            if (id == 0 || id == null)
            {
                return false;
            }
            else if (chatlieu == null)
            {
                return false;
            }
            else if (chatlieu.Tenchatlieu == null || chatlieu.Mota == null)
            {
                return false;
            }

            return _Rep.Sua(id, chatlieu);
        }

        public bool Them(Chatlieu chatlieu)
        {
            if (chatlieu == null)
            {
                return false;
            }
            else if (chatlieu.Tenchatlieu == "" || chatlieu.Mota == "")
            {
                return false;
            }
            else if (chatlieu.Mataikhoan == 0)
            {
                return false;
            }

            return _Rep.Them(chatlieu);
        }
    }
}
