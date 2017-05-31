using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VKSendPosts
{
    public class GroupsClass
    {
        
        public GroupsResponse response { get; set; }
    }

    public class GroupsResponse
    {
        public int count { get; set; }
        public GroupItem[] items { get; set; }
    }

    public class GroupItem
    {
        /*
         {
  "gid": 147549440,
  "name": "Продукция Amway, Москва, м. Ясенево",
  "screen_name": "amway_yasenevo",
  "is_closed": 0,
  "type": "group",
  "is_admin": 1,
  "admin_level": 3,
  "is_member": 1,
  "photo": "https://pp.userapi.com/c639227/v639227524/81f7b/If890Gb-2sA.jpg",
  "photo_medium": "https://pp.userapi.com/c639227/v639227524/81f7a/JHFFkVLM5NA.jpg",
  "photo_big": "https://pp.userapi.com/c639227/v639227524/81f79/Gg_MhcBp8-k.jpg"
}
         */
        public int gid { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public int is_closed { get; set; }
        public string type { get; set; }
        public int is_admin { get; set; }
        public int admin_level { get; set; }
        public int is_member { get; set; }
        public string photo { get; set; }
        public string photo_medium { get; set; }
        public string photo_big { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
