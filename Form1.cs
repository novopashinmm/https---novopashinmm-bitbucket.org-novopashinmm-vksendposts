using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace VKSendPosts
{
    public partial class Form1 : Form
    {
        string client_id = "6020546";
        string token;
        string token_group;
        string uid;

        string fields = @"fields=photo_id, verified, sex, bdate, city, country, home_town,
         has_photo, photo_50, photo_100, photo_200_orig, photo_200, photo_400_orig,
         photo_max, photo_max_orig, online, lists, domain, has_mobile, contacts,
         site, education, universities, schools, status, last_seen, 
         followers_count, common_count, occupation, nickname, relatives, relation,
         personal, connections, exports, wall_comments, activities, interests,
         music, movies, tv, books, games, about, quotes, can_post, can_see_all_posts, 
         can_see_audio, can_write_private_message, can_send_friend_request,
         is_favorite, is_hidden_from_feed, timezone, screen_name, maiden_name, 
         crop_photo, is_friend, friend_status, career, military, blacklisted, groups, wall,
         blacklisted_by_me";
        WebClient client;
        List<GroupItem> list = new List<GroupItem>();

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            client = new WebClient();

            client.Encoding = Encoding.UTF8;
            //https://oauth.vk.com/authorize?client_id=5490057&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.52
            StringBuilder sb = new StringBuilder();
            sb.Append("https://oauth.vk.com/authorize?client_id=");
            sb.Append(client_id);
            sb.Append("&display=page&redirect_uri=https://oauth.vk.com/blank.html");
            sb.Append("&scope=" + fields + "&response_type=token&v=5.52");
            string address = sb.ToString();
            web.ScriptErrorsSuppressed = true;
            web.Navigate(address);
        }

        private void buttonGetToken_Click(object sender, EventArgs e)
        {
            char[] symb = { '=', '&' };
            string[] arr = web.Url.ToString().Split(symb);
            uid = arr[5];
            token = arr[1];
            //txtWall.Text = uid;
            lblToken.Text = "Ваш id:" + arr[5] + Environment.NewLine +
                           "Ваш токен:" + arr[1];

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string address = "";
            address = "";
            address = "https://api.vk.com/method/groups.get?"
                + fields + "&access_token=" + token;
            address += "&user_id=" + uid;
            address += "&extended=true";
            address += "&version=5.53";
            address += "&count=1000";
            string s = client.DownloadString(address);
            
            JObject rss = JObject.Parse(s);
            
            JArray rss1 = (JArray ) rss["response"];
            // Получить количество групп
            int count = int.Parse(rss1[0].ToString());
            
            listGroups.Items.Clear();
			list.Clear();
            for (int i = 1; i <= count; i++)
            {
                string json = rss1[i].ToString();
                GroupItem item = JsonConvert.DeserializeObject<GroupItem>(json);
                if (item.name.Contains (textFind.Text)) 
                    list.Add(item);
            }

			foreach(var item in list) {
				listGroups.Items.Add(item);
			}
        }

        private void buttonSendPost_Click(object sender, EventArgs e)
        {
			List<int> listGroupIdAdded = new List<int>();
			//Надо отчетик замутить, о результах постинга по группам
			foreach(Object obj in listGroups.SelectedItems) {
				GroupItem item = (GroupItem)obj;
				item.gid *= -1;
				string wall = textWall.Text;

				string address = "https://api.vk.com/method/wall.post?owner_id=" + item.gid
				+ "&message=" + textWall.Text.Replace("#", "%23")
				+ "&from_group=2"
				+ "&attachments=" + textAttach.Text
				+ "&access_token=" + token;
				string s = client.DownloadString(address);
				Thread.Sleep(TimeSpan.FromSeconds(0.2));
			}
		}

		private void btnAssignAdmin_Click(object sender, EventArgs e) {
			//4922524 Вовкин ID
			//184679230 Мой ID
			foreach(GroupItem item in list) {
				string address = "https://api.vk.com/method/groups.editManager?group_id=" + item.gid
					+ "&user_id=" + txtUserId.Text
					+ "&role=administrator"
					+ "&is_contact=1"
					+ "&contact_position=По всем вопросам в личку"
					+ "&contact_phone=89036840030"
					+ "&contact_email=novopashinmm@mail.ru"
					+ "&access_token=" + token;
				string s = client.DownloadString(address);
				Thread.Sleep(TimeSpan.FromSeconds(0.5));
			}
		}
	}
}
