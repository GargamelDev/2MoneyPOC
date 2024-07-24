namespace _2MoneyPOC.Dtos
{
    public class GetTransactionDTO
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public decimal Ammount { get; set; }
    }
}
