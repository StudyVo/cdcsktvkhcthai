using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongDongCSKH.Models
{
    internal class ChatbotMessage
    {
        [Key]
        public int Id { get; set; }

        public int? UserId { get; set; }
        public int? AdminId { get; set; }

        public string NoiDung { get; set; }

        public bool LaTraLoiTuChatbot { get; set; }

        public DateTime ThoiGian { get; set; }
    }
}
