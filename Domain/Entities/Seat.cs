namespace Domain
{
    public class Seat
    {
        public int SeatID { get; set; }
        //regular or VIP
        public int EditionNumber { get; set; } // Edition 1,2,3... 
        public int SeatRow { get; set; }
        public int SeatColumn { get; set; }
        public SeatSort SeatSort { get; set; }
        public enum State
        {
            Reserved,Booked,Free
        }
    }
}
