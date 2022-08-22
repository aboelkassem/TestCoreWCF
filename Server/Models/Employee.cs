namespace Server.Models
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public decimal Salary { get; set; }
    }
}
