using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace WebChat.Database.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        
        [ForeignKey("CurrentRoom")]
        public int? CurrentRoomId { get; set; }
        [CanBeNull] public Room CurrentRoom { get; set; }
    }
}