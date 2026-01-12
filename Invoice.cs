namespace AutoMotiveProject.cs.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime EntryDate { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string VehicleYear { get; set; } = string.Empty;
        public string VehicleMake { get; set; } = string.Empty;
        public string VehicleModel { get; set; } = string.Empty;
        public string RegNo { get; set; } = string.Empty;
        public string WorkDone { get; set; } = string.Empty;
        public string Recommendation { get; set; } = string.Empty;
        public string BranchAddress { get; set; } = string.Empty;
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
        public string ModifiedBy { get; set; } = string.Empty;
    }
}