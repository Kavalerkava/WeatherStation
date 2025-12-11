namespace Database
{
    public class Sensor
    {
        private static int counter;

        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime MeasurementDate { get; set; }

        public Sensor()
        {
            counter++;
        }
    }
}