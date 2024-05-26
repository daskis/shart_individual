namespace Zhuravlev_34.Models
{
    public enum SellStatus
    {
        InProgress,
        Paid,
        Overdue
    }

    public class Sell
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Tax { get; set; }

        private int _remainingAmount;
        public int RemainingAmount
        {
            get => _remainingAmount;
            set
            {
                _remainingAmount = value;
                UpdateStatus();
            }
        }

        private DateTime _invoiceDate;
        public DateTime InvoiceDate
        {
            get => _invoiceDate;
            set => _invoiceDate = DateTime.SpecifyKind(value, DateTimeKind.Utc);
        }

        private DateTime _dueDate;
        public DateTime DueDate
        {
            get => _dueDate;
            set
            {
                _dueDate = DateTime.SpecifyKind(value, DateTimeKind.Utc);
                UpdateStatus();
            }
        }

        private SellStatus _status;
        public SellStatus Status
        {
            get => _status;
            set
            {
                if (_status != value)
                {
                    _status = value;
                }
            }
        }

        private void UpdateStatus()
        {
            if (RemainingAmount == 0)
            {
                _status = SellStatus.Paid;
            }
            else if (DateTime.UtcNow > DueDate)
            {
                _status = SellStatus.Overdue;
            }
            else
            {
                _status = SellStatus.InProgress;
            }
        }
    }
}
