using System.ComponentModel.DataAnnotations;

namespace GuessTheNumberClient.Models
{
    public class Player
    {
        //[Required(ErrorMessage = "Please enter a username")]
        [MaxLength(20, ErrorMessage = "Username must be under 20 characters")]
        public string PlayerName { get; set; } = string.Empty;
        [Required]
        [Range(1, 50, ErrorMessage = "Please enter a number between 1 and 50")]
        public int? Guess { get; set; }
        public int CurrentAttempts { get; set; } = 0;
        public int? BestAttempt { get; set; }
    }
}
