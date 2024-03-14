namespace FoodReservation
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public LinkedList<FoodMaterial> FoodMaterials { get; set; }
    }

    public class FoodMaterial
    {
        public int ProductId { get; set; }
        public double Measure { get; set; }
        public string MeasureType { get; set; }
    }

    public class FoodCalendar
    {
        public int FoodId { get; set; }
        public int Capacity { get; set; }
    }

    public class Reservation
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal ReservAuantity { get; set; }
    }
}