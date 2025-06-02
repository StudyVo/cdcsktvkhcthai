using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongDongCSKH.Models
{
    internal class ChatSession
    {
        [Key]
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? AdminId { get; set; }

        [StringLength(200)]
        public string TenDoanChat { get; set; }

        public DateTime ThoiGianTao { get; set; }

        public ICollection<ChatbotMessage> Messages { get; set; }
    }
}
