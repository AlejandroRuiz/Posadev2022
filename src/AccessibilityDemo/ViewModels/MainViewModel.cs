using System;
namespace AccessibilityDemo.ViewModels;

public class MainViewModel
{
    public string ProfilePhotoSource { get; set; } = "profile.jpg";
    public string ProfileName { get; set; } = "POSADEV";
    public string ProfileDetails { get; set; } = "Software Engineer";

    public int Income { get; set; } = 8900;
    public int Expenses { get; set; } = 5500;
    public int Loan { get; set; } = 890;

    public List<OverviewItem> OverviewItems { get; set; } = new List<OverviewItem>
    {
        new OverviewItem
        {
            IconSource = "arrow_upward",

            Title = "Sent",
            Details = "Sent payment to client.",
            Amount = 150
        },
        new OverviewItem
        {
            IconSource = "arrow_downward",

            Title = "Receive",
            Details = "Received payment from company.",
            Amount = 200
        },
        new OverviewItem
        {
            IconSource = "payments",

            Title = "Loan",
            Details = "Loan for the car.",
            Amount = 100
        },
        new OverviewItem
        {
            IconSource = "arrow_upward",

            Title = "Sent",
            Details = "Sent payment to client.",
            Amount = 150
        },
        new OverviewItem
        {
            IconSource = "arrow_downward",

            Title = "Receive",
            Details = "Received payment from company.",
            Amount = 306
        }
    };
}

public class OverviewItem
{
    public string IconSource { get; set; }

    public string Title { get; set; }

    public string Details { get; set; }

    public decimal Amount { get; set; }

    public string Description => $"{Title} {Details} {Amount}";
}
