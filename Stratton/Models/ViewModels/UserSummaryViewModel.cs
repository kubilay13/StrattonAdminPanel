namespace Stratton.Models.ViewModels
{
    public class UserSummaryViewModel
    {
        public int TotalUsers { get; set; }
        public int AdminCount { get; set; }
        public int ModeratorCount { get; set; }
        public int PremiumCount { get; set; }
    }
}
